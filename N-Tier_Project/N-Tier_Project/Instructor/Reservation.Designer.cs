namespace FrontEnd
{
    partial class Reservation
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
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.btnClearResource = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtProgramOption = new System.Windows.Forms.TextBox();
            this.lblStudentStatus = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.lblProgramOption = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
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
            this.grpResourceInfo = new System.Windows.Forms.GroupBox();
            this.chkIsReserved = new System.Windows.Forms.CheckBox();
            this.txtResourceStatus = new System.Windows.Forms.TextBox();
            this.txtResourceType = new System.Windows.Forms.TextBox();
            this.lblResourceType = new System.Windows.Forms.Label();
            this.lblReserveStatus = new System.Windows.Forms.Label();
            this.lblResourceStatus = new System.Windows.Forms.Label();
            this.txtResourceTitle = new System.Windows.Forms.TextBox();
            this.lblResourceTitle = new System.Windows.Forms.Label();
            this.grpSearchResource = new System.Windows.Forms.GroupBox();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.txtResourceIdEntry = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpbReservingStudent = new System.Windows.Forms.GroupBox();
            this.txtReservedStudend = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpStudentInfo.SuspendLayout();
            this.grpSearchStudent.SuspendLayout();
            this.pnlSelectStudent.SuspendLayout();
            this.grpResourceInfo.SuspendLayout();
            this.grpSearchResource.SuspendLayout();
            this.gpbReservingStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearStudent
            // 
            this.btnClearStudent.Location = new System.Drawing.Point(745, 445);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(118, 23);
            this.btnClearStudent.TabIndex = 16;
            this.btnClearStudent.Text = "C&lear Student";
            this.btnClearStudent.UseVisualStyleBackColor = true;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);
            // 
            // btnClearResource
            // 
            this.btnClearResource.Location = new System.Drawing.Point(275, 396);
            this.btnClearResource.Name = "btnClearResource";
            this.btnClearResource.Size = new System.Drawing.Size(118, 23);
            this.btnClearResource.TabIndex = 15;
            this.btnClearResource.Text = "&Clear Resource";
            this.btnClearResource.UseVisualStyleBackColor = true;
            this.btnClearResource.Click += new System.EventHandler(this.btnClearResource_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(563, 532);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 38);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReserve.Location = new System.Drawing.Point(347, 532);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(173, 38);
            this.btnReserve.TabIndex = 13;
            this.btnReserve.Text = "Reser&ve Resource";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpStudentInfo.Controls.Add(this.txtProgramOption);
            this.grpStudentInfo.Controls.Add(this.lblStudentStatus);
            this.grpStudentInfo.Controls.Add(this.chkIsActive);
            this.grpStudentInfo.Controls.Add(this.Label2);
            this.grpStudentInfo.Controls.Add(this.txtBalanceDue);
            this.grpStudentInfo.Controls.Add(this.lblProgramOption);
            this.grpStudentInfo.Controls.Add(this.dtpEndDate);
            this.grpStudentInfo.Controls.Add(this.lblEndDate);
            this.grpStudentInfo.Controls.Add(this.txtLastName);
            this.grpStudentInfo.Controls.Add(this.lblLastName);
            this.grpStudentInfo.Controls.Add(this.txtFirstName);
            this.grpStudentInfo.Controls.Add(this.Label1);
            this.grpStudentInfo.Controls.Add(this.dtpStartDate);
            this.grpStudentInfo.Controls.Add(this.lblStartDate);
            this.grpStudentInfo.Controls.Add(this.txtStudentId);
            this.grpStudentInfo.Controls.Add(this.lblStudentId);
            this.grpStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpStudentInfo.Location = new System.Drawing.Point(423, 244);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(440, 195);
            this.grpStudentInfo.TabIndex = 12;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Tag = "";
            this.grpStudentInfo.Text = "Student Information";
            // 
            // txtProgramOption
            // 
            this.txtProgramOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProgramOption.Location = new System.Drawing.Point(246, 40);
            this.txtProgramOption.Name = "txtProgramOption";
            this.txtProgramOption.ReadOnly = true;
            this.txtProgramOption.Size = new System.Drawing.Size(150, 20);
            this.txtProgramOption.TabIndex = 3;
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(243, 152);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStudentStatus.TabIndex = 14;
            this.lblStudentStatus.Text = "Student Status:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(246, 168);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(39, 152);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 13);
            this.Label2.TabIndex = 12;
            this.Label2.Text = "Balance Due:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBalanceDue.Location = new System.Drawing.Point(42, 168);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(150, 20);
            this.txtBalanceDue.TabIndex = 13;
            // 
            // lblProgramOption
            // 
            this.lblProgramOption.AutoSize = true;
            this.lblProgramOption.Location = new System.Drawing.Point(243, 24);
            this.lblProgramOption.Name = "lblProgramOption";
            this.lblProgramOption.Size = new System.Drawing.Size(83, 13);
            this.lblProgramOption.TabIndex = 2;
            this.lblProgramOption.Text = "Program Option:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(246, 120);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(150, 20);
            this.dtpEndDate.TabIndex = 11;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(241, 104);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(246, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(150, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(243, 65);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(40, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(152, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(39, 65);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "First Name:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(42, 120);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(150, 20);
            this.dtpStartDate.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(39, 104);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStudentId.Location = new System.Drawing.Point(42, 40);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(150, 20);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(39, 24);
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
            this.grpSearchStudent.Location = new System.Drawing.Point(423, 81);
            this.grpSearchStudent.Name = "grpSearchStudent";
            this.grpSearchStudent.Size = new System.Drawing.Size(440, 157);
            this.grpSearchStudent.TabIndex = 11;
            this.grpSearchStudent.TabStop = false;
            this.grpSearchStudent.Text = "Search Student";
            // 
            // pnlSelectStudent
            // 
            this.pnlSelectStudent.Controls.Add(this.lblSelectStudent);
            this.pnlSelectStudent.Controls.Add(this.lstMatchingStudents);
            this.pnlSelectStudent.Location = new System.Drawing.Point(239, 17);
            this.pnlSelectStudent.Name = "pnlSelectStudent";
            this.pnlSelectStudent.Size = new System.Drawing.Size(195, 134);
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
            this.lstMatchingStudents.Size = new System.Drawing.Size(186, 108);
            this.lstMatchingStudents.TabIndex = 1;
            this.lstMatchingStudents.Click += new System.EventHandler(this.lstMatchingStudents_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(103, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search &Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(9, 45);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(224, 20);
            this.txtSearchKeyword.TabIndex = 1;
            // 
            // lblSearchKeyword
            // 
            this.lblSearchKeyword.AutoSize = true;
            this.lblSearchKeyword.Location = new System.Drawing.Point(6, 24);
            this.lblSearchKeyword.Name = "lblSearchKeyword";
            this.lblSearchKeyword.Size = new System.Drawing.Size(227, 13);
            this.lblSearchKeyword.TabIndex = 0;
            this.lblSearchKeyword.Text = "Enter a Student ID or Full or Partial Last Name:";
            // 
            // grpResourceInfo
            // 
            this.grpResourceInfo.Controls.Add(this.chkIsReserved);
            this.grpResourceInfo.Controls.Add(this.txtResourceStatus);
            this.grpResourceInfo.Controls.Add(this.txtResourceType);
            this.grpResourceInfo.Controls.Add(this.lblResourceType);
            this.grpResourceInfo.Controls.Add(this.lblReserveStatus);
            this.grpResourceInfo.Controls.Add(this.lblResourceStatus);
            this.grpResourceInfo.Controls.Add(this.txtResourceTitle);
            this.grpResourceInfo.Controls.Add(this.lblResourceTitle);
            this.grpResourceInfo.Location = new System.Drawing.Point(17, 182);
            this.grpResourceInfo.Name = "grpResourceInfo";
            this.grpResourceInfo.Size = new System.Drawing.Size(376, 179);
            this.grpResourceInfo.TabIndex = 10;
            this.grpResourceInfo.TabStop = false;
            this.grpResourceInfo.Text = "Resource Information";
            // 
            // chkIsReserved
            // 
            this.chkIsReserved.AutoSize = true;
            this.chkIsReserved.Location = new System.Drawing.Point(217, 140);
            this.chkIsReserved.Name = "chkIsReserved";
            this.chkIsReserved.Size = new System.Drawing.Size(83, 17);
            this.chkIsReserved.TabIndex = 7;
            this.chkIsReserved.Text = "Is Reserved";
            this.chkIsReserved.UseVisualStyleBackColor = true;
            // 
            // txtResourceStatus
            // 
            this.txtResourceStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceStatus.Location = new System.Drawing.Point(19, 140);
            this.txtResourceStatus.Name = "txtResourceStatus";
            this.txtResourceStatus.ReadOnly = true;
            this.txtResourceStatus.Size = new System.Drawing.Size(151, 20);
            this.txtResourceStatus.TabIndex = 5;
            // 
            // txtResourceType
            // 
            this.txtResourceType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceType.Location = new System.Drawing.Point(20, 88);
            this.txtResourceType.Name = "txtResourceType";
            this.txtResourceType.ReadOnly = true;
            this.txtResourceType.Size = new System.Drawing.Size(336, 20);
            this.txtResourceType.TabIndex = 3;
            // 
            // lblResourceType
            // 
            this.lblResourceType.AutoSize = true;
            this.lblResourceType.Location = new System.Drawing.Point(17, 70);
            this.lblResourceType.Name = "lblResourceType";
            this.lblResourceType.Size = new System.Drawing.Size(80, 13);
            this.lblResourceType.TabIndex = 2;
            this.lblResourceType.Text = "Resource Type";
            // 
            // lblReserveStatus
            // 
            this.lblReserveStatus.AutoSize = true;
            this.lblReserveStatus.Location = new System.Drawing.Point(214, 123);
            this.lblReserveStatus.Name = "lblReserveStatus";
            this.lblReserveStatus.Size = new System.Drawing.Size(83, 13);
            this.lblReserveStatus.TabIndex = 6;
            this.lblReserveStatus.Text = "Reserve Status:";
            // 
            // lblResourceStatus
            // 
            this.lblResourceStatus.AutoSize = true;
            this.lblResourceStatus.Location = new System.Drawing.Point(16, 123);
            this.lblResourceStatus.Name = "lblResourceStatus";
            this.lblResourceStatus.Size = new System.Drawing.Size(89, 13);
            this.lblResourceStatus.TabIndex = 4;
            this.lblResourceStatus.Text = "Resource Status:";
            // 
            // txtResourceTitle
            // 
            this.txtResourceTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceTitle.Location = new System.Drawing.Point(20, 37);
            this.txtResourceTitle.Name = "txtResourceTitle";
            this.txtResourceTitle.ReadOnly = true;
            this.txtResourceTitle.Size = new System.Drawing.Size(336, 20);
            this.txtResourceTitle.TabIndex = 1;
            // 
            // lblResourceTitle
            // 
            this.lblResourceTitle.AutoSize = true;
            this.lblResourceTitle.Location = new System.Drawing.Point(17, 21);
            this.lblResourceTitle.Name = "lblResourceTitle";
            this.lblResourceTitle.Size = new System.Drawing.Size(79, 13);
            this.lblResourceTitle.TabIndex = 0;
            this.lblResourceTitle.Text = "Resource Title:";
            // 
            // grpSearchResource
            // 
            this.grpSearchResource.Controls.Add(this.btnSearchResource);
            this.grpSearchResource.Controls.Add(this.txtResourceIdEntry);
            this.grpSearchResource.Controls.Add(this.Label3);
            this.grpSearchResource.Location = new System.Drawing.Point(17, 103);
            this.grpSearchResource.Name = "grpSearchResource";
            this.grpSearchResource.Size = new System.Drawing.Size(376, 54);
            this.grpSearchResource.TabIndex = 9;
            this.grpSearchResource.TabStop = false;
            this.grpSearchResource.Text = "Search Resource";
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(238, 20);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(118, 23);
            this.btnSearchResource.TabIndex = 2;
            this.btnSearchResource.Text = "Search &Resource";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // txtResourceIdEntry
            // 
            this.txtResourceIdEntry.Location = new System.Drawing.Point(131, 22);
            this.txtResourceIdEntry.Name = "txtResourceIdEntry";
            this.txtResourceIdEntry.Size = new System.Drawing.Size(92, 20);
            this.txtResourceIdEntry.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 13);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Enter a Resource ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 39);
            this.label4.TabIndex = 42;
            this.label4.Text = "Reservation";
            // 
            // gpbReservingStudent
            // 
            this.gpbReservingStudent.Controls.Add(this.txtReservedStudend);
            this.gpbReservingStudent.Controls.Add(this.label5);
            this.gpbReservingStudent.Location = new System.Drawing.Point(27, 368);
            this.gpbReservingStudent.Name = "gpbReservingStudent";
            this.gpbReservingStudent.Size = new System.Drawing.Size(186, 71);
            this.gpbReservingStudent.TabIndex = 43;
            this.gpbReservingStudent.TabStop = false;
            this.gpbReservingStudent.Text = "Reserving Student";
            // 
            // txtReservedStudend
            // 
            this.txtReservedStudend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReservedStudend.Location = new System.Drawing.Point(10, 41);
            this.txtReservedStudend.Name = "txtReservedStudend";
            this.txtReservedStudend.ReadOnly = true;
            this.txtReservedStudend.Size = new System.Drawing.Size(159, 20);
            this.txtReservedStudend.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student who reserves";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 603);
            this.Controls.Add(this.gpbReservingStudent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearStudent);
            this.Controls.Add(this.btnClearResource);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.grpSearchStudent);
            this.Controls.Add(this.grpResourceInfo);
            this.Controls.Add(this.grpSearchResource);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpSearchStudent.ResumeLayout(false);
            this.grpSearchStudent.PerformLayout();
            this.pnlSelectStudent.ResumeLayout(false);
            this.pnlSelectStudent.PerformLayout();
            this.grpResourceInfo.ResumeLayout(false);
            this.grpResourceInfo.PerformLayout();
            this.grpSearchResource.ResumeLayout(false);
            this.grpSearchResource.PerformLayout();
            this.gpbReservingStudent.ResumeLayout(false);
            this.gpbReservingStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnClearStudent;
        internal System.Windows.Forms.Button btnClearResource;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnReserve;
        internal System.Windows.Forms.GroupBox grpStudentInfo;
        internal System.Windows.Forms.TextBox txtProgramOption;
        internal System.Windows.Forms.Label lblStudentStatus;
        internal System.Windows.Forms.CheckBox chkIsActive;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtBalanceDue;
        internal System.Windows.Forms.Label lblProgramOption;
        internal System.Windows.Forms.DateTimePicker dtpEndDate;
        internal System.Windows.Forms.Label lblEndDate;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DateTimePicker dtpStartDate;
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
        internal System.Windows.Forms.GroupBox grpResourceInfo;
        internal System.Windows.Forms.CheckBox chkIsReserved;
        internal System.Windows.Forms.TextBox txtResourceStatus;
        internal System.Windows.Forms.TextBox txtResourceType;
        internal System.Windows.Forms.Label lblResourceType;
        internal System.Windows.Forms.Label lblReserveStatus;
        internal System.Windows.Forms.Label lblResourceStatus;
        internal System.Windows.Forms.TextBox txtResourceTitle;
        internal System.Windows.Forms.Label lblResourceTitle;
        internal System.Windows.Forms.GroupBox grpSearchResource;
        internal System.Windows.Forms.Button btnSearchResource;
        internal System.Windows.Forms.TextBox txtResourceIdEntry;
        internal System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpbReservingStudent;
        internal System.Windows.Forms.TextBox txtReservedStudend;
        internal System.Windows.Forms.Label label5;
    }
}