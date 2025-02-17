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
            this.sideCardPanel = new System.Windows.Forms.Panel();
            this.btnRemoveImage = new System.Windows.Forms.Button();
            this.btnChangeImage = new System.Windows.Forms.Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.mainCardPanel = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.grbPersonDetails = new System.Windows.Forms.GroupBox();
            this.cmbCountryList = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtNationalNo = new System.Windows.Forms.TextBox();
            this.lblPeopleNationalID = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPeopleAddress = new System.Windows.Forms.Label();
            this.lblPeopleEmail = new System.Windows.Forms.Label();
            this.lblPeoplePhone = new System.Windows.Forms.Label();
            this.lblPeopleGender = new System.Windows.Forms.Label();
            this.lblPeopleBirthDate = new System.Windows.Forms.Label();
            this.lblPeopleCountry = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.sideCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            this.mainCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            this.grbPersonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // sideCardPanel
            // 
            this.sideCardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sideCardPanel.Controls.Add(this.btnRemoveImage);
            this.sideCardPanel.Controls.Add(this.btnChangeImage);
            this.sideCardPanel.Controls.Add(this.lblPersonID);
            this.sideCardPanel.Controls.Add(this.btnDeletePerson);
            this.sideCardPanel.Controls.Add(this.pbPersonImage);
            this.sideCardPanel.Controls.Add(this.btnEditPerson);
            this.sideCardPanel.Location = new System.Drawing.Point(0, 0);
            this.sideCardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideCardPanel.Name = "sideCardPanel";
            this.sideCardPanel.Size = new System.Drawing.Size(267, 401);
            this.sideCardPanel.TabIndex = 0;
            this.sideCardPanel.TabStop = true;
            // 
            // btnRemoveImage
            // 
            this.btnRemoveImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnRemoveImage.FlatAppearance.BorderSize = 0;
            this.btnRemoveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveImage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveImage.ForeColor = System.Drawing.Color.White;
            this.btnRemoveImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveImage.Location = new System.Drawing.Point(153, 223);
            this.btnRemoveImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveImage.Name = "btnRemoveImage";
            this.btnRemoveImage.Size = new System.Drawing.Size(78, 26);
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
            this.btnChangeImage.Location = new System.Drawing.Point(42, 223);
            this.btnChangeImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeImage.Name = "btnChangeImage";
            this.btnChangeImage.Size = new System.Drawing.Size(73, 26);
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
            this.lblPersonID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(16, 367);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(116, 25);
            this.lblPersonID.TabIndex = 15;
            this.lblPersonID.Text = "PERSON ID:";
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeletePerson.FlatAppearance.BorderSize = 0;
            this.btnDeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePerson.ForeColor = System.Drawing.Color.White;
            this.btnDeletePerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePerson.Location = new System.Drawing.Point(69, 320);
            this.btnDeletePerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(128, 37);
            this.btnDeletePerson.TabIndex = 14;
            this.btnDeletePerson.TabStop = false;
            this.btnDeletePerson.Text = "DELETE";
            this.btnDeletePerson.UseVisualStyleBackColor = false;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.ErrorImage = global::DVLD_UI.Properties.Resources.DVLD_Error_Photo;
            this.pbPersonImage.InitialImage = null;
            this.pbPersonImage.Location = new System.Drawing.Point(5, 0);
            this.pbPersonImage.Margin = new System.Windows.Forms.Padding(0);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(256, 256);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPersonImage.TabIndex = 0;
            this.pbPersonImage.TabStop = false;
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditPerson.FlatAppearance.BorderSize = 0;
            this.btnEditPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPerson.ForeColor = System.Drawing.Color.White;
            this.btnEditPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPerson.Location = new System.Drawing.Point(69, 268);
            this.btnEditPerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(128, 37);
            this.btnEditPerson.TabIndex = 13;
            this.btnEditPerson.TabStop = false;
            this.btnEditPerson.Text = "EDIT";
            this.btnEditPerson.UseVisualStyleBackColor = false;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // mainCardPanel
            // 
            this.mainCardPanel.BackColor = System.Drawing.Color.White;
            this.mainCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCardPanel.Controls.Add(this.pbCloseCard);
            this.mainCardPanel.Controls.Add(this.btnReset);
            this.mainCardPanel.Controls.Add(this.btnSavePerson);
            this.mainCardPanel.Controls.Add(this.txtLastName);
            this.mainCardPanel.Controls.Add(this.txtFirstName);
            this.mainCardPanel.Controls.Add(this.grbPersonDetails);
            this.mainCardPanel.Location = new System.Drawing.Point(267, 0);
            this.mainCardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainCardPanel.Name = "mainCardPanel";
            this.mainCardPanel.Size = new System.Drawing.Size(530, 400);
            this.mainCardPanel.TabIndex = 1;
            this.mainCardPanel.TabStop = true;
            // 
            // pbCloseCard
            // 
            this.pbCloseCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCloseCard.Image = ((System.Drawing.Image)(resources.GetObject("pbCloseCard.Image")));
            this.pbCloseCard.Location = new System.Drawing.Point(492, -1);
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
            this.btnReset.Location = new System.Drawing.Point(134, 351);
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
            this.btnSavePerson.Location = new System.Drawing.Point(281, 351);
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
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLastName.Location = new System.Drawing.Point(257, 12);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLastName.MaxLength = 20;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(162, 43);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider.SetIconAlignment(this.txtFirstName, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.txtFirstName.Location = new System.Drawing.Point(83, 12);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(162, 43);
            this.txtFirstName.TabIndex = 0;
            // 
            // grbPersonDetails
            // 
            this.grbPersonDetails.Controls.Add(this.cmbCountryList);
            this.grbPersonDetails.Controls.Add(this.cmbGender);
            this.grbPersonDetails.Controls.Add(this.dtpBirthDate);
            this.grbPersonDetails.Controls.Add(this.txtNationalNo);
            this.grbPersonDetails.Controls.Add(this.lblPeopleNationalID);
            this.grbPersonDetails.Controls.Add(this.txtAddress);
            this.grbPersonDetails.Controls.Add(this.txtEmail);
            this.grbPersonDetails.Controls.Add(this.txtPhone);
            this.grbPersonDetails.Controls.Add(this.lblPeopleAddress);
            this.grbPersonDetails.Controls.Add(this.lblPeopleEmail);
            this.grbPersonDetails.Controls.Add(this.lblPeoplePhone);
            this.grbPersonDetails.Controls.Add(this.lblPeopleGender);
            this.grbPersonDetails.Controls.Add(this.lblPeopleBirthDate);
            this.grbPersonDetails.Controls.Add(this.lblPeopleCountry);
            this.grbPersonDetails.Location = new System.Drawing.Point(59, 61);
            this.grbPersonDetails.Name = "grbPersonDetails";
            this.grbPersonDetails.Size = new System.Drawing.Size(411, 281);
            this.grbPersonDetails.TabIndex = 16;
            this.grbPersonDetails.TabStop = false;
            this.grbPersonDetails.Text = "People Details";
            // 
            // cmbCountryList
            // 
            this.cmbCountryList.Enabled = false;
            this.cmbCountryList.FormattingEnabled = true;
            this.cmbCountryList.Location = new System.Drawing.Point(145, 57);
            this.cmbCountryList.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCountryList.Name = "cmbCountryList";
            this.cmbCountryList.Size = new System.Drawing.Size(191, 29);
            this.cmbCountryList.TabIndex = 18;
            // 
            // cmbGender
            // 
            this.cmbGender.Enabled = false;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(145, 121);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(191, 29);
            this.cmbGender.TabIndex = 6;
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Enabled = false;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(145, 89);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(191, 29);
            this.dtpBirthDate.TabIndex = 5;
            // 
            // txtNationalNo
            // 
            this.txtNationalNo.Enabled = false;
            this.txtNationalNo.Location = new System.Drawing.Point(145, 25);
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
            this.lblPeopleNationalID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleNationalID.Location = new System.Drawing.Point(18, 28);
            this.lblPeopleNationalID.Name = "lblPeopleNationalID";
            this.lblPeopleNationalID.Size = new System.Drawing.Size(100, 21);
            this.lblPeopleNationalID.TabIndex = 17;
            this.lblPeopleNationalID.Text = "NationalNo";
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(145, 220);
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
            this.txtEmail.Location = new System.Drawing.Point(145, 185);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.MaxLength = 20;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(145, 153);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(191, 29);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPeopleAddress
            // 
            this.lblPeopleAddress.AutoSize = true;
            this.lblPeopleAddress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleAddress.Location = new System.Drawing.Point(18, 220);
            this.lblPeopleAddress.Name = "lblPeopleAddress";
            this.lblPeopleAddress.Size = new System.Drawing.Size(70, 21);
            this.lblPeopleAddress.TabIndex = 11;
            this.lblPeopleAddress.Text = "Address";
            // 
            // lblPeopleEmail
            // 
            this.lblPeopleEmail.AutoSize = true;
            this.lblPeopleEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleEmail.Location = new System.Drawing.Point(18, 188);
            this.lblPeopleEmail.Name = "lblPeopleEmail";
            this.lblPeopleEmail.Size = new System.Drawing.Size(53, 21);
            this.lblPeopleEmail.TabIndex = 10;
            this.lblPeopleEmail.Text = "Email";
            // 
            // lblPeoplePhone
            // 
            this.lblPeoplePhone.AutoSize = true;
            this.lblPeoplePhone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeoplePhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeoplePhone.Location = new System.Drawing.Point(18, 156);
            this.lblPeoplePhone.Name = "lblPeoplePhone";
            this.lblPeoplePhone.Size = new System.Drawing.Size(59, 21);
            this.lblPeoplePhone.TabIndex = 9;
            this.lblPeoplePhone.Text = "Phone";
            // 
            // lblPeopleGender
            // 
            this.lblPeopleGender.AutoSize = true;
            this.lblPeopleGender.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleGender.Location = new System.Drawing.Point(18, 124);
            this.lblPeopleGender.Name = "lblPeopleGender";
            this.lblPeopleGender.Size = new System.Drawing.Size(65, 21);
            this.lblPeopleGender.TabIndex = 8;
            this.lblPeopleGender.Text = "Gender";
            // 
            // lblPeopleBirthDate
            // 
            this.lblPeopleBirthDate.AutoSize = true;
            this.lblPeopleBirthDate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleBirthDate.Location = new System.Drawing.Point(18, 92);
            this.lblPeopleBirthDate.Name = "lblPeopleBirthDate";
            this.lblPeopleBirthDate.Size = new System.Drawing.Size(87, 21);
            this.lblPeopleBirthDate.TabIndex = 7;
            this.lblPeopleBirthDate.Text = "Birth Date";
            // 
            // lblPeopleCountry
            // 
            this.lblPeopleCountry.AutoSize = true;
            this.lblPeopleCountry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblPeopleCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeopleCountry.Location = new System.Drawing.Point(18, 60);
            this.lblPeopleCountry.Name = "lblPeopleCountry";
            this.lblPeopleCountry.Size = new System.Drawing.Size(72, 21);
            this.lblPeopleCountry.TabIndex = 6;
            this.lblPeopleCountry.Text = "Country";
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
            this.Controls.Add(this.mainCardPanel);
            this.Controls.Add(this.sideCardPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PersonProfileCard";
            this.Size = new System.Drawing.Size(798, 401);
            this.sideCardPanel.ResumeLayout(false);
            this.sideCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            this.mainCardPanel.ResumeLayout(false);
            this.mainCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            this.grbPersonDetails.ResumeLayout(false);
            this.grbPersonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideCardPanel;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Panel mainCardPanel;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.GroupBox grbPersonDetails;
        private System.Windows.Forms.Button btnDeletePerson;
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
    }
}
