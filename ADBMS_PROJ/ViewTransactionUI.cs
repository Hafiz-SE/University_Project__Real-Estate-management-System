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
    public partial class ViewTransactionUI : MetroForm
    {
        connection cs = new connection();
        public ViewTransactionUI()
        {
            InitializeComponent();
        }

        private void showButton_MouseClick(object sender, MouseEventArgs e)
        {   DataTable DT = new DataTable();
            String SQL = "select * from transactions";
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void showButton_MouseClick_1(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL= "select * from transactions where t_id="+Convert.ToInt32(metroTextBox1.Text);
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;

        }

        private void metroButton2_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "select * from transactions where p_id=" + Convert.ToInt32(metroTextBox3.Text);
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton3_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "select * from transactions where c_id=" + Convert.ToInt32(metroTextBox4.Text);
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton1_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "select * from transactions where status='" + metroTextBox2.Text + "'";
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton5_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "select * from transactions where t_type='" + metroTextBox6.Text + "'";
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton6_MouseClick(object sender, MouseEventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "select * from transactions where amount>" + Convert.ToInt32(metroTextBox7.Text);
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton7_MouseClick(object sender, MouseEventArgs e)
        {

            DataTable DT = new DataTable();
            String SQL = "select * from transactions where amount<" + Convert.ToInt32(metroTextBox7.Text);
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        private void metroButton8_MouseClick(object sender, MouseEventArgs e)
        {

            DataTable DT = new DataTable();
            String SQL = "select * from transactions where amount=" + Convert.ToInt32(metroTextBox7.Text);
            DT = cs.GetResult(SQL);
            dataGridView1.DataSource = DT;
        }

        

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            TransactionUI special = new TransactionUI();
            special.ShowDialog();
            this.Close();
        }

        private void ViewTransactionUI_Load(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            String SQL = "SELECT t_id from transactions";
            DT = cs.GetResult(SQL);
            metroComboBox1.DataSource = DT;
            metroComboBox1.DisplayMember = "t_id";
        }

        private void metroButton9_MouseClick(object sender, MouseEventArgs e)
        {
            String SQL = "update transactions set amount =" + Convert.ToInt32(metroTextBox8.Text)+ "where t_id =" +Convert.ToInt32(metroComboBox1.Text);
            cs.ExecuteQuery(SQL);
            MessageBox.Show("Done");
        }

        private void c(object sender, EventArgs e)
        {
            
        }
    }
}
