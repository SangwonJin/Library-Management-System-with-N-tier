namespace FrontEnd
{
    partial class AddInstructor
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
            this.btnExit = new System.Windows.Forms.Button();
            this.grpInstructorInfo = new System.Windows.Forms.GroupBox();
            this.cmbInstructorType = new System.Windows.Forms.ComboBox();
            this.lblProgramOption = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtInstructorId = new System.Windows.Forms.TextBox();
            this.lblInstructorId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpInstructorInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(592, 239);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 48);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpInstructorInfo
            // 
            this.grpInstructorInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpInstructorInfo.Controls.Add(this.cmbInstructorType);
            this.grpInstructorInfo.Controls.Add(this.lblProgramOption);
            this.grpInstructorInfo.Controls.Add(this.txtPassword);
            this.grpInstructorInfo.Controls.Add(this.lblPassword);
            this.grpInstructorInfo.Controls.Add(this.txtInstructorId);
            this.grpInstructorInfo.Controls.Add(this.lblInstructorId);
            this.grpInstructorInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpInstructorInfo.Location = new System.Drawing.Point(43, 105);
            this.grpInstructorInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInstructorInfo.Name = "grpInstructorInfo";
            this.grpInstructorInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInstructorInfo.Size = new System.Drawing.Size(896, 97);
            this.grpInstructorInfo.TabIndex = 3;
            this.grpInstructorInfo.TabStop = false;
            this.grpInstructorInfo.Tag = "";
            // 
            // cmbInstructorType
            // 
            this.cmbInstructorType.FormattingEnabled = true;
            this.cmbInstructorType.Location = new System.Drawing.Point(619, 48);
            this.cmbInstructorType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbInstructorType.Name = "cmbInstructorType";
            this.cmbInstructorType.Size = new System.Drawing.Size(227, 23);
            this.cmbInstructorType.TabIndex = 5;
            // 
            // lblProgramOption
            // 
            this.lblProgramOption.AutoSize = true;
            this.lblProgramOption.Location = new System.Drawing.Point(615, 31);
            this.lblProgramOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgramOption.Name = "lblProgramOption";
            this.lblProgramOption.Size = new System.Drawing.Size(109, 15);
            this.lblProgramOption.TabIndex = 4;
            this.lblProgramOption.Text = "Instructor Type:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(325, 48);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 25);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(324, 31);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtInstructorId
            // 
            this.txtInstructorId.Location = new System.Drawing.Point(27, 50);
            this.txtInstructorId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInstructorId.Name = "txtInstructorId";
            this.txtInstructorId.Size = new System.Drawing.Size(209, 25);
            this.txtInstructorId.TabIndex = 1;
            // 
            // lblInstructorId
            // 
            this.lblInstructorId.AutoSize = true;
            this.lblInstructorId.Location = new System.Drawing.Point(23, 31);
            this.lblInstructorId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstructorId.Name = "lblInstructorId";
            this.lblInstructorId.Size = new System.Drawing.Size(143, 15);
            this.lblInstructorId.TabIndex = 0;
            this.lblInstructorId.Text = "Instructor UserName:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 239);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(241, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&ADD New Instructor";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 52);
            this.label2.TabIndex = 44;
            this.label2.Text = "Add Instructor";
            // 
            // AddInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 352);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpInstructorInfo);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddInstructor";
            this.Text = "AddInstructor";
            this.Load += new System.EventHandler(this.AddInstructor_Load);
            this.grpInstructorInfo.ResumeLayout(false);
            this.grpInstructorInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.GroupBox grpInstructorInfo;
        internal System.Windows.Forms.ComboBox cmbInstructorType;
        internal System.Windows.Forms.Label lblProgramOption;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.Label lblPassword;
        internal System.Windows.Forms.TextBox txtInstructorId;
        internal System.Windows.Forms.Label lblInstructorId;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
    }
}