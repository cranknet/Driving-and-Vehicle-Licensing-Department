namespace DVLD_UI.UserControls.Cards
{
    partial class UserProfileCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileCard));
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageUserDetails = new System.Windows.Forms.TabPage();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblUserNameValue = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.tabPageUserSettings = new System.Windows.Forms.TabPage();
            this.txtConfimPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tabPageUserAdd = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnUserEditPerson = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            this.tabControlUser.SuspendLayout();
            this.tabPageUserDetails.SuspendLayout();
            this.tabPageUserSettings.SuspendLayout();
            this.tabPageUserAdd.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.tabControlUser);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.btnSave);
            this.panelMain.Controls.Add(this.pbPersonImage);
            this.panelMain.Controls.Add(this.btnUserEditPerson);
            this.panelMain.Controls.Add(this.btnReset);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(905, 479);
            this.panelMain.TabIndex = 2;
            this.panelMain.TabStop = true;
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.tabPageUserDetails);
            this.tabControlUser.Controls.Add(this.tabPageUserSettings);
            this.tabControlUser.Controls.Add(this.tabPageUserAdd);
            this.tabControlUser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlUser.Location = new System.Drawing.Point(366, 48);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(517, 334);
            this.tabControlUser.TabIndex = 22;
            // 
            // tabPageUserDetails
            // 
            this.tabPageUserDetails.Controls.Add(this.lblFullName);
            this.tabPageUserDetails.Controls.Add(this.lblEmailValue);
            this.tabPageUserDetails.Controls.Add(this.lblPhone);
            this.tabPageUserDetails.Controls.Add(this.lblEmail);
            this.tabPageUserDetails.Controls.Add(this.lblPhoneValue);
            this.tabPageUserDetails.Controls.Add(this.lblUsername);
            this.tabPageUserDetails.Controls.Add(this.lblUserNameValue);
            this.tabPageUserDetails.Controls.Add(this.lblFullNameValue);
            this.tabPageUserDetails.Location = new System.Drawing.Point(4, 34);
            this.tabPageUserDetails.Name = "tabPageUserDetails";
            this.tabPageUserDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserDetails.Size = new System.Drawing.Size(509, 296);
            this.tabPageUserDetails.TabIndex = 1;
            this.tabPageUserDetails.Text = "DETAILS";
            this.tabPageUserDetails.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(47, 56);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(127, 28);
            this.lblFullName.TabIndex = 32;
            this.lblFullName.Text = "FULL NAME:";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEmailValue.Location = new System.Drawing.Point(250, 232);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(0, 28);
            this.lblEmailValue.TabIndex = 34;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(47, 176);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 25);
            this.lblPhone.TabIndex = 25;
            this.lblPhone.Text = "PHONE:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(47, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 25);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "EMAIL:";
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPhoneValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPhoneValue.Location = new System.Drawing.Point(250, 173);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(0, 28);
            this.lblPhoneValue.TabIndex = 35;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(47, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(126, 28);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "USERNAME:";
            // 
            // lblUserNameValue
            // 
            this.lblUserNameValue.AutoSize = true;
            this.lblUserNameValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserNameValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUserNameValue.Location = new System.Drawing.Point(250, 120);
            this.lblUserNameValue.Name = "lblUserNameValue";
            this.lblUserNameValue.Size = new System.Drawing.Size(0, 28);
            this.lblUserNameValue.TabIndex = 36;
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFullNameValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFullNameValue.Location = new System.Drawing.Point(250, 56);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(0, 28);
            this.lblFullNameValue.TabIndex = 37;
            // 
            // tabPageUserSettings
            // 
            this.tabPageUserSettings.Controls.Add(this.txtConfimPassword);
            this.tabPageUserSettings.Controls.Add(this.lblConfirmNewPassword);
            this.tabPageUserSettings.Controls.Add(this.txtNewPassword);
            this.tabPageUserSettings.Controls.Add(this.txtOldPassword);
            this.tabPageUserSettings.Controls.Add(this.lblOldPassword);
            this.tabPageUserSettings.Controls.Add(this.lblNewPassword);
            this.tabPageUserSettings.Location = new System.Drawing.Point(4, 34);
            this.tabPageUserSettings.Name = "tabPageUserSettings";
            this.tabPageUserSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserSettings.Size = new System.Drawing.Size(509, 296);
            this.tabPageUserSettings.TabIndex = 2;
            this.tabPageUserSettings.Text = "SETTINGS";
            this.tabPageUserSettings.UseVisualStyleBackColor = true;
            this.tabPageUserSettings.Click += new System.EventHandler(this.tabPageUserSettings_Click);
            // 
            // txtConfimPassword
            // 
            this.txtConfimPassword.Location = new System.Drawing.Point(39, 256);
            this.txtConfimPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfimPassword.MaxLength = 20;
            this.txtConfimPassword.Name = "txtConfimPassword";
            this.txtConfimPassword.Size = new System.Drawing.Size(191, 32);
            this.txtConfimPassword.TabIndex = 36;
            this.txtConfimPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(34, 208);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(209, 25);
            this.lblConfirmNewPassword.TabIndex = 38;
            this.lblConfirmNewPassword.Text = "CONFIRM PASSWORD";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(39, 156);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(191, 32);
            this.txtNewPassword.TabIndex = 33;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(39, 56);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtOldPassword.MaxLength = 20;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(191, 32);
            this.txtOldPassword.TabIndex = 32;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOldPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(34, 8);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(160, 25);
            this.lblOldPassword.TabIndex = 34;
            this.lblOldPassword.Text = "OLD PASSWORD";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(34, 108);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(166, 25);
            this.lblNewPassword.TabIndex = 35;
            this.lblNewPassword.Text = "NEW PASSWORD";
            // 
            // tabPageUserAdd
            // 
            this.tabPageUserAdd.Controls.Add(this.textBox1);
            this.tabPageUserAdd.Controls.Add(this.label1);
            this.tabPageUserAdd.Controls.Add(this.textBox2);
            this.tabPageUserAdd.Controls.Add(this.textBox3);
            this.tabPageUserAdd.Controls.Add(this.label2);
            this.tabPageUserAdd.Controls.Add(this.label3);
            this.tabPageUserAdd.Location = new System.Drawing.Point(4, 34);
            this.tabPageUserAdd.Name = "tabPageUserAdd";
            this.tabPageUserAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUserAdd.Size = new System.Drawing.Size(509, 296);
            this.tabPageUserAdd.TabIndex = 3;
            this.tabPageUserAdd.Text = "ADD USER";
            this.tabPageUserAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 237);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 20;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 45);
            this.textBox1.TabIndex = 43;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "CONFIRM PASSWORD";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 143);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.MaxLength = 20;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 45);
            this.textBox2.TabIndex = 40;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 49);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.MaxLength = 20;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(250, 45);
            this.textBox3.TabIndex = 39;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "USERNAME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "PASSWORD";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.pbCloseCard);
            this.panelHeader.Controls.Add(this.lblUserID);
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
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(3, 3);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(113, 32);
            this.lblUserID.TabIndex = 15;
            this.lblUserID.Text = "USER ID:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(662, 422);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 37);
            this.btnSave.TabIndex = 39;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.ErrorImage = global::DVLD_UI.Properties.Resources.DVLD_Error_Photo;
            this.pbPersonImage.InitialImage = global::DVLD_UI.Properties.Resources.DVLD_Default_Photo;
            this.pbPersonImage.Location = new System.Drawing.Point(48, 82);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(300, 300);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 0;
            this.pbPersonImage.TabStop = false;
            // 
            // btnUserEditPerson
            // 
            this.btnUserEditPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnUserEditPerson.FlatAppearance.BorderSize = 0;
            this.btnUserEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserEditPerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserEditPerson.ForeColor = System.Drawing.Color.White;
            this.btnUserEditPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserEditPerson.Location = new System.Drawing.Point(98, 422);
            this.btnUserEditPerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserEditPerson.Name = "btnUserEditPerson";
            this.btnUserEditPerson.Size = new System.Drawing.Size(187, 37);
            this.btnUserEditPerson.TabIndex = 12;
            this.btnUserEditPerson.TabStop = false;
            this.btnUserEditPerson.Text = "EDIT INFO";
            this.btnUserEditPerson.UseVisualStyleBackColor = false;
            this.btnUserEditPerson.Visible = false;
            this.btnUserEditPerson.Click += new System.EventHandler(this.btnUserEditPerson_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(467, 422);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 37);
            this.btnReset.TabIndex = 37;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // UserProfileCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserProfileCard";
            this.Size = new System.Drawing.Size(905, 479);
            this.Load += new System.EventHandler(this.UserProfileCard_Load);
            this.panelMain.ResumeLayout(false);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageUserDetails.ResumeLayout(false);
            this.tabPageUserDetails.PerformLayout();
            this.tabPageUserSettings.ResumeLayout(false);
            this.tabPageUserSettings.PerformLayout();
            this.tabPageUserAdd.ResumeLayout(false);
            this.tabPageUserAdd.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbCloseCard;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnUserEditPerson;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageUserDetails;
        private System.Windows.Forms.TabPage tabPageUserSettings;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblUserNameValue;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.TextBox txtConfimPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TabPage tabPageUserAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
