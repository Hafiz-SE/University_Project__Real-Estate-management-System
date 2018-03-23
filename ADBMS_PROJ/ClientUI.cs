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
    public partial class ClientUI : MetroForm
    {
        public ClientUI()
        {
            InitializeComponent();
        }

        private void ClientUI_Load(object sender, EventArgs e)
        {

        }

        private void TileSearchPro_Click(object sender, EventArgs e)
        {

        }

        private void TileSearchPro_MouseClick(object sender, MouseEventArgs e)
        {this.Hide();

        SearchPropertyUI special = new SearchPropertyUI();
                special.ShowDialog();
                this.Close();
        }

        private void TileViewPro_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            ViewPropertyCLIENTUI special = new ViewPropertyCLIENTUI();
            special.ShowDialog();
            this.Close();
        }

        private void TileViewTrans_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();

            Client_viewtrans special = new Client_viewtrans();
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
