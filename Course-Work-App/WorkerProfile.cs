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
    public partial class WorkerProfile : Form
    {
        public WorkerProfile()
        {
            InitializeComponent();
            должностьComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);

        }

        private void WorkerProfile_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.hotelDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hotelDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.hotelDataSet.Персонал);
            this.персоналBindingSource.AddNew();
            

        }

        void ShowMessage(string text, string message)
        {
            if (text == "")
            {
                MessageBox.Show(message, "Ошибка");
                return;
            }
        }
        void ShowMessage(DateTime chekingValue, DateTime needValue, string message)
        {
            if (chekingValue == needValue)
            {
                MessageBox.Show(message, "Ошибка");
                return;
            }
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            
            ShowMessage(фамилияTextBox.Text, "Необходимо ввести фамилию нового сотрудника");
            ShowMessage(имяTextBox.Text, "Необходимо ввести имя нового сотрудника");
            ShowMessage(отчествоTextBox.Text, "Необходимо ввести отчество нового сотрудника");
            ShowMessage(телефонMaskedTextBox.Text, "Необходимо ввести номер телефона нового сотрудника");
            ShowMessage(серияНомерПаспортаTextBox.Text, "Необходимо ввести серию и номер паспорта нового сотрудника");
            ShowMessage(адресTextBox.Text, "Необходимо ввести адрес проживания нового сотрудника");
            ShowMessage(датаРожденияDateTimePicker.Value, DateTime.Now, "Необходимо ввести дату рождения нового сотрудника");
            ShowMessage(кодСотрудникаTextBox.Text, "Необходимо ввести код нового сотрудника");
            ShowMessage(должностьComboBox.Text, "Необходимо указать должность нового сотрудника");
            ShowMessage(началоРабДняDateTimePicker.Value,  Convert.ToDateTime("00:00"), "Необходимо ввести время начала рабочего дня нового сотрудника");
            ShowMessage(конецРабДняDateTimePicker.Value, Convert.ToDateTime("00:00"), "Необходимо ввести время начала рабочего дня нового сотрудника");

            try
            {
                персоналTableAdapter.Insert(Convert.ToInt32(кодСотрудникаTextBox.Text), фамилияTextBox.Text, имяTextBox.Text, отчествоTextBox.Text, серияНомерПаспортаTextBox.Text, адресTextBox.Text, датаРожденияDateTimePicker.Value, началоРабДняDateTimePicker.Value, конецРабДняDateTimePicker.Value, Convert.ToInt32(должностьComboBox.Text), телефонMaskedTextBox.Text, "Работает");
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString() ,"Ошибка");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

    
