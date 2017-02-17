namespace FilesRegister
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОбъектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контрагентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.помещениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аренднаяСтавкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.другиеПлатежиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документВыданDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet2 = new FilesRegister.Database1DataSet2();
            this.documentsTableAdapter1 = new FilesRegister.Database1DataSet2TableAdapters.DocumentsTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "К авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Новая запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Counter,
            this.направлениеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.наименованиеОбъектаDataGridViewTextBoxColumn,
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn,
            this.контрагентDataGridViewTextBoxColumn,
            this.помещениеDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.аренднаяСтавкаDataGridViewTextBoxColumn,
            this.другиеПлатежиDataGridViewTextBoxColumn,
            this.датаОкончанияДоговораDataGridViewTextBoxColumn,
            this.документыDataGridViewTextBoxColumn,
            this.документВыданDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentsBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(868, 395);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // Counter
            // 
            this.Counter.DataPropertyName = "Counter";
            this.Counter.HeaderText = "#";
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Width = 39;
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.Width = 63;
            // 
            // наименованиеОбъектаDataGridViewTextBoxColumn
            // 
            this.наименованиеОбъектаDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеОбъекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.HeaderText = "Наименование объекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.Name = "наименованиеОбъектаDataGridViewTextBoxColumn";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.Width = 140;
            // 
            // юрЛицоКорпорацииDataGridViewTextBoxColumn
            // 
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.DataPropertyName = "ЮрЛицоКорпорации";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.HeaderText = "Юр. лицо корпорации";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.Name = "юрЛицоКорпорацииDataGridViewTextBoxColumn";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.Width = 128;
            // 
            // контрагентDataGridViewTextBoxColumn
            // 
            this.контрагентDataGridViewTextBoxColumn.DataPropertyName = "Контрагент";
            this.контрагентDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.контрагентDataGridViewTextBoxColumn.Name = "контрагентDataGridViewTextBoxColumn";
            this.контрагентDataGridViewTextBoxColumn.Width = 90;
            // 
            // помещениеDataGridViewTextBoxColumn
            // 
            this.помещениеDataGridViewTextBoxColumn.DataPropertyName = "Помещение";
            this.помещениеDataGridViewTextBoxColumn.HeaderText = "Помещение";
            this.помещениеDataGridViewTextBoxColumn.Name = "помещениеDataGridViewTextBoxColumn";
            this.помещениеDataGridViewTextBoxColumn.Width = 93;
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            this.площадьDataGridViewTextBoxColumn.Width = 79;
            // 
            // аренднаяСтавкаDataGridViewTextBoxColumn
            // 
            this.аренднаяСтавкаDataGridViewTextBoxColumn.DataPropertyName = "АренднаяСтавка";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.HeaderText = "Арендная Ставка";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.Name = "аренднаяСтавкаDataGridViewTextBoxColumn";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.Width = 110;
            // 
            // другиеПлатежиDataGridViewTextBoxColumn
            // 
            this.другиеПлатежиDataGridViewTextBoxColumn.DataPropertyName = "ДругиеПлатежи";
            this.другиеПлатежиDataGridViewTextBoxColumn.HeaderText = "Другие платежи";
            this.другиеПлатежиDataGridViewTextBoxColumn.Name = "другиеПлатежиDataGridViewTextBoxColumn";
            this.другиеПлатежиDataGridViewTextBoxColumn.Width = 105;
            // 
            // датаОкончанияДоговораDataGridViewTextBoxColumn
            // 
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.DataPropertyName = "ДатаОкончанияДоговора";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.HeaderText = "Дата окончания договора";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.Name = "датаОкончанияДоговораDataGridViewTextBoxColumn";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.Width = 150;
            // 
            // документыDataGridViewTextBoxColumn
            // 
            this.документыDataGridViewTextBoxColumn.DataPropertyName = "Документы";
            this.документыDataGridViewTextBoxColumn.HeaderText = "Документы";
            this.документыDataGridViewTextBoxColumn.Name = "документыDataGridViewTextBoxColumn";
            this.документыDataGridViewTextBoxColumn.Width = 91;
            // 
            // документВыданDataGridViewTextBoxColumn
            // 
            this.документВыданDataGridViewTextBoxColumn.DataPropertyName = "ДокументВыдан";
            this.документВыданDataGridViewTextBoxColumn.HeaderText = "Документ выдан";
            this.документВыданDataGridViewTextBoxColumn.Name = "документВыданDataGridViewTextBoxColumn";
            this.документВыданDataGridViewTextBoxColumn.Width = 108;
            // 
            // documentsBindingSource1
            // 
            this.documentsBindingSource1.DataMember = "Documents";
            this.documentsBindingSource1.DataSource = this.database1DataSet2;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsTableAdapter1
            // 
            this.documentsTableAdapter1.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 360);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(868, 35);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 395);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Главное окно";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource documentsBindingSource1;
        private Database1DataSet2TableAdapters.DocumentsTableAdapter documentsTableAdapter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОбъектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn юрЛицоКорпорацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контрагентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn помещениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аренднаяСтавкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn другиеПлатежиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn документыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn документВыданDataGridViewTextBoxColumn;
    }
}