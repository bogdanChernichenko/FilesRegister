using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form3 : Form
    {

        string sqQLiteConnectionString =  @"Data Source =" + Directory.GetCurrentDirectory() + "\\Dv12.db;";
        public Form3()
        {
            InitializeComponent();
        }

        //вернуться к авторизации
        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            Dispose();
            ifrm.Show();
        }      

        //создание нового пользователя
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
                    if (comboBox1.Text == "Админ")
                    {
                        Form6 f6 = new Form6();
                        f6.ShowDialog();
                        if (f6.secretPassword == true)
                        {
                            AddUserSQL();
                        }
                    }
                    else
                    {
                        AddUserSQL();
                    }
                }
             }
          }     

        //Добавление пользователя в базу
        private void AddUserSQL()
        {
            string sqlExpression = "sp_InsertUser";

            using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString,true))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                command.CommandText = "INSERT into Credentials (Id,Login, Password, Role) values("+ "'" + System.Guid.NewGuid().ToString().ToUpper() + "'"+ ",@Login, @Password, @Role)";
                
                //добавляем логин
                SQLiteParameter loginParam = new SQLiteParameter
                {
                    ParameterName = "@Login",
                    Value = textBox1.Text
                };
                command.Parameters.Add(loginParam);

                //добавляем пароль
                SQLiteParameter passwordParam = new SQLiteParameter
                {
                    ParameterName = "@Password",
                    Value = textBox2.Text
                };
                command.Parameters.Add(passwordParam);

                //добавляем роль
                SQLiteParameter roleParam = new SQLiteParameter
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
            List<string> credentials = new List<string>();

            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))

                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "SELECT * from Credentials";
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

            catch (Exception)
            {
                return false;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
