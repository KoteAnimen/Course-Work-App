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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
            кодСотрудникаComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void номераBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номераBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.hotelDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Номера". При необходимости она может быть перемещена или удалена.
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);
            this.номераBindingSource.AddNew();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(кодНомераTextBox.Text == "")
            {
                MessageBox.Show("Введите код номера", "Ошибка");
                return;
            }
            if (суточнаяСтоимостьTextBox.Text == "")
            {
                MessageBox.Show("Введите суточную стоимость проживания в номере", "Ошибка");
                return;
            }
            if(количествоМестNumericUpDown.Value == 0)
            {
                MessageBox.Show("Введите количество мест в номере", "Ошибка");
                return;
            }
            try
            {
                номераTableAdapter.Insert(Convert.ToInt32(кодНомераTextBox.Text), "Свободно", Convert.ToDecimal(суточнаяСтоимостьTextBox.Text), (short)количествоМестNumericUpDown.Value, false, Convert.ToInt32(кодСотрудникаComboBox.Text));
                Close();
            }
            catch
            {
                MessageBox.Show("Неверный формат данных", "Ошибка");
                return;
            }


        }
    }
}
