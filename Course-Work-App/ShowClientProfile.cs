using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Work_App
{
    public partial class ShowClientProfile : Form
    {
                
        public ShowClientProfile()
        {
            InitializeComponent();
            кодНомераComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            состояниеComboBox.DropDownStyle = ComboBoxStyle.DropDownList;            
        }
        

        private void ClientProfile_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.СвободныеНомера". При необходимости она может быть перемещена или удалена.
            this.свободныеНомераTableAdapter.Fill(this.hotelDataSet.СвободныеНомера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.УчетРаботы". При необходимости она может быть перемещена или удалена.
            this.учетРаботыTableAdapter.Fill(this.hotelDataSet.УчетРаботы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Номера". При необходимости она может быть перемещена или удалена.
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.hotelDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.FillBy(hotelDataSet.Accounting, Client.id);           
            фамилияTextBox.Text = hotelDataSet.Accounting.Rows[0][3].ToString();
            имяTextBox.Text = hotelDataSet.Accounting.Rows[0][4].ToString();
            отчествоTextBox.Text = hotelDataSet.Accounting.Rows[0][5].ToString();
            странаTextBox.Text = hotelDataSet.Accounting.Rows[0][6].ToString();
            серияНомерПаспортаTextBox.Text = hotelDataSet.Accounting.Rows[0][7].ToString();
            адресTextBox.Text = hotelDataSet.Accounting.Rows[0][8].ToString();
            датаРожденияDateTimePicker.Value = Convert.ToDateTime(hotelDataSet.Accounting.Rows[0][9].ToString());
            цельПриездаTextBox.Text = hotelDataSet.Accounting.Rows[0][10].ToString();
            телефонMaskedTextBox.Text = hotelDataSet.Accounting.Rows[0][11].ToString();
            датаЗаселенияDateTimePicker.Value = Convert.ToDateTime(hotelDataSet.Accounting.Rows[0][12].ToString());
            датаВыселенияDateTimePicker.Value = Convert.ToDateTime(hotelDataSet.Accounting.Rows[0][13].ToString());
            общСтоимостьПроживанияTextBox.Text = hotelDataSet.Accounting.Rows[0][14].ToString();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }        

        
    }
}
