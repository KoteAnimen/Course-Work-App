
namespace Course_Work_App
{
    partial class ChangeInfJobPosition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label зарплатаLabel;
            this.hotelDataSet = new Course_Work_App.HotelDataSet();
            this.должностиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.должностиTableAdapter = new Course_Work_App.HotelDataSetTableAdapters.ДолжностиTableAdapter();
            this.tableAdapterManager = new Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.зарплатаTextBox = new System.Windows.Forms.TextBox();
            this.ChangeInformation = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            названиеLabel = new System.Windows.Forms.Label();
            зарплатаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(12, 33);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(76, 17);
            названиеLabel.TabIndex = 1;
            названиеLabel.Text = "Название:";
            // 
            // зарплатаLabel
            // 
            зарплатаLabel.AutoSize = true;
            зарплатаLabel.Location = new System.Drawing.Point(12, 62);
            зарплатаLabel.Name = "зарплатаLabel";
            зарплатаLabel.Size = new System.Drawing.Size(76, 17);
            зарплатаLabel.TabIndex = 2;
            зарплатаLabel.Text = "Зарплата:";
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // должностиBindingSource
            // 
            this.должностиBindingSource.DataMember = "Должности";
            this.должностиBindingSource.DataSource = this.hotelDataSet;
            // 
            // должностиTableAdapter
            // 
            this.должностиTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Course_Work_App.HotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ДолжностиTableAdapter = this.должностиTableAdapter;
            this.tableAdapterManager.КлиентыTableAdapter = null;
            this.tableAdapterManager.НомераTableAdapter = null;
            this.tableAdapterManager.ПерсоналTableAdapter = null;
            this.tableAdapterManager.УчетРаботыTableAdapter = null;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(94, 30);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(319, 23);
            this.названиеTextBox.TabIndex = 2;
            // 
            // зарплатаTextBox
            // 
            this.зарплатаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.должностиBindingSource, "Зарплата", true));
            this.зарплатаTextBox.Location = new System.Drawing.Point(94, 59);
            this.зарплатаTextBox.Name = "зарплатаTextBox";
            this.зарплатаTextBox.Size = new System.Drawing.Size(319, 23);
            this.зарплатаTextBox.TabIndex = 3;
            // 
            // ChangeInformation
            // 
            this.ChangeInformation.Location = new System.Drawing.Point(15, 126);
            this.ChangeInformation.Name = "ChangeInformation";
            this.ChangeInformation.Size = new System.Drawing.Size(227, 39);
            this.ChangeInformation.TabIndex = 4;
            this.ChangeInformation.Text = "Изменить информацию";
            this.ChangeInformation.UseVisualStyleBackColor = true;
            this.ChangeInformation.Click += new System.EventHandler(this.ChangeInformation_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(276, 126);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(137, 39);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ChangeInfJobPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 189);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.ChangeInformation);
            this.Controls.Add(зарплатаLabel);
            this.Controls.Add(this.зарплатаTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeInfJobPosition";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить информацию о должности";
            this.Load += new System.EventHandler(this.ChangeInfJobPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.должностиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource должностиBindingSource;
        private HotelDataSetTableAdapters.ДолжностиTableAdapter должностиTableAdapter;
        private HotelDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox зарплатаTextBox;
        private System.Windows.Forms.Button ChangeInformation;
        private System.Windows.Forms.Button Cancel;
    }
}