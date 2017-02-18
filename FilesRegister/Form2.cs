using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();
        string _role;
        
        //дефолтный конструктор
        public Form2()
        {
            InitializeComponent();
        }

        //костыльный конструтор получающий роль и запрещающий редачить поля не одмену
        public Form2 (string role)
            {
            InitializeComponent();
            _role = role;

            if (_role != "Админ")
            {
                this.адресDataGridViewTextBoxColumn.ReadOnly = true;
                this.наименованиеОбъектаDataGridViewTextBoxColumn.ReadOnly = true;
                this.юрЛицоКорпорацииDataGridViewTextBoxColumn.ReadOnly = true;
                this.направлениеDataGridViewTextBoxColumn.ReadOnly = true;
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
            Dispose();
            f4.Show();
        }

        //обновляем таблицу при активации формы
        private void Form2_Activated(object sender, EventArgs e)
        {
            UpdateGrid();
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
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Angelos.Sanguinius\Documents\Visual Studio 2015\Projects\FilesRegister\FilesRegister\Database1.mdf""; Integrated Security = True;";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                SqlDataAdapter da = new SqlDataAdapter("UPDATE Documents set " + dataGridView1.Columns[e.ColumnIndex].HeaderText + " =" + "N'" +dataGridView1[e.ColumnIndex, e.RowIndex].FormattedValue + "'" + "WHERE ID =" + "'"+ dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()+ "'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Update(dt);
            }
        }

        //метод для обновления базы
        private void UpdateGrid ()
        {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = ""C:\Users\Angelos.Sanguinius\Documents\Visual Studio 2015\Projects\FilesRegister\FilesRegister\Database1.mdf""; Integrated Security = True;";

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
    }
}
