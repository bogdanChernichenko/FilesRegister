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
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new FilesRegister.Database1DataSet3();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.documentsTableAdapter = new FilesRegister.Database1DataSet3TableAdapters.DocumentsTableAdapter();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.направлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеОбъектаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контрагентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.помещениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.аренднаяСтавкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.другиеПлатежиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОкончанияДоговораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.документВыданDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Counter,
            this.Column1,
            this.направлениеDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.наименованиеОбъектаDataGridViewTextBoxColumn,
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn,
            this.контрагентDataGridViewTextBoxColumn,
            this.номерДоговораDataGridViewTextBoxColumn,
            this.помещениеDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.аренднаяСтавкаDataGridViewTextBoxColumn,
            this.другиеПлатежиDataGridViewTextBoxColumn,
            this.датаОкончанияДоговораDataGridViewTextBoxColumn,
            this.документыDataGridViewTextBoxColumn,
            this.документВыданDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.documentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(791, 366);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 369);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(789, 35);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // Counter
            // 
            this.Counter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Counter.FillWeight = 213.198F;
            this.Counter.HeaderText = "#";
            this.Counter.Name = "Counter";
            this.Counter.ReadOnly = true;
            this.Counter.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Counter.Width = 30;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "BaseId";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // наименованиеОбъектаDataGridViewTextBoxColumn
            // 
            this.наименованиеОбъектаDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеОбъекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.наименованиеОбъектаDataGridViewTextBoxColumn.HeaderText = "НаименованиеОбъекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.Name = "наименованиеОбъектаDataGridViewTextBoxColumn";
            // 
            // юрЛицоКорпорацииDataGridViewTextBoxColumn
            // 
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.DataPropertyName = "ЮрЛицоКорпорации";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.HeaderText = "ЮрЛицоКорпорации";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.Name = "юрЛицоКорпорацииDataGridViewTextBoxColumn";
            // 
            // контрагентDataGridViewTextBoxColumn
            // 
            this.контрагентDataGridViewTextBoxColumn.DataPropertyName = "Контрагент";
            this.контрагентDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.контрагентDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.контрагентDataGridViewTextBoxColumn.Name = "контрагентDataGridViewTextBoxColumn";
            // 
            // номерДоговораDataGridViewTextBoxColumn
            // 
            this.номерДоговораDataGridViewTextBoxColumn.DataPropertyName = "НомерДоговора";
            this.номерДоговораDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.номерДоговораDataGridViewTextBoxColumn.HeaderText = "НомерДоговора";
            this.номерДоговораDataGridViewTextBoxColumn.Name = "номерДоговораDataGridViewTextBoxColumn";
            // 
            // помещениеDataGridViewTextBoxColumn
            // 
            this.помещениеDataGridViewTextBoxColumn.DataPropertyName = "Помещение";
            this.помещениеDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.помещениеDataGridViewTextBoxColumn.HeaderText = "Помещение";
            this.помещениеDataGridViewTextBoxColumn.Name = "помещениеDataGridViewTextBoxColumn";
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            // 
            // аренднаяСтавкаDataGridViewTextBoxColumn
            // 
            this.аренднаяСтавкаDataGridViewTextBoxColumn.DataPropertyName = "АренднаяСтавка";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.аренднаяСтавкаDataGridViewTextBoxColumn.HeaderText = "АренднаяСтавка";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.Name = "аренднаяСтавкаDataGridViewTextBoxColumn";
            // 
            // другиеПлатежиDataGridViewTextBoxColumn
            // 
            this.другиеПлатежиDataGridViewTextBoxColumn.DataPropertyName = "ДругиеПлатежи";
            this.другиеПлатежиDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.другиеПлатежиDataGridViewTextBoxColumn.HeaderText = "ДругиеПлатежи";
            this.другиеПлатежиDataGridViewTextBoxColumn.Name = "другиеПлатежиDataGridViewTextBoxColumn";
            // 
            // датаОкончанияДоговораDataGridViewTextBoxColumn
            // 
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.DataPropertyName = "ДатаОкончанияДоговора";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.HeaderText = "ДатаОкончанияДоговора";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.Name = "датаОкончанияДоговораDataGridViewTextBoxColumn";
            // 
            // документыDataGridViewTextBoxColumn
            // 
            this.документыDataGridViewTextBoxColumn.DataPropertyName = "Документы";
            this.документыDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.документыDataGridViewTextBoxColumn.HeaderText = "Документы";
            this.документыDataGridViewTextBoxColumn.Name = "документыDataGridViewTextBoxColumn";
            // 
            // документВыданDataGridViewTextBoxColumn
            // 
            this.документВыданDataGridViewTextBoxColumn.DataPropertyName = "ДокументВыдан";
            this.документВыданDataGridViewTextBoxColumn.FillWeight = 91.29247F;
            this.документВыданDataGridViewTextBoxColumn.HeaderText = "ДокументВыдан";
            this.документВыданDataGridViewTextBoxColumn.Name = "документВыданDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 404);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Главное окно";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private Database1DataSet3TableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Counter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеОбъектаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn юрЛицоКорпорацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контрагентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn помещениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn аренднаяСтавкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn другиеПлатежиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОкончанияДоговораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn документыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn документВыданDataGridViewTextBoxColumn;
    }
}