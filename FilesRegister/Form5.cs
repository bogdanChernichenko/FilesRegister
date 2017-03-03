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
        string connectionString = @"Data Source = (LocalDB)\v12; AttachDbFilename =" + Directory.GetCurrentDirectory() + "\\DataBaseV12.mdf " + "; Integrated Security = False;";
        string sqQLiteConnectionString = @"Data Source =" + Directory.GetCurrentDirectory() + "\\Dv12.db;";
        string _role,_documentId;
        public Form5()
        {
            InitializeComponent();
        }

        //костыльный конструтор получающий роль и ид записи по которой кликнули
        public Form5(string role,string documentId)
        {
            InitializeComponent();
            _role = role;
            _documentId = documentId;

            DataFill(documentId);

            if (_role != "Админ")
            {
                BlockElements();
                button1.Visible = false;
            }
        }

        //Заполнение полей данными из базы используя входящий ид записи
        private void DataFill(string documentId)
        {
            List<string> documentsData = new List<string>();

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

                textBox1.Text = documentsData[1];
                textBox2.Text = documentsData[2];
                textBox3.Text = documentsData[3];
                textBox4.Text = documentsData[4];
                textBox5.Text = documentsData[5];
                textBox6.Text = documentsData[6];
                textBox7.Text = documentsData[7];
                textBox8.Text = documentsData[8];
                textBox9.Text = documentsData[9];
                textBox10.Text = documentsData[10];

                comboBox1.Text = documentsData[0].Trim();
                comboBox2.Text = documentsData[11].Trim();

                dateTimePicker1.Text = documentsData[10];

                string[] documentsBy = documentsData[12].Split('\n');
                comboBox3.Text = documentsBy[0].Trim();
                textBox10.Text = documentsBy[1].Trim();
                dateTimePicker2.Text = documentsBy[2].Trim();
                textBox11.Text = documentsBy[3].Trim();
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

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
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
                command.Parameters.Add(new SQLiteParameter("@НомерДоговора", textBox5.Text));
                command.Parameters.Add(new SQLiteParameter("@Помещение", textBox6.Text));
                command.Parameters.Add(new SQLiteParameter("@Площадь", textBox7.Text));
                command.Parameters.Add(new SQLiteParameter("@АренднаяСтавка", textBox8.Text));
                command.Parameters.Add(new SQLiteParameter("@ДругиеПлатежи", textBox9.Text));

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyyMMdd";
                command.Parameters.Add(new SQLiteParameter("@ДатаОкончанияДоговора", dateTimePicker1.Text));
                command.Parameters.Add(new SQLiteParameter("@Документы", comboBox2.Text));

                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "yyyy.MM.dd";
                string document;
                document = comboBox3.Text + " \n " + textBox10.Text + " \n " + dateTimePicker2.Text + " \n " + textBox11.Text;
                command.Parameters.Add(new SQLiteParameter("@ДокументВыдан", document));

                command.Parameters.Add(new SQLiteParameter("@Id", _documentId.ToUpper()));
                command.ExecuteNonQuery();

                

                MessageBox.Show("Запись обновлена успешно!");

            }

            }
    }
}
