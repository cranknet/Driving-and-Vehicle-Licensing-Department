namespace DVLD_UI.UserControls.Cards
{
    partial class AddLocalDLApplicationCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLocalDLApplicationCard));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.lblAddNewLocalDrivingLicenseApplication = new System.Windows.Forms.Label();
            this.btnSaveApplication = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnSelectPerson = new System.Windows.Forms.Button();
            this.grbNewApplicationDetails = new System.Windows.Forms.GroupBox();
            this.lblApplicationCreatedByUserID = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationID = new System.Windows.Forms.Label();
            this.cmbApplicationLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblFees = new System.Windows.Forms.Label();
            this.lblLicenseClass = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelMain.SuspendLayout();
            this.grbNewApplicationDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.pbCloseCard);
            this.panelHeader.Controls.Add(this.lblAddNewLocalDrivingLicenseApplication);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(903, 42);
            this.panelHeader.TabIndex = 18;
            // 
            // pbCloseCard
            // 
            this.pbCloseCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseCard.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseCard.Image")));
            this.pbCloseCard.Location = new System.Drawing.Point(867, 0);
            this.pbCloseCard.Name = "pbCloseCard";
            this.pbCloseCard.Size = new System.Drawing.Size(37, 40);
            this.pbCloseCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloseCard.TabIndex = 17;
            this.pbCloseCard.TabStop = false;
            this.pbCloseCard.Click += new System.EventHandler(this.pbCloseCard_Click);
            // 
            // lblAddNewLocalDrivingLicenseApplication
            // 
            this.lblAddNewLocalDrivingLicenseApplication.AutoSize = true;
            this.lblAddNewLocalDrivingLicenseApplication.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewLocalDrivingLicenseApplication.ForeColor = System.Drawing.Color.White;
            this.lblAddNewLocalDrivingLicenseApplication.Location = new System.Drawing.Point(3, 3);
            this.lblAddNewLocalDrivingLicenseApplication.Name = "lblAddNewLocalDrivingLicenseApplication";
            this.lblAddNewLocalDrivingLicenseApplication.Size = new System.Drawing.Size(416, 32);
            this.lblAddNewLocalDrivingLicenseApplication.TabIndex = 15;
            this.lblAddNewLocalDrivingLicenseApplication.Text = "Add New Local Driving Application";
            // 
            // btnSaveApplication
            // 
            this.btnSaveApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSaveApplication.FlatAppearance.BorderSize = 0;
            this.btnSaveApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveApplication.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveApplication.ForeColor = System.Drawing.Color.White;
            this.btnSaveApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveApplication.Location = new System.Drawing.Point(673, 422);
            this.btnSaveApplication.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveApplication.Name = "btnSaveApplication";
            this.btnSaveApplication.Size = new System.Drawing.Size(128, 37);
            this.btnSaveApplication.TabIndex = 39;
            this.btnSaveApplication.TabStop = false;
            this.btnSaveApplication.Text = "SAVE";
            this.btnSaveApplication.UseVisualStyleBackColor = false;
            this.btnSaveApplication.Click += new System.EventHandler(this.btnSaveApplication_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(478, 422);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 37);
            this.btnClose.TabIndex = 37;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.lblFullName);
            this.panelMain.Controls.Add(this.btnSelectPerson);
            this.panelMain.Controls.Add(this.grbNewApplicationDetails);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.btnSaveApplication);
            this.panelMain.Controls.Add(this.pbPersonImage);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(905, 479);
            this.panelMain.TabIndex = 5;
            this.panelMain.TabStop = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(44, 70);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(0, 30);
            this.lblFullName.TabIndex = 42;
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelectPerson.FlatAppearance.BorderSize = 0;
            this.btnSelectPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPerson.Location = new System.Drawing.Point(402, 65);
            this.btnSelectPerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(187, 37);
            this.btnSelectPerson.TabIndex = 41;
            this.btnSelectPerson.TabStop = false;
            this.btnSelectPerson.Text = "SELECT PERSON";
            this.btnSelectPerson.UseVisualStyleBackColor = false;
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
            // 
            // grbNewApplicationDetails
            // 
            this.grbNewApplicationDetails.Controls.Add(this.lblApplicationCreatedByUserID);
            this.grbNewApplicationDetails.Controls.Add(this.lblApplicationDate);
            this.grbNewApplicationDetails.Controls.Add(this.lblApplicationFees);
            this.grbNewApplicationDetails.Controls.Add(this.lblApplicationID);
            this.grbNewApplicationDetails.Controls.Add(this.cmbApplicationLicenseClass);
            this.grbNewApplicationDetails.Controls.Add(this.lblID);
            this.grbNewApplicationDetails.Controls.Add(this.lblDate);
            this.grbNewApplicationDetails.Controls.Add(this.lblCreatedBy);
            this.grbNewApplicationDetails.Controls.Add(this.lblFees);
            this.grbNewApplicationDetails.Controls.Add(this.lblLicenseClass);
            this.grbNewApplicationDetails.Enabled = false;
            this.grbNewApplicationDetails.Location = new System.Drawing.Point(402, 105);
            this.grbNewApplicationDetails.Name = "grbNewApplicationDetails";
            this.grbNewApplicationDetails.Size = new System.Drawing.Size(484, 300);
            this.grbNewApplicationDetails.TabIndex = 40;
            this.grbNewApplicationDetails.TabStop = false;
            this.grbNewApplicationDetails.Text = "Application Details";
            // 
            // lblApplicationCreatedByUserID
            // 
            this.lblApplicationCreatedByUserID.AutoSize = true;
            this.lblApplicationCreatedByUserID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApplicationCreatedByUserID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationCreatedByUserID.Location = new System.Drawing.Point(190, 243);
            this.lblApplicationCreatedByUserID.Name = "lblApplicationCreatedByUserID";
            this.lblApplicationCreatedByUserID.Size = new System.Drawing.Size(84, 25);
            this.lblApplicationCreatedByUserID.TabIndex = 11;
            this.lblApplicationCreatedByUserID.Text = "No User";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApplicationDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(190, 90);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(110, 25);
            this.lblApplicationDate.TabIndex = 11;
            this.lblApplicationDate.Text = "00:00 0000";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApplicationFees.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.Location = new System.Drawing.Point(190, 192);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(61, 25);
            this.lblApplicationFees.TabIndex = 11;
            this.lblApplicationFees.Text = "00.00";
            // 
            // lblApplicationID
            // 
            this.lblApplicationID.AutoSize = true;
            this.lblApplicationID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblApplicationID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationID.Location = new System.Drawing.Point(190, 39);
            this.lblApplicationID.Name = "lblApplicationID";
            this.lblApplicationID.Size = new System.Drawing.Size(64, 25);
            this.lblApplicationID.TabIndex = 11;
            this.lblApplicationID.Text = "No ID";
            // 
            // cmbApplicationLicenseClass
            // 
            this.cmbApplicationLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbApplicationLicenseClass.FormattingEnabled = true;
            this.cmbApplicationLicenseClass.Location = new System.Drawing.Point(191, 141);
            this.cmbApplicationLicenseClass.Margin = new System.Windows.Forms.Padding(0);
            this.cmbApplicationLicenseClass.Name = "cmbApplicationLicenseClass";
            this.cmbApplicationLicenseClass.Size = new System.Drawing.Size(275, 29);
            this.cmbApplicationLicenseClass.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(26, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(144, 25);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "Application ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(27, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(165, 25);
            this.lblDate.TabIndex = 9;
            this.lblDate.Text = "Application Date:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCreatedBy.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(26, 243);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(108, 25);
            this.lblCreatedBy.TabIndex = 9;
            this.lblCreatedBy.Text = "Created By";
            // 
            // lblFees
            // 
            this.lblFees.AutoSize = true;
            this.lblFees.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFees.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.Location = new System.Drawing.Point(26, 192);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(157, 25);
            this.lblFees.TabIndex = 9;
            this.lblFees.Text = "Application Fees";
            // 
            // lblLicenseClass
            // 
            this.lblLicenseClass.AutoSize = true;
            this.lblLicenseClass.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLicenseClass.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClass.Location = new System.Drawing.Point(26, 141);
            this.lblLicenseClass.Name = "lblLicenseClass";
            this.lblLicenseClass.Size = new System.Drawing.Size(129, 25);
            this.lblLicenseClass.TabIndex = 9;
            this.lblLicenseClass.Text = "License Class:";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.ErrorImage = global::DVLD_UI.Properties.Resources.DVLD_Error_Photo;
            this.pbPersonImage.InitialImage = global::DVLD_UI.Properties.Resources.DVLD_Default_Photo;
            this.pbPersonImage.Location = new System.Drawing.Point(41, 116);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(300, 300);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 0;
            this.pbPersonImage.TabStop = false;
            // 
            // AddLocalDLApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddLocalDLApplicationCard";
            this.Size = new System.Drawing.Size(905, 479);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.grbNewApplicationDetails.ResumeLayout(false);
            this.grbNewApplicationDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbCloseCard;
        private System.Windows.Forms.Label lblAddNewLocalDrivingLicenseApplication;
        private System.Windows.Forms.Button btnSaveApplication;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grbNewApplicationDetails;
        private System.Windows.Forms.Label lblLicenseClass;
        private System.Windows.Forms.ComboBox cmbApplicationLicenseClass;
        private System.Windows.Forms.Label lblApplicationCreatedByUserID;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Button btnSelectPerson;
        private System.Windows.Forms.Label lblFullName;
    }
}
