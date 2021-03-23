
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
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.номераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номераTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.НомераTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.кодНомераTextBox = new System.Windows.Forms.TextBox();
            this.суточнаяСтоимостьTextBox = new System.Windows.Forms.TextBox();
            this.количествоМестNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.кодСотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            кодНомераLabel = new System.Windows.Forms.Label();
            суточнаяСтоимостьLabel = new System.Windows.Forms.Label();
            количествоМестLabel = new System.Windows.Forms.Label();
            кодСотрудникаLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.количествоМестNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(кодСотрудникаLabel);
            this.groupBox1.Controls.Add(this.кодСотрудникаTextBox);
            this.groupBox1.Controls.Add(количествоМестLabel);
            this.groupBox1.Controls.Add(this.количествоМестNumericUpDown);
            this.groupBox1.Controls.Add(суточнаяСтоимостьLabel);
            this.groupBox1.Controls.Add(this.суточнаяСтоимостьTextBox);
            this.groupBox1.Controls.Add(кодНомераLabel);
            this.groupBox1.Controls.Add(this.кодНомераTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(326, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры номера";
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
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НомераTableAdapter = this.номераTableAdapter;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.УчетРаботыTableAdapter = null;
            // 
            // кодНомераLabel
            // 
            кодНомераLabel.AutoSize = true;
            кодНомераLabel.Location = new System.Drawing.Point(80, 40);
            кодНомераLabel.Name = "кодНомераLabel";
            кодНомераLabel.Size = new System.Drawing.Size(90, 17);
            кодНомераLabel.TabIndex = 0;
            кодНомераLabel.Text = "Код номера:";
            // 
            // кодНомераTextBox
            // 
            this.кодНомераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номераBindingSource, "КодНомера", true));
            this.кодНомераTextBox.Location = new System.Drawing.Point(178, 37);
            this.кодНомераTextBox.Name = "кодНомераTextBox";
            this.кодНомераTextBox.Size = new System.Drawing.Size(124, 23);
            this.кодНомераTextBox.TabIndex = 1;
            // 
            // суточнаяСтоимостьLabel
            // 
            суточнаяСтоимостьLabel.AutoSize = true;
            суточнаяСтоимостьLabel.Location = new System.Drawing.Point(23, 75);
            суточнаяСтоимостьLabel.Name = "суточнаяСтоимостьLabel";
            суточнаяСтоимостьLabel.Size = new System.Drawing.Size(147, 17);
            суточнаяСтоимостьLabel.TabIndex = 2;
            суточнаяСтоимостьLabel.Text = "Суточная стоимость:";
            // 
            // суточнаяСтоимостьTextBox
            // 
            this.суточнаяСтоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номераBindingSource, "СуточнаяСтоимость", true));
            this.суточнаяСтоимостьTextBox.Location = new System.Drawing.Point(178, 72);
            this.суточнаяСтоимостьTextBox.Name = "суточнаяСтоимостьTextBox";
            this.суточнаяСтоимостьTextBox.Size = new System.Drawing.Size(124, 23);
            this.суточнаяСтоимостьTextBox.TabIndex = 3;
            // 
            // количествоМестLabel
            // 
            количествоМестLabel.AutoSize = true;
            количествоМестLabel.Location = new System.Drawing.Point(45, 107);
            количествоМестLabel.Name = "количествоМестLabel";
            количествоМестLabel.Size = new System.Drawing.Size(125, 17);
            количествоМестLabel.TabIndex = 4;
            количествоМестLabel.Text = "Количество мест:";
            // 
            // количествоМестNumericUpDown
            // 
            this.количествоМестNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.номераBindingSource, "КоличествоМест", true));
            this.количествоМестNumericUpDown.Location = new System.Drawing.Point(178, 107);
            this.количествоМестNumericUpDown.Name = "количествоМестNumericUpDown";
            this.количествоМестNumericUpDown.Size = new System.Drawing.Size(124, 23);
            this.количествоМестNumericUpDown.TabIndex = 5;
            // 
            // кодСотрудникаLabel
            // 
            кодСотрудникаLabel.AutoSize = true;
            кодСотрудникаLabel.Location = new System.Drawing.Point(53, 142);
            кодСотрудникаLabel.Name = "кодСотрудникаLabel";
            кодСотрудникаLabel.Size = new System.Drawing.Size(117, 17);
            кодСотрудникаLabel.TabIndex = 6;
            кодСотрудникаLabel.Text = "Код сотрудника:";
            // 
            // кодСотрудникаTextBox
            // 
            this.кодСотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номераBindingSource, "КодСотрудника", true));
            this.кодСотрудникаTextBox.Location = new System.Drawing.Point(178, 139);
            this.кодСотрудникаTextBox.Name = "кодСотрудникаTextBox";
            this.кодСотрудникаTextBox.Size = new System.Drawing.Size(124, 23);
            this.кодСотрудникаTextBox.TabIndex = 7;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(17, 233);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(156, 34);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(187, 233);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(156, 34);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 286);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoom";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить комнату(номер)";
            this.Load += new System.EventHandler(this.AddRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.количествоМестNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource номераBindingSource;
        private HotelDataSetTableAdapters.НомераTableAdapter номераTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox кодНомераTextBox;
        private System.Windows.Forms.TextBox кодСотрудникаTextBox;
        private System.Windows.Forms.NumericUpDown количествоМестNumericUpDown;
        private System.Windows.Forms.TextBox суточнаяСтоимостьTextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Cancel;
    }
}