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
    public partial class ChangeWorkerProfile : Form
    {
        public ChangeWorkerProfile()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void WorkerProfile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.hotelDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);

        }
    }
}
