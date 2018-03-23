namespace ADBMS_PROJ
{
    partial class ViewCustomersUI
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
            this.showButton = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroButton9 = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.backButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Highlight = true;
            this.showButton.Location = new System.Drawing.Point(253, 221);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(89, 23);
            this.showButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.showButton.TabIndex = 19;
            this.showButton.Text = "SHOW";
            this.showButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 152);
            this.dataGridView1.TabIndex = 17;
            // 
            // metroButton9
            // 
            this.metroButton9.Location = new System.Drawing.Point(417, 270);
            this.metroButton9.Name = "metroButton9";
            this.metroButton9.Size = new System.Drawing.Size(132, 23);
            this.metroButton9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton9.TabIndex = 44;
            this.metroButton9.Text = "Change Contact";
            this.metroButton9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroButton9_MouseClick);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(271, 270);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(132, 29);
            this.metroComboBox1.TabIndex = 43;
            // 
            // metroTextBox8
            // 
            this.metroTextBox8.Location = new System.Drawing.Point(271, 309);
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.Size = new System.Drawing.Size(132, 23);
            this.metroTextBox8.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTextBox8.TabIndex = 42;
            this.metroTextBox8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox8.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(43, 309);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(84, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel10.TabIndex = 40;
            this.metroLabel10.Text = "New Contact";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(43, 280);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(116, 19);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroLabel11.TabIndex = 41;
            this.metroLabel11.Text = "Choose Your C_ID";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseStyleColors = true;
            // 
            // backButton
            // 
            this.backButton.Highlight = true;
            this.backButton.Location = new System.Drawing.Point(417, 309);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(132, 23);
            this.backButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.backButton.TabIndex = 39;
            this.backButton.Text = "Back";
            this.backButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseClick);
            // 
            // ViewCustomersUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 392);
            this.Controls.Add(this.metroButton9);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroTextBox8);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewCustomersUI";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "View Customers";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ViewCustomersUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton showButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton metroButton9;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroButton backButton;
    }
}