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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Rooms_Click(object sender, EventArgs e)
        {
            Rooms room = new Rooms();
            room.Show();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Clients client = new Clients();
            client.Show();
        }

        private void Accounting_Click(object sender, EventArgs e)
        {
            Accounting account = new Accounting();
            account.Show();
        }

        private void Workers_Click(object sender, EventArgs e)
        {
            Workers worker = new Workers();
            worker.Show();

        }

        private void JobPositions_Click(object sender, EventArgs e)
        {
            JobPositions job = new JobPositions();
            job.Show();
        }
    }
}
