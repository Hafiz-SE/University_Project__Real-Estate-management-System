namespace ADBMS_PROJ
{
    partial class TransactionUI
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
            this.TileViewTrans = new MetroFramework.Controls.MetroTile();
            this.addTransTile = new MetroFramework.Controls.MetroTile();
            this.backButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TileViewTrans
            // 
            this.TileViewTrans.Location = new System.Drawing.Point(50, 92);
            this.TileViewTrans.Name = "TileViewTrans";
            this.TileViewTrans.Size = new System.Drawing.Size(160, 94);
            this.TileViewTrans.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileViewTrans.TabIndex = 2;
            this.TileViewTrans.Text = "View Transaction";
            this.TileViewTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TileViewTrans.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TileViewTrans_MouseClick);
            // 
            // addTransTile
            // 
            this.addTransTile.Location = new System.Drawing.Point(289, 92);
            this.addTransTile.Name = "addTransTile";
            this.addTransTile.Size = new System.Drawing.Size(160, 94);
            this.addTransTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.addTransTile.TabIndex = 3;
            this.addTransTile.Text = "Add Transaction";
            this.addTransTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addTransTile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addTransTile_MouseClick);
            // 
            // backButton
            // 
            this.backButton.Highlight = true;
            this.backButton.Location = new System.Drawing.Point(360, 246);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(89, 23);
            this.backButton.Style = MetroFramework.MetroColorStyle.Orange;
            this.backButton.TabIndex = 17;
            this.backButton.Text = "Back";
            this.backButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.backButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backButton_MouseClick);
            // 
            // TransactionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 292);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.addTransTile);
            this.Controls.Add(this.TileViewTrans);
            this.Name = "TransactionUI";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Transaction";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile TileViewTrans;
        private MetroFramework.Controls.MetroTile addTransTile;
        private MetroFramework.Controls.MetroButton backButton;
    }
}