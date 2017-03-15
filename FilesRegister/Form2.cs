using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();
        string _role;
        string sqQLiteConnectionString = @"Data Source =" + Directory.GetCurrentDirectory() + "\\Dv12.db;";

        //дефолтный конструктор
        public Form2()
        {
            InitializeComponent();
        }

        //костыльный конструтор получающий роль и запрещающий редачить поля не одмену
        public Form2 (string role)
            {
            InitializeComponent();
            this.KeyPreview = true;
            _role = role;

            if (_role != "Админ")
            {
                this.button2.Visible = false;
            }
        }

        //Дефолтный конструктор
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //вернуться на авторизацию
        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            Dispose();
            ifrm.Show();
        }

        //тушим свет нажимая на крестик
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           Application.Exit();
        }

        //переход на форму заполнения данных
        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(_role);
            f4.ShowDialog();
        }

        //колонка-счётчик-шмётчик
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            
        }

        //Заполнение таблицы данными из базы
        private void UpdateGrid()
        {
            DataSet ds = new DataSet();
            string sql = "SELECT * FROM Documents";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(sqQLiteConnectionString))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn))
                    {
                        da.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                }
            }
            catch (Exception)
            {
            }
            paintYesNo();
        }

        //Открываем редактирование записи по двойному клику
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dataGridView1.RowCount-1)
            {
                Form5 f5 = new Form5(_role, dataGridView1[1, e.RowIndex].FormattedValue.ToString());
                f5.ShowDialog();
            }

        }

        //Кнопащька Обновить таблицу
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGrid();
            paintYesNo();
            PrilozeniaCut();
            TowerAdd();
        }

        //Хоткей для фильтра и обновы таблицы
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                Form7 f7 = new Form7();   
                f7.ShowDialog(this);
            }
            else if (e.KeyCode == Keys.F5)
            {
                UpdateGrid();
                PrilozeniaCut();
                TowerAdd();
                paintYesNo();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                button2_Click(e,new EventArgs());
            }
        }

        //Отображаем все записи при первом запуске (закрашиваем Да/Нет зелёным/Красным, сокращаем количество 
        private void Form2_Shown(object sender, EventArgs e)
        {
            UpdateGrid();
            paintYesNo();
            PrilozeniaCut();
            TowerAdd();
            if (BleedingDogovors() != 0)
            {
                if (BleedingDogovors() <= 4)
                {
                    MessageBox.Show("Найдено " + BleedingDogovors() + " договора срок которых истекает менее, чем через месяц!", "Внимание!");
                }
                else
                {
                    MessageBox.Show("Найдено " + BleedingDogovors() + " договоров срок которых истекает менее, чем через месяц!", "Внимание!");
                }
            }
        }

        //Открываем фильтр
        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog(this);
        }

        //Закрашиваем фон ячейки документов где Да/Нет
        private void paintYesNo ()
        {
            string s = "";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                s = dataGridView1.Rows[i].Cells[15].Value.ToString();
                if (s.Contains("Да"))
                {
                    dataGridView1.Rows[i].Cells[15].Style.BackColor = System.Drawing.Color.MediumSeaGreen;
                }
                else
                {
                    dataGridView1.Rows[i].Cells[15].Style.BackColor = System.Drawing.Color.IndianRed;
                }
            }
        }

        //Повторное закрашивание ячеек при сортировке
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            paintYesNo();
        }

        //Сокращаем запись в ячейке, если есть слово "Приложение" на Есть документы
        private void PrilozeniaCut ()
        {
            string s = "";
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                s = dataGridView1.Rows[i].Cells[14].Value.ToString();

                if (s.Length != 0)
                {
                    dataGridView1.Rows[i].Cells[14].Value = "Документы есть";
                }
                else
                {
                    dataGridView1.Rows[i].Cells[14].Value = "Документы отсутствуют";
                }
            }
        }

        //добавляем слова ахуительная башня, невообразимый этаж и номер к ячейкам
        private void TowerAdd ()
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string s = dataGridView1.Rows[i].Cells[9].Value.ToString();
                string[] word = s.Split('\n');
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j].Length == 0)
                    {
                        word[j] = "Отсутсвует";
                    }
                }
                dataGridView1.Rows[i].Cells[9].Value = "Помещение " + word[0] + '\n' + "Башня " + word[1] + '\n' + "Этаж " + word[2] + '\n' + "Номер " + word[3];
            }
        }

        //Ищем договора с итекающей датой...пиздец название
        private int BleedingDogovors()
        {
            DateTime nowDate = DateTime.Now;
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string s = "";
                s = dataGridView1.Rows[i].Cells[13].Value.ToString();
                DateTime myDate = DateTime.ParseExact(s, "dd.MM.yyyy H:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                TimeSpan ts = myDate - nowDate;
                if (ts.Days <= 30)
                {
                    count++;
                }
            }
            return count;
        }

        //Показываем договора с датой истечения < месяц
        private void button5_Click(object sender, EventArgs e)
        {
            DateTime nowDate = DateTime.Now;

            for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.CurrentCell = null;
                dataGridView1.Rows[i].Visible = false;

                string s = "";
                s = dataGridView1.Rows[i].Cells[13].Value.ToString();
                DateTime myDate = DateTime.ParseExact(s, "dd.MM.yyyy H:mm:ss",
                                       System.Globalization.CultureInfo.InvariantCulture);
                TimeSpan ts = myDate - nowDate;
                if (ts.Days <= 30)
                {
                    dataGridView1.Rows[i].Visible = true;
                }
            }
        }
    }
}
