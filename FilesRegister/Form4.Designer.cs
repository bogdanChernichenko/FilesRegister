﻿using System;
using System.Windows.Forms;

namespace FilesRegister
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        //уменьшает лаги для фонового изображения
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED  
                if (this.IsXpOr2003 == true)
                    cp.ExStyle |= 0x00080000;  // Turn on WS_EX_LAYERED
                return cp;
            }
        }
        private Boolean IsXpOr2003
        {
            get
            {
                OperatingSystem os = Environment.OSVersion;
                Version vs = os.Version;
                if (os.Platform == PlatformID.Win32NT)
                    if ((vs.Major == 5) && (vs.Minor != 0))
                        return true;
                    else
                        return false;
                else
                    return false;
            }
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 43);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 67);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Наименование объекта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 116);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 38);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Арендная ставка";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(148, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(261, 20);
            this.textBox7.TabIndex = 13;
            this.textBox7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox7_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Другие  платежи";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(148, 29);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(261, 20);
            this.textBox8.TabIndex = 14;
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox8_KeyDown);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Документы";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Дата окончания договора";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Документ выдан";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox3.Location = new System.Drawing.Point(148, 267);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(261, 21);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(970, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "Создать запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(777, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Вернуться к таблице";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.04032F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.95968F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 633);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1214, 50);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.38889F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.61111F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.87786F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.12214F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(576, 158);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // comboBox4
            // 
            this.comboBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Вавилон",
            "КН-ГП",
            "Коммерческая недвижимость"});
            this.comboBox4.Location = new System.Drawing.Point(155, 9);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(241, 21);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox7, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.comboBox3, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker1, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox8, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label15, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label16, 2, 5);
            this.tableLayoutPanel4.Controls.Add(this.dateTimePicker2, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.textBox10, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.textBox11, 2, 6);
            this.tableLayoutPanel4.Controls.Add(this.textBox13, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label20, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.comboBox2, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.textBox14, 2, 7);
            this.tableLayoutPanel4.Controls.Add(this.label21, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBox15, 2, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(582, 12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(589, 589);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Кем";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(148, 306);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Когда";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(415, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Описание";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 322);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(261, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(3, 322);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(139, 20);
            this.textBox10.TabIndex = 18;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(415, 322);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(170, 127);
            this.textBox11.TabIndex = 20;
            this.textBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox11_KeyDown);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(148, 81);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(261, 169);
            this.textBox13.TabIndex = 16;
            this.textBox13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox13_KeyDown);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 458);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Витая пара";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBox2.Location = new System.Drawing.Point(148, 455);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 21);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox14.Enabled = false;
            this.textBox14.Location = new System.Drawing.Point(415, 455);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(170, 20);
            this.textBox14.TabIndex = 23;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(415, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(92, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Калькулятор дат";
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(415, 55);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 25;
            this.textBox15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox15_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBox5, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox9, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBox1, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBox6, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label18, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label19, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.comboBox6, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.textBox12, 2, 5);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox5, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 176);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(576, 267);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Контрагент";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 35);
            this.textBox3.TabIndex = 4;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(156, 44);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 35);
            this.textBox4.TabIndex = 5;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Помещение";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 126);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(240, 35);
            this.textBox5.TabIndex = 8;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Номер Договора";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(156, 85);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(240, 35);
            this.textBox9.TabIndex = 6;
            this.textBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox9_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ТЦ",
            "ОФ",
            "СК",
            "      "});
            this.comboBox1.Location = new System.Drawing.Point(402, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged_1);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(156, 216);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(240, 48);
            this.textBox6.TabIndex = 12;
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label17.Location = new System.Drawing.Point(3, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Башня";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label18.Location = new System.Drawing.Point(156, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Этаж";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label19.Location = new System.Drawing.Point(402, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(18, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "№";
            // 
            // comboBox6
            // 
            this.comboBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox6.Location = new System.Drawing.Point(156, 180);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(240, 21);
            this.comboBox6.TabIndex = 10;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(402, 180);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(123, 20);
            this.textBox12.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Юр.лицо корпорации";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "А1-7",
            "А3-7",
            "А4-7",
            "А5-7",
            "А6-7",
            "А7-7",
            "А8-7"});
            this.comboBox5.Location = new System.Drawing.Point(3, 180);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(147, 21);
            this.comboBox5.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Площадь";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1214, 683);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1230, 722);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая запись";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label7;
        private Label label20;
        private ComboBox comboBox2;
        private TextBox textBox14;
        private Label label21;
        private TextBox textBox15;
    }
}