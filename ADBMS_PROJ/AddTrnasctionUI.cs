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
using System.Data.OracleClient;
namespace ADBMS_PROJ
{
    public partial class AddTrnasctionUI : MetroForm
    {
        connection cs = new connection();
        public AddTrnasctionUI()
        {
            InitializeComponent();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddTrnasctionUI_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            DT = cs.GetResult("Select * from client");
            
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                metroComboBox1.Items.Add(DT.Rows[i]["c_id"]);
            }

            DT = cs.GetResult("Select * from property");
            
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                metroComboBox2.Items.Add(DT.Rows[i]["p_id"]);
            }








        }

        private void registerButton_MouseClick(object sender, MouseEventArgs e)
        {
            
            String SQL="insert into transactions (t_id,c_id,p_id,status,t_type,amount) values (tid_seq.nextval,"+Convert.ToInt32(metroComboBox1.Text)+","+Convert.ToInt32(metroComboBox2.Text)+",'"+metroComboBox3.Text+"','"+metroComboBox4.Text+"',"+Convert.ToInt32(amountTextBox.Text)+")";
            DataTable DT = new DataTable();
            if (cs.ExecuteQuery(SQL) == true) {
                MessageBox.Show("DONE");
            }



        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            TransactionUI special = new TransactionUI();
            special.ShowDialog();
            this.Close();
        }
    }
}
