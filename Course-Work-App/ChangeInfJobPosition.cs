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
    public partial class ChangeInfJobPosition : Form
    {
        public ChangeInfJobPosition()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void ChangeInfJobPosition_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.FillByIdJob(this.hotelDataSet.Должности, Job.id);
            названиеTextBox.Text = hotelDataSet.Должности.Rows[0][0].ToString();
            зарплатаTextBox.Text = hotelDataSet.Должности.Rows[0][1].ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeInformation_Click(object sender, EventArgs e)
        {
            if(названиеTextBox.Text == "")
            {
                MessageBox.Show("Введите название должности", "Ошибка");
                return;
            }
            if (зарплатаTextBox.Text == "")
            {
                MessageBox.Show("Введите зарплату", "Ошибка");
                return;
            }
            try
            {
                должностиTableAdapter.UpdateJobPosition(названиеTextBox.Text, Convert.ToDecimal(зарплатаTextBox.Text), Job.id);
                Close();
            }
            catch
            {
                MessageBox.Show("Неверный формат данных. Не удалось преобразовать значение в поле зарплата", "Ошибка");
                return;
            }
            
        }
    }
}
