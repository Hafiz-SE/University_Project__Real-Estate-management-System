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
    public partial class ViewReportsPRO : MetroForm
    {
        connection cs = new connection();
        public ViewReportsPRO()
        {
            InitializeComponent();
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "select * from passchange";
                DataTable DT= new DataTable();
            DT= cs.GetResult(SQL);
            dataGridView1.DataSource=DT;


        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "select * from size_changed";
            DataTable DT = new DataTable();
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;

        }

        private void metroButton3_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "select * from contact_changed";
            DataTable DT = new DataTable();
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;

        }

        private void metroButton4_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "select * from ch_add";
            DataTable DT = new DataTable();
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton10_MouseClick(object sender, MouseEventArgs e)
        { DataTable DT = new DataTable();
            String SQL = "select count(*)TOTAL  from transactions";
            
            DT=cs.GetResult(SQL);
            String fake=DT.Rows[0]["TOTAL"].ToString();
            MessageBox.Show("No of TOTAL TRANSACTION IS :"+fake);
        }

        private void ViewReportsPRO_Load(object sender, EventArgs e)
        {

        }

        private void metroButton9_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("TOTAL PROPERTY SIZE", typeof(String));
            DT.Rows.Add(cs.Getnum().ToString());
            dataGridView1.DataSource = DT;
     
        }

        private void metroButton7_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "select c_contact_NO from client";
            DataTable DT = new DataTable();
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton5_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "SELECT  (SELECT COUNT(*) FROM  transactions) AS transactions,(SELECT COUNT(*) FROM client) AS CLIENT,(SELECT COUNT(*) FROM admin) AS admin,(SELECT COUNT(*)FROM property) AS property FROM dual";
            DataTable DT = new DataTable();
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton8_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("paid", typeof(int));
            DT.Columns.Add("processing", typeof(int));
            DT.Columns.Add("cancelled", typeof(int));
            DT.Columns.Add("pending", typeof(int));
            DT.Rows.Add(Convert.ToInt32(cs.Getperc_1("paid")), Convert.ToInt32(cs.Getperc_1("processing")), Convert.ToInt32(cs.Getperc_1("cancelled")), Convert.ToInt32(cs.Getperc_1("pending")));
            dataGridView1.DataSource = DT;
        }

        private void metroButton6_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("cash", typeof(int));
            DT.Columns.Add("card", typeof(int));
            DT.Columns.Add("cheque", typeof(int));
            DT.Rows.Add(Convert.ToInt32(cs.Getperc_2("cash")), Convert.ToInt32(cs.Getperc_2("card")), Convert.ToInt32(cs.Getperc_2("cheque")));
            dataGridView1.DataSource = DT;
        }

        private void BACK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminUI special = new AdminUI();
            special.ShowDialog();
            this.Close();
        }


    }
}
