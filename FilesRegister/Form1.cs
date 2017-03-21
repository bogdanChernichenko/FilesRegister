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
            LoginBox.Select();
        }

        //конструктор принимающий логин и пароль из формы с созданием пользователя
        public Form1(string log,string pass)
        {
            InitializeComponent();
            LoginBox.Select();
            LoginBox.Text = log;
            PassBox.Text = pass;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Вход
        private void button1_Click(object sender, EventArgs e)
        { 
            string sLogin = LoginBox.Text;
            string sPassword = PassBox.Text;
            List<string> credentials = new List<string>();
            bool flag = false;

            //Начинаем строить невменяемые условия при авторизации
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

        //создание нового юзера
        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        //нажимаем войти по нажатию Enter
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,new EventArgs());
            }
        }

        //кнопка выхода
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //восстановление пароля
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LoginBox.Text.Length == 0)
            {
                MessageBox.Show("Для восстановления пароля введите логин!");
            }
            else
            {
                string pass = "";
                Form8 f8 = new Form8();
                f8.ShowDialog();
                if (f8.secretPassword == true)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))
                    {
                        connection.Open();
                        SQLiteCommand command = new SQLiteCommand(connection);
                        command.CommandText = "SELECT Password from Credentials where Login =" + "'" + LoginBox.Text + "'";
                        var reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                pass = reader.GetString(0);
                            }
                        }
                        reader.Close();
                    }
                    MessageBox.Show("Пароль для логина " + LoginBox.Text + " :" + pass);
                }
                else
                {
                    MessageBox.Show("Пароль не правильный!");
                }
            }
            
        }

    }
}
