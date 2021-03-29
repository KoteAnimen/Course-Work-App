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
    public partial class JobPositions : Form
    {
        public JobPositions()
        {
            InitializeComponent();
        }

        private void должностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.должностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void JobPositions_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.hotelDataSet.Должности);

        }

        private void ChangeInfJobPosition_Click(object sender, EventArgs e)
        {
            Job.id = должностиDataGridView[0, должностиDataGridView.CurrentRow.Index].Value.ToString();
            ChangeInfJobPosition change = new ChangeInfJobPosition();
            change.ShowDialog();
            this.должностиTableAdapter.Fill(this.hotelDataSet.Должности);
        }
        
    }
    public static class Job
    {
        public static string id;
    }
}
