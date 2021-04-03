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
    public partial class ChangeRoom : Form
    {
        public ChangeRoom()
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
            this.номераTableAdapter.FillByRoomId(this.hotelDataSet.Номера, Convert.ToInt32(Room.id));
            кодНомераTextBox.Text = hotelDataSet.Номера.Rows[0][0].ToString();
            суточнаяСтоимостьTextBox.Text = hotelDataSet.Номера.Rows[0][2].ToString();
            количествоМестNumericUpDown.Value = Convert.ToInt32(hotelDataSet.Номера.Rows[0][3]);
            кодСотрудникаComboBox.Text = hotelDataSet.Номера.Rows[0][5].ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }        

        private void Change_Click(object sender, EventArgs e)
        {
            if (суточнаяСтоимостьTextBox.Text == "")
            {
                MessageBox.Show("Введите суточную стоимость проживания в номере", "Ошибка");
                return;
            }
            if (количествоМестNumericUpDown.Value == 0)
            {
                MessageBox.Show("Введите количество мест в номере", "Ошибка");
                return;
            }
            try
            {
                номераTableAdapter.UpdateRoom("Свободен", Convert.ToDecimal(суточнаяСтоимостьTextBox.Text), (short)количествоМестNumericUpDown.Value, false, Convert.ToInt32(кодСотрудникаComboBox.Text), Convert.ToInt32(Room.id));
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
