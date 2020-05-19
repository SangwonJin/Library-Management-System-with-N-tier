namespace FrontEnd
{
    partial class Payment
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
            this.pnlAfterSelectStudent = new System.Windows.Forms.Panel();
            this.grpPayment = new System.Windows.Forms.GroupBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.txtAmountOfPayment = new System.Windows.Forms.TextBox();
            this.lblAmountOfPayment = new System.Windows.Forms.Label();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtProgramOption = new System.Windows.Forms.TextBox();
            this.lblStudentStatus = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.lblProgramOption = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.grpSearchStudent = new System.Windows.Forms.GroupBox();
            this.pnlSelectStudent = new System.Windows.Forms.Panel();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lstMatchingStudents = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlAfterSelectStudent.SuspendLayout();
            this.grpPayment.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.grpSearchStudent.SuspendLayout();
            this.pnlSelectStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(642, 487);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlAfterSelectStudent
            // 
            this.pnlAfterSelectStudent.Controls.Add(this.grpPayment);
            this.pnlAfterSelectStudent.Controls.Add(this.grpStudentInfo);
            this.pnlAfterSelectStudent.Location = new System.Drawing.Point(31, 227);
            this.pnlAfterSelectStudent.Name = "pnlAfterSelectStudent";
            this.pnlAfterSelectStudent.Size = new System.Drawing.Size(696, 245);
            this.pnlAfterSelectStudent.TabIndex = 5;
            // 
            // grpPayment
            // 
            this.grpPayment.Controls.Add(this.btnConfirmPayment);
            this.grpPayment.Controls.Add(this.txtAmountOfPayment);
            this.grpPayment.Controls.Add(this.lblAmountOfPayment);
            this.grpPayment.Location = new System.Drawing.Point(11, 154);
            this.grpPayment.Name = "grpPayment";
            this.grpPayment.Size = new System.Drawing.Size(672, 75);
            this.grpPayment.TabIndex = 2;
            this.grpPayment.TabStop = false;
            this.grpPayment.Text = "Payment";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Location = new System.Drawing.Point(437, 28);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(133, 23);
            this.btnConfirmPayment.TabIndex = 2;
            this.btnConfirmPayment.Text = "&Confirm the Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // txtAmountOfPayment
            // 
            this.txtAmountOfPayment.Location = new System.Drawing.Point(224, 30);
            this.txtAmountOfPayment.Name = "txtAmountOfPayment";
            this.txtAmountOfPayment.Size = new System.Drawing.Size(178, 20);
            this.txtAmountOfPayment.TabIndex = 1;
            // 
            // lblAmountOfPayment
            // 
            this.lblAmountOfPayment.AutoSize = true;
            this.lblAmountOfPayment.Location = new System.Drawing.Point(72, 33);
            this.lblAmountOfPayment.Name = "lblAmountOfPayment";
            this.lblAmountOfPayment.Size = new System.Drawing.Size(146, 13);
            this.lblAmountOfPayment.TabIndex = 0;
            this.lblAmountOfPayment.Text = "Enter the amount of payment:";
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpStudentInfo.Controls.Add(this.txtEndDate);
            this.grpStudentInfo.Controls.Add(this.txtStartDate);
            this.grpStudentInfo.Controls.Add(this.txtProgramOption);
            this.grpStudentInfo.Controls.Add(this.lblStudentStatus);
            this.grpStudentInfo.Controls.Add(this.chkIsActive);
            this.grpStudentInfo.Controls.Add(this.lblBalanceDue);
            this.grpStudentInfo.Controls.Add(this.txtBalanceDue);
            this.grpStudentInfo.Controls.Add(this.lblProgramOption);
            this.grpStudentInfo.Controls.Add(this.lblEndDate);
            this.grpStudentInfo.Controls.Add(this.txtLastName);
            this.grpStudentInfo.Controls.Add(this.lblLastName);
            this.grpStudentInfo.Controls.Add(this.txtFirstName);
            this.grpStudentInfo.Controls.Add(this.lblFirstName);
            this.grpStudentInfo.Controls.Add(this.lblStartDate);
            this.grpStudentInfo.Controls.Add(this.txtStudentId);
            this.grpStudentInfo.Controls.Add(this.lblStudentId);
            this.grpStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpStudentInfo.Location = new System.Drawing.Point(9, 12);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(672, 119);
            this.grpStudentInfo.TabIndex = 1;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Tag = "";
            this.grpStudentInfo.Text = "Student Information";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndDate.Location = new System.Drawing.Point(168, 89);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(140, 20);
            this.txtEndDate.TabIndex = 11;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartDate.Location = new System.Drawing.Point(17, 89);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(136, 20);
            this.txtStartDate.TabIndex = 9;
            // 
            // txtProgramOption
            // 
            this.txtProgramOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProgramOption.Location = new System.Drawing.Point(168, 39);
            this.txtProgramOption.Name = "txtProgramOption";
            this.txtProgramOption.ReadOnly = true;
            this.txtProgramOption.Size = new System.Drawing.Size(140, 20);
            this.txtProgramOption.TabIndex = 3;
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(490, 73);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStudentStatus.TabIndex = 14;
            this.lblStudentStatus.Text = "Student Status:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(493, 89);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Location = new System.Drawing.Point(325, 73);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(72, 13);
            this.lblBalanceDue.TabIndex = 12;
            this.lblBalanceDue.Text = "Balance Due:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBalanceDue.Location = new System.Drawing.Point(328, 89);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(140, 20);
            this.txtBalanceDue.TabIndex = 13;
            // 
            // lblProgramOption
            // 
            this.lblProgramOption.AutoSize = true;
            this.lblProgramOption.Location = new System.Drawing.Point(165, 24);
            this.lblProgramOption.Name = "lblProgramOption";
            this.lblProgramOption.Size = new System.Drawing.Size(83, 13);
            this.lblProgramOption.TabIndex = 2;
            this.lblProgramOption.Text = "Program Option:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(165, 73);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(489, 39);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(168, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(486, 24);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(326, 39);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(142, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(325, 24);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(13, 73);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStudentId.Location = new System.Drawing.Point(16, 40);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(137, 20);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(13, 24);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(61, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID:";
            // 
            // grpSearchStudent
            // 
            this.grpSearchStudent.Controls.Add(this.pnlSelectStudent);
            this.grpSearchStudent.Controls.Add(this.btnSearch);
            this.grpSearchStudent.Controls.Add(this.txtSearchKeyword);
            this.grpSearchStudent.Controls.Add(this.lblSearchKeyword);
            this.grpSearchStudent.Location = new System.Drawing.Point(41, 85);
            this.grpSearchStudent.Name = "grpSearchStudent";
            this.grpSearchStudent.Size = new System.Drawing.Size(672, 136);
            this.grpSearchStudent.TabIndex = 4;
            this.grpSearchStudent.TabStop = false;
            this.grpSearchStudent.Text = "Search Student";
            // 
            // pnlSelectStudent
            // 
            this.pnlSelectStudent.Controls.Add(this.lblSelectStudent);
            this.pnlSelectStudent.Controls.Add(this.lstMatchingStudents);
            this.pnlSelectStudent.Location = new System.Drawing.Point(398, 11);
            this.pnlSelectStudent.Name = "pnlSelectStudent";
            this.pnlSelectStudent.Size = new System.Drawing.Size(261, 119);
            this.pnlSelectStudent.TabIndex = 3;
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Location = new System.Drawing.Point(3, 5);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(89, 13);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Select a Student:";
            // 
            // lstMatchingStudents
            // 
            this.lstMatchingStudents.FormattingEnabled = true;
            this.lstMatchingStudents.Location = new System.Drawing.Point(6, 21);
            this.lstMatchingStudents.Name = "lstMatchingStudents";
            this.lstMatchingStudents.Size = new System.Drawing.Size(252, 95);
            this.lstMatchingStudents.TabIndex = 1;
            this.lstMatchingStudents.Click += new System.EventHandler(this.lstMatchingStudents_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(16, 50);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(224, 20);
            this.txtSearchKeyword.TabIndex = 1;
            // 
            // lblSearchKeyword
            // 
            this.lblSearchKeyword.AutoSize = true;
            this.lblSearchKeyword.Location = new System.Drawing.Point(13, 29);
            this.lblSearchKeyword.Name = "lblSearchKeyword";
            this.lblSearchKeyword.Size = new System.Drawing.Size(227, 13);
            this.lblSearchKeyword.TabIndex = 0;
            this.lblSearchKeyword.Text = "Enter a Student ID or Full or Partial Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 39);
            this.label4.TabIndex = 43;
            this.label4.Text = "Payment";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 551);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlAfterSelectStudent);
            this.Controls.Add(this.grpSearchStudent);
            this.Name = "Payment";
            this.Text = "Payment";
            this.pnlAfterSelectStudent.ResumeLayout(false);
            this.grpPayment.ResumeLayout(false);
            this.grpPayment.PerformLayout();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpSearchStudent.ResumeLayout(false);
            this.grpSearchStudent.PerformLayout();
            this.pnlSelectStudent.ResumeLayout(false);
            this.pnlSelectStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Panel pnlAfterSelectStudent;
        internal System.Windows.Forms.GroupBox grpPayment;
        internal System.Windows.Forms.Button btnConfirmPayment;
        internal System.Windows.Forms.TextBox txtAmountOfPayment;
        internal System.Windows.Forms.Label lblAmountOfPayment;
        internal System.Windows.Forms.GroupBox grpStudentInfo;
        internal System.Windows.Forms.TextBox txtEndDate;
        internal System.Windows.Forms.TextBox txtStartDate;
        internal System.Windows.Forms.TextBox txtProgramOption;
        internal System.Windows.Forms.Label lblStudentStatus;
        internal System.Windows.Forms.CheckBox chkIsActive;
        internal System.Windows.Forms.Label lblBalanceDue;
        internal System.Windows.Forms.TextBox txtBalanceDue;
        internal System.Windows.Forms.Label lblProgramOption;
        internal System.Windows.Forms.Label lblEndDate;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label lblFirstName;
        internal System.Windows.Forms.Label lblStartDate;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label lblStudentId;
        internal System.Windows.Forms.GroupBox grpSearchStudent;
        internal System.Windows.Forms.Panel pnlSelectStudent;
        internal System.Windows.Forms.Label lblSelectStudent;
        internal System.Windows.Forms.ListBox lstMatchingStudents;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox txtSearchKeyword;
        internal System.Windows.Forms.Label lblSearchKeyword;
        private System.Windows.Forms.Label label4;
    }
}