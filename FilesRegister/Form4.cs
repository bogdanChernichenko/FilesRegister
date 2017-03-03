using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form4 : Form
    {
        string connectionString = @"Data Source = (LocalDB)\v12; AttachDbFilename =" + Directory.GetCurrentDirectory() + "\\DataBaseV12.mdf " + "; Integrated Security = False;";
        string sqQLiteConnectionString = @"Data Source =" + Directory.GetCurrentDirectory() + "\\Dv12.db;";

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
           using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT into Documents (Id,Направление,Адрес,НаименованиеОбъекта,ЮрЛицоКорпорации,Контрагент,Помещение,Площадь,АренднаяСтавка,ДругиеПлатежи,ДатаОкончанияДоговора,Документы,ДокументВыдан,НомерДоговора) values(" +"'" + System.Guid.NewGuid().ToString().ToUpper() + "'" + ",Ltrim(Rtrim(@Направление)), Ltrim(Rtrim(@Адрес)), Ltrim(Rtrim(@НаименованиеОбъекта)), Ltrim(Rtrim(@ЮрЛицоКорпорации)), Ltrim(Rtrim(@Контрагент)), Ltrim(Rtrim(@Помещение)), Ltrim(Rtrim(@Площадь)), Ltrim(Rtrim(@АренднаяСтавка)), Ltrim(Rtrim(@ДругиеПлатежи)), Ltrim(Rtrim(@ДатаОкончанияДоговора)), Ltrim(Rtrim(@Документы)), Ltrim(Rtrim(@ДокументВыдан)), Ltrim(Rtrim(@НомерДоговора)))";

                //Направление

                SQLiteParameter napravlenie = new SQLiteParameter
                {
                    ParameterName = "@Направление",
                   Value = comboBox4.Text
                };
                command.Parameters.Add(napravlenie);

                //Адрес
                SQLiteParameter address = new SQLiteParameter
                {
                    ParameterName = "@Адрес",
                    Value = textBox1.Text
                };
                command.Parameters.Add(address);

                //Наименование объекта
                SQLiteParameter objectName = new SQLiteParameter
                {
                    ParameterName = "@НаименованиеОбъекта",
                    Value = textBox2.Text
                };
                command.Parameters.Add(objectName);

                //Юр.лицо корпорации
                SQLiteParameter lawFace = new SQLiteParameter
                {
                    ParameterName = "@ЮрЛицоКорпорации",
                    Value = textBox3.Text
                };
                command.Parameters.Add(lawFace);

                //Контрагент
                SQLiteParameter contrAgent = new SQLiteParameter
                {
                    ParameterName = "@Контрагент",
                    Value = textBox4.Text
                };
                command.Parameters.Add(contrAgent);

                //SqlParameter dogovorNum = new SqlParameter
                SQLiteParameter dogovorNum = new SQLiteParameter
                {
                    ParameterName = "@НомерДоговора",
                    Value = textBox9.Text
                };
                command.Parameters.Add(dogovorNum);

                //Помещение
                SQLiteParameter builing = new SQLiteParameter
                {
                    ParameterName = "@Помещение",
                    Value = textBox5.Text
                };
                command.Parameters.Add(builing);

                //Площадь
                SQLiteParameter size = new SQLiteParameter
                 {
                    ParameterName = "@Площадь",
                    Value = textBox6.Text
                };
                command.Parameters.Add(size);

                //Арендная ставка
                SQLiteParameter rentMoney = new SQLiteParameter
                {
                    ParameterName = "@АренднаяСтавка",
                    Value = textBox7.Text
                };
                command.Parameters.Add(rentMoney);

                //Другие платежи
                SQLiteParameter otherPayments = new SQLiteParameter
                {
                    ParameterName = "@ДругиеПлатежи",
                    Value = textBox8.Text
                };
                command.Parameters.Add(otherPayments);

                //Дата окончания договора

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyyMMdd";
                SQLiteParameter endDate = new SQLiteParameter
                {
                    ParameterName = "@ДатаОкончанияДоговора",
                    Value = dateTimePicker1.Text
                };
                command.Parameters.Add(endDate);

                //Документы
                SQLiteParameter documents = new SQLiteParameter
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
                SQLiteParameter documentsBroughtBy = new SQLiteParameter
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

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ТЦ")
            {
            comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",});
            }
            else
            {
                comboBox2.Items.Clear();
            }
        }
    }
}
