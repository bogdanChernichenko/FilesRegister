using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form4 : Form
    {

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

        //Не одмен не могёт редачить адрес и что там под или над ним
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
            Close();
        }

        //метод добавления данных в базу
        private void AddInfoToDatabase()
        {
           using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "INSERT into Documents (Id,Направление,Адрес,НаименованиеОбъекта,ЮрЛицоКорпорации,Контрагент,Помещение,Площадь,АренднаяСтавка,ДругиеПлатежи,ДатаОкончанияДоговора,Документы,ДокументВыдан,НомерДоговора,ВитаяПара) values(" +"'" + System.Guid.NewGuid().ToString().ToUpper() + "'" + ",Ltrim(Rtrim(@Направление)), Ltrim(Rtrim(@Адрес)), Ltrim(Rtrim(@НаименованиеОбъекта)), Ltrim(Rtrim(@ЮрЛицоКорпорации)), Ltrim(Rtrim(@Контрагент)), Ltrim(Rtrim(@Помещение)), Ltrim(Rtrim(@Площадь)), Ltrim(Rtrim(@АренднаяСтавка)), Ltrim(Rtrim(@ДругиеПлатежи)), Ltrim(Rtrim(@ДатаОкончанияДоговора)), Ltrim(Rtrim(@Документы)), Ltrim(Rtrim(@ДокументВыдан)), Ltrim(Rtrim(@НомерДоговора)),Ltrim(Rtrim(@ВитаяПара)))";

                //Направление
                command.Parameters.Add(new SQLiteParameter("@Направление", comboBox4.Text));
                command.Parameters.Add(new SQLiteParameter("@Адрес", textBox1.Text));
                command.Parameters.Add(new SQLiteParameter("@НаименованиеОбъекта", textBox2.Text));
                command.Parameters.Add(new SQLiteParameter("@ЮрЛицоКорпорации", textBox3.Text));
                command.Parameters.Add(new SQLiteParameter("@Контрагент", textBox4.Text));
                string dogovor;
                if (comboBox4.Text != "Коммерческая недвижимость")
                {
                    dogovor = textBox9.Text + " " + comboBox1.Text;
                }
                else
                {
                    dogovor = textBox9.Text;
                }
                command.Parameters.Add(new SQLiteParameter("@НомерДоговора", dogovor));

                string pomeshenie;
                if (comboBox5.Visible == false)
                {
                    pomeshenie = textBox5.Text + "\n" + "" + "\n" + comboBox6.Text + "\n" + textBox12.Text;
                    command.Parameters.Add(new SQLiteParameter("@Помещение", pomeshenie));
                }
                else
                {
                    pomeshenie = textBox5.Text + "\n" + comboBox5.Text + "\n" + comboBox6.Text + "\n" + textBox12.Text;
                    command.Parameters.Add(new SQLiteParameter("@Помещение", pomeshenie));
                }
                command.Parameters.Add(new SQLiteParameter("@Площадь", textBox6.Text));
                command.Parameters.Add(new SQLiteParameter("@АренднаяСтавка", textBox7.Text));
                command.Parameters.Add(new SQLiteParameter("@ДругиеПлатежи", textBox8.Text));

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyyMMdd";
                command.Parameters.Add(new SQLiteParameter("@ДатаОкончанияДоговора", dateTimePicker1.Text));
                command.Parameters.Add(new SQLiteParameter("@Документы", textBox13.Text));

                if (comboBox3.Text == "Нет")
                {
                    command.Parameters.Add(new SQLiteParameter("@ДокументВыдан", comboBox3.Text));
                }
                else
                {
                    string document;
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "yyyy.MM.dd";
                    document = comboBox3.Text + "\n" + textBox10.Text + "\n" + dateTimePicker2.Text + "\n" + textBox11.Text;
                    command.Parameters.Add(new SQLiteParameter("@ДокументВыдан", document));
                }

                if (comboBox2.Text == "Нет")
                {
                    command.Parameters.Add(new SQLiteParameter("@ВитаяПара", comboBox2.Text));
                }
                else
                {
                    string document;
                    document = comboBox2.Text + " " + "\n" + textBox14.Text;
                    command.Parameters.Add(new SQLiteParameter("@ВитаяПара", document));
                }
                

                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена успешно!");
            }
        }

        //Выпадающее меню Вавилон заполняет 2 текстовых поля под ним какой-то хернёй. Делаем невидимыми башню, витую пару и тд
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Вавилон")
            {
                textBox1.Text = "Маршала Малиновского ул., 2, г. Днепр";
                textBox2.Text = "Вавилон-1, МФЦ";
                comboBox1.Visible = true;
                label17.Visible = true;
                comboBox5.Visible = true;
                label20.Visible = true;
                comboBox2.Visible = true;
                comboBox2.SelectedItem = "Нет";
                textBox14.Visible = true;
            }
            else if (comboBox4.Text == "КН-ГП")
            {
                textBox1.Text = "Святослава Храброго ул., 35/пер. Ушинского 1, г.Днепр";
                textBox2.Text = "ДомЪ и ИнтерьерЪ,ТЦ";
                comboBox1.Visible = true;
                label17.Visible = false;
                comboBox5.Visible = false;
                label20.Visible = false;
                comboBox2.Visible = false;
                comboBox2.SelectedItem = "Нет";
                textBox14.Visible = false;
                textBox14.Text = "";
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.Visible = false;
                label17.Visible = false;
                comboBox5.Visible = false;
                comboBox5.Visible = false;
                label20.Visible = false;
                comboBox2.Visible = false;
                comboBox2.SelectedItem = "Нет";
                textBox14.Visible = false;
                textBox14.Text = "";
            }

            //заполняем документы если ТЦ/ОФ
            if (comboBox1.Text == "ТЦ" && comboBox4.Text == "Вавилон")
            {
                textBox13.Text = "Приложение № 1 Извлечение из плана Торгового Центра" + Environment.NewLine + "Приложение № 2 Акт Приема - передачи Помещения" + Environment.NewLine + "Приложение № 3 Спецификация Помещения" + Environment.NewLine + "Приложение № 4 Правила и Положения Торгового Центра" + Environment.NewLine + "Приложение № 5 Торговый профиль" + Environment.NewLine + "Приложение №6 Проект адаптации" + Environment.NewLine + "Приложение №7 Доверенность" + Environment.NewLine + "Приложение №8 Образцы факсимиле" + Environment.NewLine;
            }
            else if (comboBox1.Text == "ОФ" && comboBox4.Text == "Вавилон")
            {
                textBox13.Text = "Приложение №1 Выписка из плана БФЦ" + Environment.NewLine + "Приложение №2 Акт Приема - передачи Помещения" + Environment.NewLine + "Приложение №3 Правила и Положения БФЦ" + Environment.NewLine + "Приложение №4 Спецификация Помещение" + Environment.NewLine + "Приложение №5 Образцы факсимиле" + Environment.NewLine;
            }
            else if (comboBox1.Text == "КН-ГП")
            {
                comboBox5.Visible = false;
            }
            else
            {
                textBox13.Text = "";
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

        //Заполнение документов при изменении ТЦ КП и прочей хуйни
        private void comboBox1_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ТЦ" && comboBox4.Text == "Вавилон")
            {
                textBox13.Text = "Приложение № 1 Извлечение из плана Торгового Центра" + Environment.NewLine + "Приложение № 2 Акт Приема - передачи Помещения" + Environment.NewLine + "Приложение № 3 Спецификация Помещения" + Environment.NewLine + "Приложение № 4 Правила и Положения Торгового Центра" + Environment.NewLine + "Приложение № 5 Торговый профиль" + Environment.NewLine + "Приложение №6 Проект адаптации" + Environment.NewLine + "Приложение №7 Доверенность" + Environment.NewLine + "Приложение №8 Образцы факсимиле" + Environment.NewLine;
            }
            else if (comboBox1.Text == "ОФ" && comboBox4.Text == "Вавилон")
            {
                textBox13.Text = "Приложение №1 Выписка из плана БФЦ" + Environment.NewLine + "Приложение №2 Акт Приема - передачи Помещения" + Environment.NewLine + "Приложение №3 Правила и Положения БФЦ" + Environment.NewLine + "Приложение №4 Спецификация Помещение" + Environment.NewLine + "Приложение №5 Образцы факсимиле" + Environment.NewLine;
            }
            else if (comboBox1.Text == "КН-ГП")
            {
                comboBox5.Visible = false;
            }
            else
            {
                textBox13.Text = "";
            }
        }

        //Витая, мать её, пара
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Да")
            {
                textBox14.Enabled = true;
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "";
            }
        }

        //События для выделения текста Ctrl+A
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox1.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox2.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox3.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox4.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox9.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox5.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox6.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox7.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox8.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox13.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }
        private void textBox11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox11.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }

    }
}
