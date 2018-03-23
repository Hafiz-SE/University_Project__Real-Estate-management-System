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
    public partial class ViewCustomersUI : MetroForm
    {
        connection cs = new connection();
        public ViewCustomersUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            String sql = "Select * from client";
            DataTable DT = new DataTable();
            DT = cs.GetResult(sql);
            dataGridView1.DataSource = DT;
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminUI special = new AdminUI();
            special.ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewCustomersUI_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "SELECT c_id from client";
            DT = cs.GetResult(SQL);
            metroComboBox1.DataSource = DT;
            metroComboBox1.DisplayMember = "c_id";
        }

        private void metroButton9_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "update client set c_contact_no='" + metroTextBox8.Text + "'where c_id =" + Convert.ToInt32(metroComboBox1.Text);
            cs.ExecuteQuery(SQL);
            MessageBox.Show("DONE");
        }
    }
}
