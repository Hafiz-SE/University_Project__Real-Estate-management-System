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
    public partial class Client_viewtrans : MetroForm
    {
        connection cs = new connection();
        public Client_viewtrans()
        {
            InitializeComponent();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL= "Select * from transactions where c_id="+Convert.ToInt16(metroTextBox1.Text);
            DataTable DT = new DataTable();
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ClientUI special = new ClientUI();
            special.ShowDialog();
            this.Close();
        }
    }
}
