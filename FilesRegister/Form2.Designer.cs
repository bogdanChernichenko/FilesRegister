using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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

        public class DataGridViewEx : DataGridView
        {
            public DataGridViewEx()
                : base()
            {
                SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new FilesRegister.Form2.DataGridViewEx();
            this.Counter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseV12DataSet = new FilesRegister.DataBaseV12DataSet();
            this.dataBaseV12DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new FilesRegister.DataBaseV12DataSetTableAdapters.DocumentsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseV12DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseV12DataSetBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Counter,
            this.Column1,
            this.idDataGridViewTextBoxColumn,
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 305);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
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
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // направлениеDataGridViewTextBoxColumn
            // 
            this.направлениеDataGridViewTextBoxColumn.DataPropertyName = "Направление";
            this.направлениеDataGridViewTextBoxColumn.HeaderText = "Направление";
            this.направлениеDataGridViewTextBoxColumn.Name = "направлениеDataGridViewTextBoxColumn";
            this.направлениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // наименованиеОбъектаDataGridViewTextBoxColumn
            // 
            this.наименованиеОбъектаDataGridViewTextBoxColumn.DataPropertyName = "НаименованиеОбъекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.HeaderText = "Наименование Объекта";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.Name = "наименованиеОбъектаDataGridViewTextBoxColumn";
            this.наименованиеОбъектаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // юрЛицоКорпорацииDataGridViewTextBoxColumn
            // 
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.DataPropertyName = "ЮрЛицоКорпорации";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.HeaderText = "Юр. Лицо Корпорации";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.Name = "юрЛицоКорпорацииDataGridViewTextBoxColumn";
            this.юрЛицоКорпорацииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // контрагентDataGridViewTextBoxColumn
            // 
            this.контрагентDataGridViewTextBoxColumn.DataPropertyName = "Контрагент";
            this.контрагентDataGridViewTextBoxColumn.HeaderText = "Контрагент";
            this.контрагентDataGridViewTextBoxColumn.Name = "контрагентDataGridViewTextBoxColumn";
            this.контрагентDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерДоговораDataGridViewTextBoxColumn
            // 
            this.номерДоговораDataGridViewTextBoxColumn.DataPropertyName = "НомерДоговора";
            this.номерДоговораDataGridViewTextBoxColumn.HeaderText = "Номер Договора";
            this.номерДоговораDataGridViewTextBoxColumn.Name = "номерДоговораDataGridViewTextBoxColumn";
            this.номерДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // помещениеDataGridViewTextBoxColumn
            // 
            this.помещениеDataGridViewTextBoxColumn.DataPropertyName = "Помещение";
            this.помещениеDataGridViewTextBoxColumn.HeaderText = "Помещение";
            this.помещениеDataGridViewTextBoxColumn.Name = "помещениеDataGridViewTextBoxColumn";
            this.помещениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            this.площадьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // аренднаяСтавкаDataGridViewTextBoxColumn
            // 
            this.аренднаяСтавкаDataGridViewTextBoxColumn.DataPropertyName = "АренднаяСтавка";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.HeaderText = "Арендная Ставка";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.Name = "аренднаяСтавкаDataGridViewTextBoxColumn";
            this.аренднаяСтавкаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // другиеПлатежиDataGridViewTextBoxColumn
            // 
            this.другиеПлатежиDataGridViewTextBoxColumn.DataPropertyName = "ДругиеПлатежи";
            this.другиеПлатежиDataGridViewTextBoxColumn.HeaderText = "Другие Платежи";
            this.другиеПлатежиDataGridViewTextBoxColumn.Name = "другиеПлатежиDataGridViewTextBoxColumn";
            this.другиеПлатежиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаОкончанияДоговораDataGridViewTextBoxColumn
            // 
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.DataPropertyName = "ДатаОкончанияДоговора";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.HeaderText = "Дата Окончания Договора";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.Name = "датаОкончанияДоговораDataGridViewTextBoxColumn";
            this.датаОкончанияДоговораDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // документыDataGridViewTextBoxColumn
            // 
            this.документыDataGridViewTextBoxColumn.DataPropertyName = "Документы";
            this.документыDataGridViewTextBoxColumn.HeaderText = "Документы";
            this.документыDataGridViewTextBoxColumn.Name = "документыDataGridViewTextBoxColumn";
            this.документыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // документВыданDataGridViewTextBoxColumn
            // 
            this.документВыданDataGridViewTextBoxColumn.DataPropertyName = "ДокументВыдан";
            this.документВыданDataGridViewTextBoxColumn.HeaderText = "Документ Выдан";
            this.документВыданDataGridViewTextBoxColumn.Name = "документВыданDataGridViewTextBoxColumn";
            this.документВыданDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "Documents";
            this.documentsBindingSource.DataSource = this.dataBaseV12DataSet;
            // 
            // dataBaseV12DataSet
            // 
            this.dataBaseV12DataSet.DataSetName = "DataBaseV12DataSet";
            this.dataBaseV12DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBaseV12DataSetBindingSource
            // 
            this.dataBaseV12DataSetBindingSource.DataSource = this.dataBaseV12DataSet;
            this.dataBaseV12DataSetBindingSource.Position = 0;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Новая запись";
            this.toolTip3.SetToolTip(this.button2, "Хоткей для создания новой записи Ctrl+N");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "К авторизации";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(379, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Обновить таблицу";
            this.toolTip2.SetToolTip(this.button3, "Хоткей для обновления таблицы F5");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 308);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1003, 36);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Фильтр";
            this.toolTip1.SetToolTip(this.button4, "Хоткей для фильтра Ctrl+F");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(707, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(186, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "Показать истекающие договора";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(899, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 30);
            this.button6.TabIndex = 6;
            this.button6.Text = "Экспорт";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // toolTip3
            // 
            this.toolTip3.AutoPopDelay = 5000;
            this.toolTip3.InitialDelay = 900;
            this.toolTip3.ReshowDelay = 500;
            this.toolTip3.ShowAlways = true;
            // 
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 900;
            this.toolTip2.ReshowDelay = 500;
            this.toolTip2.ShowAlways = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 900;
            this.toolTip1.ReshowDelay = 500;
            this.toolTip1.ShowAlways = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Главное окно";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseV12DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseV12DataSetBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public DataGridViewEx dataGridView1;
        private DataBaseV12DataSet dataBaseV12DataSet;
        private BindingSource documentsBindingSource;
        private DataBaseV12DataSetTableAdapters.DocumentsTableAdapter documentsTableAdapter;
        private Button button2;
        private Button button1;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private ToolTip toolTip1;
        private BindingSource dataBaseV12DataSetBindingSource;
        private DataGridViewTextBoxColumn Counter;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn направлениеDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn наименованиеОбъектаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn юрЛицоКорпорацииDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn контрагентDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn номерДоговораDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn помещениеDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn аренднаяСтавкаDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn другиеПлатежиDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn датаОкончанияДоговораDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn документыDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn документВыданDataGridViewTextBoxColumn;
        private Button button5;
        private Button button6;
    }
}