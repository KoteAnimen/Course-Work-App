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
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);
        }

        private void ChangeInfWorker_Click(object sender, EventArgs e)
        {
            Data.Id = персоналDataGridView[0, персоналDataGridView.CurrentRow.Index].Value.ToString();
            ChangeWorkerProfile profile = new ChangeWorkerProfile();
            profile.ShowDialog();
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);
        }

        private void DismissWorker_Click(object sender, EventArgs e)
        {
            Data.Id = персоналDataGridView[0, персоналDataGridView.CurrentRow.Index].Value.ToString();
            this.персоналTableAdapter.Dismiss(Convert.ToInt32(Data.Id));
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);
        }
    }


    public static class Data
    {
        public static string Id;
    }
}
