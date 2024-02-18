namespace GYM_Management_System
{
    partial class User_Transactions
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Ut = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ut)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UID Name";
            // 
            // dgv_Ut
            // 
            this.dgv_Ut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Ut.Location = new System.Drawing.Point(14, 37);
            this.dgv_Ut.MultiSelect = false;
            this.dgv_Ut.Name = "dgv_Ut";
            this.dgv_Ut.ReadOnly = true;
            this.dgv_Ut.Size = new System.Drawing.Size(440, 212);
            this.dgv_Ut.TabIndex = 1;
            // 
            // User_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 261);
            this.Controls.Add(this.dgv_Ut);
            this.Controls.Add(this.label1);
            this.Name = "User_Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.User_Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Ut;
    }
}