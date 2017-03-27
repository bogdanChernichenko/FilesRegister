using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form5 : Form
    {
        string sqQLiteConnectionString = @"Data Source =" + Directory.GetCurrentDirectory() + "\\Dv12.db;";
        string _role,_documentId,_login;
        List<string> documentsData = new List<string>();

        //дефолтный конструктор
        public Form5()
        {
            InitializeComponent();
        }

        //костыльный конструтор получающий роль и ид записи по которой кликнули
        public Form5(string role,string documentId,string login)
        {
            InitializeComponent();

            _role = role;
            _login = login;
            _documentId = documentId;

            DataFill(documentId);

            if (_role != "Админ")
            {
                BlockElements();
                button1.Visible = false;
                button2.Visible = false;
            }

            if (comboBox1.Text == "КН-ГП")
            {
                comboBox5.Visible = false;
                label17.Visible = false;
            }
            else if (comboBox1.Text == "Коммерческая недвижимость")
            {
                comboBox5.Visible = false;
                comboBox4.Visible = false;
                label17.Visible = false;
            }
        }

        //Заполнение полей данными из базы используя входящий ид записи
        private void DataFill(string documentId)
        {

            using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM Documents WHERE ID =" + "'" + documentId.ToString().ToUpper() + "'";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        documentsData.Add(reader.GetString(1)); //Направление
                        documentsData.Add(reader.GetString(2)); //Адрес
                        documentsData.Add(reader.GetString(3)); //Наименование
                        documentsData.Add(reader.GetString(4)); //ЮрЛицо
                        documentsData.Add(reader.GetString(5)); //Контрагент
                        documentsData.Add(reader.GetString(6)); //НомерДоговора
                        documentsData.Add(reader.GetString(7)); //Помещение
                        documentsData.Add(reader.GetString(8)); //Площадь
                        documentsData.Add(reader.GetString(9)); //Арендная ставка
                        documentsData.Add(reader.GetString(10)); //другие платежи
                        documentsData.Add(reader.GetDateTime(11).ToString()); //ебучая дата
                        documentsData.Add(reader.GetString(12));    //документы
                        documentsData.Add(reader.GetString(13));    //документ выдан
                    }
                }
                reader.Close();

                textBox1.Text = documentsData[1];       //Адрес
                textBox2.Text = documentsData[2];       //наименование
                textBox3.Text = documentsData[3];       //ЮрЛицо
                textBox4.Text = documentsData[4];       //Контрагент

                string[] dogovorNum = documentsData[5].Split(' ');  //номерДоговора
                if (dogovorNum.Length == 1)
                {
                    textBox5.Text = dogovorNum[0];
                }
                else
                {
                    textBox5.Text = dogovorNum[0];
                    comboBox4.SelectedItem = dogovorNum[dogovorNum.Length - 1];
                }
                    
                string[] pomeshenie = documentsData[6].Split('\n'); //помещение
                if (pomeshenie.Length == 1)
                {
                    textBox6.Text = pomeshenie[0];
                }
                else if (pomeshenie.Length == 3)
                {
                    comboBox6.SelectedItem = pomeshenie[2].Trim();
                    textBox12.Text = pomeshenie[3];
                }
                else
                {
                    textBox6.Text = pomeshenie[0];
                    comboBox5.SelectedItem = pomeshenie[1].Trim();
                    comboBox6.SelectedItem = pomeshenie[2].Trim();
                    textBox12.Text = pomeshenie[3];
                }


                textBox7.Text = documentsData[7];       //площадь
                textBox8.Text = documentsData[8];       //арендная ставка
                textBox9.Text = documentsData[9];       //другие платежи

                comboBox1.Text = documentsData[0].Trim();   //документы
                textBox13.Text = documentsData[11].Trim();

                dateTimePicker1.Text = documentsData[10];

                string[] documentsBy = documentsData[12].Split('\n');
                if (documentsBy.Length == 1)
                {
                    comboBox3.SelectedItem = documentsBy[0].Trim();
                }
                else
                {
                    comboBox3.SelectedItem = documentsBy[0].Trim();
                    textBox10.Text = documentsBy[1].Trim();
                    dateTimePicker2.Text = documentsBy[2].Trim();
                    textBox11.Text = documentsBy[3].Trim();
                }
            }

        }

        //Дизейбл элементов
        private void BlockElements()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;

            comboBox1.Enabled = false;
            textBox13.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        //Удаление записи
        private void button2_Click(object sender, EventArgs e)
        {
            DeletionLog();
            using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "DELETE FROM Documents WHERE ID =" + "'" + _documentId.ToString().ToUpper() + "'";
                if (MessageBox.Show("Вы действительно хотите удалить запись?","Предупреждение",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MessageBox.Show("Запись удалена успешно!");
                    command.ExecuteNonQuery();
                }
            }
            Dispose();
        }

        //выпиливаем башню и прочую хуйню 
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "КН-ГП")
            {
                comboBox5.Visible = false;
                label17.Visible = false;
                comboBox4.Visible = true;
                comboBox5.Text = " ";
            }
            else if (comboBox1.Text == "Коммерческая недвижимость")
            {
                comboBox5.Visible = false;
                comboBox4.Visible = false;
                label17.Visible = false;
                comboBox4.Text = " ";
                comboBox5.Text = " ";
            }
            else
            {
                label17.Visible = true;
                comboBox5.Visible = true;
                comboBox4.Visible = true;
                comboBox4.Text = " ";
                comboBox5.Text = " ";
            }
        }

        //Документ Да - энейблим поля 
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

        //заполняем адрес и наименование
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Вавилон")
            {
                textBox1.Text = "Маршала Малиновского ул., 2, г. Днепр";
                textBox2.Text = "Вавилон-1, МФЦ";
                comboBox1.Visible = true;
                label17.Visible = true;
                comboBox5.Visible = true;
            }
            else if (comboBox1.Text == "КН-ГП")
            {
                textBox1.Text = "Святослава Храброго ул., 35/пер. Ушинского 1, г.Днепр";
                textBox2.Text = "ДомЪ и ИнтерьерЪ,ТЦ";
                comboBox4.Visible = true;
                label17.Visible = false;
                comboBox5.Visible = false;
            }
            else
            {
                comboBox4.Visible = false;
                label17.Visible = false;
                comboBox5.Visible = false;
            }

            //заполняем документы если ТЦ/ОФ
            if (comboBox4.Text == "ТЦ" && comboBox1.Text == "Вавилон")
            {
                textBox13.Text = "Приложение № 1 Извлечение из плана Торгового Центра" + Environment.NewLine + "Приложение № 2 Акт Приема - передачи Помещения" + Environment.NewLine + "Приложение № 3 Спецификация Помещения" + Environment.NewLine + "Приложение № 4 Правила и Положения Торгового Центра" + Environment.NewLine + "Приложение № 5 Торговый профиль" + Environment.NewLine + "Приложение №6 Проект адаптации" + Environment.NewLine + "Приложение №7 Доверенность" + Environment.NewLine + "Приложение №8 Образцы факсимиле" + Environment.NewLine;
            }
            else if (comboBox4.Text == "ОФ" && comboBox1.Text == "Вавилон")
            {
                textBox13.Text = "Приложение №1 Выписка из плана БФЦ" + Environment.NewLine + "Приложение №2 Акт Приема - передачи Помещения" + Environment.NewLine + "Приложение №3 Правила и Положения БФЦ" + Environment.NewLine + "Приложение №4 Спецификация Помещение" + Environment.NewLine + "Приложение №5 Образцы факсимиле" + Environment.NewLine;
            }
            else if (comboBox4.Text == "КН-ГП")
            {
                comboBox5.Visible = false;
            }
            else
            {
                textBox13.Text = "";
            }
        }

        //Редактирование записи
        private void button1_Click(object sender, EventArgs e)
        {
            string sqlExpression = "sp_EditDocumentsData";

            using (SQLiteConnection connection = new SQLiteConnection(sqQLiteConnectionString))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(sqlExpression, connection);
                command.CommandText = "UPDATE Documents set Направление = @Направление,Адрес = @Адрес,НаименованиеОбъекта = @НаименованиеОбъекта, ЮрЛицоКорпорации = @ЮрЛицоКорпорации, Контрагент = @Контрагент, Помещение = @Помещение, Площадь = @Площадь, АренднаяСтавка = @АренднаяСтавка, ДругиеПлатежи = @ДругиеПлатежи,ДатаОкончанияДоговора =  CAST(@ДатаОкончанияДоговора AS DATETIME), Документы = @Документы, ДокументВыдан = @ДокументВыдан, НомерДоговора = @НомерДоговора WHERE Id = @Id";
                command.Parameters.Add(new SQLiteParameter("@Направление", comboBox1.Text));
                command.Parameters.Add(new SQLiteParameter("@Адрес", textBox1.Text));
                command.Parameters.Add(new SQLiteParameter("@НаименованиеОбъекта", textBox2.Text));
                command.Parameters.Add(new SQLiteParameter("@ЮрЛицоКорпорации", textBox3.Text));
                command.Parameters.Add(new SQLiteParameter("@Контрагент", textBox4.Text));

                string dogovor;
                if (comboBox1.Text != "Коммерческая недвижимость")
                {
                    dogovor = textBox5.Text + " " + comboBox4.Text;
                }
                else
                {
                    dogovor = textBox5.Text;
                }
                
                command.Parameters.Add(new SQLiteParameter("@НомерДоговора", dogovor));

                string pomeshenie;
                if (comboBox5.Visible == false)
                {
                pomeshenie = textBox6.Text + "\n" + "" + "\n" + comboBox6.Text + "\n" + textBox12.Text;
                command.Parameters.Add(new SQLiteParameter("@Помещение", pomeshenie));
                }
                else
                {
                    pomeshenie = textBox6.Text + "\n" + comboBox5.Text + "\n" + comboBox6.Text + "\n" + textBox12.Text;
                    command.Parameters.Add(new SQLiteParameter("@Помещение", pomeshenie));
                }
                command.Parameters.Add(new SQLiteParameter("@Площадь", textBox7.Text));
                command.Parameters.Add(new SQLiteParameter("@АренднаяСтавка", textBox8.Text));
                command.Parameters.Add(new SQLiteParameter("@ДругиеПлатежи", textBox9.Text));

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
                command.Parameters.Add(new SQLiteParameter("@Id", _documentId.ToUpper()));
                command.ExecuteNonQuery();

                MessageBox.Show("Запись обновлена успешно!");
            }
            Dispose();
            }

        //Заполнение документов при выборе Вавилон и ТЦ/ОФ
        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "ТЦ" && comboBox1.Text == "Вавилон")
            {
                textBox13.Text = "Приложение № 1 Извлечение из плана Торгового Центра" + Environment.NewLine + "Приложение № 2 Акт Приема - передачи Помещения" + Environment.NewLine + "Приложение № 3 Спецификация Помещения" + Environment.NewLine + "Приложение № 4 Правила и Положения Торгового Центра" + Environment.NewLine + "Приложение № 5 Торговый профиль" + Environment.NewLine + "Приложение №6 Проект адаптации" + Environment.NewLine + "Приложение №7 Доверенность" + Environment.NewLine + "Приложение №8 Образцы факсимиле" + Environment.NewLine;
            }
            else if (comboBox4.Text == "ОФ" && comboBox1.Text == "Вавилон")
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

        //Пишем лог после удаления записи
        private void DeletionLog()
        {
            string curFile = Directory.GetCurrentDirectory() + "\\Deletelog.txt";
            List<string> zagolovki = new List<string>();
            zagolovki.Add("Направление");
            zagolovki.Add("Адрес");
            zagolovki.Add("Наименование");
            zagolovki.Add("ЮрЛицо");
            zagolovki.Add("Контрагент");
            zagolovki.Add("НомерДоговора");
            zagolovki.Add("Помещение");
            zagolovki.Add("Площадь");
            zagolovki.Add("Арендная ставка");
            zagolovki.Add("Другие платежи");
            zagolovki.Add("Дата окончания договора");
            zagolovki.Add("Документы");
            zagolovki.Add("Документ выдан");

            //шапка
            using (StreamWriter file = new StreamWriter(curFile, true))
            {
                file.WriteLine("Пользователь с логином: " + _login + " удалил в " + System.DateTime.Now + " запись: \n");

            }
            //сама инфа, наверняка можно красивее, но я днище, сорян
            using (StreamWriter file = new StreamWriter(curFile, true))
            {
                for (int i = 0; i < documentsData.Count; i++)
                {
                    file.WriteLine(zagolovki[i] + ":\n" + documentsData[i] + "\n");
                }
                file.WriteLine("------------------------------------------------------------------------------------------------");
                
            }
        }

        //Событие для выделения текста по Ctrl+A
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
        private void textBox9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox9.SelectAll();
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
        private void textBox13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                textBox13.SelectAll();
                //убираем звуковое сопровождение при нажатии клавиш
                e.Handled = e.SuppressKeyPress = true;
            }
        }

    }
}
