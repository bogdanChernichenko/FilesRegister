using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            Close();
            ifrm.Show();
        }      //вернуться к авторизации

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Поле логин не может быть пустым");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show(" Поле пароль не может быть пустым");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Пожалуйста выберите роль");
            }
            else
            {
                //проверка логина на уникальность
                if (!IsLoginUnique())
                {
                    MessageBox.Show("Логин уже занят другим пользователем");
                }
                else
                {
                    AddUserSQL();
                }
             }
          }     //создание нового пользователя

        //Добавление пользователя в базу
        private void AddUserSQL()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Angelos.Sanguinius\Documents\Visual Studio 2015\Projects\FilesRegister\FilesRegister\Database1.mdf""; Integrated Security = True;";
            string sqlExpression = "sp_InsertUser";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //добавляем логин
                SqlParameter loginParam = new SqlParameter
                {
                    ParameterName = "@Login",
                    Value = textBox1.Text
                };
                command.Parameters.Add(loginParam);

                //добавляем пароль
                SqlParameter passwordParam = new SqlParameter
                {
                    ParameterName = "@Password",
                    Value = textBox2.Text
                };
                command.Parameters.Add(passwordParam);

                //добавляем роль
                SqlParameter roleParam = new SqlParameter
                {
                    ParameterName = "@Role",
                    Value = comboBox1.Text
                };
                command.Parameters.Add(roleParam);

                var result = command.ExecuteNonQuery();

                MessageBox.Show("Пользователь добавлен успешно!");
            }
        }
        //Проверка не занят ли логин
        private bool IsLoginUnique()
        {
            bool flag = true;
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Angelos.Sanguinius\Documents\Visual Studio 2015\Projects\FilesRegister\FilesRegister\Database1.mdf""; Integrated Security = True;";
            string sqlExpression = "sp_getUsers";
            List<string> credentials = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        credentials.Add(reader.GetString(1));
                    }
                }
                reader.Close();

                for (int i = 0; i < credentials.Count; i++)
                {
                    if (credentials[i] == textBox1.Text)
                    {
                        flag = false;
                    }
                }

                return flag;
            }
        }
    }
}
