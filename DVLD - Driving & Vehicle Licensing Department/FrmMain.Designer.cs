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
            this.contextMenuStripMainDataView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTestTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.contextMenuUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApplications = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPeoples = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.filterOptionsUC = new DVLD_UI.UserControls.FilterUC();
            this.iconButtonAdd = new FontAwesome.Sharp.IconButton();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.contextMenuStripApplicationMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.applicationTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.contextMenuStripMainDataView.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.contextMenuUserOptions.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelMainMenu.SuspendLayout();
            this.contextMenuStripApplicationMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.mainGridView);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMain.Location = new System.Drawing.Point(0, 196);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(5);
            this.panelMain.Size = new System.Drawing.Size(1184, 565);
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
            this.mainGridView.ContextMenuStrip = this.contextMenuStripMainDataView;
            this.mainGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(137)))));
            this.mainGridView.Location = new System.Drawing.Point(5, 5);
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
            this.mainGridView.Size = new System.Drawing.Size(1174, 555);
            this.mainGridView.TabIndex = 1;
            this.mainGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGridView_CellContentDoubleClick);
            this.mainGridView.SelectionChanged += new System.EventHandler(this.mainGridView_SelectionChanged);
            // 
            // contextMenuStripMainDataView
            // 
            this.contextMenuStripMainDataView.Font = new System.Drawing.Font("Roboto", 12F);
            this.contextMenuStripMainDataView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDetails,
            this.toolStripSeparator,
            this.toolStripMenuEdit,
            this.toolStripMenuDelete});
            this.contextMenuStripMainDataView.Name = "contextMenuStripPeople";
            this.contextMenuStripMainDataView.Size = new System.Drawing.Size(128, 82);
            this.contextMenuStripMainDataView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMainDataVeiw_Opening);
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
            this.editPersonToolStripMenuItem,
            this.editApplicationTypeToolStripMenuItem,
            this.editTestTypeToolStripMenuItem});
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(127, 24);
            this.toolStripMenuEdit.Text = "Edit";
            this.toolStripMenuEdit.Click += new System.EventHandler(this.toolStripMenuIPeopleEdit_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.editUserToolStripMenuItem.Text = "User";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // editPersonToolStripMenuItem
            // 
            this.editPersonToolStripMenuItem.Name = "editPersonToolStripMenuItem";
            this.editPersonToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.editPersonToolStripMenuItem.Text = "Person";
            this.editPersonToolStripMenuItem.Click += new System.EventHandler(this.editPersonToolStripMenuItem_Click);
            // 
            // editApplicationTypeToolStripMenuItem
            // 
            this.editApplicationTypeToolStripMenuItem.Name = "editApplicationTypeToolStripMenuItem";
            this.editApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.editApplicationTypeToolStripMenuItem.Text = "Application Type";
            this.editApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.editApplicationTypeToolStripMenuItem_Click);
            // 
            // editTestTypeToolStripMenuItem
            // 
            this.editTestTypeToolStripMenuItem.Name = "editTestTypeToolStripMenuItem";
            this.editTestTypeToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.editTestTypeToolStripMenuItem.Text = "Test Type";
            this.editTestTypeToolStripMenuItem.Click += new System.EventHandler(this.editTestTypeToolStripMenuItem_Click);
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
            this.panelHeader.Controls.Add(this.pbCloseCard);
            this.panelHeader.Controls.Add(this.pbUserPicture);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1184, 71);
            this.panelHeader.TabIndex = 1;
            // 
            // pbCloseCard
            // 
            this.pbCloseCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseCard.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseCard.Image")));
            this.pbCloseCard.Location = new System.Drawing.Point(1135, 12);
            this.pbCloseCard.Name = "pbCloseCard";
            this.pbCloseCard.Size = new System.Drawing.Size(37, 40);
            this.pbCloseCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloseCard.TabIndex = 18;
            this.pbCloseCard.TabStop = false;
            this.pbCloseCard.Click += new System.EventHandler(this.pbCloseCard_Click);
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.ContextMenuStrip = this.contextMenuUserOptions;
            this.pbUserPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUserPicture.ErrorImage = global::DVLD_UI.Properties.Resources.DVLD_Drivers;
            this.pbUserPicture.Image = global::DVLD_UI.Properties.Resources.DVLD_Drivers;
            this.pbUserPicture.InitialImage = global::DVLD_UI.Properties.Resources.DVLD_Drivers;
            this.pbUserPicture.Location = new System.Drawing.Point(9, 9);
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
            this.btnApplications.Location = new System.Drawing.Point(39, 5);
            this.btnApplications.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(215, 50);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.Text = "APPLICATIONS";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            this.btnApplications.MouseHover += new System.EventHandler(this.btnApplications_MouseHover);
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
            this.btnUsers.Location = new System.Drawing.Point(912, 5);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(215, 50);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "USERS";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
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
            this.btnPeoples.Location = new System.Drawing.Point(621, 5);
            this.btnPeoples.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeoples.Name = "btnPeoples";
            this.btnPeoples.Size = new System.Drawing.Size(215, 50);
            this.btnPeoples.TabIndex = 0;
            this.btnPeoples.Text = "PEOPLES";
            this.btnPeoples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeoples.UseVisualStyleBackColor = false;
            this.btnPeoples.Click += new System.EventHandler(this.btnPeoples_Click);
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
            this.btnDrivers.Location = new System.Drawing.Point(330, 5);
            this.btnDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(215, 50);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "DRIVERS";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelSubMenu.Controls.Add(this.filterOptionsUC);
            this.panelSubMenu.Controls.Add(this.iconButtonAdd);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 131);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(1184, 65);
            this.panelSubMenu.TabIndex = 2;
            // 
            // filterOptionsUC
            // 
            this.filterOptionsUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOptionsUC.Location = new System.Drawing.Point(39, 1);
            this.filterOptionsUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterOptionsUC.Name = "filterOptionsUC";
            this.filterOptionsUC.Size = new System.Drawing.Size(478, 64);
            this.filterOptionsUC.TabIndex = 3;
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
            this.iconButtonAdd.Location = new System.Drawing.Point(1061, 13);
            this.iconButtonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonAdd.Name = "iconButtonAdd";
            this.iconButtonAdd.Size = new System.Drawing.Size(66, 40);
            this.iconButtonAdd.TabIndex = 2;
            this.iconButtonAdd.UseVisualStyleBackColor = true;
            this.iconButtonAdd.Click += new System.EventHandler(this.iconButtonAdd_Click);
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.White;
            this.panelMainMenu.Controls.Add(this.btnPeoples);
            this.panelMainMenu.Controls.Add(this.btnApplications);
            this.panelMainMenu.Controls.Add(this.btnDrivers);
            this.panelMainMenu.Controls.Add(this.btnUsers);
            this.panelMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainMenu.Location = new System.Drawing.Point(0, 71);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(1184, 60);
            this.panelMainMenu.TabIndex = 3;
            // 
            // contextMenuStripApplicationMenu
            // 
            this.contextMenuStripApplicationMenu.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStripApplicationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationTypesToolStripMenuItem,
            this.testTypesToolStripMenuItem});
            this.contextMenuStripApplicationMenu.Name = "contextMenuStripApplicationMenu";
            this.contextMenuStripApplicationMenu.Size = new System.Drawing.Size(205, 52);
            // 
            // applicationTypesToolStripMenuItem
            // 
            this.applicationTypesToolStripMenuItem.Name = "applicationTypesToolStripMenuItem";
            this.applicationTypesToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.applicationTypesToolStripMenuItem.Text = "Application Types";
            this.applicationTypesToolStripMenuItem.Click += new System.EventHandler(this.applicationTypesToolStripMenuItem_Click);
            // 
            // testTypesToolStripMenuItem
            // 
            this.testTypesToolStripMenuItem.Name = "testTypesToolStripMenuItem";
            this.testTypesToolStripMenuItem.Size = new System.Drawing.Size(204, 24);
            this.testTypesToolStripMenuItem.Text = "Test Types";
            this.testTypesToolStripMenuItem.Click += new System.EventHandler(this.testTypesToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelSubMenu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1184, 761);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD V1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.contextMenuStripMainDataView.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.contextMenuUserOptions.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelMainMenu.ResumeLayout(false);
            this.contextMenuStripApplicationMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMainDataView;
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
        private System.Windows.Forms.PictureBox pbCloseCard;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelMainMenu;
        private FontAwesome.Sharp.IconButton iconButtonAdd;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationTypeToolStripMenuItem;
        private UserControls.FilterUC filterOptionsUC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripApplicationMenu;
        private System.Windows.Forms.ToolStripMenuItem applicationTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTestTypeToolStripMenuItem;
    }
}
