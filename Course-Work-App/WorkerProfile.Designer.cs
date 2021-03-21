
namespace Course_Work_App
{
    partial class WorkerProfile
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
            System.Windows.Forms.Label кодСотрудникаLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label серияНомерПаспортаLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label датаРожденияLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label началоРабДняLabel;
            System.Windows.Forms.Label конецРабДняLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.персоналTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.ПерсоналTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.кодСотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.серияНомерПаспортаTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.датаРожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.конецРабДняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.началоРабДняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            кодСотрудникаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            серияНомерПаспортаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            датаРожденияLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            началоРабДняLabel = new System.Windows.Forms.Label();
            конецРабДняLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(датаРожденияLabel);
            this.groupBox1.Controls.Add(this.датаРожденияDateTimePicker);
            this.groupBox1.Controls.Add(адресLabel);
            this.groupBox1.Controls.Add(this.адресTextBox);
            this.groupBox1.Controls.Add(серияНомерПаспортаLabel);
            this.groupBox1.Controls.Add(this.серияНомерПаспортаTextBox);
            this.groupBox1.Controls.Add(отчествоLabel);
            this.groupBox1.Controls.Add(this.отчествоTextBox);
            this.groupBox1.Controls.Add(имяLabel);
            this.groupBox1.Controls.Add(this.имяTextBox);
            this.groupBox1.Controls.Add(фамилияLabel);
            this.groupBox1.Controls.Add(this.фамилияTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(693, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные сотрудника";
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
            // персоналTableAdapter
            // 
            this.персоналTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НомераTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = this.персоналTableAdapter;
            this.tableAdapterManager.УчетРаботыTableAdapter = null;
            // 
            // кодСотрудникаLabel
            // 
            кодСотрудникаLabel.AutoSize = true;
            кодСотрудникаLabel.Location = new System.Drawing.Point(20, 36);
            кодСотрудникаLabel.Name = "кодСотрудникаLabel";
            кодСотрудникаLabel.Size = new System.Drawing.Size(119, 17);
            кодСотрудникаLabel.TabIndex = 0;
            кодСотрудникаLabel.Text = "Код Сотрудника:";
            // 
            // кодСотрудникаTextBox
            // 
            this.кодСотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "КодСотрудника", true));
            this.кодСотрудникаTextBox.Location = new System.Drawing.Point(145, 33);
            this.кодСотрудникаTextBox.Name = "кодСотрудникаTextBox";
            this.кодСотрудникаTextBox.Size = new System.Drawing.Size(100, 23);
            this.кодСотрудникаTextBox.TabIndex = 1;
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(66, 86);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(74, 17);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(146, 83);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 23);
            this.фамилияTextBox.TabIndex = 3;
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(100, 132);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(39, 17);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(145, 129);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 23);
            this.имяTextBox.TabIndex = 5;
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(96, 186);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(75, 17);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(177, 183);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 23);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // серияНомерПаспортаLabel
            // 
            серияНомерПаспортаLabel.AutoSize = true;
            серияНомерПаспортаLabel.Location = new System.Drawing.Point(92, 241);
            серияНомерПаспортаLabel.Name = "серияНомерПаспортаLabel";
            серияНомерПаспортаLabel.Size = new System.Drawing.Size(168, 17);
            серияНомерПаспортаLabel.TabIndex = 8;
            серияНомерПаспортаLabel.Text = "Серия Номер Паспорта:";
            // 
            // серияНомерПаспортаTextBox
            // 
            this.серияНомерПаспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "СерияНомерПаспорта", true));
            this.серияНомерПаспортаTextBox.Location = new System.Drawing.Point(266, 238);
            this.серияНомерПаспортаTextBox.Name = "серияНомерПаспортаTextBox";
            this.серияНомерПаспортаTextBox.Size = new System.Drawing.Size(100, 23);
            this.серияНомерПаспортаTextBox.TabIndex = 9;
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(333, 63);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 10;
            адресLabel.Text = "Адрес:";
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(391, 60);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(100, 23);
            this.адресTextBox.TabIndex = 11;
            // 
            // датаРожденияLabel
            // 
            датаРожденияLabel.AutoSize = true;
            датаРожденияLabel.Location = new System.Drawing.Point(351, 129);
            датаРожденияLabel.Name = "датаРожденияLabel";
            датаРожденияLabel.Size = new System.Drawing.Size(116, 17);
            датаРожденияLabel.TabIndex = 12;
            датаРожденияLabel.Text = "Дата Рождения:";
            // 
            // датаРожденияDateTimePicker
            // 
            this.датаРожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.персоналBindingSource, "ДатаРождения", true));
            this.датаРожденияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаРожденияDateTimePicker.Location = new System.Drawing.Point(473, 125);
            this.датаРожденияDateTimePicker.Name = "датаРожденияDateTimePicker";
            this.датаРожденияDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.датаРожденияDateTimePicker.TabIndex = 13;
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(454, 239);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 14;
            телефонLabel.Text = "Телефон:";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(532, 236);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(100, 23);
            this.телефонTextBox.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(конецРабДняLabel);
            this.groupBox2.Controls.Add(this.конецРабДняDateTimePicker);
            this.groupBox2.Controls.Add(началоРабДняLabel);
            this.groupBox2.Controls.Add(this.началоРабДняDateTimePicker);
            this.groupBox2.Controls.Add(должностьLabel);
            this.groupBox2.Controls.Add(this.должностьTextBox);
            this.groupBox2.Controls.Add(this.кодСотрудникаTextBox);
            this.groupBox2.Controls.Add(кодСотрудникаLabel);
            this.groupBox2.Location = new System.Drawing.Point(17, 343);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(41, 94);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(85, 17);
            должностьLabel.TabIndex = 2;
            должностьLabel.Text = "Должность:";
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(132, 91);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(100, 23);
            this.должностьTextBox.TabIndex = 3;
            // 
            // началоРабДняLabel
            // 
            началоРабДняLabel.AutoSize = true;
            началоРабДняLabel.Location = new System.Drawing.Point(371, 56);
            началоРабДняLabel.Name = "началоРабДняLabel";
            началоРабДняLabel.Size = new System.Drawing.Size(122, 17);
            началоРабДняLabel.TabIndex = 4;
            началоРабДняLabel.Text = "Начало Раб Дня:";
            // 
            // конецРабДняLabel
            // 
            конецРабДняLabel.AutoSize = true;
            конецРабДняLabel.Location = new System.Drawing.Point(380, 105);
            конецРабДняLabel.Name = "конецРабДняLabel";
            конецРабДняLabel.Size = new System.Drawing.Size(113, 17);
            конецРабДняLabel.TabIndex = 6;
            конецРабДняLabel.Text = "Конец Раб Дня:";
            // 
            // конецРабДняDateTimePicker
            // 
            this.конецРабДняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.персоналBindingSource, "КонецРабДня", true));
            this.конецРабДняDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.конецРабДняDateTimePicker.Location = new System.Drawing.Point(499, 101);
            this.конецРабДняDateTimePicker.Name = "конецРабДняDateTimePicker";
            this.конецРабДняDateTimePicker.ShowUpDown = true;
            this.конецРабДняDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.конецРабДняDateTimePicker.TabIndex = 7;
            this.конецРабДняDateTimePicker.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            // 
            // началоРабДняDateTimePicker
            // 
            this.началоРабДняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.персоналBindingSource, "НачалоРабДня", true));
            this.началоРабДняDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.началоРабДняDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.началоРабДняDateTimePicker.Location = new System.Drawing.Point(499, 52);
            this.началоРабДняDateTimePicker.Name = "началоРабДняDateTimePicker";
            this.началоРабДняDateTimePicker.ShowUpDown = true;
            this.началоРабДняDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.началоРабДняDateTimePicker.TabIndex = 5;
            this.началоРабДняDateTimePicker.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            // 
            // WorkerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerProfile";
            this.ShowIcon = false;
            this.Text = "Анкета сотрудника";
            this.Load += new System.EventHandler(this.WorkerProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource персоналBindingSource;
        private HotelDataSetTableAdapters.ПерсоналTableAdapter персоналTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.DateTimePicker датаРожденияDateTimePicker;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox серияНомерПаспортаTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox кодСотрудникаTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.DateTimePicker конецРабДняDateTimePicker;
        private System.Windows.Forms.DateTimePicker началоРабДняDateTimePicker;
    }
}