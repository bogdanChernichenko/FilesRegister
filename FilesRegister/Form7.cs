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
            
            if (comboBox1.Text == "Все столбцы")
            {
                for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
                {
                    f2.dataGridView1.CurrentCell = null;
                    f2.dataGridView1.Rows[i].Visible = false;
                    for (int c = 0; c < f2.dataGridView1.Columns.Count; c++)
                    {
                        if (f2.dataGridView1[c, i].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            if (f2.dataGridView1[c, i].ColumnIndex == 1)
                            {
                                continue;
                            }
                            else
                            {
                                f2.dataGridView1.Rows[i].Visible = true;
                                break;
                            }

                        }
                    }
                }
            }
            else
            {
                int c = 0;
                switch (comboBox1.Text)
                {
                    case "Направление":
                        c = 3;
                        break;
                    case "Адрес":
                        c = 4;
                        break;
                    case "Наименование Объекта":
                        c = 5;
                        break;
                    case "Юр. Лицо Корпорации":
                        c = 6;
                        break;
                    case "Контрагент":
                        c = 7;
                        break;
                    case "Номер Договора":
                        c = 8;
                        break;
                    case "Помещение":
                        c = 9;
                        break;
                    case "Площадь":
                        c = 10;
                        break;
                    case "Арендная Ставка":
                        c = 11;
                        break;
                    case "Другие Платежи":
                        c = 12;
                        break;
                    case "Дата Окончания Договора":
                        c = 13;
                        break;
                    case "Документы":
                        c = 14;
                        break;
                    case "Документ Выдан":
                        c = 15;
                        break;
                }
                    

                //int c = f2.dataGridView1.Columns[comboBox1.Text].Index;
                for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
                {
                    f2.dataGridView1.CurrentCell = null;
                    f2.dataGridView1.Rows[i].Visible = false;

                    if (f2.dataGridView1[c, i].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        f2.dataGridView1.Rows[i].Visible = true;
                    }

                }
            }

            Dispose();
            
        }

        //закрываем фильтр при нажании кнопки Esc
        private void Form7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }
    }
}
