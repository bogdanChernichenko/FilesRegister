﻿using System;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form7 : Form
    {

        public Form7()
        {
            InitializeComponent();
        }

        //неебический фильтр...наконец-то
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)this.Owner;

            for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
            {
                f2.dataGridView1.CurrentCell = null;
                f2.dataGridView1.Rows[i].Visible = false;
                for (int c = 0; c < f2.dataGridView1.Columns.Count; c++)
                {
                        if (f2.dataGridView1[c, i].Value.ToString().IndexOf(textBox1.Text,StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                        f2.dataGridView1.Rows[i].Visible = true;
                        break;
                    }
                }
            }

            Dispose();
            
        }
    }
}
