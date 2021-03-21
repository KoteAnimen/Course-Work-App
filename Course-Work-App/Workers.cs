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
    public partial class Workers : Form
    {
        public Workers()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);

        }

        private void AddNewWorker_Click(object sender, EventArgs e)
        {
            WorkerProfile profile = new WorkerProfile();
            profile.ShowDialog();
        }

        private void ChangeInfWorker_Click(object sender, EventArgs e)
        {
            ChangeWorkerProfile profile = new ChangeWorkerProfile();
            profile.ShowDialog();
        }
    }
}
