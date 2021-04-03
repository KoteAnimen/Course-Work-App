﻿
namespace Course_Work_App
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.fullyRoomsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullyRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.номераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номераTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.НомераTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.учетРаботыTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.УчетРаботыTableAdapter();
            this.учетРаботыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullyRoomsTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.FullyRoomsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JobPositions = new System.Windows.Forms.Button();
            this.Workers = new System.Windows.Forms.Button();
            this.Accounting = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullyRoomsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullyRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgram});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutProgram
            // 
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(158, 22);
            this.AboutProgram.Text = "О программе";
            // 
            // fullyRoomsDataGridView
            // 
            this.fullyRoomsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullyRoomsDataGridView.AutoGenerateColumns = false;
            this.fullyRoomsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fullyRoomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fullyRoomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.fullyRoomsDataGridView.DataSource = this.fullyRoomsBindingSource;
            this.fullyRoomsDataGridView.Location = new System.Drawing.Point(13, 551);
            this.fullyRoomsDataGridView.Name = "fullyRoomsDataGridView";
            this.fullyRoomsDataGridView.Size = new System.Drawing.Size(693, 279);
            this.fullyRoomsDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодНомера";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодНомера";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Состояние";
            this.dataGridViewTextBoxColumn2.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ДатаВыселения";
            this.dataGridViewTextBoxColumn3.HeaderText = "ДатаВыселения";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // fullyRoomsBindingSource
            // 
            this.fullyRoomsBindingSource.DataMember = "FullyRooms";
            this.fullyRoomsBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // номераBindingSource
            // 
            this.номераBindingSource.DataMember = "Номера";
            this.номераBindingSource.DataSource = this.hotelDataSet;
            // 
            // номераTableAdapter
            // 
            this.номераTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НомераTableAdapter = this.номераTableAdapter;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.СвободныеНомераTableAdapter = null;
            this.tableAdapterManager.УчетРаботыTableAdapter = this.учетРаботыTableAdapter;
            // 
            // учетРаботыTableAdapter
            // 
            this.учетРаботыTableAdapter.ClearBeforeFill = true;
            // 
            // учетРаботыBindingSource
            // 
            this.учетРаботыBindingSource.DataMember = "УчетРаботы";
            this.учетРаботыBindingSource.DataSource = this.hotelDataSet;
            // 
            // fullyRoomsTableAdapter
            // 
            this.fullyRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackgroundImage = global::Course_Work_App.Properties.Resources.hotel;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.JobPositions);
            this.groupBox1.Controls.Add(this.Workers);
            this.groupBox1.Controls.Add(this.Accounting);
            this.groupBox1.Controls.Add(this.Clients);
            this.groupBox1.Controls.Add(this.Rooms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(693, 515);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Главное меню";
            // 
            // JobPositions
            // 
            this.JobPositions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.JobPositions.Location = new System.Drawing.Point(8, 460);
            this.JobPositions.Margin = new System.Windows.Forms.Padding(4);
            this.JobPositions.Name = "JobPositions";
            this.JobPositions.Size = new System.Drawing.Size(676, 47);
            this.JobPositions.TabIndex = 4;
            this.JobPositions.Text = "Должности";
            this.JobPositions.UseVisualStyleBackColor = true;
            this.JobPositions.Click += new System.EventHandler(this.JobPositions_Click);
            // 
            // Workers
            // 
            this.Workers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Workers.Location = new System.Drawing.Point(8, 240);
            this.Workers.Margin = new System.Windows.Forms.Padding(4);
            this.Workers.Name = "Workers";
            this.Workers.Size = new System.Drawing.Size(676, 47);
            this.Workers.TabIndex = 3;
            this.Workers.Text = "Персонал";
            this.Workers.UseVisualStyleBackColor = true;
            this.Workers.Click += new System.EventHandler(this.Workers_Click);
            // 
            // Accounting
            // 
            this.Accounting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Accounting.Location = new System.Drawing.Point(9, 405);
            this.Accounting.Margin = new System.Windows.Forms.Padding(4);
            this.Accounting.Name = "Accounting";
            this.Accounting.Size = new System.Drawing.Size(676, 47);
            this.Accounting.TabIndex = 2;
            this.Accounting.Text = "Список операций";
            this.Accounting.UseVisualStyleBackColor = true;
            this.Accounting.Click += new System.EventHandler(this.Accounting_Click);
            // 
            // Clients
            // 
            this.Clients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clients.Location = new System.Drawing.Point(9, 350);
            this.Clients.Margin = new System.Windows.Forms.Padding(4);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(676, 47);
            this.Clients.TabIndex = 1;
            this.Clients.Text = "Клиенты";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // Rooms
            // 
            this.Rooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rooms.Location = new System.Drawing.Point(9, 295);
            this.Rooms.Margin = new System.Windows.Forms.Padding(4);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(676, 47);
            this.Rooms.TabIndex = 0;
            this.Rooms.Text = "Номера";
            this.Rooms.UseVisualStyleBackColor = true;
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 842);
            this.Controls.Add(this.fullyRoomsDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гостиница";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullyRoomsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullyRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button JobPositions;
        private System.Windows.Forms.Button Workers;
        private System.Windows.Forms.Button Accounting;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Rooms;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgram;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource номераBindingSource;
        private HotelDataSetTableAdapters.НомераTableAdapter номераTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotelDataSetTableAdapters.УчетРаботыTableAdapter учетРаботыTableAdapter;
        private System.Windows.Forms.BindingSource учетРаботыBindingSource;
        private System.Windows.Forms.BindingSource fullyRoomsBindingSource;
        private HotelDataSetTableAdapters.FullyRoomsTableAdapter fullyRoomsTableAdapter;
        private System.Windows.Forms.DataGridView fullyRoomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

