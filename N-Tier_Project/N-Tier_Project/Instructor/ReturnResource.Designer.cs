namespace FrontEnd
{
    partial class ReturnResource
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
            this.lblLoanStatus = new System.Windows.Forms.Label();
            this.cmbLoanStatus = new System.Windows.Forms.ComboBox();
            this.grpResourceInfo = new System.Windows.Forms.GroupBox();
            this.txtResourceId = new System.Windows.Forms.TextBox();
            this.lblResourceId = new System.Windows.Forms.Label();
            this.txtResourceStatus = new System.Windows.Forms.TextBox();
            this.chkIsReserved = new System.Windows.Forms.CheckBox();
            this.txtResourceType = new System.Windows.Forms.TextBox();
            this.lblResourceType = new System.Windows.Forms.Label();
            this.lblReserveStatus = new System.Windows.Forms.Label();
            this.lblResourceStatus = new System.Windows.Forms.Label();
            this.txtResourceTitle = new System.Windows.Forms.TextBox();
            this.lblResourceTitle = new System.Windows.Forms.Label();
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpCurrentLoans = new System.Windows.Forms.GroupBox();
            this.dgvCurrentLoans = new System.Windows.Forms.DataGridView();
            this.chkDamage = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkLost = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chkReturn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpSearchResource = new System.Windows.Forms.GroupBox();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.txtResourceIdEntry = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.grpResourceInfo.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.grpCurrentLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentLoans)).BeginInit();
            this.grpSearchResource.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 39);
            this.label1.TabIndex = 41;
            this.label1.Text = "Return Resoruce";
            // 
            // lblLoanStatus
            // 
            this.lblLoanStatus.AutoSize = true;
            this.lblLoanStatus.Location = new System.Drawing.Point(454, 268);
            this.lblLoanStatus.Name = "lblLoanStatus";
            this.lblLoanStatus.Size = new System.Drawing.Size(109, 13);
            this.lblLoanStatus.TabIndex = 50;
            this.lblLoanStatus.Text = "Select a Loan Status:";
            // 
            // cmbLoanStatus
            // 
            this.cmbLoanStatus.FormattingEnabled = true;
            this.cmbLoanStatus.Location = new System.Drawing.Point(586, 265);
            this.cmbLoanStatus.Name = "cmbLoanStatus";
            this.cmbLoanStatus.Size = new System.Drawing.Size(184, 21);
            this.cmbLoanStatus.TabIndex = 49;
            // 
            // grpResourceInfo
            // 
            this.grpResourceInfo.Controls.Add(this.txtResourceId);
            this.grpResourceInfo.Controls.Add(this.lblResourceId);
            this.grpResourceInfo.Controls.Add(this.txtResourceStatus);
            this.grpResourceInfo.Controls.Add(this.chkIsReserved);
            this.grpResourceInfo.Controls.Add(this.txtResourceType);
            this.grpResourceInfo.Controls.Add(this.lblResourceType);
            this.grpResourceInfo.Controls.Add(this.lblReserveStatus);
            this.grpResourceInfo.Controls.Add(this.lblResourceStatus);
            this.grpResourceInfo.Controls.Add(this.txtResourceTitle);
            this.grpResourceInfo.Controls.Add(this.lblResourceTitle);
            this.grpResourceInfo.Location = new System.Drawing.Point(436, 59);
            this.grpResourceInfo.Name = "grpResourceInfo";
            this.grpResourceInfo.Size = new System.Drawing.Size(334, 192);
            this.grpResourceInfo.TabIndex = 48;
            this.grpResourceInfo.TabStop = false;
            this.grpResourceInfo.Text = "Resource Information";
            // 
            // txtResourceId
            // 
            this.txtResourceId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceId.Location = new System.Drawing.Point(21, 42);
            this.txtResourceId.Name = "txtResourceId";
            this.txtResourceId.ReadOnly = true;
            this.txtResourceId.Size = new System.Drawing.Size(172, 20);
            this.txtResourceId.TabIndex = 13;
            // 
            // lblResourceId
            // 
            this.lblResourceId.AutoSize = true;
            this.lblResourceId.Location = new System.Drawing.Point(18, 26);
            this.lblResourceId.Name = "lblResourceId";
            this.lblResourceId.Size = new System.Drawing.Size(70, 13);
            this.lblResourceId.TabIndex = 12;
            this.lblResourceId.Text = "Resource ID:";
            // 
            // txtResourceStatus
            // 
            this.txtResourceStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceStatus.Location = new System.Drawing.Point(21, 157);
            this.txtResourceStatus.Name = "txtResourceStatus";
            this.txtResourceStatus.ReadOnly = true;
            this.txtResourceStatus.Size = new System.Drawing.Size(149, 20);
            this.txtResourceStatus.TabIndex = 11;
            // 
            // chkIsReserved
            // 
            this.chkIsReserved.AutoSize = true;
            this.chkIsReserved.Enabled = false;
            this.chkIsReserved.Location = new System.Drawing.Point(192, 163);
            this.chkIsReserved.Name = "chkIsReserved";
            this.chkIsReserved.Size = new System.Drawing.Size(83, 17);
            this.chkIsReserved.TabIndex = 10;
            this.chkIsReserved.Text = "Is Reserved";
            this.chkIsReserved.UseVisualStyleBackColor = true;
            // 
            // txtResourceType
            // 
            this.txtResourceType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceType.Location = new System.Drawing.Point(20, 117);
            this.txtResourceType.Name = "txtResourceType";
            this.txtResourceType.ReadOnly = true;
            this.txtResourceType.Size = new System.Drawing.Size(294, 20);
            this.txtResourceType.TabIndex = 9;
            // 
            // lblResourceType
            // 
            this.lblResourceType.AutoSize = true;
            this.lblResourceType.Location = new System.Drawing.Point(17, 102);
            this.lblResourceType.Name = "lblResourceType";
            this.lblResourceType.Size = new System.Drawing.Size(80, 13);
            this.lblResourceType.TabIndex = 2;
            this.lblResourceType.Text = "Resource Type";
            // 
            // lblReserveStatus
            // 
            this.lblReserveStatus.AutoSize = true;
            this.lblReserveStatus.Location = new System.Drawing.Point(189, 141);
            this.lblReserveStatus.Name = "lblReserveStatus";
            this.lblReserveStatus.Size = new System.Drawing.Size(83, 13);
            this.lblReserveStatus.TabIndex = 6;
            this.lblReserveStatus.Text = "Reserve Status:";
            // 
            // lblResourceStatus
            // 
            this.lblResourceStatus.AutoSize = true;
            this.lblResourceStatus.Location = new System.Drawing.Point(18, 142);
            this.lblResourceStatus.Name = "lblResourceStatus";
            this.lblResourceStatus.Size = new System.Drawing.Size(89, 13);
            this.lblResourceStatus.TabIndex = 4;
            this.lblResourceStatus.Text = "Resource Status:";
            // 
            // txtResourceTitle
            // 
            this.txtResourceTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResourceTitle.Location = new System.Drawing.Point(20, 79);
            this.txtResourceTitle.Name = "txtResourceTitle";
            this.txtResourceTitle.ReadOnly = true;
            this.txtResourceTitle.Size = new System.Drawing.Size(294, 20);
            this.txtResourceTitle.TabIndex = 1;
            // 
            // lblResourceTitle
            // 
            this.lblResourceTitle.AutoSize = true;
            this.lblResourceTitle.Location = new System.Drawing.Point(18, 63);
            this.lblResourceTitle.Name = "lblResourceTitle";
            this.lblResourceTitle.Size = new System.Drawing.Size(79, 13);
            this.lblResourceTitle.TabIndex = 0;
            this.lblResourceTitle.Text = "Resource Title:";
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
            this.grpStudentInfo.Location = new System.Drawing.Point(10, 132);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Size = new System.Drawing.Size(392, 180);
            this.grpStudentInfo.TabIndex = 47;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Tag = "";
            this.grpStudentInfo.Text = "Borrower\'s Information";
            // 
            // txtEndDate
            // 
            this.txtEndDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEndDate.Location = new System.Drawing.Point(205, 111);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.ReadOnly = true;
            this.txtEndDate.Size = new System.Drawing.Size(172, 20);
            this.txtEndDate.TabIndex = 17;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStartDate.Location = new System.Drawing.Point(19, 111);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(172, 20);
            this.txtStartDate.TabIndex = 16;
            // 
            // txtProgramOption
            // 
            this.txtProgramOption.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtProgramOption.Location = new System.Drawing.Point(205, 32);
            this.txtProgramOption.Name = "txtProgramOption";
            this.txtProgramOption.ReadOnly = true;
            this.txtProgramOption.Size = new System.Drawing.Size(172, 20);
            this.txtProgramOption.TabIndex = 3;
            // 
            // lblStudentStatus
            // 
            this.lblStudentStatus.AutoSize = true;
            this.lblStudentStatus.Location = new System.Drawing.Point(202, 136);
            this.lblStudentStatus.Name = "lblStudentStatus";
            this.lblStudentStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStudentStatus.TabIndex = 14;
            this.lblStudentStatus.Text = "Student Status:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Enabled = false;
            this.chkIsActive.Location = new System.Drawing.Point(205, 152);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(67, 17);
            this.chkIsActive.TabIndex = 15;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Location = new System.Drawing.Point(16, 136);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(72, 13);
            this.lblBalanceDue.TabIndex = 12;
            this.lblBalanceDue.Text = "Balance Due:";
            // 
            // txtBalanceDue
            // 
            this.txtBalanceDue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBalanceDue.Location = new System.Drawing.Point(19, 152);
            this.txtBalanceDue.Name = "txtBalanceDue";
            this.txtBalanceDue.ReadOnly = true;
            this.txtBalanceDue.Size = new System.Drawing.Size(172, 20);
            this.txtBalanceDue.TabIndex = 13;
            // 
            // lblProgramOption
            // 
            this.lblProgramOption.AutoSize = true;
            this.lblProgramOption.Location = new System.Drawing.Point(202, 16);
            this.lblProgramOption.Name = "lblProgramOption";
            this.lblProgramOption.Size = new System.Drawing.Size(83, 13);
            this.lblProgramOption.TabIndex = 2;
            this.lblProgramOption.Text = "Program Option:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(202, 94);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.Location = new System.Drawing.Point(205, 70);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(172, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(202, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.Location = new System.Drawing.Point(17, 70);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(174, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(16, 95);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtStudentId
            // 
            this.txtStudentId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStudentId.Location = new System.Drawing.Point(19, 32);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.ReadOnly = true;
            this.txtStudentId.Size = new System.Drawing.Size(172, 20);
            this.txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(16, 16);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(61, 13);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(689, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 27);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReturn.Location = new System.Drawing.Point(632, 299);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(138, 27);
            this.btnReturn.TabIndex = 45;
            this.btnReturn.Text = "&Return Resource";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpCurrentLoans
            // 
            this.grpCurrentLoans.Controls.Add(this.dgvCurrentLoans);
            this.grpCurrentLoans.Location = new System.Drawing.Point(10, 341);
            this.grpCurrentLoans.Name = "grpCurrentLoans";
            this.grpCurrentLoans.Size = new System.Drawing.Size(785, 126);
            this.grpCurrentLoans.TabIndex = 43;
            this.grpCurrentLoans.TabStop = false;
            this.grpCurrentLoans.Text = "Borrower\'s Current Loans";
            // 
            // dgvCurrentLoans
            // 
            this.dgvCurrentLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentLoans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkDamage,
            this.chkLost,
            this.chkReturn});
            this.dgvCurrentLoans.Location = new System.Drawing.Point(13, 11);
            this.dgvCurrentLoans.Name = "dgvCurrentLoans";
            this.dgvCurrentLoans.Size = new System.Drawing.Size(759, 104);
            this.dgvCurrentLoans.TabIndex = 1;
            this.dgvCurrentLoans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrentLoans_CellClick_1);
            // 
            // chkDamage
            // 
            this.chkDamage.HeaderText = "Damage";
            this.chkDamage.Name = "chkDamage";
            // 
            // chkLost
            // 
            this.chkLost.HeaderText = "Lost";
            this.chkLost.Name = "chkLost";
            // 
            // chkReturn
            // 
            this.chkReturn.HeaderText = "Return";
            this.chkReturn.Name = "chkReturn";
            // 
            // grpSearchResource
            // 
            this.grpSearchResource.Controls.Add(this.btnSearchResource);
            this.grpSearchResource.Controls.Add(this.txtResourceIdEntry);
            this.grpSearchResource.Controls.Add(this.Label3);
            this.grpSearchResource.Location = new System.Drawing.Point(10, 59);
            this.grpSearchResource.Name = "grpSearchResource";
            this.grpSearchResource.Size = new System.Drawing.Size(392, 54);
            this.grpSearchResource.TabIndex = 42;
            this.grpSearchResource.TabStop = false;
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(258, 20);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(118, 23);
            this.btnSearchResource.TabIndex = 15;
            this.btnSearchResource.Text = "&Search Resource";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // txtResourceIdEntry
            // 
            this.txtResourceIdEntry.Location = new System.Drawing.Point(131, 22);
            this.txtResourceIdEntry.Name = "txtResourceIdEntry";
            this.txtResourceIdEntry.Size = new System.Drawing.Size(105, 20);
            this.txtResourceIdEntry.TabIndex = 4;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 25);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(107, 13);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Enter a Resource ID:";
            // 
            // ReturnResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoanStatus);
            this.Controls.Add(this.cmbLoanStatus);
            this.Controls.Add(this.grpResourceInfo);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.grpCurrentLoans);
            this.Controls.Add(this.grpSearchResource);
            this.Name = "ReturnResource";
            this.Text = "ReturnResource";
            this.grpResourceInfo.ResumeLayout(false);
            this.grpResourceInfo.PerformLayout();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.grpCurrentLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentLoans)).EndInit();
            this.grpSearchResource.ResumeLayout(false);
            this.grpSearchResource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblLoanStatus;
        internal System.Windows.Forms.ComboBox cmbLoanStatus;
        internal System.Windows.Forms.GroupBox grpResourceInfo;
        internal System.Windows.Forms.TextBox txtResourceId;
        internal System.Windows.Forms.Label lblResourceId;
        internal System.Windows.Forms.TextBox txtResourceStatus;
        internal System.Windows.Forms.CheckBox chkIsReserved;
        internal System.Windows.Forms.TextBox txtResourceType;
        internal System.Windows.Forms.Label lblResourceType;
        internal System.Windows.Forms.Label lblReserveStatus;
        internal System.Windows.Forms.Label lblResourceStatus;
        internal System.Windows.Forms.TextBox txtResourceTitle;
        internal System.Windows.Forms.Label lblResourceTitle;
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
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnReturn;
        internal System.Windows.Forms.GroupBox grpCurrentLoans;
        internal System.Windows.Forms.GroupBox grpSearchResource;
        internal System.Windows.Forms.Button btnSearchResource;
        internal System.Windows.Forms.TextBox txtResourceIdEntry;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView dgvCurrentLoans;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkDamage;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkLost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkReturn;
    }
}