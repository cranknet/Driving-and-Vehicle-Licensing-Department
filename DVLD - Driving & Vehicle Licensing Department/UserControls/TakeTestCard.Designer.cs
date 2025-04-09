namespace DVLD_UI.UserControls
{
    partial class TakeTestCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeTestCard));
            this.ButtonClose = new System.Windows.Forms.Button();
            this.LabelScheduledTestValue = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.LabelTakTestTitle = new System.Windows.Forms.Label();
            this.LabelTestFeesValue = new System.Windows.Forms.Label();
            this.LabelTestTrialValue = new System.Windows.Forms.Label();
            this.LabelApplicantNameValue = new System.Windows.Forms.Label();
            this.LabelLicenseClassValue = new System.Windows.Forms.Label();
            this.LabelApplicationIDValue = new System.Windows.Forms.Label();
            this.LabelTestFees = new System.Windows.Forms.Label();
            this.LabelScheduleTestDate = new System.Windows.Forms.Label();
            this.LabelTestTrial = new System.Windows.Forms.Label();
            this.LabelApplicantName = new System.Windows.Forms.Label();
            this.LabelLicenseClass = new System.Windows.Forms.Label();
            this.LabelApplicationID = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.GroupBoxTestTypeValue = new System.Windows.Forms.GroupBox();
            this.PictureBoxClose = new System.Windows.Forms.PictureBox();
            this.LabelScheduledTestDateValue = new System.Windows.Forms.Label();
            this.LabelTestIDValue = new System.Windows.Forms.Label();
            this.LabelTestID = new System.Windows.Forms.Label();
            this.RadioButtonPass = new System.Windows.Forms.RadioButton();
            this.LabelNotes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RadioButtonFail = new System.Windows.Forms.RadioButton();
            this.TextBoxNotesValue = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.GroupBoxTestTypeValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClose.Location = new System.Drawing.Point(152, 550);
            this.ButtonClose.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(99, 37);
            this.ButtonClose.TabIndex = 43;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Text = "CLOSE";
            this.ButtonClose.UseVisualStyleBackColor = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelScheduledTestValue
            // 
            this.LabelScheduledTestValue.AutoSize = true;
            this.LabelScheduledTestValue.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScheduledTestValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.LabelScheduledTestValue.Location = new System.Drawing.Point(67, 46);
            this.LabelScheduledTestValue.Name = "LabelScheduledTestValue";
            this.LabelScheduledTestValue.Size = new System.Drawing.Size(285, 43);
            this.LabelScheduledTestValue.TabIndex = 44;
            this.LabelScheduledTestValue.Text = "Scheduled Test";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.PictureBoxClose);
            this.panelHeader.Controls.Add(this.LabelTakTestTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(398, 45);
            this.panelHeader.TabIndex = 41;
            // 
            // LabelTakTestTitle
            // 
            this.LabelTakTestTitle.AutoSize = true;
            this.LabelTakTestTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTakTestTitle.ForeColor = System.Drawing.Color.White;
            this.LabelTakTestTitle.Location = new System.Drawing.Point(3, 3);
            this.LabelTakTestTitle.Name = "LabelTakTestTitle";
            this.LabelTakTestTitle.Size = new System.Drawing.Size(117, 32);
            this.LabelTakTestTitle.TabIndex = 15;
            this.LabelTakTestTitle.Text = "Take Test";
            // 
            // LabelTestFeesValue
            // 
            this.LabelTestFeesValue.AutoSize = true;
            this.LabelTestFeesValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestFeesValue.Location = new System.Drawing.Point(184, 343);
            this.LabelTestFeesValue.Name = "LabelTestFeesValue";
            this.LabelTestFeesValue.Size = new System.Drawing.Size(19, 21);
            this.LabelTestFeesValue.TabIndex = 43;
            this.LabelTestFeesValue.Text = "0";
            // 
            // LabelTestTrialValue
            // 
            this.LabelTestTrialValue.AutoSize = true;
            this.LabelTestTrialValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestTrialValue.Location = new System.Drawing.Point(184, 261);
            this.LabelTestTrialValue.Name = "LabelTestTrialValue";
            this.LabelTestTrialValue.Size = new System.Drawing.Size(19, 21);
            this.LabelTestTrialValue.TabIndex = 43;
            this.LabelTestTrialValue.Text = "0";
            // 
            // LabelApplicantNameValue
            // 
            this.LabelApplicantNameValue.AutoSize = true;
            this.LabelApplicantNameValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicantNameValue.Location = new System.Drawing.Point(184, 220);
            this.LabelApplicantNameValue.Name = "LabelApplicantNameValue";
            this.LabelApplicantNameValue.Size = new System.Drawing.Size(83, 21);
            this.LabelApplicantNameValue.TabIndex = 43;
            this.LabelApplicantNameValue.Text = "No Name";
            // 
            // LabelLicenseClassValue
            // 
            this.LabelLicenseClassValue.AutoSize = true;
            this.LabelLicenseClassValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicenseClassValue.Location = new System.Drawing.Point(184, 179);
            this.LabelLicenseClassValue.Name = "LabelLicenseClassValue";
            this.LabelLicenseClassValue.Size = new System.Drawing.Size(75, 21);
            this.LabelLicenseClassValue.TabIndex = 43;
            this.LabelLicenseClassValue.Text = "No Class";
            // 
            // LabelApplicationIDValue
            // 
            this.LabelApplicationIDValue.AutoSize = true;
            this.LabelApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationIDValue.Location = new System.Drawing.Point(184, 138);
            this.LabelApplicationIDValue.Name = "LabelApplicationIDValue";
            this.LabelApplicationIDValue.Size = new System.Drawing.Size(54, 21);
            this.LabelApplicationIDValue.TabIndex = 43;
            this.LabelApplicationIDValue.Text = "No ID";
            // 
            // LabelTestFees
            // 
            this.LabelTestFees.AutoSize = true;
            this.LabelTestFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestFees.Location = new System.Drawing.Point(131, 343);
            this.LabelTestFees.Name = "LabelTestFees";
            this.LabelTestFees.Size = new System.Drawing.Size(47, 21);
            this.LabelTestFees.TabIndex = 42;
            this.LabelTestFees.Text = "Fees:";
            // 
            // LabelScheduleTestDate
            // 
            this.LabelScheduleTestDate.AutoSize = true;
            this.LabelScheduleTestDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScheduleTestDate.Location = new System.Drawing.Point(126, 302);
            this.LabelScheduleTestDate.Name = "LabelScheduleTestDate";
            this.LabelScheduleTestDate.Size = new System.Drawing.Size(50, 21);
            this.LabelScheduleTestDate.TabIndex = 42;
            this.LabelScheduleTestDate.Text = "Date:";
            // 
            // LabelTestTrial
            // 
            this.LabelTestTrial.AutoSize = true;
            this.LabelTestTrial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestTrial.Location = new System.Drawing.Point(129, 261);
            this.LabelTestTrial.Name = "LabelTestTrial";
            this.LabelTestTrial.Size = new System.Drawing.Size(47, 21);
            this.LabelTestTrial.TabIndex = 42;
            this.LabelTestTrial.Text = "Trial:";
            // 
            // LabelApplicantName
            // 
            this.LabelApplicantName.AutoSize = true;
            this.LabelApplicantName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicantName.Location = new System.Drawing.Point(116, 220);
            this.LabelApplicantName.Name = "LabelApplicantName";
            this.LabelApplicantName.Size = new System.Drawing.Size(60, 21);
            this.LabelApplicantName.TabIndex = 42;
            this.LabelApplicantName.Text = "Name:";
            // 
            // LabelLicenseClass
            // 
            this.LabelLicenseClass.AutoSize = true;
            this.LabelLicenseClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLicenseClass.Location = new System.Drawing.Point(67, 179);
            this.LabelLicenseClass.Name = "LabelLicenseClass";
            this.LabelLicenseClass.Size = new System.Drawing.Size(112, 21);
            this.LabelLicenseClass.TabIndex = 42;
            this.LabelLicenseClass.Text = "License Class:";
            // 
            // LabelApplicationID
            // 
            this.LabelApplicationID.AutoSize = true;
            this.LabelApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationID.Location = new System.Drawing.Point(57, 138);
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
            this.ButtonSave.Location = new System.Drawing.Point(275, 550);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(96, 37);
            this.ButtonSave.TabIndex = 41;
            this.ButtonSave.TabStop = false;
            this.ButtonSave.Text = "SAVE";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // GroupBoxTestTypeValue
            // 
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestIDValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestID);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelScheduledTestDateValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelScheduledTestValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestFeesValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestTrialValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicantNameValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelLicenseClassValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicationIDValue);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestFees);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelScheduleTestDate);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelTestTrial);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicantName);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelLicenseClass);
            this.GroupBoxTestTypeValue.Controls.Add(this.LabelApplicationID);
            this.GroupBoxTestTypeValue.Location = new System.Drawing.Point(3, 55);
            this.GroupBoxTestTypeValue.Name = "GroupBoxTestTypeValue";
            this.GroupBoxTestTypeValue.Size = new System.Drawing.Size(394, 377);
            this.GroupBoxTestTypeValue.TabIndex = 42;
            this.GroupBoxTestTypeValue.TabStop = false;
            this.GroupBoxTestTypeValue.Text = "Test Type";
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
            // LabelScheduledTestDateValue
            // 
            this.LabelScheduledTestDateValue.AutoSize = true;
            this.LabelScheduledTestDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScheduledTestDateValue.Location = new System.Drawing.Point(184, 302);
            this.LabelScheduledTestDateValue.Name = "LabelScheduledTestDateValue";
            this.LabelScheduledTestDateValue.Size = new System.Drawing.Size(96, 21);
            this.LabelScheduledTestDateValue.TabIndex = 48;
            this.LabelScheduledTestDateValue.Text = "00/00/0000";
            // 
            // LabelTestIDValue
            // 
            this.LabelTestIDValue.AutoSize = true;
            this.LabelTestIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestIDValue.Location = new System.Drawing.Point(184, 105);
            this.LabelTestIDValue.Name = "LabelTestIDValue";
            this.LabelTestIDValue.Size = new System.Drawing.Size(54, 21);
            this.LabelTestIDValue.TabIndex = 50;
            this.LabelTestIDValue.Text = "No ID";
            // 
            // LabelTestID
            // 
            this.LabelTestID.AutoSize = true;
            this.LabelTestID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestID.Location = new System.Drawing.Point(116, 105);
            this.LabelTestID.Name = "LabelTestID";
            this.LabelTestID.Size = new System.Drawing.Size(65, 21);
            this.LabelTestID.TabIndex = 49;
            this.LabelTestID.Text = "Test ID:";
            // 
            // RadioButtonPass
            // 
            this.RadioButtonPass.AutoSize = true;
            this.RadioButtonPass.Location = new System.Drawing.Point(106, 440);
            this.RadioButtonPass.Name = "RadioButtonPass";
            this.RadioButtonPass.Size = new System.Drawing.Size(58, 25);
            this.RadioButtonPass.TabIndex = 51;
            this.RadioButtonPass.TabStop = true;
            this.RadioButtonPass.Text = "Pass";
            this.RadioButtonPass.UseVisualStyleBackColor = true;
            // 
            // LabelNotes
            // 
            this.LabelNotes.AutoSize = true;
            this.LabelNotes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNotes.Location = new System.Drawing.Point(30, 473);
            this.LabelNotes.Name = "LabelNotes";
            this.LabelNotes.Size = new System.Drawing.Size(59, 21);
            this.LabelNotes.TabIndex = 51;
            this.LabelNotes.Text = "Notes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 52;
            this.label2.Text = "Date:";
            // 
            // RadioButtonFail
            // 
            this.RadioButtonFail.AutoSize = true;
            this.RadioButtonFail.Location = new System.Drawing.Point(179, 440);
            this.RadioButtonFail.Name = "RadioButtonFail";
            this.RadioButtonFail.Size = new System.Drawing.Size(51, 25);
            this.RadioButtonFail.TabIndex = 53;
            this.RadioButtonFail.TabStop = true;
            this.RadioButtonFail.Text = "Fail";
            this.RadioButtonFail.UseVisualStyleBackColor = true;
            // 
            // TextBoxNotesValue
            // 
            this.TextBoxNotesValue.Location = new System.Drawing.Point(106, 473);
            this.TextBoxNotesValue.Multiline = true;
            this.TextBoxNotesValue.Name = "TextBoxNotesValue";
            this.TextBoxNotesValue.Size = new System.Drawing.Size(265, 64);
            this.TextBoxNotesValue.TabIndex = 54;
            // 
            // TakeTestCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxNotesValue);
            this.Controls.Add(this.RadioButtonFail);
            this.Controls.Add(this.LabelNotes);
            this.Controls.Add(this.RadioButtonPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.GroupBoxTestTypeValue);
            this.Controls.Add(this.ButtonSave);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TakeTestCard";
            this.Size = new System.Drawing.Size(398, 598);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.GroupBoxTestTypeValue.ResumeLayout(false);
            this.GroupBoxTestTypeValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelScheduledTestValue;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox PictureBoxClose;
        private System.Windows.Forms.Label LabelTakTestTitle;
        private System.Windows.Forms.Label LabelTestFeesValue;
        private System.Windows.Forms.Label LabelTestTrialValue;
        private System.Windows.Forms.Label LabelApplicantNameValue;
        private System.Windows.Forms.Label LabelLicenseClassValue;
        private System.Windows.Forms.Label LabelApplicationIDValue;
        private System.Windows.Forms.Label LabelTestFees;
        private System.Windows.Forms.Label LabelScheduleTestDate;
        private System.Windows.Forms.Label LabelTestTrial;
        private System.Windows.Forms.Label LabelApplicantName;
        private System.Windows.Forms.Label LabelLicenseClass;
        private System.Windows.Forms.Label LabelApplicationID;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.GroupBox GroupBoxTestTypeValue;
        private System.Windows.Forms.Label LabelScheduledTestDateValue;
        private System.Windows.Forms.Label LabelTestIDValue;
        private System.Windows.Forms.Label LabelTestID;
        private System.Windows.Forms.RadioButton RadioButtonPass;
        private System.Windows.Forms.Label LabelNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RadioButtonFail;
        private System.Windows.Forms.TextBox TextBoxNotesValue;
    }
}
