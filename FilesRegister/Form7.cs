using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FilesRegister
{
    public partial class Form7 : Form
    {
        string sqQLiteConnectionString = @"Data Source =" + Directory.GetCurrentDirectory() + "\\Dv12.db;";
        List<int> CheckIndexes = new List<int>();

        public Form7()
        {
            InitializeComponent();
        }

        //неебический фильтр...наконец-то. Нажатие кнопки фильтрации
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

                //делаем невидимыми все строки
                for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
                {
                    f2.dataGridView1.CurrentCell = null;
                    f2.dataGridView1.Rows[i].Visible = false;                    
                }

                //Записываем имена чекнутых записей
                List<string> temp = new List<string>();
                for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i ++)
                {
                    temp.Add(checkedListBox1.CheckedItems[i].ToString());
                }

                //делаем видимыми строки, которые чекнуты в листе
                for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < temp.Count; j++)
                    {
                        if (f2.dataGridView1[c, i].Value.ToString() == temp[j])
                        {
                            f2.dataGridView1.Rows[i].Visible = true;
                            break;
                        }
                    }

                }
            }
            Dispose();
        }

        //Начинаем выводить значения прдварительного фильтрования при вводе в поле "Значение"
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)this.Owner;
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
            if (c != 0)
            {
                checkedListBox1.Items.Clear();
                CheckIndexes.Clear();
                for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
                {
                    f2.dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.White;
                }

                    for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
                {
                    if (f2.dataGridView1[c, i].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        CheckIndexes.Add(i);
                        //подсвечиваем строки в гриде
                        f2.dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightSkyBlue;
                        //Не добавляем повторно, если запись уже найдена
                        if (checkedListBox1.Items.Contains(f2.dataGridView1[c, i].Value.ToString()) == false)
                        {
                            checkedListBox1.Items.AddRange(new object[]
                            {
                                f2.dataGridView1[c, i].Value.ToString()
                            });
                        }

                    }
                }
                //Чекаем список
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
            }
            else
            {
                checkedListBox1.Items.Clear();
                CheckIndexes.Clear();
                for (int j = 3; j < f2.dataGridView1.Columns.Count;j++)
                {
                    for (int i = 0; i < f2.dataGridView1.Rows.Count - 1; i++)
                    {
                        if (f2.dataGridView1[j, i].Value.ToString().IndexOf(textBox1.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            //Не добавляем повторно, если запись уже найдена
                            if (checkedListBox1.Items.Contains(f2.dataGridView1[c, i].Value.ToString()) == false)
                            {
                                CheckIndexes.Add(i);
                                checkedListBox1.Items.AddRange(new object[]
                                {
                                f2.dataGridView1[j, i].Value.ToString()
                                });
                            }
                        }
                    }
                }

                //Чекаем список
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
            }


        }
    }
}
