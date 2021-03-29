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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        private void номераBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номераBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Номера". При необходимости она может быть перемещена или удалена.
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);

        }

        private void AddRoom_Click(object sender, EventArgs e)
        {
            AddRoom room = new AddRoom();
            room.ShowDialog();
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);
        }

        private void ChangeInfRoom_Click(object sender, EventArgs e)
        {
            Room.id = номераDataGridView[0, номераDataGridView.CurrentRow.Index].Value.ToString();
            ChangeRoom room = new ChangeRoom();
            room.ShowDialog();
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);
        }

        private void DeleteRoom_Click(object sender, EventArgs e)
        {
            Room.id = номераDataGridView[0, номераDataGridView.CurrentRow.Index].Value.ToString();
            try
            {
                номераTableAdapter.DeleteRoom(Convert.ToInt32(Room.id));
            }
            catch
            {
                MessageBox.Show("Невозможно удилить информацию о номере, так как информация связана с другими таблицами", "Ошибка");
            }
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);
        }
    }

    public static class Room
    {
        public static string id;
    }
}
