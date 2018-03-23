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
    public partial class ViewPropertyCLIENTUI : MetroForm
    {
        connection cs = new connection();
        public ViewPropertyCLIENTUI()
        {
            InitializeComponent();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "select p_area,p_size,p_desc from property p,transactions t, client c where p.p_id=t.p_id and c.c_id = " + Convert.ToInt16(metroTextBox1.Text);
            DataTable DT = new DataTable();
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource=DT;
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ClientUI special = new ClientUI();
            special.ShowDialog();
            this.Close();
        }
    }
}
