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
    public partial class ViewPropertyUI : MetroForm
    {
        connection cs = new connection(); 
        public ViewPropertyUI()
        {
            InitializeComponent();
        }

        private void showButton_MouseClick(object sender, MouseEventArgs e)
        {
            String sql = "Select * from property";
            DataTable DT = new DataTable();
            DT = cs.GetResult(sql);
            dataGridView1.DataSource = DT;
        }

        private void ViewPropertyUI_Load(object sender, EventArgs e)
        {
           
            DataTable DT = new DataTable();
            String SQL= "SELECT p_id from property";
            DT=cs.GetResult(SQL);
            comboBox1.DataSource = DT;
            comboBox1.DisplayMember = "p_id";
        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "update property set p_size=" + metroTextBox3.Text + " where p_id=" + comboBox1.Text;
            if (cs.ExecuteQuery(SQL) == true) { MessageBox.Show("DONE"); }
            
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
