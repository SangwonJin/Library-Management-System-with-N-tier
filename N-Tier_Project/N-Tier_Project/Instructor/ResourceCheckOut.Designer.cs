namespace FrontEnd
{
    partial class ResourceCheckOut
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
            this.btnCheckout = new System.Windows.Forms.Button();
            this.grpResourceInfo = new System.Windows.Forms.GroupBox();
            this.chkIsReserved = new System.Windows.Forms.CheckBox();
            this.txtResourceType = new System.Windows.Forms.TextBox();
            this.txtResourceStatus = new System.Windows.Forms.TextBox();
            this.lblResourceType = new System.Windows.Forms.Label();
            this.lblReserveStatus = new System.Windows.Forms.Label();
            this.lblResourceStatus = new System.Windows.Forms.Label();
            this.txtResourceTitle = new System.Windows.Forms.TextBox();
            this.lblResourceTitle = new System.Windows.Forms.Label();
            this.grpSearchResource = new System.Windows.Forms.GroupBox();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.txtResourceIdEntry = new System.Windows.Forms.TextBox();
            this.lblResourceIdEntry = new System.Windows.Forms.Label();
            this.grpCurrentLoans = new System.Windows.Forms.GroupBox();
            this.dgvCurrentLoans = new System.Windows.Forms.DataGridView();
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
            this.lstMatchingStudents = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReservedStudend = new System.Windows.Forms.TextBox();
            this.grpResourceInfo.SuspendLayout();
            this.grpSearchResource.SuspendLayout();
            this.grpCurrentLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentLoans)).BeginInit();
            this.grpStudentInfo.SuspendLayout();
            this.grpSearchStudent.SuspendLayout();
            this.pnlSelectStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(442, 545);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 27);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheckout.Location = new System.Drawing.Point(263, 546);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(173, 26);
            this.btnCheckout.TabIndex = 21;
            this.btnCheckout.Text = "&Checkout Resource";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // grpResourceInfo
            // 
            this.grpResourceInfo.Controls.Add(this.txtReservedStudend);
            this.grpResourceInfo.Controls.Add(this.label2);
            this.grpResourceInfo.Controls.Add(this.chkIsReserved);
            this.grpResourceInfo.Controls.Add(this.txtResourceType);
            this.grpResourceInfo.Controls.Add(this.txtResourceStatus);
            this.grpResourceInfo.Controls.Add(this.lblResourceType);
            this.grpResourceInfo.Controls.Add(this.lblReserveStatus);
            this.grpResourceInfo.Controls.Add(this.lblResourceStatus);
            this.grpResourceInfo.Controls.Add(this.txtResourceTitle);
            this.grpResourceInfo.Controls.Add(this.lblResourceTitle);
            this.grpResourceInfo.Location = new System.Drawing.Point(490, 165);
            this.grpResourceInfo.Name = "grpResourceInfo";
            this.grpResourceInfo.Size = new System.Drawing.Size(297, 191);
            this.grpResourceInfo.TabIndex = 20;
            this.grpResourceInfo.TabStop = false;
            this.grpResourceInfo.Text = "Resource Information";
            // 
            // chkIsReserved
            // 
            this.chkIsReserved.AutoSize = true;
            this.chkIsReserved.Enabled = false;
            this.chkIsReserved.Location = new System.Drawing.Point(192, 118);
            this.chkIsReserved.Name = "chkIsReserved";
            this.chkIsReserved.Size = new System.Drawing.Size(83, 17);
            this.chkIsReserved.TabIndex = 10;
            this.chkIsReserved.Text = "Is Reserved";
            this.chkIsReserved.UseVisualStyleBackColor = true;
            // 
            // txtResourceType
            // 
            this.txtResourceType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceType.Location = new System.Drawing.Point(20, 72);
            this.txtResourceType.Name = "txtResourceType";
            this.txtResourceType.ReadOnly = true;
            this.txtResourceType.Size = new System.Drawing.Size(252, 20);
            this.txtResourceType.TabIndex = 9;
            // 
            // txtResourceStatus
            // 
            this.txtResourceStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceStatus.Location = new System.Drawing.Point(21, 114);
            this.txtResourceStatus.Name = "txtResourceStatus";
            this.txtResourceStatus.ReadOnly = true;
            this.txtResourceStatus.Size = new System.Drawing.Size(159, 20);
            this.txtResourceStatus.TabIndex = 8;
            // 
            // lblResourceType
            // 
            this.lblResourceType.AutoSize = true;
            this.lblResourceType.Location = new System.Drawing.Point(17, 57);
            this.lblResourceType.Name = "lblResourceType";
            this.lblResourceType.Size = new System.Drawing.Size(80, 13);
            this.lblResourceType.TabIndex = 2;
            this.lblResourceType.Text = "Resource Type";
            // 
            // lblReserveStatus
            // 
            this.lblReserveStatus.AutoSize = true;
            this.lblReserveStatus.Location = new System.Drawing.Point(189, 96);
            this.lblReserveStatus.Name = "lblReserveStatus";
            this.lblReserveStatus.Size = new System.Drawing.Size(83, 13);
            this.lblReserveStatus.TabIndex = 6;
            this.lblReserveStatus.Text = "Reserve Status:";
            // 
            // lblResourceStatus
            // 
            this.lblResourceStatus.AutoSize = true;
            this.lblResourceStatus.Location = new System.Drawing.Point(18, 97);
            this.lblResourceStatus.Name = "lblResourceStatus";
            this.lblResourceStatus.Size = new System.Drawing.Size(89, 13);
            this.lblResourceStatus.TabIndex = 4;
            this.lblResourceStatus.Text = "Resource Status:";
            // 
            // txtResourceTitle
            // 
            this.txtResourceTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceTitle.Location = new System.Drawing.Point(20, 34);
            this.txtResourceTitle.Name = "txtResourceTitle";
            this.txtResourceTitle.ReadOnly = true;
            this.txtResourceTitle.Size = new System.Drawing.Size(252, 20);
            this.txtResourceTitle.TabIndex = 1;
            // 
            // lblResourceTitle
            // 
            this.lblResourceTitle.AutoSize = true;
            this.lblResourceTitle.Location = new System.Drawing.Point(18, 18);
            this.lblResourceTitle.Name = "lblResourceTitle";
            this.lblResourceTitle.Size = new System.Drawing.Size(79, 13);
            this.lblResourceTitle.TabIndex = 0;
            this.lblResourceTitle.Text = "Resource Title:";
            // 
            // grpSearchResource
            // 
            this.grpSearchResource.Controls.Add(this.btnSearchResource);
            this.grpSearchResource.Controls.Add(this.txtResourceIdEntry);
            this.grpSearchResource.Controls.Add(this.lblResourceIdEntry);
            this.grpSearchResource.Location = new System.Drawing.Point(490, 63);
            this.grpSearchResource.Name = "grpSearchResource";
            this.grpSearchResource.Size = new System.Drawing.Size(297, 95);
            this.grpSearchResource.TabIndex = 19;
            this.grpSearchResource.TabStop = false;
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(154, 38);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(118, 23);
            this.btnSearchResource.TabIndex = 2;
            this.btnSearchResource.Text = "Search &Resource";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // txtResourceIdEntry
            // 
            this.txtResourceIdEntry.Location = new System.Drawing.Point(18, 41);
            this.txtResourceIdEntry.Name = "txtResourceIdEntry";
            this.txtResourceIdEntry.Size = new System.Drawing.Size(105, 20);
            this.txtResourceIdEntry.TabIndex = 1;
            // 
            // lblResourceIdEntry
            // 
            this.lblResourceIdEntry.AutoSize = true;
            this.lblResourceIdEntry.Location = new System.Drawing.Point(16, 25);
            this.lblResourceIdEntry.Name = "lblResourceIdEntry";
            this.lblResourceIdEntry.Size = new System.Drawing.Size(107, 13);
            this.lblResourceIdEntry.TabIndex = 0;
            this.lblResourceIdEntry.Text = "Enter a Resource ID:";
            // 
            // grpCurrentLoans
            // 
            this.grpCurrentLoans.Controls.Add(this.dgvCurrentLoans);
            this.grpCurrentLoans.Location = new System.Drawing.Point(12, 406);
            this.grpCurrentLoans.Name = "grpCurrentLoans";
            this.grpCurrentLoans.Size = new System.Drawing.Size(555, 133);
            this.grpCurrentLoans.TabIndex = 23;
            this.grpCurrentLoans.TabStop = false;
            this.grpCurrentLoans.Text = "Student\'s Current Loan";
            // 
            // dgvCurrentLoans
            // 
            this.dgvCurrentLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentLoans.Location = new System.Drawing.Point(6, 17);
            this.dgvCurrentLoans.Name = "dgvCurrentLoans";
            this.dgvCurrentLoans.Size = new System.Drawing.Size(535, 104);
            this.dgvCurrentLoans.TabIndex = 0;
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
            this.grpStudentInfo.Location = new System.Drawing.Point(12, 165);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(458, 180);
            this.grpStudentInfo.TabIndex = 18;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Tag = "";
            this.grpStudentInfo.Text = "Student Information";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndDate.Location = new System.Drawing.Point(242, 113);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(172, 20);
            this.txtEndDate.TabIndex = 17;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartDate.Location = new System.Drawing.Point(42, 113);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(172, 20);
            this.txtStartDate.TabIndex = 16;
            // 
            // txtProgramOption
            // 
            this.txtProgramOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProgramOption.Location = new System.Drawing.Point(242, 34);
            this.txtProgramOption.Name = "txtProgramOption";
            this.txtProgramOption.ReadOnly = true;
            this.txtProgramOption.Size = new System.Drawing.Size(172, 20);
            this.txtProgramOption.TabIndex = 3;
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(239, 138);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStudentStatus.TabIndex = 14;
            this.lblStudentStatus.Text = "Student Status:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(242, 154);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Location = new System.Drawing.Point(39, 138);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(72, 13);
            this.lblBalanceDue.TabIndex = 12;
            this.lblBalanceDue.Text = "Balance Due:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBalanceDue.Location = new System.Drawing.Point(42, 154);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(172, 20);
            this.txtBalanceDue.TabIndex = 13;
            // 
            // lblProgramOption
            // 
            this.lblProgramOption.AutoSize = true;
            this.lblProgramOption.Location = new System.Drawing.Point(239, 18);
            this.lblProgramOption.Name = "lblProgramOption";
            this.lblProgramOption.Size = new System.Drawing.Size(83, 13);
            this.lblProgramOption.TabIndex = 2;
            this.lblProgramOption.Text = "Program Option:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(239, 96);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(242, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(172, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(239, 57);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(40, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(174, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(39, 57);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(39, 97);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStudentId.Location = new System.Drawing.Point(42, 34);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(172, 20);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(39, 18);
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
            this.grpSearchStudent.Location = new System.Drawing.Point(12, 50);
            this.grpSearchStudent.Name = "grpSearchStudent";
            this.grpSearchStudent.Size = new System.Drawing.Size(458, 109);
            this.grpSearchStudent.TabIndex = 17;
            this.grpSearchStudent.TabStop = false;
            this.grpSearchStudent.Text = "Search Student";
            // 
            // pnlSelectStudent
            // 
            this.pnlSelectStudent.Controls.Add(this.lstMatchingStudents);
            this.pnlSelectStudent.Location = new System.Drawing.Point(239, 13);
            this.pnlSelectStudent.Name = "pnlSelectStudent";
            this.pnlSelectStudent.Size = new System.Drawing.Size(213, 90);
            this.pnlSelectStudent.TabIndex = 3;
            // 
            // lstMatchingStudents
            // 
            this.lstMatchingStudents.FormattingEnabled = true;
            this.lstMatchingStudents.Location = new System.Drawing.Point(3, 6);
            this.lstMatchingStudents.Name = "lstMatchingStudents";
            this.lstMatchingStudents.Size = new System.Drawing.Size(207, 82);
            this.lstMatchingStudents.TabIndex = 0;
            this.lstMatchingStudents.Click += new System.EventHandler(this.lstMatchingStudents_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(76, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search &Student";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(9, 54);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(183, 20);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Resource CheckOut";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(573, 406);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 133);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Items";
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(6, 19);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(199, 98);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(579, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 26);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.Location = new System.Drawing.Point(690, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 26);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student who reserves";
            // 
            // txtReservedStudend
            // 
            this.txtReservedStudend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReservedStudend.Location = new System.Drawing.Point(21, 154);
            this.txtReservedStudend.Name = "txtReservedStudend";
            this.txtReservedStudend.ReadOnly = true;
            this.txtReservedStudend.Size = new System.Drawing.Size(159, 20);
            this.txtReservedStudend.TabIndex = 12;
            // 
            // ResourceCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 741);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.grpResourceInfo);
            this.Controls.Add(this.grpSearchResource);
            this.Controls.Add(this.grpCurrentLoans);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.grpSearchStudent);
            this.Controls.Add(this.label1);
            this.Name = "ResourceCheckOut";
            this.Text = "ResourceTransaction";
            this.grpResourceInfo.ResumeLayout(false);
            this.grpResourceInfo.PerformLayout();
            this.grpSearchResource.ResumeLayout(false);
            this.grpSearchResource.PerformLayout();
            this.grpCurrentLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentLoans)).EndInit();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpSearchStudent.ResumeLayout(false);
            this.grpSearchStudent.PerformLayout();
            this.pnlSelectStudent.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnCheckout;
        internal System.Windows.Forms.GroupBox grpResourceInfo;
        internal System.Windows.Forms.CheckBox chkIsReserved;
        internal System.Windows.Forms.TextBox txtResourceType;
        internal System.Windows.Forms.TextBox txtResourceStatus;
        internal System.Windows.Forms.Label lblResourceType;
        internal System.Windows.Forms.Label lblReserveStatus;
        internal System.Windows.Forms.Label lblResourceStatus;
        internal System.Windows.Forms.TextBox txtResourceTitle;
        internal System.Windows.Forms.Label lblResourceTitle;
        internal System.Windows.Forms.GroupBox grpSearchResource;
        internal System.Windows.Forms.Button btnSearchResource;
        internal System.Windows.Forms.TextBox txtResourceIdEntry;
        internal System.Windows.Forms.Label lblResourceIdEntry;
        internal System.Windows.Forms.GroupBox grpCurrentLoans;
        internal System.Windows.Forms.DataGridView dgvCurrentLoans;
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
        internal System.Windows.Forms.ListBox lstMatchingStudents;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.TextBox txtSearchKeyword;
        internal System.Windows.Forms.Label lblSearchKeyword;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvList;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.TextBox txtReservedStudend;
        internal System.Windows.Forms.Label label2;
    }
}