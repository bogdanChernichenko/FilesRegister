using System;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public bool secretPassword = false;

        //секретный пароль
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "love")
            {
                MessageBox.Show("Секретный пароль не правильный!");
            }
            else
            {
                secretPassword = true;
                Dispose();
            }
        }
    }
}
