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
    public partial class AdminDashboard : Form
    {
        int ID;

        public AdminDashboard()
        {
            InitializeComponent();
            dgv_allUsers.AutoGenerateColumns = true;
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            DataSet ds = new DB().getAllUsers();
            dgv_allUsers.DataSource = ds.Tables[0].DefaultView;
            ID = int.Parse(dgv_allUsers.CurrentCell.Value.ToString());
            l_pendig.Text = "Pending Fees :" + new DB().getFees(dgv_allUsers.CurrentCell.Value.ToString());
        }

        private void btn_details_Click(object sender, EventArgs e)
        {
            //take ID of selected user from list
            new UserDetails(ID).Show();
            Close();
        }

        private void btn_viewAll_Click(object sender, EventArgs e)
        {
            new User_Transactions(ID).Show();
        }

        private void ll_out_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
            new Login().Show();
        }

        private void dgv_allUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex==0)
            {
                ID = int.Parse(dgv_allUsers.CurrentCell.Value.ToString());
            }
            //Fetch fees & print 
            l_pendig.Text = "Pending Fees :"+new DB().getFees(dgv_allUsers.CurrentCell.Value.ToString());
        }
    }
}
