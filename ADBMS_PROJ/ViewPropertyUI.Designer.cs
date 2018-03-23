namespace ADBMS_PROJ
{
    partial class ViewPropertyUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.showButton = new MetroFramework.Controls.MetroButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Highlight = true;
            this.backButton.Location = new System.Drawing.Point(382, 277);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.backButton.TabIndex = 16;
            this.backButton.Text = "Back";
            this.backButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseClick);
            // 
            // showButton
            // 
            this.showButton.Highlight = true;
            this.showButton.Location = new System.Drawing.Point(382, 230);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(89, 23);
            this.showButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.showButton.TabIndex = 16;
            this.showButton.Text = "SHOW";
            this.showButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.showButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showButton_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 237);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "PROPERTY ID";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTextBox2.Location = new System.Drawing.Point(3, 265);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PromptText = "NEW SIZE";
            this.metroTextBox2.Size = new System.Drawing.Size(190, 23);
            this.metroTextBox2.TabIndex = 19;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseStyleColors = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(382, 230);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(89, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton1.TabIndex = 16;
            this.metroButton1.Text = "SHOW";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.showButton_MouseClick);
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTextBox3.Location = new System.Drawing.Point(3, 265);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PromptText = "NEW SIZE";
            this.metroTextBox3.Size = new System.Drawing.Size(206, 23);
            this.metroTextBox3.TabIndex = 19;
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox3.UseStyleColors = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(3, 294);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(206, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Change Size";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.metroButton2_MouseClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 212);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(206, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Select Property ID to Change Size";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // ViewPropertyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 323);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewPropertyUI";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "View Property";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ViewPropertyUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroButton backButton;
        private MetroFramework.Controls.MetroButton showButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}