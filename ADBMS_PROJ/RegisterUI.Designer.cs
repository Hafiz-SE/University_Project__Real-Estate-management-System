namespace ADBMS_PROJ
{
    partial class RegisterUI
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
            this.TileAddClient = new MetroFramework.Controls.MetroTile();
            this.TileAddAdmin = new MetroFramework.Controls.MetroTile();
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TileAddClient
            // 
            this.TileAddClient.Location = new System.Drawing.Point(244, 63);
            this.TileAddClient.Name = "TileAddClient";
            this.TileAddClient.Size = new System.Drawing.Size(160, 94);
            this.TileAddClient.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileAddClient.TabIndex = 1;
            this.TileAddClient.Text = "Add Client";
            this.TileAddClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileAddClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileAddClient_MouseClick);
            // 
            // TileAddAdmin
            // 
            this.TileAddAdmin.Location = new System.Drawing.Point(34, 63);
            this.TileAddAdmin.Name = "TileAddAdmin";
            this.TileAddAdmin.Size = new System.Drawing.Size(160, 94);
            this.TileAddAdmin.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileAddAdmin.TabIndex = 2;
            this.TileAddAdmin.Text = "Add Admin";
            this.TileAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileAddAdmin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileAddAdmin_MouseClick);
            // 
            // backButton
            // 
            this.backButton.Highlight = true;
            this.backButton.Location = new System.Drawing.Point(315, 200);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Back";
            this.backButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseClick);
            // 
            // RegisterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 271);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.TileAddAdmin);
            this.Controls.Add(this.TileAddClient);
            this.Name = "RegisterUI";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Register";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.RegisterUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TileAddClient;
        private MetroFramework.Controls.MetroTile TileAddAdmin;
        private MetroFramework.Controls.MetroButton backButton;
    }
}