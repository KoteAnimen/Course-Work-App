
namespace Course_Work_App
{
    partial class Workers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьИнформациюОСотрудникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уволитьСотрудникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьИнформациюОУволеномСотрудникеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовогоСотрудникаToolStripMenuItem,
            this.изменитьИнформациюОСотрудникеToolStripMenuItem,
            this.уволитьСотрудникаToolStripMenuItem,
            this.удалитьИнформациюОУволеномСотрудникеToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // добавитьНовогоСотрудникаToolStripMenuItem
            // 
            this.добавитьНовогоСотрудникаToolStripMenuItem.Name = "добавитьНовогоСотрудникаToolStripMenuItem";
            this.добавитьНовогоСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.добавитьНовогоСотрудникаToolStripMenuItem.Text = "Добавить нового сотрудника";
            // 
            // изменитьИнформациюОСотрудникеToolStripMenuItem
            // 
            this.изменитьИнформациюОСотрудникеToolStripMenuItem.Name = "изменитьИнформациюОСотрудникеToolStripMenuItem";
            this.изменитьИнформациюОСотрудникеToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.изменитьИнформациюОСотрудникеToolStripMenuItem.Text = "Изменить информацию о сотруднике";
            // 
            // уволитьСотрудникаToolStripMenuItem
            // 
            this.уволитьСотрудникаToolStripMenuItem.Name = "уволитьСотрудникаToolStripMenuItem";
            this.уволитьСотрудникаToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.уволитьСотрудникаToolStripMenuItem.Text = "Уволить сотрудника";
            // 
            // удалитьИнформациюОУволеномСотрудникеToolStripMenuItem
            // 
            this.удалитьИнформациюОУволеномСотрудникеToolStripMenuItem.Name = "удалитьИнформациюОУволеномСотрудникеToolStripMenuItem";
            this.удалитьИнформациюОУволеномСотрудникеToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.удалитьИнформациюОУволеномСотрудникеToolStripMenuItem.Text = "Удалить информацию о уволеном сотруднике";
            // 
            // Workers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 515);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Workers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьИнформациюОСотрудникеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уволитьСотрудникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьИнформациюОУволеномСотрудникеToolStripMenuItem;
    }
}