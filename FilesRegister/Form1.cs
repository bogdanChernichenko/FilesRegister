using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            string sLogin = LoginBox.Text;
            string sPassword = PassBox.Text;
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Angelos.Sanguinius\Documents\Visual Studio 2015\Projects\FilesRegister\FilesRegister\Database1.mdf""; Integrated Security = True;";
            string sqlExpression = "sp_getUsers";
            List<string> credentials = new List<string>();
            bool flag = false;

            //Начинаем строить невменяемые условия при авторизации
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
                        credentials.Add(reader.GetString(2));
                        credentials.Add(reader.GetString(3));
                    }
                }
                reader.Close();
                //Проверяем наличие указанного пользователя в базе дегенератским перебором
                for (int i = 0; i < credentials.Count;i+=3)
                {
                    if (LoginBox.Text == credentials[i] && PassBox.Text == credentials[i + 1])
                        {
                            flag = true;
                        }
                }
                if (flag)
                {
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Указанная комбинация логина и пароля не найдена в базе");
                }
            }
        }   //Вход

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   //умри,сука

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
            this.Hide();
        }   //создание нового юзера

    }
}
