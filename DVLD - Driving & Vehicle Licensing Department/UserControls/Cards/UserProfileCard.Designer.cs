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
            this.grpUserPassword = new System.Windows.Forms.GroupBox();
            this.txtConfimPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.grbPersonDetails = new System.Windows.Forms.GroupBox();
            this.lblEmailValue = new System.Windows.Forms.Label();
            this.lblPhoneValue = new System.Windows.Forms.Label();
            this.lblUserNameValue = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnUserEditPerson = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMain.SuspendLayout();
            this.grpUserPassword.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            this.grbPersonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.grpUserPassword);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.grbPersonDetails);
            this.panelMain.Controls.Add(this.pbPersonImage);
            this.panelMain.Controls.Add(this.btnUserEditPerson);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(905, 502);
            this.panelMain.TabIndex = 2;
            this.panelMain.TabStop = true;
            // 
            // grpUserPassword
            // 
            this.grpUserPassword.Controls.Add(this.txtConfimPassword);
            this.grpUserPassword.Controls.Add(this.lblConfirmNewPassword);
            this.grpUserPassword.Controls.Add(this.txtNewPassword);
            this.grpUserPassword.Controls.Add(this.txtOldPassword);
            this.grpUserPassword.Controls.Add(this.lblNewPassword);
            this.grpUserPassword.Controls.Add(this.lblOldPassword);
            this.grpUserPassword.Location = new System.Drawing.Point(432, 247);
            this.grpUserPassword.Name = "grpUserPassword";
            this.grpUserPassword.Size = new System.Drawing.Size(421, 153);
            this.grpUserPassword.TabIndex = 21;
            this.grpUserPassword.TabStop = false;
            this.grpUserPassword.Text = "Password Details: ";
            // 
            // txtConfimPassword
            // 
            this.txtConfimPassword.Location = new System.Drawing.Point(213, 96);
            this.txtConfimPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfimPassword.MaxLength = 20;
            this.txtConfimPassword.Name = "txtConfimPassword";
            this.txtConfimPassword.Size = new System.Drawing.Size(191, 29);
            this.txtConfimPassword.TabIndex = 11;
            this.txtConfimPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(17, 96);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(175, 25);
            this.lblConfirmNewPassword.TabIndex = 12;
            this.lblConfirmNewPassword.Text = "Confirm Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(213, 63);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(191, 29);
            this.txtNewPassword.TabIndex = 8;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(213, 28);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtOldPassword.MaxLength = 20;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(191, 29);
            this.txtOldPassword.TabIndex = 7;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(17, 63);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(142, 25);
            this.lblNewPassword.TabIndex = 10;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOldPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.Location = new System.Drawing.Point(17, 31);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(133, 25);
            this.lblOldPassword.TabIndex = 9;
            this.lblOldPassword.Text = "Old Password";
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
            // grbPersonDetails
            // 
            this.grbPersonDetails.Controls.Add(this.lblEmailValue);
            this.grbPersonDetails.Controls.Add(this.lblPhoneValue);
            this.grbPersonDetails.Controls.Add(this.lblUserNameValue);
            this.grbPersonDetails.Controls.Add(this.lblFullNameValue);
            this.grbPersonDetails.Controls.Add(this.btnReset);
            this.grbPersonDetails.Controls.Add(this.lblUsername);
            this.grbPersonDetails.Controls.Add(this.btnSave);
            this.grbPersonDetails.Controls.Add(this.lblFullName);
            this.grbPersonDetails.Controls.Add(this.lblEmail);
            this.grbPersonDetails.Controls.Add(this.lblPhone);
            this.grbPersonDetails.Location = new System.Drawing.Point(432, 68);
            this.grbPersonDetails.Name = "grbPersonDetails";
            this.grbPersonDetails.Size = new System.Drawing.Size(421, 392);
            this.grbPersonDetails.TabIndex = 16;
            this.grbPersonDetails.TabStop = false;
            this.grbPersonDetails.Text = "User Details: ";
            // 
            // lblEmailValue
            // 
            this.lblEmailValue.AutoSize = true;
            this.lblEmailValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmailValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblEmailValue.Location = new System.Drawing.Point(149, 137);
            this.lblEmailValue.Name = "lblEmailValue";
            this.lblEmailValue.Size = new System.Drawing.Size(0, 28);
            this.lblEmailValue.TabIndex = 21;
            // 
            // lblPhoneValue
            // 
            this.lblPhoneValue.AutoSize = true;
            this.lblPhoneValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPhoneValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPhoneValue.Location = new System.Drawing.Point(149, 99);
            this.lblPhoneValue.Name = "lblPhoneValue";
            this.lblPhoneValue.Size = new System.Drawing.Size(0, 28);
            this.lblPhoneValue.TabIndex = 21;
            // 
            // lblUserNameValue
            // 
            this.lblUserNameValue.AutoSize = true;
            this.lblUserNameValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUserNameValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUserNameValue.Location = new System.Drawing.Point(149, 61);
            this.lblUserNameValue.Name = "lblUserNameValue";
            this.lblUserNameValue.Size = new System.Drawing.Size(0, 28);
            this.lblUserNameValue.TabIndex = 21;
            // 
            // lblFullNameValue
            // 
            this.lblFullNameValue.AutoSize = true;
            this.lblFullNameValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFullNameValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFullNameValue.Location = new System.Drawing.Point(149, 25);
            this.lblFullNameValue.Name = "lblFullNameValue";
            this.lblFullNameValue.Size = new System.Drawing.Size(0, 28);
            this.lblFullNameValue.TabIndex = 21;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(49, 342);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 37);
            this.btnReset.TabIndex = 11;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(17, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 28);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "User Name:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(244, 342);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 37);
            this.btnSave.TabIndex = 12;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(17, 25);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(113, 28);
            this.lblFullName.TabIndex = 19;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 25);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(17, 102);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 25);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone:";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.ErrorImage = global::DVLD_UI.Properties.Resources.DVLD_Error_Photo;
            this.pbPersonImage.InitialImage = global::DVLD_UI.Properties.Resources.DVLD_Default_Photo;
            this.pbPersonImage.Location = new System.Drawing.Point(49, 90);
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
            this.btnUserEditPerson.Location = new System.Drawing.Point(98, 410);
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
            this.Size = new System.Drawing.Size(905, 502);
            this.Load += new System.EventHandler(this.UserProfileCard_Load);
            this.panelMain.ResumeLayout(false);
            this.grpUserPassword.ResumeLayout(false);
            this.grpUserPassword.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            this.grbPersonDetails.ResumeLayout(false);
            this.grbPersonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbCloseCard;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grbPersonDetails;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.GroupBox grpUserPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtConfimPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Label lblEmailValue;
        private System.Windows.Forms.Label lblPhoneValue;
        private System.Windows.Forms.Label lblUserNameValue;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Button btnUserEditPerson;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
