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
    public partial class UserDashboard : Form
    {
        int ID;
        public UserDashboard(int UID)
        {
            InitializeComponent();
            ID = UID;
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            List<string> l = new DB().getUserDetails(ID);
            l_PD.Text = null;
            foreach (string s in l) l_PD.Text = l_PD.Text + "\n" + s;
            l_Pdetails.Text = "\nName\nDate of Birth\nGender\nEmail\nMobile\nCourse\nFees\nStart Date\nEnd Date";
            //gb_course.Text = l.ElementAt(5);
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

        private void btn_pay_Click(object sender, EventArgs e)
        {
            new Payment(ID).Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            new User_Transactions(ID).Show();
        }

        private void ll_prd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact admin", "Forgot Password");
        }

        private void ll_out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            new Login().Show();
        }
    }
}
