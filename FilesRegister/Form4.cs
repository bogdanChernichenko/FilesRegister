using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + Directory.GetCurrentDirectory() + "\\Database1.mdf" + "; Integrated Security = True;";
        string _role;
        Form2 f2 = new Form2();
        
        public Form4()
        {
            InitializeComponent();
        }

        public Form4(string role)
        {
            InitializeComponent();
            _role = role;
        }

        //Вернуться к таблище
        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (_role != "Админ")
            {
                this.textBox1.ReadOnly = true;
                this.textBox2.ReadOnly = true;
            }
        }

        //Кнопка добавить запись
        private void button3_Click(object sender, EventArgs e)
        {
            AddInfoToDatabase();
        }

        //метод добавления данных в базу
        private void AddInfoToDatabase()
        {
           
            string sqlExpression = "sp_AddInfo";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.CommandType = CommandType.StoredProcedure;

                //Направление
                SqlParameter napravlenie = new SqlParameter
                {
                    ParameterName = "@Направление",
                   Value = comboBox4.Text
                };
                command.Parameters.Add(napravlenie);

                //Адрес
                SqlParameter address = new SqlParameter
                {
                    ParameterName = "@Адрес",
                    Value = textBox1.Text
                };
                command.Parameters.Add(address);

                //Наименование объекта
                SqlParameter objectName = new SqlParameter
                {
                    ParameterName = "@НаименованиеОбъекта",
                    Value = textBox2.Text
                };
                command.Parameters.Add(objectName);

                //Юр.лицо корпорации
                SqlParameter lawFace = new SqlParameter
                {
                    ParameterName = "@ЮрЛицоКорпорации",
                    Value = textBox3.Text
                };
                command.Parameters.Add(lawFace);

                //Контрагент
                SqlParameter contrAgent = new SqlParameter
                {
                    ParameterName = "@Контрагент",
                    Value = textBox4.Text
                };
                command.Parameters.Add(contrAgent);

                SqlParameter dogovorNum = new SqlParameter
                {
                    ParameterName = "@НомерДоговора",
                    Value = textBox9.Text
                };
                command.Parameters.Add(dogovorNum);

                //Помещение
                SqlParameter builing = new SqlParameter
                {
                    ParameterName = "@Помещение",
                    Value = textBox5.Text
                };
                command.Parameters.Add(builing);

                //Площадь
                SqlParameter size = new SqlParameter
                {
                    ParameterName = "@Площадь",
                    Value = textBox6.Text
                };
                command.Parameters.Add(size);

                //Арендная ставка
                SqlParameter rentMoney = new SqlParameter
                {
                    ParameterName = "@АренднаяСтавка",
                    Value = textBox7.Text
                };
                command.Parameters.Add(rentMoney);

                //Другие платежи
                SqlParameter otherPayments = new SqlParameter
                {
                    ParameterName = "@ДругиеПлатежи",
                    Value = textBox8.Text
                };
                command.Parameters.Add(otherPayments);

                //Дата окончания договора

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyyMMdd";
                SqlParameter endDate = new SqlParameter
                {
                    ParameterName = "@ДатаОкончанияДоговора",
                    Value = dateTimePicker1.Text
                };
                command.Parameters.Add(endDate);

                //Документы
                SqlParameter documents = new SqlParameter
                {
                    ParameterName = "@Документы",
                    Value = comboBox2.Text
                };
                command.Parameters.Add(documents);

                //Документ выдан
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy.MM.dd";
                string document;
                List<string> documentBroughtList = new List<string>();

                document = comboBox3.Text + " \n " + textBox10.Text + " \n " + dateTimePicker2.Text + " \n " + textBox11.Text;
                SqlParameter documentsBroughtBy = new SqlParameter
                {
                    ParameterName = "@ДокументВыдан",
                    Value = document
                };
                command.Parameters.Add(documentsBroughtBy);
               
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена успешно!");
            }
        }

        //Выпадающее меню Вавилон заполняет 2 текстовых поля под ним какой-то хернёй
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Вавилон")
            {
                textBox1.Text = "Маршала Малиновского ул., 2, г. Днепр";
                textBox2.Text = "Вавилон-1, МФЦ";
            }
            else
            {
                textBox1.Text = "Какой-то адрес";
                textBox2.Text = "Ещё какая-то надпись";
            }
        }

        //При выборе "ДА" открывает 3 контрола Кто? Где? Кого и сколько раз?
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Да")
            {
                textBox10.Enabled = true;
                dateTimePicker2.Enabled = true;
                textBox11.Enabled = true;
            }
            else
            {
                textBox10.Enabled = false;
                dateTimePicker2.Enabled = false;
                textBox11.Enabled = false;
            }
        }

    }
}
