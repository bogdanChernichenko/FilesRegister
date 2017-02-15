using System;
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet1.Documents". При необходимости она может быть перемещена или удалена.
            this.documentsTableAdapter.Fill(this.database1DataSet1.Documents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Credentials". При необходимости она может быть перемещена или удалена.
            //this.credentialsTableAdapter.Fill(this.database1DataSet.Credentials);

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
    }
}
