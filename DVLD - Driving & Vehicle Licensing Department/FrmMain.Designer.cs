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
            this.mainGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStripMainDataVeiw = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuPeopleCardShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorPeople = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuIPeopleEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPeopleDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbUserPicture = new System.Windows.Forms.PictureBox();
            this.btnApplications = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnPeoples = new System.Windows.Forms.Button();
            this.btnDrivers = new System.Windows.Forms.Button();
            this.contextMenuUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).BeginInit();
            this.contextMenuStripMainDataVeiw.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            this.contextMenuUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelMain.Controls.Add(this.mainGridView);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMain.Location = new System.Drawing.Point(0, 133);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1184, 628);
            this.panelMain.TabIndex = 1;
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
            this.mainGridView.Location = new System.Drawing.Point(0, 61);
            this.mainGridView.Margin = new System.Windows.Forms.Padding(0);
            this.mainGridView.Name = "mainGridView";
            this.mainGridView.ReadOnly = true;
            this.mainGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainGridView.Size = new System.Drawing.Size(1184, 567);
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
            // pbUserPicture
            // 
            this.pbUserPicture.ContextMenuStrip = this.contextMenuUserOptions;
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
            // btnApplications
            // 
            this.btnApplications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnApplications.FlatAppearance.BorderSize = 0;
            this.btnApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplications.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnApplications.Image = global::DVLD_UI.Properties.Resources.DVLD_Applications_32;
            this.btnApplications.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplications.Location = new System.Drawing.Point(46, 77);
            this.btnApplications.Margin = new System.Windows.Forms.Padding(0);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.Size = new System.Drawing.Size(215, 50);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.Text = "APPLICATIONS";
            this.btnApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplications.UseVisualStyleBackColor = false;
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
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
            this.btnUsers.Location = new System.Drawing.Point(919, 77);
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
            this.btnPeoples.FlatAppearance.BorderSize = 0;
            this.btnPeoples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeoples.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeoples.ForeColor = System.Drawing.Color.White;
            this.btnPeoples.Image = global::DVLD_UI.Properties.Resources.DVLD_Peoples_32;
            this.btnPeoples.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPeoples.Location = new System.Drawing.Point(628, 77);
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
            this.btnDrivers.FlatAppearance.BorderSize = 0;
            this.btnDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrivers.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.Image = global::DVLD_UI.Properties.Resources.DVLD_Drivers_32;
            this.btnDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDrivers.Location = new System.Drawing.Point(337, 77);
            this.btnDrivers.Margin = new System.Windows.Forms.Padding(0);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.Size = new System.Drawing.Size(215, 50);
            this.btnDrivers.TabIndex = 0;
            this.btnDrivers.Text = "DRIVERS";
            this.btnDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrivers.UseVisualStyleBackColor = false;
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // contextMenuUserOptions
            // 
            this.contextMenuUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.contextMenuUserOptions.Name = "contextMenuUserOptions";
            this.contextMenuUserOptions.Size = new System.Drawing.Size(169, 76);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.btnApplications);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPeoples);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnDrivers);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD V1.0";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainGridView)).EndInit();
            this.contextMenuStripMainDataVeiw.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            this.contextMenuUserOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView mainGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMainDataVeiw;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleCardShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIPeopleEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleDelete;
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
    }
}

