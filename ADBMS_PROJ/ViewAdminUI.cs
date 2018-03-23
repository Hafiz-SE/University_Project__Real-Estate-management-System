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
    public partial class ViewAdminUI : MetroForm
    {
        connection cs = new connection();
        public ViewAdminUI()
        {
            InitializeComponent();
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminUI special = new AdminUI();
            special.ShowDialog();
            this.Close();
        }

        private void ViewAdminUI_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "SELECT u_id from admin";
            DT = cs.GetResult(SQL);
            metroComboBox1.DataSource = DT;
            metroComboBox1.DisplayMember = "u_id";
        }

        private void showButton_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            DT=cs.GetResult("SELECT * from Admin");
            dataGridView1.DataSource = DT;
        }

        private void metroButton9_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "update admin set address='" + metroTextBox8.Text + "' where u_id=" + metroComboBox1.Text;
            cs.ExecuteQuery(SQL);
            MessageBox.Show("DONE");
        }
    }
}
