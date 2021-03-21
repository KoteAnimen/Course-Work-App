
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
            System.Windows.Forms.Label началоРабДняLabel;
            System.Windows.Forms.Label конецРабДняLabel;
            System.Windows.Forms.Label должностьLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.персоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.датаРожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.серияНомерПаспортаTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.персоналTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.ПерсоналTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.кодСотрудникаTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.конецРабДняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.началоРабДняDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddWorker = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.должностьComboBox = new System.Windows.Forms.ComboBox();
            кодСотрудникаLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            серияНомерПаспортаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            датаРожденияLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            началоРабДняLabel = new System.Windows.Forms.Label();
            конецРабДняLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодСотрудникаLabel
            // 
            кодСотрудникаLabel.AutoSize = true;
            кодСотрудникаLabel.Location = new System.Drawing.Point(20, 36);
            кодСотрудникаLabel.Name = "кодСотрудникаLabel";
            кодСотрудникаLabel.Size = new System.Drawing.Size(117, 17);
            кодСотрудникаLabel.TabIndex = 0;
            кодСотрудникаLabel.Text = "Код сотрудника:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(19, 35);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(74, 17);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(54, 65);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(39, 17);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(18, 98);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(75, 17);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // серияНомерПаспортаLabel
            // 
            серияНомерПаспортаLabel.AutoSize = true;
            серияНомерПаспортаLabel.Location = new System.Drawing.Point(330, 35);
            серияНомерПаспортаLabel.Name = "серияНомерПаспортаLabel";
            серияНомерПаспортаLabel.Size = new System.Drawing.Size(176, 17);
            серияНомерПаспортаLabel.TabIndex = 8;
            серияНомерПаспортаLabel.Text = "Серия и номер паспорта:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(369, 65);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 10;
            адресLabel.Text = "Адрес:";
            // 
            // датаРожденияLabel
            // 
            датаРожденияLabel.AutoSize = true;
            датаРожденияLabel.Location = new System.Drawing.Point(360, 101);
            датаРожденияLabel.Name = "датаРожденияLabel";
            датаРожденияLabel.Size = new System.Drawing.Size(116, 17);
            датаРожденияLabel.TabIndex = 12;
            датаРожденияLabel.Text = "Дата Рождения:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(20, 128);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 14;
            телефонLabel.Text = "Телефон:";
            // 
            // началоРабДняLabel
            // 
            началоРабДняLabel.AutoSize = true;
            началоРабДняLabel.Location = new System.Drawing.Point(321, 36);
            началоРабДняLabel.Name = "началоРабДняLabel";
            началоРабДняLabel.Size = new System.Drawing.Size(155, 17);
            началоРабДняLabel.TabIndex = 4;
            началоРабДняLabel.Text = "Начало рабочего дня:";
            // 
            // конецРабДняLabel
            // 
            конецРабДняLabel.AutoSize = true;
            конецРабДняLabel.Location = new System.Drawing.Point(321, 74);
            конецРабДняLabel.Name = "конецРабДняLabel";
            конецРабДняLabel.Size = new System.Drawing.Size(146, 17);
            конецРабДняLabel.TabIndex = 6;
            конецРабДняLabel.Text = "Конец рабочего дня:";
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
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(693, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные сотрудника";
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Телефон", true));
            this.телефонTextBox.Location = new System.Drawing.Point(98, 125);
            this.телефонTextBox.MaxLength = 11;
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(181, 23);
            this.телефонTextBox.TabIndex = 15;
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
            // датаРожденияDateTimePicker
            // 
            this.датаРожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.персоналBindingSource, "ДатаРождения", true));
            this.датаРожденияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаРожденияDateTimePicker.Location = new System.Drawing.Point(482, 98);
            this.датаРожденияDateTimePicker.Name = "датаРожденияDateTimePicker";
            this.датаРожденияDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.датаРожденияDateTimePicker.TabIndex = 13;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(427, 65);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(255, 23);
            this.адресTextBox.TabIndex = 11;
            // 
            // серияНомерПаспортаTextBox
            // 
            this.серияНомерПаспортаTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.серияНомерПаспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "СерияНомерПаспорта", true));
            this.серияНомерПаспортаTextBox.Location = new System.Drawing.Point(507, 32);
            this.серияНомерПаспортаTextBox.MaxLength = 10;
            this.серияНомерПаспортаTextBox.Name = "серияНомерПаспортаTextBox";
            this.серияНомерПаспортаTextBox.Size = new System.Drawing.Size(175, 23);
            this.серияНомерПаспортаTextBox.TabIndex = 9;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(99, 95);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(180, 23);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(99, 62);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(180, 23);
            this.имяTextBox.TabIndex = 5;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(99, 32);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(180, 23);
            this.фамилияTextBox.TabIndex = 3;
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
            // кодСотрудникаTextBox
            // 
            this.кодСотрудникаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "КодСотрудника", true));
            this.кодСотрудникаTextBox.Location = new System.Drawing.Point(145, 33);
            this.кодСотрудникаTextBox.Name = "кодСотрудникаTextBox";
            this.кодСотрудникаTextBox.Size = new System.Drawing.Size(100, 23);
            this.кодСотрудникаTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(должностьLabel);
            this.groupBox2.Controls.Add(this.должностьComboBox);
            this.groupBox2.Controls.Add(конецРабДняLabel);
            this.groupBox2.Controls.Add(this.конецРабДняDateTimePicker);
            this.groupBox2.Controls.Add(началоРабДняLabel);
            this.groupBox2.Controls.Add(this.началоРабДняDateTimePicker);
            this.groupBox2.Controls.Add(this.кодСотрудникаTextBox);
            this.groupBox2.Controls.Add(кодСотрудникаLabel);
            this.groupBox2.Location = new System.Drawing.Point(17, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Рабочие данные сотрудника";
            // 
            // конецРабДняDateTimePicker
            // 
            this.конецРабДняDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.персоналBindingSource, "КонецРабДня", true));
            this.конецРабДняDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.конецРабДняDateTimePicker.Location = new System.Drawing.Point(482, 74);
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
            this.началоРабДняDateTimePicker.Location = new System.Drawing.Point(482, 36);
            this.началоРабДняDateTimePicker.Name = "началоРабДняDateTimePicker";
            this.началоРабДняDateTimePicker.ShowUpDown = true;
            this.началоРабДняDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.началоРабДняDateTimePicker.TabIndex = 5;
            this.началоРабДняDateTimePicker.Value = new System.DateTime(2021, 3, 21, 0, 0, 0, 0);
            // 
            // AddWorker
            // 
            this.AddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWorker.Location = new System.Drawing.Point(17, 328);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(309, 45);
            this.AddWorker.TabIndex = 2;
            this.AddWorker.Text = "Добавить нового сотрудника";
            this.AddWorker.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(401, 328);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(309, 45);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(33, 74);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(85, 17);
            должностьLabel.TabIndex = 7;
            должностьLabel.Text = "Должность:";
            // 
            // должностьComboBox
            // 
            this.должностьComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.персоналBindingSource, "Должность", true));
            this.должностьComboBox.FormattingEnabled = true;
            this.должностьComboBox.Location = new System.Drawing.Point(124, 71);
            this.должностьComboBox.Name = "должностьComboBox";
            this.должностьComboBox.Size = new System.Drawing.Size(121, 24);
            this.должностьComboBox.TabIndex = 8;
            // 
            // WorkerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 390);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddWorker);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkerProfile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анкета сотрудника";
            this.Load += new System.EventHandler(this.WorkerProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.персоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
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
        private System.Windows.Forms.DateTimePicker конецРабДняDateTimePicker;
        private System.Windows.Forms.DateTimePicker началоРабДняDateTimePicker;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox должностьComboBox;
    }
}