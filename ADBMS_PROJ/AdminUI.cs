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
    public partial class AdminUI : MetroForm
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        private void AdminUI_Load(object sender, EventArgs e)
        {

        }

        private void TileRegister_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            RegisterUI special = new RegisterUI();
            special.ShowDialog();
            this.Close();
        }

        private void TileViewPro_MouseClick(object sender, MouseEventArgs e)
        {

            this.Hide();
            ViewPropertyUI special = new ViewPropertyUI();
            special.ShowDialog();
            this.Close();
        }

        private void TileAddPro_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddPropertyUI special = new AddPropertyUI();
            special.ShowDialog();
            this.Close();
        }

        private void viewCustomersTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomersUI special = new ViewCustomersUI();
            special.ShowDialog();
            this.Close();
        }

        private void TileViewTrans_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            TransactionUI special = new TransactionUI();
            special.ShowDialog();
            this.Close();
        }

        private void TileViewReport_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewReportsPRO special = new ViewReportsPRO();
            special.ShowDialog();
            this.Close();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {

            this.Hide();
            ChangePASSUI special = new ChangePASSUI();
            special.ShowDialog();
            this.Close();
        }

        private void adminTile_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ViewAdminUI special = new ViewAdminUI();
            special.ShowDialog();
            this.Close();
        }

        private void TileLogout_MouseClick(object sender, MouseEventArgs e)
        {
            
           this.Hide();
           ADBMS_PROJ special = new ADBMS_PROJ();
            special.ShowDialog();
            this.Close();
        }
    }
}
