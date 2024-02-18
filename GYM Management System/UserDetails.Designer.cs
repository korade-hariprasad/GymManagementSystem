namespace GYM_Management_System
{
    partial class UserDetails
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
            this.l_UID = new System.Windows.Forms.Label();
            this.btn_rReset = new System.Windows.Forms.Button();
            this.btn_rSub = new System.Windows.Forms.Button();
            this.l_StartDate = new System.Windows.Forms.Label();
            this.l_EndDate = new System.Windows.Forms.Label();
            this.tb_Mobile = new System.Windows.Forms.MaskedTextBox();
            this.dt_Start = new System.Windows.Forms.DateTimePicker();
            this.dt_End = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtb_rprd = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_rFees
            // 
            this.l_rFees.AutoSize = true;
            this.l_rFees.Location = new System.Drawing.Point(26, 217);
            this.l_rFees.Name = "l_rFees";
            this.l_rFees.Size = new System.Drawing.Size(30, 13);
            this.l_rFees.TabIndex = 25;
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
            this.cb_Course.Location = new System.Drawing.Point(98, 182);
            this.cb_Course.Name = "cb_Course";
            this.cb_Course.Size = new System.Drawing.Size(145, 21);
            this.cb_Course.TabIndex = 24;
            this.cb_Course.SelectedIndexChanged += new System.EventHandler(this.cb_Course_SelectedIndexChanged);
            // 
            // tb_Email
            // 
            this.tb_Email.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_Email.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tb_Email.Location = new System.Drawing.Point(98, 152);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(145, 20);
            this.tb_Email.TabIndex = 22;
            // 
            // cb_Gender
            // 
            this.cb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Gender.FormattingEnabled = true;
            this.cb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Not to specify"});
            this.cb_Gender.Location = new System.Drawing.Point(327, 126);
            this.cb_Gender.Name = "cb_Gender";
            this.cb_Gender.Size = new System.Drawing.Size(121, 21);
            this.cb_Gender.TabIndex = 21;
            // 
            // dt_DOB
            // 
            this.dt_DOB.Location = new System.Drawing.Point(98, 126);
            this.dt_DOB.Name = "dt_DOB";
            this.dt_DOB.Size = new System.Drawing.Size(145, 20);
            this.dt_DOB.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mobile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Date of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // tb_UserName
            // 
            this.tb_UserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_UserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.tb_UserName.Location = new System.Drawing.Point(98, 74);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(350, 20);
            this.tb_UserName.TabIndex = 13;
            // 
            // l_UID
            // 
            this.l_UID.AutoSize = true;
            this.l_UID.Location = new System.Drawing.Point(26, 33);
            this.l_UID.Name = "l_UID";
            this.l_UID.Size = new System.Drawing.Size(26, 13);
            this.l_UID.TabIndex = 26;
            this.l_UID.Text = "UID";
            // 
            // btn_rReset
            // 
            this.btn_rReset.Location = new System.Drawing.Point(107, 253);
            this.btn_rReset.Name = "btn_rReset";
            this.btn_rReset.Size = new System.Drawing.Size(75, 23);
            this.btn_rReset.TabIndex = 28;
            this.btn_rReset.Text = "Refresh";
            this.btn_rReset.UseVisualStyleBackColor = true;
            this.btn_rReset.Click += new System.EventHandler(this.btn_rReset_Click);
            // 
            // btn_rSub
            // 
            this.btn_rSub.Location = new System.Drawing.Point(26, 253);
            this.btn_rSub.Name = "btn_rSub";
            this.btn_rSub.Size = new System.Drawing.Size(75, 23);
            this.btn_rSub.TabIndex = 27;
            this.btn_rSub.Text = "Update";
            this.btn_rSub.UseVisualStyleBackColor = true;
            this.btn_rSub.Click += new System.EventHandler(this.btn_rSub_Click);
            // 
            // l_StartDate
            // 
            this.l_StartDate.AutoSize = true;
            this.l_StartDate.Location = new System.Drawing.Point(271, 185);
            this.l_StartDate.Name = "l_StartDate";
            this.l_StartDate.Size = new System.Drawing.Size(55, 13);
            this.l_StartDate.TabIndex = 29;
            this.l_StartDate.Text = "Start Date";
            // 
            // l_EndDate
            // 
            this.l_EndDate.AutoSize = true;
            this.l_EndDate.Location = new System.Drawing.Point(271, 217);
            this.l_EndDate.Name = "l_EndDate";
            this.l_EndDate.Size = new System.Drawing.Size(52, 13);
            this.l_EndDate.TabIndex = 30;
            this.l_EndDate.Text = "End Date";
            // 
            // tb_Mobile
            // 
            this.tb_Mobile.Location = new System.Drawing.Point(327, 151);
            this.tb_Mobile.Mask = "0000000000";
            this.tb_Mobile.Name = "tb_Mobile";
            this.tb_Mobile.Size = new System.Drawing.Size(70, 20);
            this.tb_Mobile.TabIndex = 31;
            // 
            // dt_Start
            // 
            this.dt_Start.Location = new System.Drawing.Point(327, 179);
            this.dt_Start.Name = "dt_Start";
            this.dt_Start.Size = new System.Drawing.Size(145, 20);
            this.dt_Start.TabIndex = 32;
            // 
            // dt_End
            // 
            this.dt_End.Location = new System.Drawing.Point(327, 210);
            this.dt_End.Name = "dt_End";
            this.dt_End.Size = new System.Drawing.Size(145, 20);
            this.dt_End.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(188, 253);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtb_rprd
            // 
            this.mtb_rprd.Location = new System.Drawing.Point(98, 100);
            this.mtb_rprd.Name = "mtb_rprd";
            this.mtb_rprd.PasswordChar = '*';
            this.mtb_rprd.Size = new System.Drawing.Size(145, 20);
            this.mtb_rprd.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Password";
            // 
            // UserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 322);
            this.Controls.Add(this.mtb_rprd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dt_End);
            this.Controls.Add(this.dt_Start);
            this.Controls.Add(this.tb_Mobile);
            this.Controls.Add(this.l_EndDate);
            this.Controls.Add(this.l_StartDate);
            this.Controls.Add(this.btn_rReset);
            this.Controls.Add(this.btn_rSub);
            this.Controls.Add(this.l_UID);
            this.Controls.Add(this.l_rFees);
            this.Controls.Add(this.cb_Course);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.cb_Gender);
            this.Controls.Add(this.dt_DOB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_UserName);
            this.Name = "UserDetails";
            this.Text = "UserDetails";
            this.Load += new System.EventHandler(this.UserDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_rFees;
        private System.Windows.Forms.ComboBox cb_Course;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.ComboBox cb_Gender;
        private System.Windows.Forms.DateTimePicker dt_DOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.Label l_UID;
        private System.Windows.Forms.Button btn_rReset;
        private System.Windows.Forms.Button btn_rSub;
        private System.Windows.Forms.Label l_StartDate;
        private System.Windows.Forms.Label l_EndDate;
        private System.Windows.Forms.MaskedTextBox tb_Mobile;
        private System.Windows.Forms.DateTimePicker dt_Start;
        private System.Windows.Forms.DateTimePicker dt_End;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox mtb_rprd;
        private System.Windows.Forms.Label label7;
    }
}