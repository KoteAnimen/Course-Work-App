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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Номера". При необходимости она может быть перемещена или удалена.
            this.номераTableAdapter.Fill(this.hotelDataSet.Номера);

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
            Client.idRoom = accountingDataGridView[1, accountingDataGridView.CurrentRow.Index].Value.ToString();
            searchRoom(Convert.ToInt32(Client.idRoom), ref Client.statusRoom);
            ChangeClientProfile client = new ChangeClientProfile();
            client.ShowDialog();
            this.accountingTableAdapter.Fill(this.hotelDataSet.Accounting);
        }
        void searchRoom(int idRoom, ref string statusRoom)
        {

            for (int i = 0; i < hotelDataSet.Номера.Rows.Count; i++)
            {
                if (Convert.ToInt32(hotelDataSet.Номера.Rows[i][0]) == idRoom)
                {
                    statusRoom = hotelDataSet.Номера.Rows[i][1].ToString();
                    break;
                }
            }          

        }

        private void ShowClient_Click(object sender, EventArgs e)
        {
            Client.id = Convert.ToInt32(accountingDataGridView[2, accountingDataGridView.CurrentRow.Index].Value);
            ShowClientProfile client = new ShowClientProfile();
            client.ShowDialog();

        }
    }

    public static class Client
    {
        public static int id;
        public static string idRoom;
        public static string statusRoom;
    }
}
