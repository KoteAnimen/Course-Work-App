
namespace Course_Work_App
{
    partial class Workers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeInfWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.DismissWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowWorkWorkers = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowDismissWorkers = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllWorkers = new System.Windows.Forms.ToolStripMenuItem();
            this.персоналDataGridView = new System.Windows.Forms.DataGridView();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.персоналTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.ПерсоналTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewWorker,
            this.ChangeInfWorker,
            this.DismissWorker,
            this.ShowWorkWorkers,
            this.ShowDismissWorkers,
            this.ShowAllWorkers});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // AddNewWorker
            // 
            this.AddNewWorker.Name = "AddNewWorker";
            this.AddNewWorker.Size = new System.Drawing.Size(285, 22);
            this.AddNewWorker.Text = "Добавить нового сотрудника";
            this.AddNewWorker.Click += new System.EventHandler(this.AddNewWorker_Click);
            // 
            // ChangeInfWorker
            // 
            this.ChangeInfWorker.Name = "ChangeInfWorker";
            this.ChangeInfWorker.Size = new System.Drawing.Size(285, 22);
            this.ChangeInfWorker.Text = "Изменить информацию о сотруднике";
            this.ChangeInfWorker.Click += new System.EventHandler(this.ChangeInfWorker_Click);
            // 
            // DismissWorker
            // 
            this.DismissWorker.Name = "DismissWorker";
            this.DismissWorker.Size = new System.Drawing.Size(285, 22);
            this.DismissWorker.Text = "Уволить сотрудника";
            this.DismissWorker.Click += new System.EventHandler(this.DismissWorker_Click);
            // 
            // ShowWorkWorkers
            // 
            this.ShowWorkWorkers.Name = "ShowWorkWorkers";
            this.ShowWorkWorkers.Size = new System.Drawing.Size(285, 22);
            this.ShowWorkWorkers.Text = "Отобразить работающих сотрудников";
            this.ShowWorkWorkers.Click += new System.EventHandler(this.ShowWorkWorkers_Click);
            // 
            // ShowDismissWorkers
            // 
            this.ShowDismissWorkers.Name = "ShowDismissWorkers";
            this.ShowDismissWorkers.Size = new System.Drawing.Size(285, 22);
            this.ShowDismissWorkers.Text = "Отобразить уволенных сотрудников";
            this.ShowDismissWorkers.Click += new System.EventHandler(this.ShowDismissWorkers_Click);
            // 
            // ShowAllWorkers
            // 
            this.ShowAllWorkers.Name = "ShowAllWorkers";
            this.ShowAllWorkers.Size = new System.Drawing.Size(285, 22);
            this.ShowAllWorkers.Text = "Отобразить всех";
            this.ShowAllWorkers.Click += new System.EventHandler(this.ShowAllWorkers_Click);
            // 
            // персоналDataGridView
            // 
            this.персоналDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.персоналDataGridView.AutoGenerateColumns = false;
            this.персоналDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.персоналDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.персоналDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.персоналDataGridView.DataSource = this.персоналBindingSource;
            this.персоналDataGridView.Location = new System.Drawing.Point(12, 28);
            this.персоналDataGridView.Name = "персоналDataGridView";
            this.персоналDataGridView.ReadOnly = true;
            this.персоналDataGridView.Size = new System.Drawing.Size(947, 475);
            this.персоналDataGridView.TabIndex = 2;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НомераTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = this.персоналTableAdapter;
            this.tableAdapterManager.СвободныеНомераTableAdapter = null;
            this.tableAdapterManager.УчетРаботыTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодСотрудника";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код сотрудника";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "СерияНомерПаспорта";
            this.dataGridViewTextBoxColumn5.HeaderText = "Серия и номер паспорта";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ДатаРождения";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "НачалоРабДня";
            this.dataGridViewTextBoxColumn8.HeaderText = "Начало рабочего дня";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "КонецРабДня";
            this.dataGridViewTextBoxColumn9.HeaderText = "Конец рабочего дня";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn10.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn11.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Статус";
            this.dataGridViewTextBoxColumn12.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 515);
            this.Controls.Add(this.персоналDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Workers";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Workers_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddNewWorker;
        private System.Windows.Forms.ToolStripMenuItem ChangeInfWorker;
        private System.Windows.Forms.ToolStripMenuItem DismissWorker;
        private System.Windows.Forms.ToolStripMenuItem ShowWorkWorkers;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private HotelDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView персоналDataGridView;
        private System.Windows.Forms.ToolStripMenuItem ShowDismissWorkers;
        private System.Windows.Forms.ToolStripMenuItem ShowAllWorkers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}