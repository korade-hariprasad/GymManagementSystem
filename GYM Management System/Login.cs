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
    public partial class Login : Form
    {
        int Age = 0, fees = 0;
        DateTime EndDate;
        //DateTime StartDate = new DateTime.Today;
        
        public Login()
        {
            InitializeComponent();
        }

        private void btn_AdminLogin_Click(object sender, EventArgs e)
        {
            if (tb_uid.Text == "" || mtb_prd.Text == "") { MessageBox.Show("Enter proper text in User ID or passowrd", "Improper input"); }
            if (tb_uid.Text == "Admin" && mtb_prd.Text == "password")
            {
                Hide();
                new AdminDashboard().Show();
            }
            else {
                MessageBox.Show("Incorrect User ID or Password", "Invalid Input");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt_DOB.Value = DateTime.Today;
        }

        private void btn_UserLogin_Click(object sender, EventArgs e)
        {
            if (tb_uid.Text == "" || mtb_prd.Text == "") { MessageBox.Show("Please fill all values", "Invalid input"); }
            else {
                DB d = new DB();
                List<string> IDlist = d.getIDlist();
                //Test
                
                //Test
                if (IDlist.Contains(tb_uid.Text))
                {
                    if (mtb_prd.Text.Equals(d.SelectPrd(tb_uid.Text)))
                    {
                        new UserDashboard(int.Parse(tb_uid.Text)).Show();
                        Hide();
                    }
                    else {
                        MessageBox.Show("Incorrect Password", "Invalid Input");
                    }
                }
                else {
                    MessageBox.Show("User ID does not exists", "Invalid Input");
                }
                
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("If you are admin, please contact developer\nIf you are user, please contact admin", "Forgot Password");
        }

        private void btn_rSub_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text.Equals("") || tb_Email.Text.Equals("") || tb_Mobile.Text.Equals("") || cb_Course.SelectedItem == null || cb_Gender.SelectedItem==null || mtb_rprd.Text.Equals(""))
            {
                MessageBox.Show("Please fill all values", "Invalid input");
            }
            else {
                //Enter data into database here//
                DB d = new DB();
                string dob = dt_DOB.Value.ToString().Split(' ')[0], ed = EndDate.ToString().Split(' ')[0];
                string ID = d.InsertQ(tb_UserName.Text, dob, tb_Email.Text, tb_Mobile.Text, cb_Gender.Text.ToString(), cb_Course.Text.ToString(), ed, fees, mtb_rprd.Text);
                //also print uid in this box
                MessageBox.Show("User Registered Successfully\n User ID: " + ID);
            }
        }

        private void cb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Course.SelectedIndex == 0 || cb_Course.SelectedIndex == 3 || cb_Course.SelectedIndex == 6)
            {
                fees = 600; l_rFees.Text = "Fees " + fees +" Rs"; EndDate = DateTime.Today.AddMonths(1);
            }
            else if (cb_Course.SelectedIndex == 1 || cb_Course.SelectedIndex == 4 || cb_Course.SelectedIndex == 7)
            {
                fees = 600 * 3; l_rFees.Text = "Fees " + fees + " Rs"; EndDate = DateTime.Today.AddMonths(3);
            }
            else if (cb_Course.SelectedIndex == 2 || cb_Course.SelectedIndex == 5 || cb_Course.SelectedIndex == 8)
            {
                fees = 600 * 6; l_rFees.Text = "Fees " + fees + " Rs"; EndDate = DateTime.Today.AddMonths(6);
            }
        }

        private void btn_rReset_Click(object sender, EventArgs e)
        {
            l_rFees.Text = l_rAge.Text = "NA";
            tb_Email.Text = tb_Mobile.Text = tb_UserName.Text = "";
            cb_Course.Text = cb_Gender.Text = "";
        }

        private void coursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Courses().Show();
        }

        private void equipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Equipemnts().Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void gymPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Photos().Show();
        }

        private void dt_DOB_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dt_DOB.Value;
            Age = DateTime.Today.Year - dt.Year;
            l_rAge.Text = "Age " + Age;
        }
    }
}
