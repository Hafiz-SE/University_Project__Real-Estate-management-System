namespace ADBMS_PROJ
{
    partial class ClientUI
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
            this.TileViewPro = new MetroFramework.Controls.MetroTile();
            this.TileViewTrans = new MetroFramework.Controls.MetroTile();
            this.TileLogout = new MetroFramework.Controls.MetroTile();
            this.TileSearchPro = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // TileViewPro
            // 
            this.TileViewPro.Location = new System.Drawing.Point(23, 63);
            this.TileViewPro.Name = "TileViewPro";
            this.TileViewPro.Size = new System.Drawing.Size(160, 94);
            this.TileViewPro.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileViewPro.TabIndex = 3;
            this.TileViewPro.Text = "View Property";
            this.TileViewPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileViewPro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileViewPro_MouseClick);
            // 
            // TileViewTrans
            // 
            this.TileViewTrans.Location = new System.Drawing.Point(23, 191);
            this.TileViewTrans.Name = "TileViewTrans";
            this.TileViewTrans.Size = new System.Drawing.Size(160, 94);
            this.TileViewTrans.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileViewTrans.TabIndex = 4;
            this.TileViewTrans.Text = "View Transaction";
            this.TileViewTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileViewTrans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileViewTrans_MouseClick);
            // 
            // TileLogout
            // 
            this.TileLogout.Location = new System.Drawing.Point(231, 191);
            this.TileLogout.Name = "TileLogout";
            this.TileLogout.Size = new System.Drawing.Size(160, 94);
            this.TileLogout.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileLogout.TabIndex = 6;
            this.TileLogout.Text = "Log out";
            this.TileLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileLogout_MouseClick);
            // 
            // TileSearchPro
            // 
            this.TileSearchPro.Location = new System.Drawing.Point(231, 63);
            this.TileSearchPro.Name = "TileSearchPro";
            this.TileSearchPro.Size = new System.Drawing.Size(160, 94);
            this.TileSearchPro.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileSearchPro.TabIndex = 7;
            this.TileSearchPro.Text = "Search Property";
            this.TileSearchPro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileSearchPro.Click += new System.EventHandler(this.TileSearchPro_Click);
            this.TileSearchPro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileSearchPro_MouseClick);
            // 
            // ClientUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 344);
            this.Controls.Add(this.TileSearchPro);
            this.Controls.Add(this.TileLogout);
            this.Controls.Add(this.TileViewTrans);
            this.Controls.Add(this.TileViewPro);
            this.Name = "ClientUI";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Client";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ClientUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TileViewPro;
        private MetroFramework.Controls.MetroTile TileViewTrans;
        private MetroFramework.Controls.MetroTile TileLogout;
        private MetroFramework.Controls.MetroTile TileSearchPro;

    }
}