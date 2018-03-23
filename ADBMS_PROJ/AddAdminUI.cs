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
    public partial class AddAdminUI : MetroForm
    {
        connection cs = new connection();
        connection ds = new connection();
        public AddAdminUI()
        {
            InitializeComponent();
        }

        private void AddAdminUI_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "begin add_admin('" + nameTextBox.Text + "','" + addressTextBox.Text + "','" + contactTextBox.Text + "','" + passTextBox.Text + "','"+"admin"+"'); end;";

            if (cs.ExecuteQuery(SQL) == true)
            {

                DataTable DT = new DataTable();
                String sqls = "select u_id from admin where name='" + nameTextBox.Text + "'" + " and contact_no='" + contactTextBox.Text + "'";
                
                DT = ds.GetResult(sqls);
                string sf = DT.Rows[0][0].ToString();
                MessageBox.Show("Registration Successful for USER ID : " + sf);
                this.Hide();
                RegisterUI special = new RegisterUI();
                special.ShowDialog();
                this.Close();
            }
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            RegisterUI special = new RegisterUI();
            special.ShowDialog();
            this.Close();
        }
    }
}
