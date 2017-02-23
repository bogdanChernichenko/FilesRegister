using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "11101991love")
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
