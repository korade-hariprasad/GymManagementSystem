namespace GYM_Management_System
{
    partial class Login
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
            this.tb_uid = new System.Windows.Forms.TextBox();
            this.mtb_prd = new System.Windows.Forms.MaskedTextBox();
            this.btn_AdminLogin = new System.Windows.Forms.Button();
            this.btn_UserLogin = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.msMaster = new System.Windows.Forms.MenuStrip();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gymPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Login = new System.Windows.Forms.TabPage();
            this.tab_register = new System.Windows.Forms.TabPage();
            this.mtb_rprd = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.l_rAge = new System.Windows.Forms.Label();
            this.btn_rReset = new System.Windows.Forms.Button();
            this.btn_rSub = new System.Windows.Forms.Button();
            this.l_rFees = new System.Windows.Forms.Label();
            this.cb_Course = new System.Windows.Forms.ComboBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.cb_Gender = new System.Windows.Forms.ComboBox();
            this.dt_DOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Mobile = new System.Windows.Forms.MaskedTextBox();
            this.msMaster.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_Login.SuspendLayout();
            this.tab_register.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_uid
            // 
            this.tb_uid.Location = new System.Drawing.Point(17, 14);
            this.tb_uid.Name = "tb_uid";
            this.tb_uid.Size = new System.Drawing.Size(100, 20);
            this.tb_uid.TabIndex = 1;
            this.tb_uid.Text = "User ID";
            // 
            // mtb_prd
            // 
            this.mtb_prd.HidePromptOnLeave = true;
            this.mtb_prd.Location = new System.Drawing.Point(17, 40);
            this.mtb_prd.Name = "mtb_prd";
            this.mtb_prd.PasswordChar = '*';
            this.mtb_prd.Size = new System.Drawing.Size(100, 20);
            this.mtb_prd.TabIndex = 2;
            this.mtb_prd.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_AdminLogin
            // 
            this.btn_AdminLogin.Location = new System.Drawing.Point(15, 120);
            this.btn_AdminLogin.Name = "btn_AdminLogin";
            this.btn_AdminLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminLogin.TabIndex = 3;
            this.btn_AdminLogin.Text = "Admin Login";
            this.btn_AdminLogin.UseVisualStyleBackColor = true;
            this.btn_AdminLogin.Click += new System.EventHandler(this.btn_AdminLogin_Click);
            // 
            // btn_UserLogin
            // 
            this.btn_UserLogin.Location = new System.Drawing.Point(96, 120);
            this.btn_UserLogin.Name = "btn_UserLogin";
            this.btn_UserLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_UserLogin.TabIndex = 4;
            this.btn_UserLogin.Text = "User Login";
            this.btn_UserLogin.UseVisualStyleBackColor = true;
            this.btn_UserLogin.Click += new System.EventHandler(this.btn_UserLogin_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(14, 63);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(86, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
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
            this.msMaster.TabIndex = 7;
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
            this.equipmentsToolStripMenuItem.Click += new System.EventHandler(this.equipmentsToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // gymPhotosToolStripMenuItem
            // 
            this.gymPhotosToolStripMenuItem.Name = "gymPhotosToolStripMenuItem";
            this.gymPhotosToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.gymPhotosToolStripMenuItem.Text = "Gym Photos";
            this.gymPhotosToolStripMenuItem.Click += new System.EventHandler(this.gymPhotosToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Login);
            this.tabControl1.Controls.Add(this.tab_register);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 217);
            this.tabControl1.TabIndex = 8;
            // 
            // tab_Login
            // 
            this.tab_Login.Controls.Add(this.mtb_prd);
            this.tab_Login.Controls.Add(this.linkLabel2);
            this.tab_Login.Controls.Add(this.tb_uid);
            this.tab_Login.Controls.Add(this.btn_AdminLogin);
            this.tab_Login.Controls.Add(this.btn_UserLogin);
            this.tab_Login.Location = new System.Drawing.Point(4, 22);
            this.tab_Login.Name = "tab_Login";
            this.tab_Login.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Login.Size = new System.Drawing.Size(445, 191);
            this.tab_Login.TabIndex = 0;
            this.tab_Login.Text = "Login";
            this.tab_Login.UseVisualStyleBackColor = true;
            // 
            // tab_register
            // 
            this.tab_register.Controls.Add(this.tb_Mobile);
            this.tab_register.Controls.Add(this.mtb_rprd);
            this.tab_register.Controls.Add(this.label7);
            this.tab_register.Controls.Add(this.l_rAge);
            this.tab_register.Controls.Add(this.btn_rReset);
            this.tab_register.Controls.Add(this.btn_rSub);
            this.tab_register.Controls.Add(this.l_rFees);
            this.tab_register.Controls.Add(this.cb_Course);
            this.tab_register.Controls.Add(this.tb_Email);
            this.tab_register.Controls.Add(this.cb_Gender);
            this.tab_register.Controls.Add(this.dt_DOB);
            this.tab_register.Controls.Add(this.label6);
            this.tab_register.Controls.Add(this.label5);
            this.tab_register.Controls.Add(this.label4);
            this.tab_register.Controls.Add(this.label3);
            this.tab_register.Controls.Add(this.label2);
            this.tab_register.Controls.Add(this.label1);
            this.tab_register.Controls.Add(this.tb_UserName);
            this.tab_register.Location = new System.Drawing.Point(4, 22);
            this.tab_register.Name = "tab_register";
            this.tab_register.Padding = new System.Windows.Forms.Padding(3);
            this.tab_register.Size = new System.Drawing.Size(445, 191);
            this.tab_register.TabIndex = 1;
            this.tab_register.Text = "Register";
            this.tab_register.UseVisualStyleBackColor = true;
            // 
            // mtb_rprd
            // 
            this.mtb_rprd.Location = new System.Drawing.Point(78, 32);
            this.mtb_rprd.Name = "mtb_rprd";
            this.mtb_rprd.PasswordChar = '*';
            this.mtb_rprd.Size = new System.Drawing.Size(145, 20);
            this.mtb_rprd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Password";
            // 
            // l_rAge
            // 
            this.l_rAge.AutoSize = true;
            this.l_rAge.Location = new System.Drawing.Point(255, 55);
            this.l_rAge.Name = "l_rAge";
            this.l_rAge.Size = new System.Drawing.Size(26, 13);
            this.l_rAge.TabIndex = 15;
            this.l_rAge.Text = "Age";
            // 
            // btn_rReset
            // 
            this.btn_rReset.Location = new System.Drawing.Point(90, 150);
            this.btn_rReset.Name = "btn_rReset";
            this.btn_rReset.Size = new System.Drawing.Size(75, 23);
            this.btn_rReset.TabIndex = 14;
            this.btn_rReset.Text = "Reset";
            this.btn_rReset.UseVisualStyleBackColor = true;
            this.btn_rReset.Click += new System.EventHandler(this.btn_rReset_Click);
            // 
            // btn_rSub
            // 
            this.btn_rSub.Location = new System.Drawing.Point(9, 150);
            this.btn_rSub.Name = "btn_rSub";
            this.btn_rSub.Size = new System.Drawing.Size(75, 23);
            this.btn_rSub.TabIndex = 13;
            this.btn_rSub.Text = "Submit";
            this.btn_rSub.UseVisualStyleBackColor = true;
            this.btn_rSub.Click += new System.EventHandler(this.btn_rSub_Click);
            // 
            // l_rFees
            // 
            this.l_rFees.AutoSize = true;
            this.l_rFees.Location = new System.Drawing.Point(255, 150);
            this.l_rFees.Name = "l_rFees";
            this.l_rFees.Size = new System.Drawing.Size(30, 13);
            this.l_rFees.TabIndex = 12;
            this.l_rFees.Text = "Fees";
            // 
            // cb_Course
            // 
            this.cb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Course.FormattingEnabled = true;
            this.cb_Course.Items.AddRange(new object[] {
            "Full-1-Month",
            "Full-3-Month",
            "Full-6-Month",
            "Core-1-Month",
            "Core-3-Month",
            "Core-6-Month",
            "Flex-1-Month",
            "Flex-3-Month",
            "Flex-6-Month"});
            this.cb_Course.Location = new System.Drawing.Point(78, 111);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(145, 21);
            this.cb_Course.TabIndex = 11;
            this.cb_Course.SelectedIndexChanged += new System.EventHandler(this.cb_Course_SelectedIndexChanged);
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(78, 81);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(145, 20);
            this.tb_Email.TabIndex = 9;
            // 
            // cb_Gender
            // 
            this.cb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Not to specify"});
            this.cb_Gender.Location = new System.Drawing.Point(307, 80);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(121, 21);
            this.cb_Gender.TabIndex = 8;
            // 
            // dt_DOB
            // 
            this.dt_DOB.Location = new System.Drawing.Point(78, 55);
            this.dt_DOB.Name = "dt_DOB";
            this.dt_DOB.Size = new System.Drawing.Size(145, 20);
            this.dt_DOB.TabIndex = 7;
            this.dt_DOB.ValueChanged += new System.EventHandler(this.dt_DOB_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // tb_UserName
            // 
            this.tb_UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tb_UserName.Location = new System.Drawing.Point(78, 6);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(350, 20);
            this.tb_UserName.TabIndex = 0;
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Location = new System.Drawing.Point(307, 107);
            this.tb_Mobile.Mask = "0000000000";
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(70, 20);
            this.tb_Mobile.TabIndex = 18;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 256);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.msMaster);
            this.MainMenuStrip = this.msMaster;
            this.Name = "Login";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMaster.ResumeLayout(false);
            this.msMaster.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_Login.ResumeLayout(false);
            this.tab_Login.PerformLayout();
            this.tab_register.ResumeLayout(false);
            this.tab_register.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_uid;
        private System.Windows.Forms.MaskedTextBox mtb_prd;
        private System.Windows.Forms.Button btn_AdminLogin;
        private System.Windows.Forms.Button btn_UserLogin;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.MenuStrip msMaster;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gymPhotosToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Login;
        private System.Windows.Forms.TabPage tab_register;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.DateTimePicker dt_DOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Button btn_rReset;
        private System.Windows.Forms.Button btn_rSub;
        private System.Windows.Forms.Label l_rFees;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.Label l_rAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtb_rprd;
        private System.Windows.Forms.MaskedTextBox tb_Mobile;
    }
}

