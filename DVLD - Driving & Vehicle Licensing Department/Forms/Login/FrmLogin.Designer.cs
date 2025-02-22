namespace DVLD_UI.Login
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblLoginWelcome = new System.Windows.Forms.Label();
            this.pbUsername = new System.Windows.Forms.PictureBox();
            this.pbLoginLogo = new System.Windows.Forms.PictureBox();
            this.pbPassword = new System.Windows.Forms.PictureBox();
            this.panelUsernameSeperator = new System.Windows.Forms.Panel();
            this.panelPasswordSeperator = new System.Windows.Forms.Panel();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginWelcome
            // 
            this.lblLoginWelcome.AutoSize = true;
            this.lblLoginWelcome.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblLoginWelcome.Location = new System.Drawing.Point(115, 231);
            this.lblLoginWelcome.Name = "lblLoginWelcome";
            this.lblLoginWelcome.Size = new System.Drawing.Size(152, 43);
            this.lblLoginWelcome.TabIndex = 0;
            this.lblLoginWelcome.Text = "WELCOME";
            // 
            // pbUsername
            // 
            this.pbUsername.BackColor = System.Drawing.Color.Transparent;
            this.pbUsername.Image = global::DVLD_UI.Properties.Resources.DVLD_Login_Username;
            this.pbUsername.Location = new System.Drawing.Point(53, 319);
            this.pbUsername.Margin = new System.Windows.Forms.Padding(0);
            this.pbUsername.Name = "pbUsername";
            this.pbUsername.Size = new System.Drawing.Size(32, 32);
            this.pbUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsername.TabIndex = 2;
            this.pbUsername.TabStop = false;
            this.pbUsername.Click += new System.EventHandler(this.pbUsername_Click);
            // 
            // pbLoginLogo
            // 
            this.pbLoginLogo.Image = global::DVLD_UI.Properties.Resources.DVLD_Main_Logo_Bright_Blue;
            this.pbLoginLogo.Location = new System.Drawing.Point(141, 64);
            this.pbLoginLogo.Name = "pbLoginLogo";
            this.pbLoginLogo.Size = new System.Drawing.Size(128, 128);
            this.pbLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoginLogo.TabIndex = 0;
            this.pbLoginLogo.TabStop = false;
            // 
            // pbPassword
            // 
            this.pbPassword.BackColor = System.Drawing.Color.Transparent;
            this.pbPassword.Image = global::DVLD_UI.Properties.Resources.DVLD_Login_Password;
            this.pbPassword.Location = new System.Drawing.Point(53, 389);
            this.pbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.pbPassword.Name = "pbPassword";
            this.pbPassword.Size = new System.Drawing.Size(32, 32);
            this.pbPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPassword.TabIndex = 2;
            this.pbPassword.TabStop = false;
            this.pbPassword.Click += new System.EventHandler(this.pbPassword_Click);
            // 
            // panelUsernameSeperator
            // 
            this.panelUsernameSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelUsernameSeperator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelUsernameSeperator.Location = new System.Drawing.Point(88, 354);
            this.panelUsernameSeperator.Name = "panelUsernameSeperator";
            this.panelUsernameSeperator.Size = new System.Drawing.Size(259, 2);
            this.panelUsernameSeperator.TabIndex = 3;
            // 
            // panelPasswordSeperator
            // 
            this.panelPasswordSeperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelPasswordSeperator.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelPasswordSeperator.Location = new System.Drawing.Point(88, 424);
            this.panelPasswordSeperator.Name = "panelPasswordSeperator";
            this.panelPasswordSeperator.Size = new System.Drawing.Size(259, 2);
            this.panelPasswordSeperator.TabIndex = 3;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.chkRemember.Location = new System.Drawing.Point(231, 444);
            this.chkRemember.Margin = new System.Windows.Forms.Padding(0);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(113, 25);
            this.chkRemember.TabIndex = 3;
            this.chkRemember.Text = "REMEMBER";
            this.chkRemember.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(53, 487);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(294, 54);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN IN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(88, 324);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.MaxLength = 25;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(259, 28);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(88, 394);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(259, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblExit.Location = new System.Drawing.Point(172, 555);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(56, 25);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "EXIT";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
            this.errorProviderLogin.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProviderLogin.Icon")));
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.panelPasswordSeperator);
            this.Controls.Add(this.panelUsernameSeperator);
            this.Controls.Add(this.pbPassword);
            this.Controls.Add(this.pbUsername);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblLoginWelcome);
            this.Controls.Add(this.pbLoginLogo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD - Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoginLogo;
        private System.Windows.Forms.Label lblLoginWelcome;
        private System.Windows.Forms.PictureBox pbUsername;
        private System.Windows.Forms.PictureBox pbPassword;
        private System.Windows.Forms.Panel panelUsernameSeperator;
        private System.Windows.Forms.Panel panelPasswordSeperator;
        private System.Windows.Forms.CheckBox chkRemember;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
    }
}