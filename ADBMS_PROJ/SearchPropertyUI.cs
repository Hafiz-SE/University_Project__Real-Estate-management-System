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
    public partial class SearchPropertyUI : MetroForm
    {
        connection cs = new connection();
        public SearchPropertyUI()
        {
            InitializeComponent();
        }

        private void SearchPropertyUI_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if(metroComboBox1.Text.Equals("")){
                DataTable DT = new DataTable();
                String SQL = "select * from property where p_area='"+metroComboBox2.Text+"'";
                DT = cs.GetResult(SQL);
                dataGridView1.DataSource = DT;
            }
            else if (metroComboBox2.Text.Equals(""))
            {
                DataTable DT = new DataTable();

                String SQL = "select * from property where p_size>" + Convert.ToInt16(metroComboBox1.Text);
                DT = cs.GetResult(SQL);
                dataGridView1.DataSource = DT;
            }
            else
            {
                DataTable DT = new DataTable();
                String SQL = "select * from property where p_size>" + Convert.ToInt16(metroComboBox1.Text)+" and p_area='"+metroComboBox2.Text+"'";
                DT = cs.GetResult(SQL);
                dataGridView1.DataSource = DT;
            }
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            ClientUI special = new ClientUI();
            special.ShowDialog();
            this.Close();
        }
    }
}
