namespace DVLD_UI
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripUsersPeoples = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.contextMenuUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.btnPeoples = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.contextMenuStripApplicationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drivingLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripLDLApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.schuedeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleVisionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWritingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleDrivingTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicense1stTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonHistoryLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterOptionsUC = new DVLD_UI.UserControls.FilterUC();
            this.contextMenuStripTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.contextMenuStripUsersPeoples.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.contextMenuUserOptions.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.contextMenuStripApplicationMenu.SuspendLayout();
            this.contextMenuStripLDLApplication.SuspendLayout();
            this.contextMenuStripApplicationTypes.SuspendLayout();
            this.contextMenuStripTestTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.mainGridView);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMain.Location = new System.Drawing.Point(0, 130);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(5);
            this.panelMain.Size = new System.Drawing.Size(1184, 592);
            this.panelMain.TabIndex = 1;
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.mainGridView.BackgroundColor = System.Drawing.Color.White;
            this.mainGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(137)))));
            this.mainGridView.Location = new System.Drawing.Point(5, 0);
            this.mainGridView.Margin = new System.Windows.Forms.Padding(0);
            this.mainGridView.MultiSelect = false;
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.RowHeadersVisible = false;
            this.mainGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.mainGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.mainGridView.RowTemplate.Height = 25;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(1174, 587);
            this.mainGridView.TabIndex = 1;
            this.mainGridView.SelectionChanged += new System.EventHandler(this.mainGridView_SelectionChanged);
            // 
            // contextMenuStripUsersPeoples
            // 
            this.contextMenuStripUsersPeoples.Font = new System.Drawing.Font("Roboto", 12F);
            this.contextMenuStripUsersPeoples.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDetails,
            this.toolStripSeparator,
            this.toolStripMenuEdit,
            this.toolStripMenuDelete});
            this.contextMenuStripUsersPeoples.Name = "contextMenuStripPeople";
            this.contextMenuStripUsersPeoples.Size = new System.Drawing.Size(128, 82);
            this.contextMenuStripUsersPeoples.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMainDataView_Opening);
            // 
            // toolStripMenuDetails
            // 
            this.toolStripMenuDetails.Name = "toolStripMenuDetails";
            this.toolStripMenuDetails.Size = new System.Drawing.Size(127, 24);
            this.toolStripMenuDetails.Text = "Details";
            this.toolStripMenuDetails.Click += new System.EventHandler(this.toolStripMenuPeopleCardShow_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(124, 6);
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUserToolStripMenuItem,
            this.editPersonToolStripMenuItem});
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(127, 24);
            this.toolStripMenuEdit.Text = "Edit";
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.editUserToolStripMenuItem.Text = "User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.editPersonToolStripMenuItem.Text = "Person";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // toolStripMenuDelete
            // 
            this.toolStripMenuDelete.Name = "toolStripMenuDelete";
            this.toolStripMenuDelete.Size = new System.Drawing.Size(127, 24);
            this.toolStripMenuDelete.Text = "Delete";
            this.toolStripMenuDelete.Click += new System.EventHandler(this.toolStripMenuPeopleDelete_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.pbUserPicture);
            this.panelHeader.Controls.Add(this.panelMainMenu);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1184, 61);
            this.panelHeader.TabIndex = 1;
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.BackColor = System.Drawing.Color.White;
            this.pbUserPicture.ContextMenuStrip = this.contextMenuUserOptions;
            this.pbUserPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserPicture.ErrorImage = global::DVLD_UI.Properties.Resources.DVLD_Drivers;
            this.pbUserPicture.Image = global::DVLD_UI.Properties.Resources.LoggedUser;
            this.pbUserPicture.InitialImage = global::DVLD_UI.Properties.Resources.DVLD_Drivers;
            this.pbUserPicture.Location = new System.Drawing.Point(11, 11);
            this.pbUserPicture.Margin = new System.Windows.Forms.Padding(0);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.Size = new System.Drawing.Size(48, 48);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserPicture.TabIndex = 0;
            this.pbUserPicture.TabStop = false;
            this.pbUserPicture.Click += new System.EventHandler(this.pbUserPicture_Click);
            // 
            // contextMenuUserOptions
            // 
            this.contextMenuUserOptions.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.contextMenuUserOptions.Name = "contextMenuUserOptions";
            this.contextMenuUserOptions.Size = new System.Drawing.Size(172, 82);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.userInfoToolStripMenuItem.Text = "Show Details";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(168, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.changePasswordToolStripMenuItem.Text = "Settings";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.White;
            this.panelMainMenu.Controls.Add(this.btnPeoples);
            this.panelMainMenu.Controls.Add(this.btnApplications);
            this.panelMainMenu.Controls.Add(this.btnDrivers);
            this.panelMainMenu.Controls.Add(this.btnUsers);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1184, 61);
            this.panelMainMenu.TabIndex = 3;
            // 
            // btnPeoples
            // 
            this.btnPeoples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPeoples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeoples.FlatAppearance.BorderSize = 0;
            this.btnPeoples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeoples.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeoples.ForeColor = System.Drawing.Color.White;
            this.btnPeoples.Image = global::DVLD_UI.Properties.Resources.DVLD_Peoples_32;
            this.btnPeoples.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeoples.Location = new System.Drawing.Point(662, 9);
            this.btnPeoples.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeoples.Name = "btnPeoples";
            this.btnPeoples.Size = new System.Drawing.Size(215, 50);
            this.btnPeoples.TabIndex = 0;
            this.btnPeoples.Text = "PEOPLES";
            this.btnPeoples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeoples.UseVisualStyleBackColor = false;
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnApplications.ContextMenuStrip = this.contextMenuUserOptions;
            this.btnApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.Image = global::DVLD_UI.Properties.Resources.DVLD_Applications_32;
            this.btnApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplications.Location = new System.Drawing.Point(80, 9);
            this.btnApplications.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(215, 50);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.Text = "APPLICATIONS";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.MouseHover += new System.EventHandler(this.btnApplications_MouseHover);
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Image = global::DVLD_UI.Properties.Resources.DVLD_Drivers_32;
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrivers.Location = new System.Drawing.Point(371, 9);
            this.btnDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(215, 50);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "DRIVERS";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::DVLD_UI.Properties.Resources.DVLD_Users_32;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.Location = new System.Drawing.Point(953, 9);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(215, 50);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "USERS";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSubMenu.Controls.Add(this.filterOptionsUC);
            this.panelSubMenu.Controls.Add(this.iconButtonAdd);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 61);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(1184, 69);
            this.panelSubMenu.TabIndex = 2;
            // 
            // iconButtonAdd
            // 
            this.iconButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonAdd.FlatAppearance.BorderSize = 0;
            this.iconButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconButtonAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonAdd.IconColor = System.Drawing.Color.Black;
            this.iconButtonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAdd.Location = new System.Drawing.Point(1102, 8);
            this.iconButtonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(66, 54);
            this.iconButtonAdd.TabIndex = 2;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // contextMenuStripApplicationMenu
            // 
            this.contextMenuStripApplicationMenu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripApplicationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.applicationTypesToolStripMenuItem,
            this.testTypesToolStripMenuItem});
            this.contextMenuStripApplicationMenu.Name = "contextMenuStripApplicationMenu";
            this.contextMenuStripApplicationMenu.Size = new System.Drawing.Size(255, 100);
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            this.drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem});
            this.drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            this.drivingLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.drivingLicenseServicesToolStripMenuItem.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(224, 24);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // addLocalLicenseToolStripMenuItem
            // 
            this.addLocalLicenseToolStripMenuItem.Name = "addLocalLicenseToolStripMenuItem";
            this.addLocalLicenseToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.addLocalLicenseToolStripMenuItem.Text = "Local License";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicensesToolStripMenuItem,
            this.internationalLicensesToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localLicensesToolStripMenuItem
            // 
            this.localLicensesToolStripMenuItem.Name = "localLicensesToolStripMenuItem";
            this.localLicensesToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.localLicensesToolStripMenuItem.Text = "Local Licenses";
            // 
            // internationalLicensesToolStripMenuItem
            // 
            this.internationalLicensesToolStripMenuItem.Name = "internationalLicensesToolStripMenuItem";
            this.internationalLicensesToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.internationalLicensesToolStripMenuItem.Text = "International Licenses";
            // 
            // applicationTypesToolStripMenuItem
            // 
            this.applicationTypesToolStripMenuItem.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationTypesToolStripMenuItem.Name = "applicationTypesToolStripMenuItem";
            this.applicationTypesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.applicationTypesToolStripMenuItem.Text = "Application Types";
            // 
            // testTypesToolStripMenuItem
            // 
            this.testTypesToolStripMenuItem.Name = "testTypesToolStripMenuItem";
            this.testTypesToolStripMenuItem.Size = new System.Drawing.Size(254, 24);
            this.testTypesToolStripMenuItem.Text = "Test Types";
            // 
            // contextMenuStripLDLApplication
            // 
            this.contextMenuStripLDLApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetailsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem4,
            this.schuedeleToolStripMenuItem,
            this.toolStripMenuItem5,
            this.issueDrivingLicense1stTimeToolStripMenuItem,
            this.toolStripMenuItem6,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.showPersonHistoryLicensesToolStripMenuItem});
            this.contextMenuStripLDLApplication.Name = "contextMenuStripApplicationGridView";
            this.contextMenuStripLDLApplication.Size = new System.Drawing.Size(240, 222);
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            this.showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            this.showApplicationDetailsToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(236, 6);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(236, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(236, 6);
            // 
            // schuedeleToolStripMenuItem
            // 
            this.schuedeleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleVisionTestToolStripMenuItem,
            this.scheduleWritingTestToolStripMenuItem,
            this.scheduleDrivingTestToolStripMenuItem});
            this.schuedeleToolStripMenuItem.Name = "schuedeleToolStripMenuItem";
            this.schuedeleToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.schuedeleToolStripMenuItem.Text = "Schedule Test";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            this.scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            this.scheduleVisionTestToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            // 
            // scheduleWritingTestToolStripMenuItem
            // 
            this.scheduleWritingTestToolStripMenuItem.Name = "scheduleWritingTestToolStripMenuItem";
            this.scheduleWritingTestToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.scheduleWritingTestToolStripMenuItem.Text = "Schedule Writing Test";
            // 
            // scheduleDrivingTestToolStripMenuItem
            // 
            this.scheduleDrivingTestToolStripMenuItem.Name = "scheduleDrivingTestToolStripMenuItem";
            this.scheduleDrivingTestToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.scheduleDrivingTestToolStripMenuItem.Text = "Schedule Driving Test";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(236, 6);
            // 
            // issueDrivingLicense1stTimeToolStripMenuItem
            // 
            this.issueDrivingLicense1stTimeToolStripMenuItem.Name = "issueDrivingLicense1stTimeToolStripMenuItem";
            this.issueDrivingLicense1stTimeToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.issueDrivingLicense1stTimeToolStripMenuItem.Text = "Issue Driving License (1st Time)";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(236, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(236, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(236, 6);
            // 
            // showPersonHistoryLicensesToolStripMenuItem
            // 
            this.showPersonHistoryLicensesToolStripMenuItem.Name = "showPersonHistoryLicensesToolStripMenuItem";
            this.showPersonHistoryLicensesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.showPersonHistoryLicensesToolStripMenuItem.Text = "Show Person License History";
            // 
            // contextMenuStripApplicationTypes
            // 
            this.contextMenuStripApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editApplicationTypeToolStripMenuItem});
            this.contextMenuStripApplicationTypes.Name = "contextMenuStripApplicationTypesGridView";
            this.contextMenuStripApplicationTypes.Size = new System.Drawing.Size(161, 26);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.editApplicationTypeToolStripMenuItem.Text = "Edit Type Details";
            // 
            // filterOptionsUC
            // 
            this.filterOptionsUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOptionsUC.Location = new System.Drawing.Point(80, 8);
            this.filterOptionsUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterOptionsUC.Name = "filterOptionsUC";
            this.filterOptionsUC.Size = new System.Drawing.Size(522, 54);
            this.filterOptionsUC.TabIndex = 3;
            // 
            // contextMenuStripTestTypes
            // 
            this.contextMenuStripTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTestTypeToolStripMenuItem});
            this.contextMenuStripTestTypes.Name = "contextMenuStripTestTypes";
            this.contextMenuStripTestTypes.Size = new System.Drawing.Size(147, 26);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editTestTypeToolStripMenuItem.Text = "Edit Test Type";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 722);
            this.Controls.Add(this.panelSubMenu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD V1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.contextMenuStripUsersPeoples.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.contextMenuUserOptions.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.contextMenuStripApplicationMenu.ResumeLayout(false);
            this.contextMenuStripLDLApplication.ResumeLayout(false);
            this.contextMenuStripApplicationTypes.ResumeLayout(false);
            this.contextMenuStripTestTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripUsersPeoples;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDelete;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnPeoples;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.PictureBox pbUserPicture;
        private System.Windows.Forms.ContextMenuStrip contextMenuUserOptions;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelMainMenu;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private UserControls.FilterUC filterOptionsUC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripApplicationMenu;
        private System.Windows.Forms.ToolStripMenuItem applicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicensesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLDLApplication;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem schuedeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWritingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleDrivingTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicense1stTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem showPersonHistoryLicensesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTestTypes;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}
