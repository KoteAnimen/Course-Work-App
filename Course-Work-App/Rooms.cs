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
    }
}
