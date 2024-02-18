namespace GYM_Management_System
{
    partial class FormTest
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.msMaster = new System.Windows.Forms.MenuStrip();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gymPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_allUsers = new System.Windows.Forms.DataGridView();
            
            this.masterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.msMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(77, 270);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 91);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 65);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.msMaster.Size = new System.Drawing.Size(431, 24);
            this.msMaster.TabIndex = 8;
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
            // dgv_allUsers
            // 
            this.dgv_allUsers.AutoGenerateColumns = false;
            this.dgv_allUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_allUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.unameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.feesDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.dgv_allUsers.DataSource = this.masterBindingSource;
            this.dgv_allUsers.Location = new System.Drawing.Point(13, 38);
            this.dgv_allUsers.Name = "dgv_allUsers";
            this.dgv_allUsers.Size = new System.Drawing.Size(406, 190);
            this.dgv_allUsers.TabIndex = 18;
            this.dgv_allUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_allUsers_CellContentClick);
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // unameDataGridViewTextBoxColumn
            // 
            this.unameDataGridViewTextBoxColumn.DataPropertyName = "uname";
            this.unameDataGridViewTextBoxColumn.HeaderText = "uname";
            this.unameDataGridViewTextBoxColumn.Name = "unameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // feesDataGridViewTextBoxColumn
            // 
            this.feesDataGridViewTextBoxColumn.DataPropertyName = "fees";
            this.feesDataGridViewTextBoxColumn.HeaderText = "fees";
            this.feesDataGridViewTextBoxColumn.Name = "feesDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 380);
            this.Controls.Add(this.dgv_allUsers);
            this.Controls.Add(this.msMaster);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.tabControl1.ResumeLayout(false);
            this.msMaster.ResumeLayout(false);
            this.msMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_allUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip msMaster;
        private System.Windows.Forms.ToolStripMenuItem equipmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gymPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coursesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_allUsers;
        private System.Windows.Forms.BindingSource masterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
    }
}