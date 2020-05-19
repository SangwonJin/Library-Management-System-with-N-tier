namespace FrontEnd
{
    partial class AddResoruce
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
            this.btnAddResource = new System.Windows.Forms.Button();
            this.grpResourceInfo = new System.Windows.Forms.GroupBox();
            this.lblImageOfItem = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.dtpDateOfPurchase = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfPurchase = new System.Windows.Forms.Label();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.txtPubRefNumber = new System.Windows.Forms.TextBox();
            this.lblPubRefNumber = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.cmbResourceStatus = new System.Windows.Forms.ComboBox();
            this.cmbResourceType = new System.Windows.Forms.ComboBox();
            this.lblResourceType = new System.Windows.Forms.Label();
            this.lblResourceStatus = new System.Windows.Forms.Label();
            this.txtResourceTitle = new System.Windows.Forms.TextBox();
            this.lblResourceTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResourceId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picImageOfItem = new System.Windows.Forms.PictureBox();
            this.grpResourceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageOfItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(444, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddResource
            // 
            this.btnAddResource.Location = new System.Drawing.Point(254, 378);
            this.btnAddResource.Name = "btnAddResource";
            this.btnAddResource.Size = new System.Drawing.Size(129, 36);
            this.btnAddResource.TabIndex = 4;
            this.btnAddResource.Text = "&Add New Resource";
            this.btnAddResource.UseVisualStyleBackColor = true;
            this.btnAddResource.Click += new System.EventHandler(this.btnAddResource_Click);
            // 
            // grpResourceInfo
            // 
            this.grpResourceInfo.Controls.Add(this.txtResourceId);
            this.grpResourceInfo.Controls.Add(this.label1);
            this.grpResourceInfo.Controls.Add(this.lblImageOfItem);
            this.grpResourceInfo.Controls.Add(this.txtPurchasePrice);
            this.grpResourceInfo.Controls.Add(this.lblPurchasePrice);
            this.grpResourceInfo.Controls.Add(this.dtpDateOfPurchase);
            this.grpResourceInfo.Controls.Add(this.lblDateOfPurchase);
            this.grpResourceInfo.Controls.Add(this.btnAddImage);
            this.grpResourceInfo.Controls.Add(this.picImageOfItem);
            this.grpResourceInfo.Controls.Add(this.txtPubRefNumber);
            this.grpResourceInfo.Controls.Add(this.lblPubRefNumber);
            this.grpResourceInfo.Controls.Add(this.txtPublisher);
            this.grpResourceInfo.Controls.Add(this.lblPublisher);
            this.grpResourceInfo.Controls.Add(this.cmbResourceStatus);
            this.grpResourceInfo.Controls.Add(this.cmbResourceType);
            this.grpResourceInfo.Controls.Add(this.lblResourceType);
            this.grpResourceInfo.Controls.Add(this.lblResourceStatus);
            this.grpResourceInfo.Controls.Add(this.txtResourceTitle);
            this.grpResourceInfo.Controls.Add(this.lblResourceTitle);
            this.grpResourceInfo.Location = new System.Drawing.Point(39, 65);
            this.grpResourceInfo.Name = "grpResourceInfo";
            this.grpResourceInfo.Size = new System.Drawing.Size(672, 296);
            this.grpResourceInfo.TabIndex = 3;
            this.grpResourceInfo.TabStop = false;
            this.grpResourceInfo.Text = "Resource Information";
            // 
            // lblImageOfItem
            // 
            this.lblImageOfItem.AutoSize = true;
            this.lblImageOfItem.Location = new System.Drawing.Point(414, 25);
            this.lblImageOfItem.Name = "lblImageOfItem";
            this.lblImageOfItem.Size = new System.Drawing.Size(74, 13);
            this.lblImageOfItem.TabIndex = 47;
            this.lblImageOfItem.Text = "Image of Item:";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(241, 146);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(143, 20);
            this.txtPurchasePrice.TabIndex = 9;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(238, 130);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(79, 13);
            this.lblPurchasePrice.TabIndex = 8;
            this.lblPurchasePrice.Text = "Purchase Price";
            // 
            // dtpDateOfPurchase
            // 
            this.dtpDateOfPurchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfPurchase.Location = new System.Drawing.Point(19, 146);
            this.dtpDateOfPurchase.Name = "dtpDateOfPurchase";
            this.dtpDateOfPurchase.Size = new System.Drawing.Size(197, 20);
            this.dtpDateOfPurchase.TabIndex = 7;
            // 
            // lblDateOfPurchase
            // 
            this.lblDateOfPurchase.AutoSize = true;
            this.lblDateOfPurchase.Location = new System.Drawing.Point(16, 130);
            this.lblDateOfPurchase.Name = "lblDateOfPurchase";
            this.lblDateOfPurchase.Size = new System.Drawing.Size(93, 13);
            this.lblDateOfPurchase.TabIndex = 6;
            this.lblDateOfPurchase.Text = "Date of Purchase:";
            // 
            // btnAddImage
            // 
            this.btnAddImage.Location = new System.Drawing.Point(285, 228);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(99, 46);
            this.btnAddImage.TabIndex = 14;
            this.btnAddImage.Text = "Add &Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // txtPubRefNumber
            // 
            this.txtPubRefNumber.Location = new System.Drawing.Point(241, 94);
            this.txtPubRefNumber.Name = "txtPubRefNumber";
            this.txtPubRefNumber.Size = new System.Drawing.Size(143, 20);
            this.txtPubRefNumber.TabIndex = 5;
            // 
            // lblPubRefNumber
            // 
            this.lblPubRefNumber.AutoSize = true;
            this.lblPubRefNumber.Location = new System.Drawing.Point(238, 78);
            this.lblPubRefNumber.Name = "lblPubRefNumber";
            this.lblPubRefNumber.Size = new System.Drawing.Size(146, 13);
            this.lblPubRefNumber.TabIndex = 4;
            this.lblPubRefNumber.Text = "Publisher Reference Number:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(19, 94);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(197, 20);
            this.txtPublisher.TabIndex = 3;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(16, 78);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(53, 13);
            this.lblPublisher.TabIndex = 2;
            this.lblPublisher.Text = "Publisher:";
            // 
            // cmbResourceStatus
            // 
            this.cmbResourceStatus.FormattingEnabled = true;
            this.cmbResourceStatus.Location = new System.Drawing.Point(19, 253);
            this.cmbResourceStatus.Name = "cmbResourceStatus";
            this.cmbResourceStatus.Size = new System.Drawing.Size(197, 21);
            this.cmbResourceStatus.TabIndex = 13;
            // 
            // cmbResourceType
            // 
            this.cmbResourceType.FormattingEnabled = true;
            this.cmbResourceType.Location = new System.Drawing.Point(19, 198);
            this.cmbResourceType.Name = "cmbResourceType";
            this.cmbResourceType.Size = new System.Drawing.Size(197, 21);
            this.cmbResourceType.TabIndex = 11;
            // 
            // lblResourceType
            // 
            this.lblResourceType.AutoSize = true;
            this.lblResourceType.Location = new System.Drawing.Point(16, 182);
            this.lblResourceType.Name = "lblResourceType";
            this.lblResourceType.Size = new System.Drawing.Size(80, 13);
            this.lblResourceType.TabIndex = 10;
            this.lblResourceType.Text = "Resource Type";
            // 
            // lblResourceStatus
            // 
            this.lblResourceStatus.AutoSize = true;
            this.lblResourceStatus.Location = new System.Drawing.Point(16, 237);
            this.lblResourceStatus.Name = "lblResourceStatus";
            this.lblResourceStatus.Size = new System.Drawing.Size(89, 13);
            this.lblResourceStatus.TabIndex = 12;
            this.lblResourceStatus.Text = "Resource Status:";
            // 
            // txtResourceTitle
            // 
            this.txtResourceTitle.Location = new System.Drawing.Point(241, 41);
            this.txtResourceTitle.Name = "txtResourceTitle";
            this.txtResourceTitle.Size = new System.Drawing.Size(143, 20);
            this.txtResourceTitle.TabIndex = 1;
            // 
            // lblResourceTitle
            // 
            this.lblResourceTitle.AutoSize = true;
            this.lblResourceTitle.Location = new System.Drawing.Point(238, 25);
            this.lblResourceTitle.Name = "lblResourceTitle";
            this.lblResourceTitle.Size = new System.Drawing.Size(79, 13);
            this.lblResourceTitle.TabIndex = 0;
            this.lblResourceTitle.Text = "Resource Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 39);
            this.label2.TabIndex = 43;
            this.label2.Text = "Add Resource";
            // 
            // txtResourceId
            // 
            this.txtResourceId.Location = new System.Drawing.Point(19, 41);
            this.txtResourceId.Name = "txtResourceId";
            this.txtResourceId.Size = new System.Drawing.Size(197, 20);
            this.txtResourceId.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "ResourceID";
            // 
            // picImageOfItem
            // 
            this.picImageOfItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picImageOfItem.Location = new System.Drawing.Point(417, 41);
            this.picImageOfItem.Name = "picImageOfItem";
            this.picImageOfItem.Size = new System.Drawing.Size(226, 233);
            this.picImageOfItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageOfItem.TabIndex = 46;
            this.picImageOfItem.TabStop = false;
            // 
            // AddResoruce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddResource);
            this.Controls.Add(this.grpResourceInfo);
            this.Name = "AddResoruce";
            this.Text = "AddResoruce";
            this.Load += new System.EventHandler(this.AddResoruce_Load);
            this.grpResourceInfo.ResumeLayout(false);
            this.grpResourceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageOfItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnAddResource;
        internal System.Windows.Forms.GroupBox grpResourceInfo;
        internal System.Windows.Forms.Label lblImageOfItem;
        internal System.Windows.Forms.TextBox txtPurchasePrice;
        internal System.Windows.Forms.Label lblPurchasePrice;
        internal System.Windows.Forms.DateTimePicker dtpDateOfPurchase;
        internal System.Windows.Forms.Label lblDateOfPurchase;
        internal System.Windows.Forms.Button btnAddImage;
        internal System.Windows.Forms.PictureBox picImageOfItem;
        internal System.Windows.Forms.TextBox txtPubRefNumber;
        internal System.Windows.Forms.Label lblPubRefNumber;
        internal System.Windows.Forms.TextBox txtPublisher;
        internal System.Windows.Forms.Label lblPublisher;
        internal System.Windows.Forms.ComboBox cmbResourceStatus;
        internal System.Windows.Forms.ComboBox cmbResourceType;
        internal System.Windows.Forms.Label lblResourceType;
        internal System.Windows.Forms.Label lblResourceStatus;
        internal System.Windows.Forms.TextBox txtResourceTitle;
        internal System.Windows.Forms.Label lblResourceTitle;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtResourceId;
        internal System.Windows.Forms.Label label1;
    }
}