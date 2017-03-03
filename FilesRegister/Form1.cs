using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form1 : Form
    {
        string currentFolder = Directory.GetCurrentDirectory();
        string sqQLiteConnectionString = @"Data Source =" + Directory.GetCurrentDirectory() + "\\Dv12.db;";

        public string role;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Вход
        private void button1_Click(object sender, EventArgs e)
        { 
            string sLogin = LoginBox.Text;
            string sPassword = PassBox.Text;
            string sqlExpression = "sp_getUsers";
            List<string> credentials = new List<string>();
            bool flag = false;

            //Начинаем строить невменяемые условия при авторизации
            using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                command.CommandText = "SELECT * from Credentials";
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
            }
                //Проверяем наличие указанного пользователя в базе дегенератским перебором
                for (int i = 0; i < credentials.Count;i+=3)
                {
                    if (LoginBox.Text == credentials[i] && PassBox.Text == credentials[i + 1])
                        {
                            flag = true;
                            Form2 f2q = new Form2(credentials[i + 2]);
                            f2q.Show();
                            this.Hide();
                        }
                }
                if (flag == false)
                {
                MessageBox.Show("Указанная комбинация логина и пароля не найдена в базе");
                }

        }   

        //умри,сука
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        //создание нового юзера
        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
            this.Hide();
        }   

    }
}
