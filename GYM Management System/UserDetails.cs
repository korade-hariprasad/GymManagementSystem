using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM_Management_System
{
    public partial class UserDetails : Form
    {
        int ID, fees;
        public UserDetails(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        public void fillAllBoxex() {
            List<string> l = new DB().getUserDetails(ID);
            l_UID.Text = ID.ToString();
            tb_UserName.Text = l.ElementAt(0);
            dt_DOB.Value = DateTime.Parse(l.ElementAt(1));
            cb_Gender.Text = l.ElementAt(2);
            tb_Email.Text = l.ElementAt(3);
            tb_Mobile.Text = l.ElementAt(4);
            cb_Course.Text = l.ElementAt(5);
            dt_Start.Value = DateTime.Parse(l.ElementAt(6));
            dt_End.Value = DateTime.Parse(l.ElementAt(7));
            l_rFees.Text = "Fees: " + l.ElementAt(8);
        }

        private void UserDetails_Load(object sender, EventArgs e)
        {
            //get all deatisl from ID & Fill them in the boxes
            fillAllBoxex();
        }

        private void btn_rSub_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text.Equals("") || tb_Email.Text.Equals("") || tb_Mobile.Text.Equals("") || cb_Course.SelectedItem == null || cb_Gender.SelectedItem == null)
            {
                MessageBox.Show("Please fill all values", "Invalid input");
            }
            else
            {
                //Update data into database here
                new DB().updateQ(ID, tb_UserName.Text, dt_DOB.Value.ToString(), tb_Email.Text, tb_Mobile.Text, cb_Gender.Text.ToString(), cb_Course.Text.ToString(), dt_Start.Value.ToString(), dt_End.Value.ToString(), fees, mtb_rprd.Text);
                MessageBox.Show("Values have been updated", ID+"-Updated");
            }
        }

        private void btn_rReset_Click(object sender, EventArgs e)
        {
            fillAllBoxex();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            new DB().deleteUser(ID);
            MessageBox.Show("User Deleted");
            Close();
            new AdminDashboard().Show();
        }

        private void cb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_Start.Value = DateTime.Now;
            if (cb_Course.SelectedIndex == 0 || cb_Course.SelectedIndex == 3 || cb_Course.SelectedIndex == 6)
            {
                fees = 600; l_rFees.Text = "Fees " + fees; dt_End.Value = dt_Start.Value.AddMonths(1);
            }
            else if (cb_Course.SelectedIndex == 1 || cb_Course.SelectedIndex == 4 || cb_Course.SelectedIndex == 7)
            {
                fees = 600 * 3; l_rFees.Text = "Fees " + fees; dt_End.Value = dt_Start.Value.AddMonths(3);
            }
            else if (cb_Course.SelectedIndex == 2 || cb_Course.SelectedIndex == 5 || cb_Course.SelectedIndex == 8)
            {
                fees = 600 * 6; l_rFees.Text = "Fees " + fees; dt_End.Value = dt_Start.Value.AddMonths(6);
            }
            
        }
    }
}
