using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.OracleClient;
namespace ADBMS_PROJ
{
    public partial class ADBMS_PROJ : MetroFramework.Forms.MetroForm
    {
        connection con = new connection();
        public ADBMS_PROJ()
        {
            InitializeComponent();
        }

        private void metroLink1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            Register special = new Register();
            special.ShowDialog();
            this.Close();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            string User = metroTextBox1.Text;
            string passw = metroTextBox2.Text;
            try
            {
                DataTable DT = new DataTable();
                String sql = "select u_type from login where u_id='" + User + "' and pass='" + passw + "'";
                DT = con.GetResult(sql);
            
                int count = DT.Rows.Count;
                if (count == 1)
                {
                    if (DT.Rows[0]["u_type"].ToString() == "admin") {
                        this.Hide();
                        AdminUI special = new AdminUI();
                        special.ShowDialog();
                        this.Close();
                    }
                    
                    if (DT.Rows[0]["u_type"].ToString() == "customer")
                    {
                        this.Hide();
                        ClientUI special = new ClientUI();
                        special.ShowDialog();
                        this.Close();
                    }



                }
                else MessageBox.Show("INVALID LOGIN CREDENTIALS");
            }
            catch (Exception er) { MessageBox.Show(er.ToString()); }
        }
    }
}
