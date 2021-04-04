
namespace Course_Work_App
{
    partial class AddRoom
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
            System.Windows.Forms.Label кодНомераLabel;
            System.Windows.Forms.Label суточнаяСтоимостьLabel;
            System.Windows.Forms.Label количествоМестLabel;
            System.Windows.Forms.Label кодСотрудникаLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.кодСотрудникаComboBox = new System.Windows.Forms.ComboBox();
            this.номераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.количествоМестNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.суточнаяСтоимостьTextBox = new System.Windows.Forms.TextBox();
            this.кодНомераTextBox = new System.Windows.Forms.TextBox();
            this.номераTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.НомераTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.персоналTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.ПерсоналTableAdapter();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.WorkersTableAdapter();
            this.workersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            кодНомераLabel = new System.Windows.Forms.Label();
            суточнаяСтоимостьLabel = new System.Windows.Forms.Label();
            количествоМестLabel = new System.Windows.Forms.Label();
            кодСотрудникаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.количествоМестNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // кодНомераLabel
            // 
            кодНомераLabel.AutoSize = true;
            кодНомераLabel.Location = new System.Drawing.Point(62, 40);
            кодНомераLabel.Name = "кодНомераLabel";
            кодНомераLabel.Size = new System.Drawing.Size(90, 17);
            кодНомераLabel.TabIndex = 0;
            кодНомераLabel.Text = "Код номера:";
            // 
            // суточнаяСтоимостьLabel
            // 
            суточнаяСтоимостьLabel.AutoSize = true;
            суточнаяСтоимостьLabel.Location = new System.Drawing.Point(5, 75);
            суточнаяСтоимостьLabel.Name = "суточнаяСтоимостьLabel";
            суточнаяСтоимостьLabel.Size = new System.Drawing.Size(147, 17);
            суточнаяСтоимостьLabel.TabIndex = 2;
            суточнаяСтоимостьLabel.Text = "Суточная стоимость:";
            // 
            // количествоМестLabel
            // 
            количествоМестLabel.AutoSize = true;
            количествоМестLabel.Location = new System.Drawing.Point(305, 40);
            количествоМестLabel.Name = "количествоМестLabel";
            количествоМестLabel.Size = new System.Drawing.Size(125, 17);
            количествоМестLabel.TabIndex = 4;
            количествоМестLabel.Text = "Количество мест:";
            // 
            // кодСотрудникаLabel
            // 
            кодСотрудникаLabel.AutoSize = true;
            кодСотрудникаLabel.Location = new System.Drawing.Point(313, 72);
            кодСотрудникаLabel.Name = "кодСотрудникаLabel";
            кодСотрудникаLabel.Size = new System.Drawing.Size(117, 17);
            кодСотрудникаLabel.TabIndex = 6;
            кодСотрудникаLabel.Text = "Код сотрудника:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(кодСотрудникаLabel);
            this.groupBox1.Controls.Add(this.кодСотрудникаComboBox);
            this.groupBox1.Controls.Add(количествоМестLabel);
            this.groupBox1.Controls.Add(this.количествоМестNumericUpDown);
            this.groupBox1.Controls.Add(суточнаяСтоимостьLabel);
            this.groupBox1.Controls.Add(this.суточнаяСтоимостьTextBox);
            this.groupBox1.Controls.Add(кодНомераLabel);
            this.groupBox1.Controls.Add(this.кодНомераTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(573, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры номера";
            // 
            // кодСотрудникаComboBox
            // 
            this.кодСотрудникаComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номераBindingSource, "КодСотрудника", true));
            this.кодСотрудникаComboBox.DataSource = this.персоналBindingSource;
            this.кодСотрудникаComboBox.DisplayMember = "КодСотрудника";
            this.кодСотрудникаComboBox.FormattingEnabled = true;
            this.кодСотрудникаComboBox.Location = new System.Drawing.Point(438, 69);
            this.кодСотрудникаComboBox.Name = "кодСотрудникаComboBox";
            this.кодСотрудникаComboBox.Size = new System.Drawing.Size(124, 24);
            this.кодСотрудникаComboBox.TabIndex = 7;
            // 
            // номераBindingSource
            // 
            this.номераBindingSource.DataMember = "Номера";
            this.номераBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // персоналBindingSource
            // 
            this.персоналBindingSource.DataMember = "Персонал";
            this.персоналBindingSource.DataSource = this.hotelDataSet;
            // 
            // количествоМестNumericUpDown
            // 
            this.количествоМестNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.номераBindingSource, "КоличествоМест", true));
            this.количествоМестNumericUpDown.Location = new System.Drawing.Point(438, 40);
            this.количествоМестNumericUpDown.Name = "количествоМестNumericUpDown";
            this.количествоМестNumericUpDown.Size = new System.Drawing.Size(124, 23);
            this.количествоМестNumericUpDown.TabIndex = 5;
            // 
            // суточнаяСтоимостьTextBox
            // 
            this.суточнаяСтоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номераBindingSource, "СуточнаяСтоимость", true));
            this.суточнаяСтоимостьTextBox.Location = new System.Drawing.Point(160, 72);
            this.суточнаяСтоимостьTextBox.Name = "суточнаяСтоимостьTextBox";
            this.суточнаяСтоимостьTextBox.Size = new System.Drawing.Size(124, 23);
            this.суточнаяСтоимостьTextBox.TabIndex = 3;
            // 
            // кодНомераTextBox
            // 
            this.кодНомераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номераBindingSource, "КодНомера", true));
            this.кодНомераTextBox.Location = new System.Drawing.Point(160, 37);
            this.кодНомераTextBox.Name = "кодНомераTextBox";
            this.кодНомераTextBox.Size = new System.Drawing.Size(124, 23);
            this.кодНомераTextBox.TabIndex = 1;
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
            this.tableAdapterManager.УчетРаботыTableAdapter = null;
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(17, 346);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(233, 41);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(360, 346);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(233, 41);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "Workers";
            this.workersBindingSource.DataSource = this.hotelDataSet;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // workersDataGridView
            // 
            this.workersDataGridView.AutoGenerateColumns = false;
            this.workersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.workersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.workersDataGridView.DataSource = this.workersBindingSource;
            this.workersDataGridView.Location = new System.Drawing.Point(17, 135);
            this.workersDataGridView.Name = "workersDataGridView";
            this.workersDataGridView.ReadOnly = true;
            this.workersDataGridView.Size = new System.Drawing.Size(573, 205);
            this.workersDataGridView.TabIndex = 3;
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn5.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 400);
            this.Controls.Add(this.workersDataGridView);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoom";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить комнату(номер)";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.количествоМестNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource номераBindingSource;
        private HotelDataSetTableAdapters.НомераTableAdapter номераTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодНомераTextBox;
        private System.Windows.Forms.NumericUpDown количествоМестNumericUpDown;
        private System.Windows.Forms.TextBox суточнаяСтоимостьTextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox кодСотрудникаComboBox;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private HotelDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private HotelDataSetTableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.DataGridView workersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}