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
    public partial class Report : Form
    {

        decimal earning;
        decimal outlay;
        decimal total;

        public Report()
        {
            InitializeComponent();
        }

        private void учетРаботыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учетРаботыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.ListSalaryWorkers". При необходимости она может быть перемещена или удалена.
            this.listSalaryWorkersTableAdapter.Fill(this.hotelDataSet.ListSalaryWorkers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.УчетРаботы". При необходимости она может быть перемещена или удалена.
            this.учетРаботыTableAdapter.FillBy(this.hotelDataSet.УчетРаботы);            
            for(int i = 0; i < hotelDataSet.ListSalaryWorkers.Rows.Count; i++)
            {
                outlay += Convert.ToDecimal(hotelDataSet.ListSalaryWorkers.Rows[i][2]);
            }
            for(int i = 0; i < учетРаботыDataGridView.RowCount; i++)
            {
                earning += Convert.ToDecimal(учетРаботыDataGridView[5, i].Value);
            }
            total = earning - outlay;
            tableCount.RowCount += 3;
            tableCount.Columns[0].HeaderText = "Итоги месяца";
            tableCount[0, tableCount.RowCount - 3].Value = "Доходы: " + earning.ToString();
            tableCount[0, tableCount.RowCount - 2].Value = "Расходы: " + outlay.ToString();
            tableCount[0, tableCount.RowCount - 1].Value = "Итого: " + total.ToString();


        }
    }
}
