using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBMS_PROJ
{
    public partial class TransactionUI : MetroForm
    {
        public TransactionUI()
        {
            InitializeComponent();
        }

        private void TileViewTrans_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
           ViewTransactionUI special = new ViewTransactionUI();
            special.ShowDialog();
            this.Close();
        }

        private void addTransTile_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddTrnasctionUI special = new AddTrnasctionUI();
            special.ShowDialog();
            this.Close();
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminUI special = new AdminUI();
            special.ShowDialog();
            this.Close();
        }
    }
}
