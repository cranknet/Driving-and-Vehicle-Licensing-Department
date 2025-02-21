namespace DVLD_UI.UserControls.Cards
{
    partial class PersonProfileCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonProfileCard));
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.grbPersonDetails = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cmbCountryList = new System.Windows.Forms.ComboBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.lblPeopleNationalID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblPeopleAddress = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPeopleEmail = new System.Windows.Forms.Label();
            this.lblPeoplePhone = new System.Windows.Forms.Label();
            this.lblPeopleGender = new System.Windows.Forms.Label();
            this.lblPeopleBirthDate = new System.Windows.Forms.Label();
            this.lblPeopleCountry = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            this.grbPersonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveImage.Location = new System.Drawing.Point(250, 357);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(90, 32);
            this.btnRemoveImage.TabIndex = 16;
            this.btnRemoveImage.Text = "REMOVE";
            this.btnRemoveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveImage.UseVisualStyleBackColor = false;
            this.btnRemoveImage.Visible = false;
            this.btnRemoveImage.Click += new System.EventHandler(this.btnRemoveImage_Click);
            // 
            // btnChangeImage
            // 
            this.btnChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnChangeImage.FlatAppearance.BorderSize = 0;
            this.btnChangeImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeImage.ForeColor = System.Drawing.Color.White;
            this.btnChangeImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeImage.Location = new System.Drawing.Point(40, 357);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(90, 32);
            this.btnChangeImage.TabIndex = 10;
            this.btnChangeImage.Text = "CHANGE";
            this.btnChangeImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeImage.UseVisualStyleBackColor = false;
            this.btnChangeImage.Visible = false;
            this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(3, 3);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(148, 32);
            this.lblPersonID.TabIndex = 15;
            this.lblPersonID.Text = "PERSON ID:";
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.ErrorImage = global::DVLD_UI.Properties.Resources.DVLD_Error_Photo;
            this.pbPersonImage.InitialImage = global::DVLD_UI.Properties.Resources.DVLD_Default_Photo;
            this.pbPersonImage.Location = new System.Drawing.Point(40, 90);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(300, 300);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 0;
            this.pbPersonImage.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.btnChangeImage);
            this.panelMain.Controls.Add(this.btnReset);
            this.panelMain.Controls.Add(this.btnRemoveImage);
            this.panelMain.Controls.Add(this.btnSavePerson);
            this.panelMain.Controls.Add(this.grbPersonDetails);
            this.panelMain.Controls.Add(this.pbPersonImage);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(905, 502);
            this.panelMain.TabIndex = 1;
            this.panelMain.TabStop = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.pbCloseCard);
            this.panelHeader.Controls.Add(this.lblPersonID);
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
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(40, 426);
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
            // btnSavePerson
            // 
            this.btnSavePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSavePerson.FlatAppearance.BorderSize = 0;
            this.btnSavePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePerson.ForeColor = System.Drawing.Color.White;
            this.btnSavePerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavePerson.Location = new System.Drawing.Point(212, 426);
            this.btnSavePerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(128, 37);
            this.btnSavePerson.TabIndex = 12;
            this.btnSavePerson.TabStop = false;
            this.btnSavePerson.Text = "SAVE";
            this.btnSavePerson.UseVisualStyleBackColor = false;
            this.btnSavePerson.Visible = false;
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // grbPersonDetails
            // 
            this.grbPersonDetails.Controls.Add(this.lblLastName);
            this.grbPersonDetails.Controls.Add(this.cmbCountryList);
            this.grbPersonDetails.Controls.Add(this.lblFirstName);
            this.grbPersonDetails.Controls.Add(this.cmbGender);
            this.grbPersonDetails.Controls.Add(this.dtpBirthDate);
            this.grbPersonDetails.Controls.Add(this.txtNationalNo);
            this.grbPersonDetails.Controls.Add(this.lblPeopleNationalID);
            this.grbPersonDetails.Controls.Add(this.txtAddress);
            this.grbPersonDetails.Controls.Add(this.txtEmail);
            this.grbPersonDetails.Controls.Add(this.txtPhone);
            this.grbPersonDetails.Controls.Add(this.txtLastName);
            this.grbPersonDetails.Controls.Add(this.lblPeopleAddress);
            this.grbPersonDetails.Controls.Add(this.txtFirstName);
            this.grbPersonDetails.Controls.Add(this.lblPeopleEmail);
            this.grbPersonDetails.Controls.Add(this.lblPeoplePhone);
            this.grbPersonDetails.Controls.Add(this.lblPeopleGender);
            this.grbPersonDetails.Controls.Add(this.lblPeopleBirthDate);
            this.grbPersonDetails.Controls.Add(this.lblPeopleCountry);
            this.grbPersonDetails.Location = new System.Drawing.Point(423, 68);
            this.grbPersonDetails.Name = "grbPersonDetails";
            this.grbPersonDetails.Size = new System.Drawing.Size(421, 395);
            this.grbPersonDetails.TabIndex = 16;
            this.grbPersonDetails.TabStop = false;
            this.grbPersonDetails.Text = "Person Details: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(226, 35);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 28);
            this.lblLastName.TabIndex = 20;
            this.lblLastName.Text = "LastName";
            // 
            // cmbCountryList
            // 
            this.cmbCountryList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountryList.Enabled = false;
            this.cmbCountryList.FormattingEnabled = true;
            this.cmbCountryList.Location = new System.Drawing.Point(181, 169);
            this.cmbCountryList.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCountryList.Name = "cmbCountryList";
            this.cmbCountryList.Size = new System.Drawing.Size(191, 29);
            this.cmbCountryList.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(16, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(109, 28);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Text = "FirstName";
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Enabled = false;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(181, 233);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(191, 29);
            this.cmbGender.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Enabled = false;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(181, 201);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(191, 29);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Enabled = false;
            this.txtNationalNo.Location = new System.Drawing.Point(181, 137);
            this.txtNationalNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtNationalNo.MaxLength = 20;
            this.txtNationalNo.Name = "txtNationalNo";
            this.txtNationalNo.Size = new System.Drawing.Size(191, 29);
            this.txtNationalNo.TabIndex = 3;
            this.txtNationalNo.Leave += new System.EventHandler(this.textBoxNationalNo_Leave);
            // 
            // lblPeopleNationalID
            // 
            this.lblPeopleNationalID.AutoSize = true;
            this.lblPeopleNationalID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleNationalID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleNationalID.Location = new System.Drawing.Point(45, 141);
            this.lblPeopleNationalID.Name = "lblPeopleNationalID";
            this.lblPeopleNationalID.Size = new System.Drawing.Size(115, 25);
            this.lblPeopleNationalID.TabIndex = 17;
            this.lblPeopleNationalID.Text = "NationalNo";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(181, 332);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(191, 51);
            this.txtAddress.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(181, 297);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(181, 265);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(191, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastName.Location = new System.Drawing.Point(231, 82);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(162, 28);
            this.txtLastName.TabIndex = 2;
            // 
            // lblPeopleAddress
            // 
            this.lblPeopleAddress.AutoSize = true;
            this.lblPeopleAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleAddress.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleAddress.Location = new System.Drawing.Point(45, 332);
            this.lblPeopleAddress.Name = "lblPeopleAddress";
            this.lblPeopleAddress.Size = new System.Drawing.Size(83, 25);
            this.lblPeopleAddress.TabIndex = 11;
            this.lblPeopleAddress.Text = "Address";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider.SetIconAlignment(this.txtFirstName, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtFirstName.Location = new System.Drawing.Point(21, 82);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(162, 28);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblPeopleEmail
            // 
            this.lblPeopleEmail.AutoSize = true;
            this.lblPeopleEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleEmail.Location = new System.Drawing.Point(45, 300);
            this.lblPeopleEmail.Name = "lblPeopleEmail";
            this.lblPeopleEmail.Size = new System.Drawing.Size(59, 25);
            this.lblPeopleEmail.TabIndex = 10;
            this.lblPeopleEmail.Text = "Email";
            // 
            // lblPeoplePhone
            // 
            this.lblPeoplePhone.AutoSize = true;
            this.lblPeoplePhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeoplePhone.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeoplePhone.Location = new System.Drawing.Point(45, 268);
            this.lblPeoplePhone.Name = "lblPeoplePhone";
            this.lblPeoplePhone.Size = new System.Drawing.Size(69, 25);
            this.lblPeoplePhone.TabIndex = 9;
            this.lblPeoplePhone.Text = "Phone";
            // 
            // lblPeopleGender
            // 
            this.lblPeopleGender.AutoSize = true;
            this.lblPeopleGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleGender.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleGender.Location = new System.Drawing.Point(45, 236);
            this.lblPeopleGender.Name = "lblPeopleGender";
            this.lblPeopleGender.Size = new System.Drawing.Size(78, 25);
            this.lblPeopleGender.TabIndex = 8;
            this.lblPeopleGender.Text = "Gender";
            // 
            // lblPeopleBirthDate
            // 
            this.lblPeopleBirthDate.AutoSize = true;
            this.lblPeopleBirthDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleBirthDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleBirthDate.Location = new System.Drawing.Point(45, 204);
            this.lblPeopleBirthDate.Name = "lblPeopleBirthDate";
            this.lblPeopleBirthDate.Size = new System.Drawing.Size(102, 25);
            this.lblPeopleBirthDate.TabIndex = 7;
            this.lblPeopleBirthDate.Text = "Birth Date";
            // 
            // lblPeopleCountry
            // 
            this.lblPeopleCountry.AutoSize = true;
            this.lblPeopleCountry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleCountry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleCountry.Location = new System.Drawing.Point(45, 173);
            this.lblPeopleCountry.Name = "lblPeopleCountry";
            this.lblPeopleCountry.Size = new System.Drawing.Size(138, 25);
            this.lblPeopleCountry.TabIndex = 6;
            this.lblPeopleCountry.Text = "CountryName";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // PersonProfileCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PersonProfileCard";
            this.Size = new System.Drawing.Size(905, 503);
            this.Load += new System.EventHandler(this.PersonProfileCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            this.grbPersonDetails.ResumeLayout(false);
            this.grbPersonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox grbPersonDetails;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblPeopleCountry;
        private System.Windows.Forms.Label lblPeopleBirthDate;
        private System.Windows.Forms.Label lblPeopleEmail;
        private System.Windows.Forms.Label lblPeoplePhone;
        private System.Windows.Forms.Label lblPeopleGender;
        private System.Windows.Forms.Label lblPeopleAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNationalNo;
        private System.Windows.Forms.Label lblPeopleNationalID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnChangeImage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSavePerson;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.PictureBox pbCloseCard;
        private System.Windows.Forms.Button btnRemoveImage;
        private System.Windows.Forms.ComboBox cmbCountryList;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
    }
}
