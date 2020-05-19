namespace FrontEnd
{
    partial class StudentForm
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
            this.grpSearchStudent = new System.Windows.Forms.GroupBox();
            this.pnlSelectStudent = new System.Windows.Forms.Panel();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.lstMatchingStudents = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStudentStatus = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.txtBalanceDue = new System.Windows.Forms.TextBox();
            this.cmbProgramOption = new System.Windows.Forms.ComboBox();
            this.lblProgramOption = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSearchStudent.SuspendLayout();
            this.pnlSelectStudent.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearchStudent
            // 
            this.grpSearchStudent.Controls.Add(this.pnlSelectStudent);
            this.grpSearchStudent.Controls.Add(this.btnSearch);
            this.grpSearchStudent.Controls.Add(this.txtSearchKeyword);
            this.grpSearchStudent.Controls.Add(this.lblSearchKeyword);
            this.grpSearchStudent.Location = new System.Drawing.Point(25, 76);
            this.grpSearchStudent.Name = "grpSearchStudent";
            this.grpSearchStudent.Size = new System.Drawing.Size(672, 136);
            this.grpSearchStudent.TabIndex = 6;
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(589, 413);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 42);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(401, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 42);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "&UPDATE Student Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(270, 413);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&DELETE Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpStudentInfo.Controls.Add(this.btnClear);
            this.grpStudentInfo.Controls.Add(this.lblStudentStatus);
            this.grpStudentInfo.Controls.Add(this.chkIsActive);
            this.grpStudentInfo.Controls.Add(this.lblBalanceDue);
            this.grpStudentInfo.Controls.Add(this.txtBalanceDue);
            this.grpStudentInfo.Controls.Add(this.cmbProgramOption);
            this.grpStudentInfo.Controls.Add(this.lblProgramOption);
            this.grpStudentInfo.Controls.Add(this.dtpEndDate);
            this.grpStudentInfo.Controls.Add(this.lblEndDate);
            this.grpStudentInfo.Controls.Add(this.lblTelephone);
            this.grpStudentInfo.Controls.Add(this.txtLastName);
            this.grpStudentInfo.Controls.Add(this.lblLastName);
            this.grpStudentInfo.Controls.Add(this.txtAddress);
            this.grpStudentInfo.Controls.Add(this.txtFirstName);
            this.grpStudentInfo.Controls.Add(this.Label1);
            this.grpStudentInfo.Controls.Add(this.lblAddress);
            this.grpStudentInfo.Controls.Add(this.dtpStartDate);
            this.grpStudentInfo.Controls.Add(this.lblStartDate);
            this.grpStudentInfo.Controls.Add(this.txtTelephone);
            this.grpStudentInfo.Controls.Add(this.txtCity);
            this.grpStudentInfo.Controls.Add(this.txtPostalCode);
            this.grpStudentInfo.Controls.Add(this.txtStudentId);
            this.grpStudentInfo.Controls.Add(this.lblPostalCode);
            this.grpStudentInfo.Controls.Add(this.lblCity);
            this.grpStudentInfo.Controls.Add(this.lblStudentId);
            this.grpStudentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpStudentInfo.Location = new System.Drawing.Point(24, 218);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(672, 176);
            this.grpStudentInfo.TabIndex = 7;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Tag = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(565, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 26);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(451, 118);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStudentStatus.TabIndex = 22;
            this.lblStudentStatus.Text = "Student Status:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Location = new System.Drawing.Point(454, 136);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 23;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Location = new System.Drawing.Point(319, 118);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(72, 13);
            this.lblBalanceDue.TabIndex = 20;
            this.lblBalanceDue.Text = "Balance Due:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.SystemColors.Window;
            this.txtBalanceDue.Enabled = false;
            this.txtBalanceDue.Location = new System.Drawing.Point(322, 134);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.Size = new System.Drawing.Size(106, 20);
            this.txtBalanceDue.TabIndex = 21;
            this.txtBalanceDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbProgramOption
            // 
            this.cmbProgramOption.FormattingEnabled = true;
            this.cmbProgramOption.Location = new System.Drawing.Point(156, 42);
            this.cmbProgramOption.Name = "cmbProgramOption";
            this.cmbProgramOption.Size = new System.Drawing.Size(135, 21);
            this.cmbProgramOption.TabIndex = 3;
            // 
            // lblProgramOption
            // 
            this.lblProgramOption.AutoSize = true;
            this.lblProgramOption.Location = new System.Drawing.Point(153, 27);
            this.lblProgramOption.Name = "lblProgramOption";
            this.lblProgramOption.Size = new System.Drawing.Size(83, 13);
            this.lblProgramOption.TabIndex = 2;
            this.lblProgramOption.Text = "Program Option:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(169, 134);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(138, 20);
            this.dtpEndDate.TabIndex = 19;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(166, 118);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 18;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(511, 73);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 14;
            this.lblTelephone.Text = "Telephone:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(514, 42);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(136, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(511, 27);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(20, 89);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(332, 42);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(136, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(331, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "First Name:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(17, 73);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(20, 134);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(131, 20);
            this.dtpStartDate.TabIndex = 17;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(17, 118);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 16;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(514, 89);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(136, 20);
            this.txtTelephone.TabIndex = 15;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(197, 89);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(138, 20);
            this.txtCity.TabIndex = 11;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(364, 89);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(106, 20);
            this.txtPostalCode.TabIndex = 13;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(20, 43);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(90, 20);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(361, 73);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(67, 13);
            this.lblPostalCode.TabIndex = 12;
            this.lblPostalCode.Text = "Postal Code:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(194, 73);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "City:";
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(17, 27);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(61, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 42);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "&ADD New Student Information";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Student";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpSearchStudent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.btnAdd);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.grpSearchStudent.ResumeLayout(false);
            this.grpSearchStudent.PerformLayout();
            this.pnlSelectStudent.ResumeLayout(false);
            this.pnlSelectStudent.PerformLayout();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox grpSearchStudent;
        internal System.Windows.Forms.Panel pnlSelectStudent;
        internal System.Windows.Forms.Label lblSelectStudent;
        internal System.Windows.Forms.ListBox lstMatchingStudents;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox txtSearchKeyword;
        internal System.Windows.Forms.Label lblSearchKeyword;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.GroupBox grpStudentInfo;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label lblStudentStatus;
        internal System.Windows.Forms.CheckBox chkIsActive;
        internal System.Windows.Forms.Label lblBalanceDue;
        internal System.Windows.Forms.TextBox txtBalanceDue;
        internal System.Windows.Forms.ComboBox cmbProgramOption;
        internal System.Windows.Forms.Label lblProgramOption;
        internal System.Windows.Forms.DateTimePicker dtpEndDate;
        internal System.Windows.Forms.Label lblEndDate;
        internal System.Windows.Forms.Label lblTelephone;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label lblAddress;
        internal System.Windows.Forms.DateTimePicker dtpStartDate;
        internal System.Windows.Forms.Label lblStartDate;
        internal System.Windows.Forms.TextBox txtTelephone;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtPostalCode;
        internal System.Windows.Forms.TextBox txtStudentId;
        internal System.Windows.Forms.Label lblPostalCode;
        internal System.Windows.Forms.Label lblCity;
        internal System.Windows.Forms.Label lblStudentId;
        internal System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
    }
}