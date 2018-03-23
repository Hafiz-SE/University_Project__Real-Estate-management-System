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
    public partial class AddClientUI : MetroForm
    {
        connection cs = new connection();
        public AddClientUI()
        {
            InitializeComponent();
        }

        private void AddClientUI_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "begin add_client('" + nameTextBox.Text + "','" + addressTextBox.Text + "','" + contactTextBox.Text + "','" + passTextBox.Text + "','" + "customer" + "'); end;";
            if (cs.ExecuteQuery(SQL) == true)
            {String sqls = "select u_id from client where c_name='" + nameTextBox.Text + "'" + " and c_contact_no='" + contactTextBox.Text + "'";
                DataTable DT = new DataTable();
                DT=cs.GetResult(sqls);
                String xp = DT.Rows[0][0].ToString();
                MessageBox.Show("Registration Succesful for USER ID : " + xp);
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
