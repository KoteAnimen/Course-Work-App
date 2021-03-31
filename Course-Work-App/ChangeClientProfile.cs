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
    public partial class ChangeClientProfile : Form
    {
        decimal countDays;
        decimal countCost;
        
        public ChangeClientProfile()
        {
            InitializeComponent();
            кодНомераComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            состояниеComboBox.DropDownStyle = ComboBoxStyle.DropDownList;            
        }
        

        private void ClientProfile_Load(object sender, EventArgs e)
        {
            
            номераTableAdapter.UpdateStatusRoom("Свободно", Convert.ToInt32(Client.idRoom));
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
            общСтоимостьПроживанияTextBox.Text = "";


        }
        



        private void Cancel_Click(object sender, EventArgs e)
        {
            номераTableAdapter.UpdateStatusRoom(Client.statusRoom, Convert.ToInt32(Client.idRoom));
            Close();
        }        

        private void состояниеОплатыCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(состояниеОплатыCheckBox.Checked == true)
            {
                countDays = датаВыселенияDateTimePicker.Value.DayOfYear - датаЗаселенияDateTimePicker.Value.DayOfYear;
                if(кодНомераComboBox.Text != "" && датаЗаселенияDateTimePicker.Value.DayOfYear != датаВыселенияDateTimePicker.Value.DayOfYear)
                {                    
                    for(int i = 0; i < свободныеНомераDataGridView.RowCount; i++)
                    {
                        if(кодНомераComboBox.Text == свободныеНомераDataGridView[0, i].Value.ToString())
                        {
                            countCost = Convert.ToDecimal(свободныеНомераDataGridView[2, i].Value) * countDays;                            
                            break;
                        }
                    }
                    общСтоимостьПроживанияTextBox.Text = countCost.ToString();

                }
                else
                {
                    MessageBox.Show("Введите код номера, дату заселения и дату выселения", "Ошибка");
                    состояниеОплатыCheckBox.Checked = false;
                }

            }
        }

        private void ChangeClient_Click(object sender, EventArgs e)
        {
            if (фамилияTextBox.Text == "")
            {
                MessageBox.Show("Введите фамилию клиента", "Ошибка");
                return;
            }
            if (имяTextBox.Text == "")
            {
                MessageBox.Show("Введите имя клиента", "Ошибка");
                return;
            }
            if (отчествоTextBox.Text == "")
            {
                MessageBox.Show("Введите отчество клиента", "Ошибка");
                return;
            }
            if (странаTextBox.Text == "")
            {
                MessageBox.Show("Введите страну клиента", "Ошибка");
                return;
            }
            if (телефонMaskedTextBox.Text == "")
            {
                MessageBox.Show("Введите телефон клиента", "Ошибка");
                return;
            }
            if (серияНомерПаспортаTextBox.Text == "")
            {
                MessageBox.Show("Введите серию и номер паспорта клиента", "Ошибка");
                return;
            }
            if (адресTextBox.Text == "")
            {
                MessageBox.Show("Введите адрес фактического проживания клиента", "Ошибка");
                return;
            }
            if (датаРожденияDateTimePicker.Value == DateTime.Now)
            {
                MessageBox.Show("Введите дату рождения клиента", "Ошибка");
                return;
            }
            if (кодНомераComboBox.Text == "")
            {
                MessageBox.Show("Введите код номера, в который бронирует или заселяет клиент", "Ошибка");
                return;
            }
            if (состояниеComboBox.Text == "")
            {
                MessageBox.Show("Введите состояние номера (забронирован или заселен)", "Ошибка");
                return;
            }
            if (датаВыселенияDateTimePicker.Value == DateTime.Now)
            {
                MessageBox.Show("Введите дату выселения клиента в номер", "Ошибка");
                return;
            }

            try
            {
                клиентыTableAdapter.UpdateClient(фамилияTextBox.Text, имяTextBox.Text, отчествоTextBox.Text, странаTextBox.Text, серияНомерПаспортаTextBox.Text, адресTextBox.Text, датаРожденияDateTimePicker.Value, цельПриездаTextBox.Text, телефонMaskedTextBox.Text, Client.id);
                this.клиентыTableAdapter.Fill(this.hotelDataSet.Клиенты);
                номераTableAdapter.UpdateStatusRoom(состояниеComboBox.Text, Convert.ToInt32(кодНомераComboBox.Text));
                учетРаботыTableAdapter.UpdateAccount(Convert.ToInt32(кодНомераComboBox.Text), датаЗаселенияDateTimePicker.Value, датаВыселенияDateTimePicker.Value, countCost, Client.id);
                Close();
            }
            catch
            {
                MessageBox.Show("Неправильный формат данных, проверьте правильность заполнения информации", "Ошибка");
            }
        }
    }
}
