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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.hotelDataSet.Accounting);

        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            ClientProfile profile = new ClientProfile();
            profile.ShowDialog();
            this.accountingTableAdapter.Fill(this.hotelDataSet.Accounting);
        }

        private void ChangeInfClient_Click(object sender, EventArgs e)
        {
            Client.id = Convert.ToInt32(accountingDataGridView[2, accountingDataGridView.CurrentRow.Index].Value);
            Client.room = accountingDataGridView[1, accountingDataGridView.CurrentRow.Index].Value.ToString();
            
            ChangeClientProfile client = new ChangeClientProfile();
            client.ShowDialog();
            this.accountingTableAdapter.Fill(this.hotelDataSet.Accounting);
        }
    }

    public static class Client
    {
        public static int id;
        public static string room;
    }
}
