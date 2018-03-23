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
    public partial class ChangePASSUI : MetroForm
    {
        connection cs = new connection();
        public ChangePASSUI()
        {
            InitializeComponent();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if(cs.Getperc_3(metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, Convert.ToInt32(metroTextBox1.Text))==true)
            MessageBox.Show("DONE");
        }

        private void metroButton1_MouseHover(object sender, EventArgs e)
        {
            metroButton1.Highlight = true;
        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminUI special = new AdminUI();
            special.ShowDialog();
            this.Close();
        }
    }
}
