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
    public partial class RegisterUI : MetroForm
    {
        public RegisterUI()
        {
            InitializeComponent();
        }

        private void RegisterUI_Load(object sender, EventArgs e)
        {

        }

        private void TileAddAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddAdminUI special = new AddAdminUI();
            special.ShowDialog();
            this.Close();
        }

        private void TileAddClient_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AddClientUI special = new AddClientUI();
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
