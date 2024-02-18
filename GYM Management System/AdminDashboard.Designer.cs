namespace GYM_Management_System
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msMaster = new System.Windows.Forms.MenuStrip();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gymPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_details = new System.Windows.Forms.Button();
            this.btn_viewAll = new System.Windows.Forms.Button();
            this.ll_out = new System.Windows.Forms.LinkLabel();
            this.l_pendig = new System.Windows.Forms.Label();
            this.dgv_allUsers = new System.Windows.Forms.DataGridView();
            this.msMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // msMaster
            // 
            this.msMaster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursesToolStripMenuItem,
            this.equipmentsToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.gymPhotosToolStripMenuItem});
            this.msMaster.Location = new System.Drawing.Point(0, 0);
            this.msMaster.Name = "msMaster";
            this.msMaster.Size = new System.Drawing.Size(474, 24);
            this.msMaster.TabIndex = 9;
            this.msMaster.Text = "msMaster";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
            this.coursesToolStripMenuItem.Click += new System.EventHandler(this.coursesToolStripMenuItem_Click);
            // 
            // equipmentsToolStripMenuItem
            // 
            this.equipmentsToolStripMenuItem.Name = "equipmentsToolStripMenuItem";
            this.equipmentsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.equipmentsToolStripMenuItem.Text = "Equipments";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // gymPhotosToolStripMenuItem
            // 
            this.gymPhotosToolStripMenuItem.Name = "gymPhotosToolStripMenuItem";
            this.gymPhotosToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gymPhotosToolStripMenuItem.Text = "Gym Photos";
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(25, 239);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(75, 23);
            this.btn_details.TabIndex = 10;
            this.btn_details.Text = "Details";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // btn_viewAll
            // 
            this.btn_viewAll.Location = new System.Drawing.Point(106, 239);
            this.btn_viewAll.Name = "btn_viewAll";
            this.btn_viewAll.Size = new System.Drawing.Size(132, 23);
            this.btn_viewAll.TabIndex = 11;
            this.btn_viewAll.Text = "View All Transactions";
            this.btn_viewAll.UseVisualStyleBackColor = true;
            this.btn_viewAll.Click += new System.EventHandler(this.btn_viewAll_Click);
            // 
            // ll_out
            // 
            this.ll_out.AutoSize = true;
            this.ll_out.Location = new System.Drawing.Point(434, 24);
            this.ll_out.Name = "ll_out";
            this.ll_out.Size = new System.Drawing.Size(40, 13);
            this.ll_out.TabIndex = 15;
            this.ll_out.TabStop = true;
            this.ll_out.Text = "Logout";
            this.ll_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_out_LinkClicked);
            // 
            // l_pendig
            // 
            this.l_pendig.AutoSize = true;
            this.l_pendig.Location = new System.Drawing.Point(269, 244);
            this.l_pendig.Name = "l_pendig";
            this.l_pendig.Size = new System.Drawing.Size(72, 13);
            this.l_pendig.TabIndex = 16;
            this.l_pendig.Text = "Pending Fees";
            // 
            // dgv_allUsers
            // 
            this.dgv_allUsers.AllowUserToAddRows = false;
            this.dgv_allUsers.AllowUserToDeleteRows = false;
            this.dgv_allUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allUsers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_allUsers.Location = new System.Drawing.Point(17, 36);
            this.dgv_allUsers.MultiSelect = false;
            this.dgv_allUsers.Name = "dgv_allUsers";
            this.dgv_allUsers.ReadOnly = true;
            this.dgv_allUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_allUsers.Size = new System.Drawing.Size(406, 190);
            this.dgv_allUsers.TabIndex = 17;
            this.dgv_allUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_allUsers_CellContentClick);
            this.dgv_allUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_allUsers_CellContentClick);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 291);
            this.Controls.Add(this.dgv_allUsers);
            this.Controls.Add(this.l_pendig);
            this.Controls.Add(this.ll_out);
            this.Controls.Add(this.btn_viewAll);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.msMaster);
            this.Name = "AdminDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.msMaster.ResumeLayout(false);
            this.msMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMaster;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gymPhotosToolStripMenuItem;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Button btn_viewAll;
        private System.Windows.Forms.LinkLabel ll_out;
        private System.Windows.Forms.Label l_pendig;
        private System.Windows.Forms.DataGridView dgv_allUsers;
    }
}