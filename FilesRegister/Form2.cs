using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.documentsTableAdapter1.Fill(this.database1DataSet2.Documents); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = Application.OpenForms[0];
            Dispose();
            ifrm.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

           Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            Dispose();
            f4.Show();
        }

        private void Form2_Activated(object sender, EventArgs e)
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
                connection.Close();
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
            
        }
    }
}
