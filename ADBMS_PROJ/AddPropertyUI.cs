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
    public partial class AddPropertyUI : MetroForm
    {
        connection cs = new connection();
        public AddPropertyUI()
        {
            InitializeComponent();
        }

        private void AddPropertyUI_Load(object sender, EventArgs e)
        {

        }

        private void registerButton_MouseClick(object sender, MouseEventArgs e)
        {
            
            String sad = sizeTextBox.Text;
            String SQL = "insert into property (p_id,p_name,p_area,p_size,p_desc) values (pid_seq.nextval,'" + propNameTextBox.Text + "','" + areaTextBox.Text + "'," + Convert.ToInt32(sad) + ",'" + descriptionTextBox.Text + "')";
            if (cs.ExecuteQuery(SQL) == true) {
                MessageBox.Show("DONE");
              
            }
        }

        private void backButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            AdminUI special = new AdminUI();
            special.ShowDialog();
            this.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
