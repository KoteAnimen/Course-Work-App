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
    public partial class ClientProfile : Form
    {
        decimal countDays;
        decimal countCost;
        
        public ClientProfile()
        {
            InitializeComponent();
        }

        private void ClientProfile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.УчетРаботы". При необходимости она может быть перемещена или удалена.
            this.учетРаботыTableAdapter.Fill(this.hotelDataSet.УчетРаботы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Номера". При необходимости она может быть перемещена или удалена.
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.hotelDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Accounting". При необходимости она может быть перемещена или удалена.
            

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        void SetValue(string value, string message)
        {
            if(value == "")
            {
                MessageBox.Show(message, "Ошибка");
                return;
            }
        }
        void SetValue(DateTime value, string message)
        {
            if (value == DateTime.Now)
            {
                MessageBox.Show(message, "Ошибка");
                return;
            }
        }
        void SetValue(int value, string message)
        {
            if (value == 0)
            {
                MessageBox.Show(message, "Ошибка");
                return;
            }
        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            SetValue(фамилияTextBox.Text, "Введите фамилию клиента");
            SetValue(имяTextBox.Text, "Введите имя клиента");
            SetValue(отчествоTextBox.Text, "Введите отчество клиента");
            SetValue(странаTextBox.Text, "Введите страну клиента");
            SetValue(телефонMaskedTextBox.Text, "Введите телефон клиента");
            SetValue(серияНомерПаспортаTextBox.Text, "Введите серию и номер паспорта клиента");
            SetValue(адресTextBox.Text, "Введите адрес фактического проживания клиента");
            SetValue(датаРожденияDateTimePicker.Value, "Введите дату рождения клиента");
            SetValue(кодНомераComboBox.Text, "Введите код номера, в который бронирует или заселяет клиент");
            SetValue(состояниеComboBox.Text, "Введите состояние номера (забронирован или заселен)");
            SetValue(датаЗаселенияDateTimePicker.Value, "Введите дату заселения клиента в номер");
            SetValue(датаВыселенияDateTimePicker.Value, "Введите дату выселения клиента в номер");
            
        }

        private void состояниеОплатыCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(состояниеОплатыCheckBox.Checked == true)
            {
                countDays = датаВыселенияDateTimePicker.Value.DayOfYear - датаЗаселенияDateTimePicker.Value.DayOfYear;
                if(кодНомераComboBox.Text == "" && датаЗаселенияDateTimePicker.Value != DateTime.Now && датаВыселенияDateTimePicker.Value != DateTime.Now && датаЗаселенияDateTimePicker.Value != датаВыселенияDateTimePicker.Value)
                {
                    MessageBox.Show("Введите код номера, дату заселения и дату выселения", "Ошибка");
                    состояниеОплатыCheckBox.Checked = false;
                    for(int i = 0; i < номераDataGridView.RowCount; i++)
                    {
                        if(кодНомераComboBox.Text == номераDataGridView[0, i].Value.ToString())
                        {
                            countCost = Convert.ToDecimal(номераDataGridView[2, i].Value) * countDays;
                            break;
                        }
                    }
                    общСтоимостьПроживанияTextBox.Text = countCost.ToString();
                }

            }
        }
    }
}
