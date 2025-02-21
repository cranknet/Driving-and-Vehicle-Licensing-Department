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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelFilterOptions = new System.Windows.Forms.Panel();
            this.cmbFilterOptions = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripMainDataVeiw = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuPeopleCardShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorPeople = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuIPeopleEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPeopleDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbExitApplication = new System.Windows.Forms.PictureBox();
            this.pictureMainLogo = new System.Windows.Forms.PictureBox();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.btnPeoples = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnApplications = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.subMenuControl = new DVLD_UI.UserControls.SubItems.SubMenuControl();
            this.panelMain.SuspendLayout();
            this.panelFilterOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.contextMenuStripMainDataVeiw.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExitApplication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panelFilterOptions);
            this.panelMain.Controls.Add(this.mainGridView);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(267, 107);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(917, 654);
            this.panelMain.TabIndex = 1;
            // 
            // panelFilterOptions
            // 
            this.panelFilterOptions.Controls.Add(this.cmbFilterOptions);
            this.panelFilterOptions.Controls.Add(this.lblFilter);
            this.panelFilterOptions.Controls.Add(this.txtFilterValue);
            this.panelFilterOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterOptions.Location = new System.Drawing.Point(0, 0);
            this.panelFilterOptions.Name = "panelFilterOptions";
            this.panelFilterOptions.Size = new System.Drawing.Size(917, 46);
            this.panelFilterOptions.TabIndex = 5;
            // 
            // cmbFilterOptions
            // 
            this.cmbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterOptions.FormattingEnabled = true;
            this.cmbFilterOptions.Location = new System.Drawing.Point(302, 9);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Size = new System.Drawing.Size(158, 29);
            this.cmbFilterOptions.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(230, 11);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 25);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(475, 9);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(212, 29);
            this.txtFilterValue.TabIndex = 3;
            this.txtFilterValue.Visible = false;
            // 
            // mainGridView
            // 
            this.mainGridView.AllowUserToAddRows = false;
            this.mainGridView.AllowUserToDeleteRows = false;
            this.mainGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainGridView.BackgroundColor = System.Drawing.Color.White;
            this.mainGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainGridView.ContextMenuStrip = this.contextMenuStripMainDataVeiw;
            this.mainGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainGridView.GridColor = System.Drawing.Color.White;
            this.mainGridView.Location = new System.Drawing.Point(0, 49);
            this.mainGridView.Margin = new System.Windows.Forms.Padding(0);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(917, 605);
            this.mainGridView.TabIndex = 1;
            this.mainGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mainGridView_CellContentDoubleClick);
            this.mainGridView.CurrentCellChanged += new System.EventHandler(this.mainGridView_CurrentCellChanged);
            // 
            // contextMenuStripMainDataVeiw
            // 
            this.contextMenuStripMainDataVeiw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuPeopleCardShow,
            this.toolStripSeparatorPeople,
            this.toolStripMenuIPeopleEdit,
            this.toolStripMenuPeopleDelete});
            this.contextMenuStripMainDataVeiw.Name = "contextMenuStripPeople";
            this.contextMenuStripMainDataVeiw.Size = new System.Drawing.Size(110, 76);
            // 
            // toolStripMenuPeopleCardShow
            // 
            this.toolStripMenuPeopleCardShow.Name = "toolStripMenuPeopleCardShow";
            this.toolStripMenuPeopleCardShow.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuPeopleCardShow.Text = "Details";
            this.toolStripMenuPeopleCardShow.Click += new System.EventHandler(this.toolStripMenuPeopleCardShow_Click);
            // 
            // toolStripSeparatorPeople
            // 
            this.toolStripSeparatorPeople.Name = "toolStripSeparatorPeople";
            this.toolStripSeparatorPeople.Size = new System.Drawing.Size(106, 6);
            // 
            // toolStripMenuIPeopleEdit
            // 
            this.toolStripMenuIPeopleEdit.Name = "toolStripMenuIPeopleEdit";
            this.toolStripMenuIPeopleEdit.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuIPeopleEdit.Text = "Edit";
            this.toolStripMenuIPeopleEdit.Click += new System.EventHandler(this.toolStripMenuIPeopleEdit_Click);
            // 
            // toolStripMenuPeopleDelete
            // 
            this.toolStripMenuPeopleDelete.Name = "toolStripMenuPeopleDelete";
            this.toolStripMenuPeopleDelete.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuPeopleDelete.Text = "Delete";
            this.toolStripMenuPeopleDelete.Click += new System.EventHandler(this.toolStripMenuPeopleDelete_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.pbExitApplication);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(267, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(917, 50);
            this.panelHeader.TabIndex = 1;
            // 
            // pbExitApplication
            // 
            this.pbExitApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExitApplication.Image = ((System.Drawing.Image)(resources.GetObject("pbExitApplication.Image")));
            this.pbExitApplication.Location = new System.Drawing.Point(877, 5);
            this.pbExitApplication.Name = "pbExitApplication";
            this.pbExitApplication.Size = new System.Drawing.Size(37, 40);
            this.pbExitApplication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExitApplication.TabIndex = 0;
            this.pbExitApplication.TabStop = false;
            this.pbExitApplication.Click += new System.EventHandler(this.pbExitApplication_Click);
            // 
            // pictureMainLogo
            // 
            this.pictureMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureMainLogo.Image")));
            this.pictureMainLogo.Location = new System.Drawing.Point(69, 25);
            this.pictureMainLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureMainLogo.Name = "pictureMainLogo";
            this.pictureMainLogo.Size = new System.Drawing.Size(128, 128);
            this.pictureMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMainLogo.TabIndex = 0;
            this.pictureMainLogo.TabStop = false;
            // 
            // btnDrivers
            // 
            this.btnDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Image = global::DVLD_UI.Properties.Resources.DVLD_Drivers_32;
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrivers.Location = new System.Drawing.Point(26, 358);
            this.btnDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(215, 50);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "DRIVERS";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // btnPeoples
            // 
            this.btnPeoples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnPeoples.FlatAppearance.BorderSize = 0;
            this.btnPeoples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeoples.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeoples.ForeColor = System.Drawing.Color.White;
            this.btnPeoples.Image = global::DVLD_UI.Properties.Resources.DVLD_Peoples_32;
            this.btnPeoples.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeoples.Location = new System.Drawing.Point(26, 445);
            this.btnPeoples.Margin = new System.Windows.Forms.Padding(0);
            this.btnPeoples.Name = "btnPeoples";
            this.btnPeoples.Size = new System.Drawing.Size(215, 50);
            this.btnPeoples.TabIndex = 0;
            this.btnPeoples.Text = "PEOPLES";
            this.btnPeoples.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeoples.UseVisualStyleBackColor = false;
            this.btnPeoples.Click += new System.EventHandler(this.btnPeoples_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Image = global::DVLD_UI.Properties.Resources.DVLD_Users_32;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.Location = new System.Drawing.Point(26, 532);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(215, 50);
            this.btnUsers.TabIndex = 0;
            this.btnUsers.Text = "USERS";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.Image = global::DVLD_UI.Properties.Resources.DVLD_UserSettings_32;
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserSettings.Location = new System.Drawing.Point(26, 619);
            this.btnUserSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(215, 50);
            this.btnUserSettings.TabIndex = 0;
            this.btnUserSettings.Text = "USER SETTINGS";
            this.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.UseVisualStyleBackColor = false;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.Image = global::DVLD_UI.Properties.Resources.DVLD_Applications_32;
            this.btnApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplications.Location = new System.Drawing.Point(26, 279);
            this.btnApplications.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(215, 50);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.Text = "APPLICATIONS";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.btnApplications);
            this.panelMenu.Controls.Add(this.btnUserSettings);
            this.panelMenu.Controls.Add(this.btnUsers);
            this.panelMenu.Controls.Add(this.btnPeoples);
            this.panelMenu.Controls.Add(this.btnDrivers);
            this.panelMenu.Controls.Add(this.pictureMainLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 761);
            this.panelMenu.TabIndex = 0;
            // 
            // subMenuControl
            // 
            this.subMenuControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subMenuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subMenuControl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subMenuControl.Location = new System.Drawing.Point(0, 0);
            this.subMenuControl.Margin = new System.Windows.Forms.Padding(0);
            this.subMenuControl.Name = "subMenuControl";
            this.subMenuControl.Size = new System.Drawing.Size(854, 64);
            this.subMenuControl.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD V1.0";
            this.panelMain.ResumeLayout(false);
            this.panelFilterOptions.ResumeLayout(false);
            this.panelFilterOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.contextMenuStripMainDataVeiw.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExitApplication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMainLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbExitApplication;
        private System.Windows.Forms.Panel panelHeader;
        private UserControls.SubItems.SubMenuControl subMenuControl;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMainDataVeiw;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleCardShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIPeopleEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleDelete;
        private System.Windows.Forms.Panel panelFilterOptions;
        private System.Windows.Forms.ComboBox cmbFilterOptions;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.PictureBox pictureMainLogo;
        private System.Windows.Forms.Button btnDrivers;
        private System.Windows.Forms.Button btnPeoples;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnUserSettings;
        private System.Windows.Forms.Button btnApplications;
        private System.Windows.Forms.Panel panelMenu;
    }
}

