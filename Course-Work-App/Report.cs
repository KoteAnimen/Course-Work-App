using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
            for (int i = 0; i < hotelDataSet.ListSalaryWorkers.Rows.Count; i++)
            {
                outlay += Convert.ToDecimal(hotelDataSet.ListSalaryWorkers.Rows[i][2]);
            }
            for (int i = 0; i < учетРаботыDataGridView.RowCount; i++)
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

        private void SaveReport_Click(object sender, EventArgs e)
        {
            string path = string.Empty;
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveDialog.FileName;
                    SaveTable(учетРаботыDataGridView, tableCount, path);                   
                }
            }

        }

        void SaveTable(DataGridView dgw1, DataGridView dgw2, string path)        {
            

            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dgw1.RowCount + 1; i++)
            {
                for (int j = 1; j < dgw1.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dgw1.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            for (int i = 1; i < dgw2.RowCount + 1; i++)
            {
                for (int j = 1; j < dgw2.ColumnCount + 1; j++)
                {
                    worksheet.Rows[i].Columns[j] = dgw2.Rows[i - 1].Cells[j - 1].Value;
                }
            }
            excelapp.AlertBeforeOverwriting = false;
            workbook.SaveAs(path);
            excelapp.Quit();

        }
    }
}
