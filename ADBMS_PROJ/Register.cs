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
namespace ADBMS_PROJ
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }
        connection c = new connection();
        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ADBMS_PROJ special = new ADBMS_PROJ();
            special.ShowDialog();
            this.Close();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            int k = 0;
            String user = metroTextBox1.Text;
            String pass = metroTextBox2.Text;
            String name = metroTextBox3.Text;
            String email = metroTextBox5.Text;
            if (metroTextBox1.Text == "" || metroTextBox2.Text == "" || metroTextBox5.Text == "")
            {
                MessageBox.Show("SOME FIELD IS MISSING, PLEASE ENTER CORRECT VALUES");
            }
                
            else {
                try
                {
                    string connstring = "Data Source = (DESCRIPTION = "+
    "(ADDRESS = (PROTOCOL = TCP)(HOST = IceFrog-PC)(PORT = 1521))" +
    "(CONNECT_DATA ="+
      "(SERVER = DEDICATED)"+
      "(SERVICE_NAME = XE)"+
    ")"+
  ");User Id = icefrog; password = 123four;";

                    OracleConnection cc = new OracleConnection(connstring);
                    string ssqqll = "select * from users";
                    OracleDataAdapter adapter = new OracleDataAdapter(ssqqll, cc);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    cc.Close();
                    int rowcount = dt.Rows.Count;
                    for(int i=0; i<rowcount; i++)
                    {
                        
                        if (dt.Rows[i]["uname"].ToString().Equals(user)) {
                            k = 1;
                        } 
                    }
                    if (k == 1) { MessageBox.Show("USERNAME ALREADY EXISTS!"); k = 0; }
                    else
                    {
                        string sql = "insert into users values('" + user + "','" + pass + "','" + name + "','" + email + "')";
                        c.ExecuteQuery(sql);
                        
                        MessageBox.Show("REGISTRATION SUCCESSFUL!");
                        this.Hide();
                        ADBMS_PROJ special = new ADBMS_PROJ();
                        special.ShowDialog();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }
    }
}
