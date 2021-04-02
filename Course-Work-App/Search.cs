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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Accounting". При необходимости она может быть перемещена или удалена.
           

        }        

        private void Cancel_Click(object sender, EventArgs e)
        {
            Client.resolve = false;
            Close();
        }

        private void SearchClient_Click(object sender, EventArgs e)
        {
            if(фамилияTextBox.Text == "")
            {
                MessageBox.Show("Введите фамилию клиента", "Ошибка");
                return;
            }
            if (имяTextBox.Text == "")
            {
                MessageBox.Show("Введите имя клиента", "Ошибка");
                return;
            }
            if (отчествоTextBox.Text == "")
            {
                MessageBox.Show("Введите отчество клиента", "Ошибка");
                return;
            }
            Client.firstName = имяTextBox.Text;
            Client.lastName = фамилияTextBox.Text;
            Client.middleName = отчествоTextBox.Text;
            Client.resolve = true;
            Close();
        }
    }
}
