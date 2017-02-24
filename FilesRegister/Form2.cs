using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();
        string _role;
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =" + Directory.GetCurrentDirectory() + "\\Database1.mdf" + "; Integrated Security = True;";

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

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet3.Documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.database1DataSet3.Documents);
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

        //Событие для обновления базы при редактировании ячейки...это было круто
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                String s = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                //эвейдим баг с форматом даты при корректировке даты
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText.ToString() == "ДатаОкончанияДоговора")
                {
                    s = dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue.ToString();
                    string sDays = s.Substring(0,2);
                    string sMonth = s.Substring(3,2);
                    string sYear = s.Substring(6,4);
                    s = sYear +"."+ sMonth +"." + sDays;

                    SqlDataAdapter da = new SqlDataAdapter("UPDATE Documents set " + dataGridView1.Columns[e.ColumnIndex].HeaderText + " =" + "N'" + s + "'" + "WHERE ID =" + "'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Update(dt);
                }
                else
                {
                    SqlDataAdapter da = new SqlDataAdapter("UPDATE Documents set " + dataGridView1.Columns[e.ColumnIndex].HeaderText + " =" + "N'" + dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue + "'" + "WHERE ID =" + "'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    da.Update(dt);
                }
            }
        }

        //метод для обновления базы
        private void UpdateGrid ()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter("Select * from Documents", connection);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataSet ds = new DataSet();
                da.Fill(ds, "Documents");

                dataGridView1.DataSource = ds.Tables[0];
            }
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

        //Обновить таблицу
        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        //Хоткей для фильтра
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {
                Form7 f7 = new Form7();   
                f7.ShowDialog(this);
            }
        }

    }
}
