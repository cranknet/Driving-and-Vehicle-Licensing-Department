namespace DVLD_UI.UserControls.Cards
{
    partial class TestAppointmentCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestAppointmentCard));
            this.panelMain = new System.Windows.Forms.Panel();
            this.AppointmentsGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAddTestAppointment = new FontAwesome.Sharp.IconButton();
            this.LabelAppointments = new System.Windows.Forms.Label();
            this.GroupBoxApplicationInfo = new System.Windows.Forms.GroupBox();
            this.ButtonShowPersonInfo = new System.Windows.Forms.Button();
            this.LabelCreatedByValue = new System.Windows.Forms.Label();
            this.LabelCreatedBy = new System.Windows.Forms.Label();
            this.LabelStatusDateValue = new System.Windows.Forms.Label();
            this.LabelStatusDate = new System.Windows.Forms.Label();
            this.LabelApplicantValue = new System.Windows.Forms.Label();
            this.LabelApplicant = new System.Windows.Forms.Label();
            this.LabelTypeValue = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelFeesValue = new System.Windows.Forms.Label();
            this.LabelFees = new System.Windows.Forms.Label();
            this.LabelStatusValue = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.LabelDateValue = new System.Windows.Forms.Label();
            this.LabelDate = new System.Windows.Forms.Label();
            this.LabelApplicationIDValue = new System.Windows.Forms.Label();
            this.LabelApplicationID = new System.Windows.Forms.Label();
            this.GroupBoxLDLApplicationInfo = new System.Windows.Forms.GroupBox();
            this.LabelPassedTestsValue = new System.Windows.Forms.Label();
            this.LabelPassedTests = new System.Windows.Forms.Label();
            this.LabelAppliedLicenseValue = new System.Windows.Forms.Label();
            this.LabelAppliedLicense = new System.Windows.Forms.Label();
            this.LabelLDLAppIDValue = new System.Windows.Forms.Label();
            this.LabelLDLAppID = new System.Windows.Forms.Label();
            this.lblLoginWelcome = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.LabelTestType = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGridView)).BeginInit();
            this.contextMenuStripAppointments.SuspendLayout();
            this.GroupBoxApplicationInfo.SuspendLayout();
            this.GroupBoxLDLApplicationInfo.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.AppointmentsGridView);
            this.panelMain.Controls.Add(this.ButtonAddTestAppointment);
            this.panelMain.Controls.Add(this.LabelAppointments);
            this.panelMain.Controls.Add(this.GroupBoxApplicationInfo);
            this.panelMain.Controls.Add(this.GroupBoxLDLApplicationInfo);
            this.panelMain.Controls.Add(this.lblLoginWelcome);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.Location = new System.Drawing.Point(0, -113);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(706, 705);
            this.panelMain.TabIndex = 0;
            // 
            // AppointmentsGridView
            // 
            this.AppointmentsGridView.AllowUserToAddRows = false;
            this.AppointmentsGridView.AllowUserToDeleteRows = false;
            this.AppointmentsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.AppointmentsGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AppointmentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsGridView.ContextMenuStrip = this.contextMenuStripAppointments;
            this.AppointmentsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AppointmentsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(137)))));
            this.AppointmentsGridView.Location = new System.Drawing.Point(0, 493);
            this.AppointmentsGridView.Margin = new System.Windows.Forms.Padding(0);
            this.AppointmentsGridView.MultiSelect = false;
            this.AppointmentsGridView.Name = "AppointmentsGridView";
            this.AppointmentsGridView.ReadOnly = true;
            this.AppointmentsGridView.RowHeadersVisible = false;
            this.AppointmentsGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentsGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.AppointmentsGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.AppointmentsGridView.RowTemplate.Height = 25;
            this.AppointmentsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentsGridView.Size = new System.Drawing.Size(706, 212);
            this.AppointmentsGridView.TabIndex = 9;
            this.AppointmentsGridView.SelectionChanged += new System.EventHandler(this.AppointmentsGridView_SelectionChanged);
            // 
            // contextMenuStripAppointments
            // 
            this.contextMenuStripAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStripAppointments.Name = "contextMenuStripAppointments";
            this.contextMenuStripAppointments.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStripAppointments.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripAppointments_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // ButtonAddTestAppointment
            // 
            this.ButtonAddTestAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddTestAppointment.FlatAppearance.BorderSize = 0;
            this.ButtonAddTestAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonAddTestAppointment.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddTestAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonAddTestAppointment.IconChar = FontAwesome.Sharp.IconChar.Cuttlefish;
            this.ButtonAddTestAppointment.IconColor = System.Drawing.Color.Black;
            this.ButtonAddTestAppointment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonAddTestAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonAddTestAppointment.Location = new System.Drawing.Point(645, 458);
            this.ButtonAddTestAppointment.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAddTestAppointment.Name = "ButtonAddTestAppointment";
            this.ButtonAddTestAppointment.Size = new System.Drawing.Size(44, 31);
            this.ButtonAddTestAppointment.TabIndex = 8;
            this.ButtonAddTestAppointment.UseVisualStyleBackColor = true;
            this.ButtonAddTestAppointment.Click += new System.EventHandler(this.ButtonAddTestAppointment_Click);
            // 
            // LabelAppointments
            // 
            this.LabelAppointments.AutoSize = true;
            this.LabelAppointments.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppointments.Location = new System.Drawing.Point(15, 460);
            this.LabelAppointments.Name = "LabelAppointments";
            this.LabelAppointments.Size = new System.Drawing.Size(144, 25);
            this.LabelAppointments.TabIndex = 7;
            this.LabelAppointments.Text = "Appointments:";
            // 
            // GroupBoxApplicationInfo
            // 
            this.GroupBoxApplicationInfo.Controls.Add(this.ButtonShowPersonInfo);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelCreatedByValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelCreatedBy);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelStatusDateValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelStatusDate);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelApplicantValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelApplicant);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelTypeValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelType);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelFeesValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelFees);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelStatusValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelStatus);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelDateValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelDate);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelApplicationIDValue);
            this.GroupBoxApplicationInfo.Controls.Add(this.LabelApplicationID);
            this.GroupBoxApplicationInfo.Location = new System.Drawing.Point(16, 239);
            this.GroupBoxApplicationInfo.Name = "GroupBoxApplicationInfo";
            this.GroupBoxApplicationInfo.Size = new System.Drawing.Size(673, 216);
            this.GroupBoxApplicationInfo.TabIndex = 6;
            this.GroupBoxApplicationInfo.TabStop = false;
            this.GroupBoxApplicationInfo.Text = "Application Basic Info";
            // 
            // ButtonShowPersonInfo
            // 
            this.ButtonShowPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ButtonShowPersonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowPersonInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowPersonInfo.ForeColor = System.Drawing.Color.White;
            this.ButtonShowPersonInfo.Location = new System.Drawing.Point(506, 165);
            this.ButtonShowPersonInfo.Name = "ButtonShowPersonInfo";
            this.ButtonShowPersonInfo.Size = new System.Drawing.Size(161, 43);
            this.ButtonShowPersonInfo.TabIndex = 18;
            this.ButtonShowPersonInfo.Text = "Show Person Info";
            this.ButtonShowPersonInfo.UseVisualStyleBackColor = false;
            this.ButtonShowPersonInfo.Click += new System.EventHandler(this.ButtonShowPersonInfo_Click);
            // 
            // LabelCreatedByValue
            // 
            this.LabelCreatedByValue.AutoSize = true;
            this.LabelCreatedByValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreatedByValue.Location = new System.Drawing.Point(499, 94);
            this.LabelCreatedByValue.Name = "LabelCreatedByValue";
            this.LabelCreatedByValue.Size = new System.Drawing.Size(71, 21);
            this.LabelCreatedByValue.TabIndex = 17;
            this.LabelCreatedByValue.Text = "No User";
            // 
            // LabelCreatedBy
            // 
            this.LabelCreatedBy.AutoSize = true;
            this.LabelCreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCreatedBy.Location = new System.Drawing.Point(403, 94);
            this.LabelCreatedBy.Name = "LabelCreatedBy";
            this.LabelCreatedBy.Size = new System.Drawing.Size(92, 21);
            this.LabelCreatedBy.TabIndex = 16;
            this.LabelCreatedBy.Text = "CreatedBy:";
            // 
            // LabelStatusDateValue
            // 
            this.LabelStatusDateValue.AutoSize = true;
            this.LabelStatusDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatusDateValue.Location = new System.Drawing.Point(499, 58);
            this.LabelStatusDateValue.Name = "LabelStatusDateValue";
            this.LabelStatusDateValue.Size = new System.Drawing.Size(96, 21);
            this.LabelStatusDateValue.TabIndex = 15;
            this.LabelStatusDateValue.Text = "00/00/0000";
            // 
            // LabelStatusDate
            // 
            this.LabelStatusDate.AutoSize = true;
            this.LabelStatusDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatusDate.Location = new System.Drawing.Point(403, 58);
            this.LabelStatusDate.Name = "LabelStatusDate";
            this.LabelStatusDate.Size = new System.Drawing.Size(101, 21);
            this.LabelStatusDate.TabIndex = 14;
            this.LabelStatusDate.Text = "Status Date:";
            // 
            // LabelApplicantValue
            // 
            this.LabelApplicantValue.AutoSize = true;
            this.LabelApplicantValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicantValue.Location = new System.Drawing.Point(126, 176);
            this.LabelApplicantValue.Name = "LabelApplicantValue";
            this.LabelApplicantValue.Size = new System.Drawing.Size(83, 21);
            this.LabelApplicantValue.TabIndex = 13;
            this.LabelApplicantValue.Text = "No Name";
            // 
            // LabelApplicant
            // 
            this.LabelApplicant.AutoSize = true;
            this.LabelApplicant.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicant.Location = new System.Drawing.Point(6, 176);
            this.LabelApplicant.Name = "LabelApplicant";
            this.LabelApplicant.Size = new System.Drawing.Size(92, 21);
            this.LabelApplicant.TabIndex = 12;
            this.LabelApplicant.Text = "Applicant: ";
            // 
            // LabelTypeValue
            // 
            this.LabelTypeValue.AutoSize = true;
            this.LabelTypeValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTypeValue.Location = new System.Drawing.Point(126, 136);
            this.LabelTypeValue.Name = "LabelTypeValue";
            this.LabelTypeValue.Size = new System.Drawing.Size(52, 21);
            this.LabelTypeValue.TabIndex = 11;
            this.LabelTypeValue.Text = "None";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelType.Location = new System.Drawing.Point(6, 136);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(50, 21);
            this.LabelType.TabIndex = 10;
            this.LabelType.Text = "Type:";
            // 
            // LabelFeesValue
            // 
            this.LabelFeesValue.AutoSize = true;
            this.LabelFeesValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFeesValue.Location = new System.Drawing.Point(126, 94);
            this.LabelFeesValue.Name = "LabelFeesValue";
            this.LabelFeesValue.Size = new System.Drawing.Size(19, 21);
            this.LabelFeesValue.TabIndex = 9;
            this.LabelFeesValue.Text = "0";
            // 
            // LabelFees
            // 
            this.LabelFees.AutoSize = true;
            this.LabelFees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFees.Location = new System.Drawing.Point(6, 94);
            this.LabelFees.Name = "LabelFees";
            this.LabelFees.Size = new System.Drawing.Size(47, 21);
            this.LabelFees.TabIndex = 8;
            this.LabelFees.Text = "Fees:";
            // 
            // LabelStatusValue
            // 
            this.LabelStatusValue.AutoSize = true;
            this.LabelStatusValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatusValue.Location = new System.Drawing.Point(126, 58);
            this.LabelStatusValue.Name = "LabelStatusValue";
            this.LabelStatusValue.Size = new System.Drawing.Size(52, 21);
            this.LabelStatusValue.TabIndex = 7;
            this.LabelStatusValue.Text = "None";
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(6, 58);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(61, 21);
            this.LabelStatus.TabIndex = 6;
            this.LabelStatus.Text = "Status:";
            // 
            // LabelDateValue
            // 
            this.LabelDateValue.AutoSize = true;
            this.LabelDateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDateValue.Location = new System.Drawing.Point(499, 27);
            this.LabelDateValue.Name = "LabelDateValue";
            this.LabelDateValue.Size = new System.Drawing.Size(96, 21);
            this.LabelDateValue.TabIndex = 5;
            this.LabelDateValue.Text = "00/00/0000";
            // 
            // LabelDate
            // 
            this.LabelDate.AutoSize = true;
            this.LabelDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDate.Location = new System.Drawing.Point(403, 27);
            this.LabelDate.Name = "LabelDate";
            this.LabelDate.Size = new System.Drawing.Size(50, 21);
            this.LabelDate.TabIndex = 4;
            this.LabelDate.Text = "Date:";
            // 
            // LabelApplicationIDValue
            // 
            this.LabelApplicationIDValue.AutoSize = true;
            this.LabelApplicationIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationIDValue.Location = new System.Drawing.Point(127, 27);
            this.LabelApplicationIDValue.Name = "LabelApplicationIDValue";
            this.LabelApplicationIDValue.Size = new System.Drawing.Size(25, 21);
            this.LabelApplicationIDValue.TabIndex = 1;
            this.LabelApplicationIDValue.Text = "-1";
            // 
            // LabelApplicationID
            // 
            this.LabelApplicationID.AutoSize = true;
            this.LabelApplicationID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApplicationID.Location = new System.Drawing.Point(6, 27);
            this.LabelApplicationID.Name = "LabelApplicationID";
            this.LabelApplicationID.Size = new System.Drawing.Size(128, 21);
            this.LabelApplicationID.TabIndex = 0;
            this.LabelApplicationID.Text = "Application ID: ";
            // 
            // GroupBoxLDLApplicationInfo
            // 
            this.GroupBoxLDLApplicationInfo.Controls.Add(this.LabelPassedTestsValue);
            this.GroupBoxLDLApplicationInfo.Controls.Add(this.LabelPassedTests);
            this.GroupBoxLDLApplicationInfo.Controls.Add(this.LabelAppliedLicenseValue);
            this.GroupBoxLDLApplicationInfo.Controls.Add(this.LabelAppliedLicense);
            this.GroupBoxLDLApplicationInfo.Controls.Add(this.LabelLDLAppIDValue);
            this.GroupBoxLDLApplicationInfo.Controls.Add(this.LabelLDLAppID);
            this.GroupBoxLDLApplicationInfo.Location = new System.Drawing.Point(16, 159);
            this.GroupBoxLDLApplicationInfo.Name = "GroupBoxLDLApplicationInfo";
            this.GroupBoxLDLApplicationInfo.Size = new System.Drawing.Size(673, 81);
            this.GroupBoxLDLApplicationInfo.TabIndex = 3;
            this.GroupBoxLDLApplicationInfo.TabStop = false;
            this.GroupBoxLDLApplicationInfo.Text = "Driving License Application Info";
            // 
            // LabelPassedTestsValue
            // 
            this.LabelPassedTestsValue.AutoSize = true;
            this.LabelPassedTestsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassedTestsValue.Location = new System.Drawing.Point(116, 53);
            this.LabelPassedTestsValue.Name = "LabelPassedTestsValue";
            this.LabelPassedTestsValue.Size = new System.Drawing.Size(43, 21);
            this.LabelPassedTestsValue.TabIndex = 5;
            this.LabelPassedTestsValue.Text = "0 / 3";
            // 
            // LabelPassedTests
            // 
            this.LabelPassedTests.AutoSize = true;
            this.LabelPassedTests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassedTests.Location = new System.Drawing.Point(6, 53);
            this.LabelPassedTests.Name = "LabelPassedTests";
            this.LabelPassedTests.Size = new System.Drawing.Size(111, 21);
            this.LabelPassedTests.TabIndex = 4;
            this.LabelPassedTests.Text = "Passed Tests: ";
            // 
            // LabelAppliedLicenseValue
            // 
            this.LabelAppliedLicenseValue.AutoSize = true;
            this.LabelAppliedLicenseValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppliedLicenseValue.Location = new System.Drawing.Point(389, 27);
            this.LabelAppliedLicenseValue.Name = "LabelAppliedLicenseValue";
            this.LabelAppliedLicenseValue.Size = new System.Drawing.Size(93, 21);
            this.LabelAppliedLicenseValue.TabIndex = 3;
            this.LabelAppliedLicenseValue.Text = "No License";
            // 
            // LabelAppliedLicense
            // 
            this.LabelAppliedLicense.AutoSize = true;
            this.LabelAppliedLicense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAppliedLicense.Location = new System.Drawing.Point(249, 27);
            this.LabelAppliedLicense.Name = "LabelAppliedLicense";
            this.LabelAppliedLicense.Size = new System.Drawing.Size(134, 21);
            this.LabelAppliedLicense.TabIndex = 2;
            this.LabelAppliedLicense.Text = "Applied License:";
            // 
            // LabelLDLAppIDValue
            // 
            this.LabelLDLAppIDValue.AutoSize = true;
            this.LabelLDLAppIDValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLDLAppIDValue.Location = new System.Drawing.Point(168, 27);
            this.LabelLDLAppIDValue.Name = "LabelLDLAppIDValue";
            this.LabelLDLAppIDValue.Size = new System.Drawing.Size(25, 21);
            this.LabelLDLAppIDValue.TabIndex = 1;
            this.LabelLDLAppIDValue.Text = "-1";
            // 
            // LabelLDLAppID
            // 
            this.LabelLDLAppID.AutoSize = true;
            this.LabelLDLAppID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLDLAppID.Location = new System.Drawing.Point(6, 27);
            this.LabelLDLAppID.Name = "LabelLDLAppID";
            this.LabelLDLAppID.Size = new System.Drawing.Size(156, 21);
            this.LabelLDLAppID.TabIndex = 0;
            this.LabelLDLAppID.Text = "LDL Application ID:";
            // 
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.AutoSize = true;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblLoginWelcome.Location = new System.Drawing.Point(153, 11);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(475, 43);
            this.lblLoginWelcome.TabIndex = 2;
            this.lblLoginWelcome.Text = "Vision Test Appointments";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.pbCloseCard);
            this.panelHeader.Controls.Add(this.LabelTestType);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(706, 45);
            this.panelHeader.TabIndex = 22;
            // 
            // pbCloseCard
            // 
            this.pbCloseCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseCard.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseCard.Image")));
            this.pbCloseCard.Location = new System.Drawing.Point(670, 0);
            this.pbCloseCard.Name = "pbCloseCard";
            this.pbCloseCard.Size = new System.Drawing.Size(37, 43);
            this.pbCloseCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloseCard.TabIndex = 17;
            this.pbCloseCard.TabStop = false;
            this.pbCloseCard.Click += new System.EventHandler(this.pbCloseCard_Click);
            // 
            // LabelTestType
            // 
            this.LabelTestType.AutoSize = true;
            this.LabelTestType.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTestType.ForeColor = System.Drawing.Color.White;
            this.LabelTestType.Location = new System.Drawing.Point(3, 3);
            this.LabelTestType.Name = "LabelTestType";
            this.LabelTestType.Size = new System.Drawing.Size(229, 32);
            this.LabelTestType.TabIndex = 15;
            this.LabelTestType.Text = "Test Appointments";
            // 
            // TestAppointmentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TestAppointmentCard";
            this.Size = new System.Drawing.Size(706, 592);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsGridView)).EndInit();
            this.contextMenuStripAppointments.ResumeLayout(false);
            this.GroupBoxApplicationInfo.ResumeLayout(false);
            this.GroupBoxApplicationInfo.PerformLayout();
            this.GroupBoxLDLApplicationInfo.ResumeLayout(false);
            this.GroupBoxLDLApplicationInfo.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox GroupBoxLDLApplicationInfo;
        private System.Windows.Forms.Label LabelLDLAppID;
        private System.Windows.Forms.Label lblLoginWelcome;
        private System.Windows.Forms.Label LabelPassedTestsValue;
        private System.Windows.Forms.Label LabelPassedTests;
        private System.Windows.Forms.Label LabelAppliedLicenseValue;
        private System.Windows.Forms.Label LabelAppliedLicense;
        private System.Windows.Forms.Label LabelLDLAppIDValue;
        private System.Windows.Forms.GroupBox GroupBoxApplicationInfo;
        private System.Windows.Forms.Label LabelStatusValue;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.Label LabelDateValue;
        private System.Windows.Forms.Label LabelDate;
        private System.Windows.Forms.Label LabelApplicationIDValue;
        private System.Windows.Forms.Label LabelApplicationID;
        private System.Windows.Forms.Label LabelStatusDateValue;
        private System.Windows.Forms.Label LabelStatusDate;
        private System.Windows.Forms.Label LabelApplicantValue;
        private System.Windows.Forms.Label LabelApplicant;
        private System.Windows.Forms.Label LabelTypeValue;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelFeesValue;
        private System.Windows.Forms.Label LabelFees;
        private System.Windows.Forms.Label LabelCreatedByValue;
        private System.Windows.Forms.Label LabelCreatedBy;
        private System.Windows.Forms.Label LabelAppointments;
        private System.Windows.Forms.Button ButtonShowPersonInfo;
        private FontAwesome.Sharp.IconButton ButtonAddTestAppointment;
        private System.Windows.Forms.DataGridView AppointmentsGridView;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbCloseCard;
        private System.Windows.Forms.Label LabelTestType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAppointments;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}
