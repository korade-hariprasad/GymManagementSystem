namespace GYM_Management_System
{
    partial class UserDashboard
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
            this.ll_prd = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_Pdetails = new System.Windows.Forms.Label();
            this.gb_course = new System.Windows.Forms.GroupBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.msMaster = new System.Windows.Forms.MenuStrip();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gymPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ll_out = new System.Windows.Forms.LinkLabel();
            this.l_PD = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.msMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // ll_prd
            // 
            this.ll_prd.AutoSize = true;
            this.ll_prd.Location = new System.Drawing.Point(372, 414);
            this.ll_prd.Name = "ll_prd";
            this.ll_prd.Size = new System.Drawing.Size(90, 13);
            this.ll_prd.TabIndex = 1;
            this.ll_prd.TabStop = true;
            this.ll_prd.Text = "Password Issue ?";
            this.ll_prd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_prd_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_PD);
            this.groupBox1.Controls.Add(this.l_Pdetails);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 184);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // l_Pdetails
            // 
            this.l_Pdetails.AutoSize = true;
            this.l_Pdetails.Location = new System.Drawing.Point(6, 16);
            this.l_Pdetails.Name = "l_Pdetails";
            this.l_Pdetails.Size = new System.Drawing.Size(97, 13);
            this.l_Pdetails.TabIndex = 0;
            this.l_Pdetails.Text = "Personal Details All";
            // 
            // gb_course
            // 
            this.gb_course.Location = new System.Drawing.Point(12, 230);
            this.gb_course.Name = "gb_course";
            this.gb_course.Size = new System.Drawing.Size(359, 148);
            this.gb_course.TabIndex = 10;
            this.gb_course.TabStop = false;
            this.gb_course.Text = "Course Details";
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(21, 414);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(75, 23);
            this.btn_pay.TabIndex = 11;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(102, 414);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(152, 23);
            this.btn_view.TabIndex = 12;
            this.btn_view.Text = "View all transactions";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
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
            this.msMaster.TabIndex = 13;
            this.msMaster.Text = "msMaster";
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
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
            // ll_out
            // 
            this.ll_out.AutoSize = true;
            this.ll_out.Location = new System.Drawing.Point(407, 40);
            this.ll_out.Name = "ll_out";
            this.ll_out.Size = new System.Drawing.Size(40, 13);
            this.ll_out.TabIndex = 14;
            this.ll_out.TabStop = true;
            this.ll_out.Text = "Logout";
            this.ll_out.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_out_LinkClicked);
            // 
            // l_PD
            // 
            this.l_PD.AutoSize = true;
            this.l_PD.Location = new System.Drawing.Point(109, 16);
            this.l_PD.Name = "l_PD";
            this.l_PD.Size = new System.Drawing.Size(97, 13);
            this.l_PD.TabIndex = 1;
            this.l_PD.Text = "Personal Details All";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 454);
            this.Controls.Add(this.ll_out);
            this.Controls.Add(this.msMaster);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.gb_course);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ll_prd);
            this.Name = "UserDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.msMaster.ResumeLayout(false);
            this.msMaster.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel ll_prd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_Pdetails;
        private System.Windows.Forms.GroupBox gb_course;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.MenuStrip msMaster;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gymPhotosToolStripMenuItem;
        private System.Windows.Forms.LinkLabel ll_out;
        private System.Windows.Forms.Label l_PD;
    }
}