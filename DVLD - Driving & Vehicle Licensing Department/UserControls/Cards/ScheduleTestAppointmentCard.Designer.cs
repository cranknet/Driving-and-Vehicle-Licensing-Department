namespace DVLD_UI.UserControls.Cards
{
    partial class ScheduleTestAppointmentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleTestAppointmentCard));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.PictureBoxClose = new System.Windows.Forms.PictureBox();
            this.LabelScheduleTestTitle = new System.Windows.Forms.Label();
            this.GroupBoxTestTypeValue = new System.Windows.Forms.GroupBox();
            this.LabelTotalFeesValue = new System.Windows.Forms.Label();
            this.LabelTotalFees = new System.Windows.Forms.Label();
            this.GroupBoxRetakeTest = new System.Windows.Forms.GroupBox();
            this.LabelRetakeTestFeeValue = new System.Windows.Forms.Label();
            this.LabelRetakeTestFee = new System.Windows.Forms.Label();
            this.LabelRetakeTestApplicationIDValue = new System.Windows.Forms.Label();
            this.LabelRetakeTestApplicationID = new System.Windows.Forms.Label();
            this.LabelScheduleTestValue = new System.Windows.Forms.Label();
            this.LabelTestFeesValue = new System.Windows.Forms.Label();
            this.LabelTestTrialValue = new System.Windows.Forms.Label();
            this.LabelApplicantNameValue = new System.Windows.Forms.Label();
            this.LabelLicenseClassValue = new System.Windows.Forms.Label();
            this.LabelApplicationIDValue = new System.Windows.Forms.Label();
            this.LabelTestFees = new System.Windows.Forms.Label();
            this.LabelScheduleTestDateValue = new System.Windows.Forms.Label();
            this.LabelTestTrial = new System.Windows.Forms.Label();
            this.LabelApplicantName = new System.Windows.Forms.Label();
            this.LabelLicenseClass = new System.Windows.Forms.Label();
            this.LabelApplicationID = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.dateTimePickerScheduleTestDateValue = new System.Windows.Forms.DateTimePicker();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).BeginInit();
            this.GroupBoxTestTypeValue.SuspendLayout();
            this.GroupBoxRetakeTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.PictureBoxClose);
            this.panelHeader.Controls.Add(this.LabelScheduleTestTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(398, 45);
            this.panelHeader.TabIndex = 23;
            // 
            // PictureBoxClose
            // 
            this.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxClose.Image")));
            this.PictureBoxClose.Location = new System.Drawing.Point(363, -1);
            this.PictureBoxClose.Name = "PictureBoxClose";
            this.PictureBoxClose.Size = new System.Drawing.Size(37, 43);
            this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxClose.TabIndex = 17;
            this.PictureBoxClose.TabStop = false;
            this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // LabelScheduleTestTitle
            // 
            this.LabelScheduleTestTitle.AutoSize = true;
            this.LabelScheduleTestTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScheduleTestTitle.ForeColor = System.Drawing.Color.White;
            this.LabelScheduleTestTitle.Location = new System.Drawing.Point(3, 3);
            this.LabelScheduleTestTitle.Name = "LabelScheduleTestTitle";
            this.LabelScheduleTestTitle.Size = new System.Drawing.Size(168, 32);
            this.LabelScheduleTestTitle.TabIndex = 15;
            this.LabelScheduleTestTitle.Text = "Schedule Test";
            // 
            // GroupBoxTestTypeValue
            // 
            this.GroupBoxTestTypeValue.Controls.Add(this.dateTimePickerScheduleTestDateValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTotalFeesValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTotalFees);
            this.GroupBoxTestTypeValue.Controls.Add(this.GroupBoxRetakeTest);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelScheduleTestValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestFeesValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestTrialValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicantNameValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelLicenseClassValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicationIDValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestFees);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelScheduleTestDateValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestTrial);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicantName);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelLicenseClass);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicationID);
            this.GroupBoxTestTypeValue.Controls.Add(this.ButtonSave);
            this.GroupBoxTestTypeValue.Location = new System.Drawing.Point(3, 51);
            this.GroupBoxTestTypeValue.Name = "GroupBoxTestTypeValue";
            this.GroupBoxTestTypeValue.Size = new System.Drawing.Size(394, 497);
            this.GroupBoxTestTypeValue.TabIndex = 25;
            this.GroupBoxTestTypeValue.TabStop = false;
            this.GroupBoxTestTypeValue.Text = "Test Type";
            // 
            // LabelTotalFeesValue
            // 
            this.LabelTotalFeesValue.AutoSize = true;
            this.LabelTotalFeesValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalFeesValue.Location = new System.Drawing.Point(128, 463);
            this.LabelTotalFeesValue.Name = "LabelTotalFeesValue";
            this.LabelTotalFeesValue.Size = new System.Drawing.Size(19, 21);
            this.LabelTotalFeesValue.TabIndex = 47;
            this.LabelTotalFeesValue.Text = "0";
            // 
            // LabelTotalFees
            // 
            this.LabelTotalFees.AutoSize = true;
            this.LabelTotalFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalFees.Location = new System.Drawing.Point(12, 463);
            this.LabelTotalFees.Name = "LabelTotalFees";
            this.LabelTotalFees.Size = new System.Drawing.Size(89, 21);
            this.LabelTotalFees.TabIndex = 46;
            this.LabelTotalFees.Text = "Total Fees:";
            // 
            // GroupBoxRetakeTest
            // 
            this.GroupBoxRetakeTest.Controls.Add(this.LabelRetakeTestFeeValue);
            this.GroupBoxRetakeTest.Controls.Add(this.LabelRetakeTestFee);
            this.GroupBoxRetakeTest.Controls.Add(this.LabelRetakeTestApplicationIDValue);
            this.GroupBoxRetakeTest.Controls.Add(this.LabelRetakeTestApplicationID);
            this.GroupBoxRetakeTest.Location = new System.Drawing.Point(6, 348);
            this.GroupBoxRetakeTest.Name = "GroupBoxRetakeTest";
            this.GroupBoxRetakeTest.Size = new System.Drawing.Size(382, 100);
            this.GroupBoxRetakeTest.TabIndex = 45;
            this.GroupBoxRetakeTest.TabStop = false;
            this.GroupBoxRetakeTest.Text = "RetakeTest";
            // 
            // LabelRetakeTestFeeValue
            // 
            this.LabelRetakeTestFeeValue.AutoSize = true;
            this.LabelRetakeTestFeeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRetakeTestFeeValue.Location = new System.Drawing.Point(199, 66);
            this.LabelRetakeTestFeeValue.Name = "LabelRetakeTestFeeValue";
            this.LabelRetakeTestFeeValue.Size = new System.Drawing.Size(19, 21);
            this.LabelRetakeTestFeeValue.TabIndex = 47;
            this.LabelRetakeTestFeeValue.Text = "0";
            // 
            // LabelRetakeTestFee
            // 
            this.LabelRetakeTestFee.AutoSize = true;
            this.LabelRetakeTestFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRetakeTestFee.Location = new System.Drawing.Point(6, 66);
            this.LabelRetakeTestFee.Name = "LabelRetakeTestFee";
            this.LabelRetakeTestFee.Size = new System.Drawing.Size(130, 21);
            this.LabelRetakeTestFee.TabIndex = 46;
            this.LabelRetakeTestFee.Text = "Retake Test Fee:";
            // 
            // LabelRetakeTestApplicationIDValue
            // 
            this.LabelRetakeTestApplicationIDValue.AutoSize = true;
            this.LabelRetakeTestApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRetakeTestApplicationIDValue.Location = new System.Drawing.Point(193, 36);
            this.LabelRetakeTestApplicationIDValue.Name = "LabelRetakeTestApplicationIDValue";
            this.LabelRetakeTestApplicationIDValue.Size = new System.Drawing.Size(25, 21);
            this.LabelRetakeTestApplicationIDValue.TabIndex = 45;
            this.LabelRetakeTestApplicationIDValue.Text = "-1";
            // 
            // LabelRetakeTestApplicationID
            // 
            this.LabelRetakeTestApplicationID.AutoSize = true;
            this.LabelRetakeTestApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRetakeTestApplicationID.Location = new System.Drawing.Point(6, 36);
            this.LabelRetakeTestApplicationID.Name = "LabelRetakeTestApplicationID";
            this.LabelRetakeTestApplicationID.Size = new System.Drawing.Size(184, 21);
            this.LabelRetakeTestApplicationID.TabIndex = 44;
            this.LabelRetakeTestApplicationID.Text = "Retake Application ID: ";
            // 
            // LabelScheduleTestValue
            // 
            this.LabelScheduleTestValue.AutoSize = true;
            this.LabelScheduleTestValue.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScheduleTestValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.LabelScheduleTestValue.Location = new System.Drawing.Point(67, 46);
            this.LabelScheduleTestValue.Name = "LabelScheduleTestValue";
            this.LabelScheduleTestValue.Size = new System.Drawing.Size(266, 43);
            this.LabelScheduleTestValue.TabIndex = 44;
            this.LabelScheduleTestValue.Text = "Schedule Test";
            // 
            // LabelTestFeesValue
            // 
            this.LabelTestFeesValue.AutoSize = true;
            this.LabelTestFeesValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestFeesValue.Location = new System.Drawing.Point(128, 324);
            this.LabelTestFeesValue.Name = "LabelTestFeesValue";
            this.LabelTestFeesValue.Size = new System.Drawing.Size(19, 21);
            this.LabelTestFeesValue.TabIndex = 43;
            this.LabelTestFeesValue.Text = "0";
            // 
            // LabelTestTrialValue
            // 
            this.LabelTestTrialValue.AutoSize = true;
            this.LabelTestTrialValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestTrialValue.Location = new System.Drawing.Point(128, 242);
            this.LabelTestTrialValue.Name = "LabelTestTrialValue";
            this.LabelTestTrialValue.Size = new System.Drawing.Size(19, 21);
            this.LabelTestTrialValue.TabIndex = 43;
            this.LabelTestTrialValue.Text = "0";
            // 
            // LabelApplicantNameValue
            // 
            this.LabelApplicantNameValue.AutoSize = true;
            this.LabelApplicantNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicantNameValue.Location = new System.Drawing.Point(128, 201);
            this.LabelApplicantNameValue.Name = "LabelApplicantNameValue";
            this.LabelApplicantNameValue.Size = new System.Drawing.Size(83, 21);
            this.LabelApplicantNameValue.TabIndex = 43;
            this.LabelApplicantNameValue.Text = "No Name";
            // 
            // LabelLicenseClassValue
            // 
            this.LabelLicenseClassValue.AutoSize = true;
            this.LabelLicenseClassValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicenseClassValue.Location = new System.Drawing.Point(128, 160);
            this.LabelLicenseClassValue.Name = "LabelLicenseClassValue";
            this.LabelLicenseClassValue.Size = new System.Drawing.Size(75, 21);
            this.LabelLicenseClassValue.TabIndex = 43;
            this.LabelLicenseClassValue.Text = "No Class";
            // 
            // LabelApplicationIDValue
            // 
            this.LabelApplicationIDValue.AutoSize = true;
            this.LabelApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationIDValue.Location = new System.Drawing.Point(128, 119);
            this.LabelApplicationIDValue.Name = "LabelApplicationIDValue";
            this.LabelApplicationIDValue.Size = new System.Drawing.Size(25, 21);
            this.LabelApplicationIDValue.TabIndex = 43;
            this.LabelApplicationIDValue.Text = "-1";
            // 
            // LabelTestFees
            // 
            this.LabelTestFees.AutoSize = true;
            this.LabelTestFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestFees.Location = new System.Drawing.Point(75, 324);
            this.LabelTestFees.Name = "LabelTestFees";
            this.LabelTestFees.Size = new System.Drawing.Size(47, 21);
            this.LabelTestFees.TabIndex = 42;
            this.LabelTestFees.Text = "Fees:";
            // 
            // LabelScheduleTestDateValue
            // 
            this.LabelScheduleTestDateValue.AutoSize = true;
            this.LabelScheduleTestDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScheduleTestDateValue.Location = new System.Drawing.Point(70, 283);
            this.LabelScheduleTestDateValue.Name = "LabelScheduleTestDateValue";
            this.LabelScheduleTestDateValue.Size = new System.Drawing.Size(50, 21);
            this.LabelScheduleTestDateValue.TabIndex = 42;
            this.LabelScheduleTestDateValue.Text = "Date:";
            // 
            // LabelTestTrial
            // 
            this.LabelTestTrial.AutoSize = true;
            this.LabelTestTrial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestTrial.Location = new System.Drawing.Point(73, 242);
            this.LabelTestTrial.Name = "LabelTestTrial";
            this.LabelTestTrial.Size = new System.Drawing.Size(47, 21);
            this.LabelTestTrial.TabIndex = 42;
            this.LabelTestTrial.Text = "Trial:";
            // 
            // LabelApplicantName
            // 
            this.LabelApplicantName.AutoSize = true;
            this.LabelApplicantName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicantName.Location = new System.Drawing.Point(60, 201);
            this.LabelApplicantName.Name = "LabelApplicantName";
            this.LabelApplicantName.Size = new System.Drawing.Size(60, 21);
            this.LabelApplicantName.TabIndex = 42;
            this.LabelApplicantName.Text = "Name:";
            // 
            // LabelLicenseClass
            // 
            this.LabelLicenseClass.AutoSize = true;
            this.LabelLicenseClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicenseClass.Location = new System.Drawing.Point(11, 160);
            this.LabelLicenseClass.Name = "LabelLicenseClass";
            this.LabelLicenseClass.Size = new System.Drawing.Size(112, 21);
            this.LabelLicenseClass.TabIndex = 42;
            this.LabelLicenseClass.Text = "License Class:";
            // 
            // LabelApplicationID
            // 
            this.LabelApplicationID.AutoSize = true;
            this.LabelApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationID.Location = new System.Drawing.Point(1, 119);
            this.LabelApplicationID.Name = "LabelApplicationID";
            this.LabelApplicationID.Size = new System.Drawing.Size(128, 21);
            this.LabelApplicationID.TabIndex = 42;
            this.LabelApplicationID.Text = "Application ID: ";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSave.Location = new System.Drawing.Point(291, 453);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 37);
            this.ButtonSave.TabIndex = 41;
            this.ButtonSave.TabStop = false;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new System.Drawing.Point(151, 554);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(99, 37);
            this.ButtonClose.TabIndex = 40;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.UseVisualStyleBackColor = false;
            // 
            // dateTimePickerScheduleTestDateValue
            // 
            this.dateTimePickerScheduleTestDateValue.Location = new System.Drawing.Point(126, 283);
            this.dateTimePickerScheduleTestDateValue.Name = "dateTimePickerScheduleTestDateValue";
            this.dateTimePickerScheduleTestDateValue.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerScheduleTestDateValue.TabIndex = 48;
            // 
            // ScheduleTestAppointmentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.GroupBoxTestTypeValue);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ScheduleTestAppointmentCard";
            this.Size = new System.Drawing.Size(398, 598);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).EndInit();
            this.GroupBoxTestTypeValue.ResumeLayout(false);
            this.GroupBoxTestTypeValue.PerformLayout();
            this.GroupBoxRetakeTest.ResumeLayout(false);
            this.GroupBoxRetakeTest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox PictureBoxClose;
        private System.Windows.Forms.Label LabelScheduleTestTitle;
        private System.Windows.Forms.GroupBox GroupBoxTestTypeValue;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelApplicationIDValue;
        private System.Windows.Forms.Label LabelApplicationID;
        private System.Windows.Forms.Label LabelScheduleTestValue;
        private System.Windows.Forms.Label LabelTestFeesValue;
        private System.Windows.Forms.Label LabelTestTrialValue;
        private System.Windows.Forms.Label LabelApplicantNameValue;
        private System.Windows.Forms.Label LabelLicenseClassValue;
        private System.Windows.Forms.Label LabelTestFees;
        private System.Windows.Forms.Label LabelScheduleTestDateValue;
        private System.Windows.Forms.Label LabelTestTrial;
        private System.Windows.Forms.Label LabelApplicantName;
        private System.Windows.Forms.Label LabelLicenseClass;
        private System.Windows.Forms.GroupBox GroupBoxRetakeTest;
        private System.Windows.Forms.Label LabelTotalFeesValue;
        private System.Windows.Forms.Label LabelTotalFees;
        private System.Windows.Forms.Label LabelRetakeTestFeeValue;
        private System.Windows.Forms.Label LabelRetakeTestFee;
        private System.Windows.Forms.Label LabelRetakeTestApplicationIDValue;
        private System.Windows.Forms.Label LabelRetakeTestApplicationID;
        private System.Windows.Forms.DateTimePicker dateTimePickerScheduleTestDateValue;
    }
}
