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
    public partial class ShowClientProfile : Form
    {
        public ShowClientProfile()
        {
            InitializeComponent();
        }

        private void ClientProfile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.УчетРаботы". При необходимости она может быть перемещена или удалена.
            this.учетРаботыTableAdapter.Fill(this.hotelDataSet.УчетРаботы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Номера". При необходимости она может быть перемещена или удалена.
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.hotelDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.hotelDataSet.Accounting);

        }
    }
}
