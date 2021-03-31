
namespace Course_Work_App
{
    partial class ShowClientProfile
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label странаLabel;
            System.Windows.Forms.Label серияНомерПаспортаLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label датаРожденияLabel;
            System.Windows.Forms.Label цельПриездаLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label датаЗаселенияLabel;
            System.Windows.Forms.Label датаВыселенияLabel;
            System.Windows.Forms.Label общСтоимостьПроживанияLabel;
            System.Windows.Forms.Label состояниеLabel;
            System.Windows.Forms.Label кодНомераLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.телефонMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.цельПриездаTextBox = new System.Windows.Forms.TextBox();
            this.датаРожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.серияНомерПаспортаTextBox = new System.Windows.Forms.TextBox();
            this.странаTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.кодНомераComboBox = new System.Windows.Forms.ComboBox();
            this.учетРаботыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.номераBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.состояниеComboBox = new System.Windows.Forms.ComboBox();
            this.номераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.общСтоимостьПроживанияTextBox = new System.Windows.Forms.TextBox();
            this.датаВыселенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.датаЗаселенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.клиентыTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.КлиентыTableAdapter();
            this.номераTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.НомераTableAdapter();
            this.учетРаботыTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.УчетРаботыTableAdapter();
            this.Cancel = new System.Windows.Forms.Button();
            this.свободныеНомераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.свободныеНомераTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.СвободныеНомераTableAdapter();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.свободныеНомераDataGridView = new System.Windows.Forms.DataGridView();
            this.accountingTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.AccountingTableAdapter();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            странаLabel = new System.Windows.Forms.Label();
            серияНомерПаспортаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            датаРожденияLabel = new System.Windows.Forms.Label();
            цельПриездаLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            датаЗаселенияLabel = new System.Windows.Forms.Label();
            датаВыселенияLabel = new System.Windows.Forms.Label();
            общСтоимостьПроживанияLabel = new System.Windows.Forms.Label();
            состояниеLabel = new System.Windows.Forms.Label();
            кодНомераLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.свободныеНомераBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.свободныеНомераDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(24, 34);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(74, 17);
            фамилияLabel.TabIndex = 0;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(59, 63);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(39, 17);
            имяLabel.TabIndex = 2;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(23, 92);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(75, 17);
            отчествоLabel.TabIndex = 4;
            отчествоLabel.Text = "Отчество:";
            // 
            // странаLabel
            // 
            странаLabel.AutoSize = true;
            странаLabel.Location = new System.Drawing.Point(38, 121);
            странаLabel.Name = "странаLabel";
            странаLabel.Size = new System.Drawing.Size(60, 17);
            странаLabel.TabIndex = 6;
            странаLabel.Text = "Страна:";
            // 
            // серияНомерПаспортаLabel
            // 
            серияНомерПаспортаLabel.AutoSize = true;
            серияНомерПаспортаLabel.Location = new System.Drawing.Point(296, 34);
            серияНомерПаспортаLabel.Name = "серияНомерПаспортаLabel";
            серияНомерПаспортаLabel.Size = new System.Drawing.Size(176, 17);
            серияНомерПаспортаLabel.TabIndex = 8;
            серияНомерПаспортаLabel.Text = "Серия и номер паспорта:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(420, 63);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 10;
            адресLabel.Text = "Адрес:";
            // 
            // датаРожденияLabel
            // 
            датаРожденияLabel.AutoSize = true;
            датаРожденияLabel.Location = new System.Drawing.Point(356, 93);
            датаРожденияLabel.Name = "датаРожденияLabel";
            датаРожденияLabel.Size = new System.Drawing.Size(115, 17);
            датаРожденияLabel.TabIndex = 12;
            датаРожденияLabel.Text = "Дата рождения:";
            // 
            // цельПриездаLabel
            // 
            цельПриездаLabel.AutoSize = true;
            цельПриездаLabel.Location = new System.Drawing.Point(365, 121);
            цельПриездаLabel.Name = "цельПриездаLabel";
            цельПриездаLabel.Size = new System.Drawing.Size(105, 17);
            цельПриездаLabel.TabIndex = 14;
            цельПриездаLabel.Text = "Цель приезда:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(26, 150);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 16;
            телефонLabel.Text = "Телефон:";
            // 
            // датаЗаселенияLabel
            // 
            датаЗаселенияLabel.AutoSize = true;
            датаЗаселенияLabel.Location = new System.Drawing.Point(240, 43);
            датаЗаселенияLabel.Name = "датаЗаселенияLabel";
            датаЗаселенияLabel.Size = new System.Drawing.Size(120, 17);
            датаЗаселенияLabel.TabIndex = 6;
            датаЗаселенияLabel.Text = "Дата заселения:";
            // 
            // датаВыселенияLabel
            // 
            датаВыселенияLabel.AutoSize = true;
            датаВыселенияLabel.Location = new System.Drawing.Point(238, 87);
            датаВыселенияLabel.Name = "датаВыселенияLabel";
            датаВыселенияLabel.Size = new System.Drawing.Size(122, 17);
            датаВыселенияLabel.TabIndex = 8;
            датаВыселенияLabel.Text = "Дата выселения:";
            // 
            // общСтоимостьПроживанияLabel
            // 
            общСтоимостьПроживанияLabel.AutoSize = true;
            общСтоимостьПроживанияLabel.Location = new System.Drawing.Point(607, 66);
            общСтоимостьПроживанияLabel.Name = "общСтоимостьПроживанияLabel";
            общСтоимостьПроживанияLabel.Size = new System.Drawing.Size(214, 17);
            общСтоимостьПроживанияLabel.TabIndex = 10;
            общСтоимостьПроживанияLabel.Text = "Общая стоимость проживания:";
            // 
            // состояниеLabel
            // 
            состояниеLabel.AutoSize = true;
            состояниеLabel.Location = new System.Drawing.Point(15, 84);
            состояниеLabel.Name = "состояниеLabel";
            состояниеLabel.Size = new System.Drawing.Size(83, 17);
            состояниеLabel.TabIndex = 11;
            состояниеLabel.Text = "Состояние:";
            // 
            // кодНомераLabel
            // 
            кодНомераLabel.AutoSize = true;
            кодНомераLabel.Location = new System.Drawing.Point(6, 43);
            кодНомераLabel.Name = "кодНомераLabel";
            кодНомераLabel.Size = new System.Drawing.Size(92, 17);
            кодНомераLabel.TabIndex = 12;
            кодНомераLabel.Text = "Код Номера:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.телефонMaskedTextBox);
            this.groupBox1.Controls.Add(цельПриездаLabel);
            this.groupBox1.Controls.Add(this.цельПриездаTextBox);
            this.groupBox1.Controls.Add(датаРожденияLabel);
            this.groupBox1.Controls.Add(this.датаРожденияDateTimePicker);
            this.groupBox1.Controls.Add(адресLabel);
            this.groupBox1.Controls.Add(this.адресTextBox);
            this.groupBox1.Controls.Add(серияНомерПаспортаLabel);
            this.groupBox1.Controls.Add(this.серияНомерПаспортаTextBox);
            this.groupBox1.Controls.Add(странаLabel);
            this.groupBox1.Controls.Add(this.странаTextBox);
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
            this.groupBox1.Size = new System.Drawing.Size(873, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личные данные клиента";
            // 
            // телефонMaskedTextBox
            // 
            this.телефонMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Телефон", true));
            this.телефонMaskedTextBox.Location = new System.Drawing.Point(104, 147);
            this.телефонMaskedTextBox.Mask = "0\\-000\\-000\\-00\\-00";
            this.телефонMaskedTextBox.Name = "телефонMaskedTextBox";
            this.телефонMaskedTextBox.Size = new System.Drawing.Size(170, 23);
            this.телефонMaskedTextBox.TabIndex = 17;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.hotelDataSet;
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // цельПриездаTextBox
            // 
            this.цельПриездаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "ЦельПриезда", true));
            this.цельПриездаTextBox.Location = new System.Drawing.Point(478, 118);
            this.цельПриездаTextBox.Name = "цельПриездаTextBox";
            this.цельПриездаTextBox.Size = new System.Drawing.Size(200, 23);
            this.цельПриездаTextBox.TabIndex = 15;
            // 
            // датаРожденияDateTimePicker
            // 
            this.датаРожденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.клиентыBindingSource, "ДатаРождения", true));
            this.датаРожденияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаРожденияDateTimePicker.Location = new System.Drawing.Point(478, 89);
            this.датаРожденияDateTimePicker.Name = "датаРожденияDateTimePicker";
            this.датаРожденияDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.датаРожденияDateTimePicker.TabIndex = 13;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(478, 60);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(360, 23);
            this.адресTextBox.TabIndex = 11;
            // 
            // серияНомерПаспортаTextBox
            // 
            this.серияНомерПаспортаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "СерияНомерПаспорта", true));
            this.серияНомерПаспортаTextBox.Location = new System.Drawing.Point(478, 31);
            this.серияНомерПаспортаTextBox.Name = "серияНомерПаспортаTextBox";
            this.серияНомерПаспортаTextBox.Size = new System.Drawing.Size(200, 23);
            this.серияНомерПаспортаTextBox.TabIndex = 9;
            // 
            // странаTextBox
            // 
            this.странаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Страна", true));
            this.странаTextBox.Location = new System.Drawing.Point(104, 118);
            this.странаTextBox.Name = "странаTextBox";
            this.странаTextBox.Size = new System.Drawing.Size(170, 23);
            this.странаTextBox.TabIndex = 7;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(104, 89);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(170, 23);
            this.отчествоTextBox.TabIndex = 5;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(104, 60);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(170, 23);
            this.имяTextBox.TabIndex = 3;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.клиентыBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(104, 31);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(170, 23);
            this.фамилияTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(кодНомераLabel);
            this.groupBox2.Controls.Add(this.кодНомераComboBox);
            this.groupBox2.Controls.Add(состояниеLabel);
            this.groupBox2.Controls.Add(this.состояниеComboBox);
            this.groupBox2.Controls.Add(общСтоимостьПроживанияLabel);
            this.groupBox2.Controls.Add(this.общСтоимостьПроживанияTextBox);
            this.groupBox2.Controls.Add(датаВыселенияLabel);
            this.groupBox2.Controls.Add(this.датаВыселенияDateTimePicker);
            this.groupBox2.Controls.Add(датаЗаселенияLabel);
            this.groupBox2.Controls.Add(this.датаЗаселенияDateTimePicker);
            this.groupBox2.Location = new System.Drawing.Point(17, 221);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(876, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные о номере";
            // 
            // кодНомераComboBox
            // 
            this.кодНомераComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетРаботыBindingSource, "КодНомера", true));
            this.кодНомераComboBox.DataSource = this.номераBindingSource1;
            this.кодНомераComboBox.DisplayMember = "КодНомера";
            this.кодНомераComboBox.FormattingEnabled = true;
            this.кодНомераComboBox.Location = new System.Drawing.Point(104, 40);
            this.кодНомераComboBox.Name = "кодНомераComboBox";
            this.кодНомераComboBox.Size = new System.Drawing.Size(121, 24);
            this.кодНомераComboBox.TabIndex = 13;
            // 
            // учетРаботыBindingSource
            // 
            this.учетРаботыBindingSource.DataMember = "УчетРаботы";
            this.учетРаботыBindingSource.DataSource = this.hotelDataSet;
            // 
            // номераBindingSource1
            // 
            this.номераBindingSource1.DataMember = "Номера";
            this.номераBindingSource1.DataSource = this.hotelDataSet;
            // 
            // состояниеComboBox
            // 
            this.состояниеComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.номераBindingSource, "Состояние", true));
            this.состояниеComboBox.FormattingEnabled = true;
            this.состояниеComboBox.Items.AddRange(new object[] {
            "Забронировано",
            "Заселен"});
            this.состояниеComboBox.Location = new System.Drawing.Point(104, 84);
            this.состояниеComboBox.Name = "состояниеComboBox";
            this.состояниеComboBox.Size = new System.Drawing.Size(121, 24);
            this.состояниеComboBox.TabIndex = 12;
            // 
            // номераBindingSource
            // 
            this.номераBindingSource.DataMember = "Номера";
            this.номераBindingSource.DataSource = this.hotelDataSet;
            // 
            // общСтоимостьПроживанияTextBox
            // 
            this.общСтоимостьПроживанияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.учетРаботыBindingSource, "ОбщСтоимостьПроживания", true));
            this.общСтоимостьПроживанияTextBox.Location = new System.Drawing.Point(610, 87);
            this.общСтоимостьПроживанияTextBox.Name = "общСтоимостьПроживанияTextBox";
            this.общСтоимостьПроживанияTextBox.ReadOnly = true;
            this.общСтоимостьПроживанияTextBox.Size = new System.Drawing.Size(228, 23);
            this.общСтоимостьПроживанияTextBox.TabIndex = 11;
            // 
            // датаВыселенияDateTimePicker
            // 
            this.датаВыселенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учетРаботыBindingSource, "ДатаВыселения", true));
            this.датаВыселенияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаВыселенияDateTimePicker.Location = new System.Drawing.Point(368, 87);
            this.датаВыселенияDateTimePicker.Name = "датаВыселенияDateTimePicker";
            this.датаВыселенияDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.датаВыселенияDateTimePicker.TabIndex = 9;
            // 
            // датаЗаселенияDateTimePicker
            // 
            this.датаЗаселенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.учетРаботыBindingSource, "ДатаЗаселения", true));
            this.датаЗаселенияDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.датаЗаселенияDateTimePicker.Location = new System.Drawing.Point(368, 43);
            this.датаЗаселенияDateTimePicker.Name = "датаЗаселенияDateTimePicker";
            this.датаЗаселенияDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.датаЗаселенияDateTimePicker.TabIndex = 7;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "Accounting";
            this.accountingBindingSource.DataSource = this.hotelDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.ДолжностиTableAdapter = null;
            this.tableAdapterManager.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager.НомераTableAdapter = this.номераTableAdapter;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.СвободныеНомераTableAdapter = null;
            this.tableAdapterManager.УчетРаботыTableAdapter = this.учетРаботыTableAdapter;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // номераTableAdapter
            // 
            this.номераTableAdapter.ClearBeforeFill = true;
            // 
            // учетРаботыTableAdapter
            // 
            this.учетРаботыTableAdapter.ClearBeforeFill = true;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(337, 583);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(231, 37);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Выход";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // свободныеНомераBindingSource
            // 
            this.свободныеНомераBindingSource.DataMember = "СвободныеНомера";
            this.свободныеНомераBindingSource.DataSource = this.hotelDataSet;
            // 
            // свободныеНомераTableAdapter
            // 
            this.свободныеНомераTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "СостояниеОплаты";
            this.dataGridViewCheckBoxColumn1.HeaderText = "СостояниеОплаты";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "КодСотрудника";
            this.dataGridViewTextBoxColumn5.HeaderText = "КодСотрудника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "КоличествоМест";
            this.dataGridViewTextBoxColumn4.HeaderText = "КоличествоМест";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "СуточнаяСтоимость";
            this.dataGridViewTextBoxColumn3.HeaderText = "СуточнаяСтоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Состояние";
            this.dataGridViewTextBoxColumn2.HeaderText = "Состояние";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "КодНомера";
            this.dataGridViewTextBoxColumn1.HeaderText = "КодНомера";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // свободныеНомераDataGridView
            // 
            this.свободныеНомераDataGridView.AutoGenerateColumns = false;
            this.свободныеНомераDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.свободныеНомераDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.свободныеНомераDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.свободныеНомераDataGridView.DataSource = this.свободныеНомераBindingSource;
            this.свободныеНомераDataGridView.Location = new System.Drawing.Point(17, 367);
            this.свободныеНомераDataGridView.Name = "свободныеНомераDataGridView";
            this.свободныеНомераDataGridView.ReadOnly = true;
            this.свободныеНомераDataGridView.Size = new System.Drawing.Size(876, 210);
            this.свободныеНомераDataGridView.TabIndex = 4;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // ShowClientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 640);
            this.Controls.Add(this.свободныеНомераDataGridView);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowClientProfile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить анкету клиента";
            this.Load += new System.EventHandler(this.ClientProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.учетРаботыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.номераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.свободныеНомераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.свободныеНомераDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HotelDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.MaskedTextBox телефонMaskedTextBox;
        private System.Windows.Forms.TextBox цельПриездаTextBox;
        private System.Windows.Forms.DateTimePicker датаРожденияDateTimePicker;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox серияНомерПаспортаTextBox;
        private System.Windows.Forms.TextBox странаTextBox;
        private HotelDataSetTableAdapters.НомераTableAdapter номераTableAdapter;
        private System.Windows.Forms.BindingSource номераBindingSource;
        private HotelDataSetTableAdapters.УчетРаботыTableAdapter учетРаботыTableAdapter;
        private System.Windows.Forms.BindingSource учетРаботыBindingSource;
        private System.Windows.Forms.ComboBox состояниеComboBox;
        private System.Windows.Forms.TextBox общСтоимостьПроживанияTextBox;
        private System.Windows.Forms.DateTimePicker датаВыселенияDateTimePicker;
        private System.Windows.Forms.DateTimePicker датаЗаселенияDateTimePicker;
        private System.Windows.Forms.ComboBox кодНомераComboBox;
        private System.Windows.Forms.BindingSource номераBindingSource1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.BindingSource свободныеНомераBindingSource;
        private HotelDataSetTableAdapters.СвободныеНомераTableAdapter свободныеНомераTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView свободныеНомераDataGridView;
        private HotelDataSetTableAdapters.AccountingTableAdapter accountingTableAdapter;
    }
}