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
    public partial class User_Transactions : Form
    {
        int ID;
        public User_Transactions(int ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void User_Transactions_Load(object sender, EventArgs e)
        {
            DataSet ds = new DB().getUserTrans(ID);
            dgv_Ut.DataSource = ds.Tables[0].DefaultView;
            label1.Text = ID.ToString();
        }
        
    }
}
