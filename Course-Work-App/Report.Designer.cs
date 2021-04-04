
namespace Course_Work_App
{
    partial class Report
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
            this.Save = new System.Windows.Forms.ToolStrip();
            this.SaveReport = new System.Windows.Forms.ToolStripButton();
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.учетРаботыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учетРаботыTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.УчетРаботыTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.listSalaryWorkersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listSalaryWorkersTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.ListSalaryWorkersTableAdapter();
            this.учетРаботыDataGridView = new System.Windows.Forms.DataGridView();
            this.tableCount = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSalaryWorkersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCount)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveReport});
            this.Save.Location = new System.Drawing.Point(0, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(1067, 25);
            this.Save.TabIndex = 0;
            // 
            // SaveReport
            // 
            this.SaveReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveReport.Image = global::Course_Work_App.Properties.Resources.save;
            this.SaveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(23, 22);
            this.SaveReport.Text = "Сохранить отчет";
            this.SaveReport.Click += new System.EventHandler(this.SaveReport_Click);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // учетРаботыBindingSource
            // 
            this.учетРаботыBindingSource.DataMember = "УчетРаботы";
            this.учетРаботыBindingSource.DataSource = this.hotelDataSet;
            // 
            // учетРаботыTableAdapter
            // 
            this.учетРаботыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НомераTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.СвободныеНомераTableAdapter = null;
            this.tableAdapterManager.УчетРаботыTableAdapter = this.учетРаботыTableAdapter;
            // 
            // listSalaryWorkersBindingSource
            // 
            this.listSalaryWorkersBindingSource.DataMember = "ListSalaryWorkers";
            this.listSalaryWorkersBindingSource.DataSource = this.hotelDataSet;
            // 
            // listSalaryWorkersTableAdapter
            // 
            this.listSalaryWorkersTableAdapter.ClearBeforeFill = true;
            // 
            // учетРаботыDataGridView
            // 
            this.учетРаботыDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.учетРаботыDataGridView.AutoGenerateColumns = false;
            this.учетРаботыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.учетРаботыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.учетРаботыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.учетРаботыDataGridView.DataSource = this.учетРаботыBindingSource;
            this.учетРаботыDataGridView.Location = new System.Drawing.Point(12, 28);
            this.учетРаботыDataGridView.Name = "учетРаботыDataGridView";
            this.учетРаботыDataGridView.Size = new System.Drawing.Size(1043, 393);
            this.учетРаботыDataGridView.TabIndex = 1;
            // 
            // tableCount
            // 
            this.tableCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCount.Location = new System.Drawing.Point(13, 427);
            this.tableCount.Name = "tableCount";
            this.tableCount.Size = new System.Drawing.Size(1042, 115);
            this.tableCount.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодОперации";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код операции";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "КодНомера";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код номера";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "КодКлиента";
            this.dataGridViewTextBoxColumn3.HeaderText = "Код клиента";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ДатаЗаселения";
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата заселения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ДатаВыселения";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата выселения";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ОбщСтоимостьПроживания";
            this.dataGridViewTextBoxColumn6.HeaderText = "Стоимость проживания";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableCount);
            this.Controls.Add(this.учетРаботыDataGridView);
            this.Controls.Add(this.Save);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет за текущий месяц";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            this.Save.ResumeLayout(false);
            this.Save.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSalaryWorkersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Save;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource учетРаботыBindingSource;
        private HotelDataSetTableAdapters.УчетРаботыTableAdapter учетРаботыTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource listSalaryWorkersBindingSource;
        private HotelDataSetTableAdapters.ListSalaryWorkersTableAdapter listSalaryWorkersTableAdapter;
        private System.Windows.Forms.DataGridView учетРаботыDataGridView;
        private System.Windows.Forms.DataGridView tableCount;
        private System.Windows.Forms.ToolStripButton SaveReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}