namespace DVLD_UI.UserControls.Cards
{
    partial class PersonSelectCard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonSelectCard));
            this.selectPersonCardGridView = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbCloseCard = new System.Windows.Forms.PictureBox();
            this.lblSelectPerson = new System.Windows.Forms.Label();
            this.btnSelectPerson = new System.Windows.Forms.Button();
            this.pbPersonImage = new System.Windows.Forms.PictureBox();
            this.btnUserEditPerson = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.filterOptionsUC = new DVLD_UI.UserControls.FilterOptionsUC();
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonCardGridView)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPersonCardGridView
            // 
            this.selectPersonCardGridView.AllowUserToAddRows = false;
            this.selectPersonCardGridView.AllowUserToDeleteRows = false;
            this.selectPersonCardGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectPersonCardGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.selectPersonCardGridView.BackgroundColor = System.Drawing.Color.White;
            this.selectPersonCardGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectPersonCardGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.selectPersonCardGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectPersonCardGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectPersonCardGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(95)))), ((int)(((byte)(137)))));
            this.selectPersonCardGridView.Location = new System.Drawing.Point(348, 151);
            this.selectPersonCardGridView.Margin = new System.Windows.Forms.Padding(0);
            this.selectPersonCardGridView.MultiSelect = false;
            this.selectPersonCardGridView.Name = "selectPersonCardGridView";
            this.selectPersonCardGridView.ReadOnly = true;
            this.selectPersonCardGridView.RowHeadersVisible = false;
            this.selectPersonCardGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPersonCardGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.selectPersonCardGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(1);
            this.selectPersonCardGridView.RowTemplate.Height = 25;
            this.selectPersonCardGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectPersonCardGridView.Size = new System.Drawing.Size(555, 231);
            this.selectPersonCardGridView.TabIndex = 40;
            this.selectPersonCardGridView.SelectionChanged += new System.EventHandler(this.selectPersonCardGridView_SelectionChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.pbCloseCard);
            this.panelHeader.Controls.Add(this.lblSelectPerson);
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
            // lblSelectPerson
            // 
            this.lblSelectPerson.AutoSize = true;
            this.lblSelectPerson.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectPerson.ForeColor = System.Drawing.Color.White;
            this.lblSelectPerson.Location = new System.Drawing.Point(3, 3);
            this.lblSelectPerson.Name = "lblSelectPerson";
            this.lblSelectPerson.Size = new System.Drawing.Size(186, 32);
            this.lblSelectPerson.TabIndex = 15;
            this.lblSelectPerson.Text = "Select a Person";
            // 
            // btnSelectPerson
            // 
            this.btnSelectPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSelectPerson.FlatAppearance.BorderSize = 0;
            this.btnSelectPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPerson.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPerson.ForeColor = System.Drawing.Color.White;
            this.btnSelectPerson.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectPerson.Location = new System.Drawing.Point(662, 422);
            this.btnSelectPerson.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectPerson.Name = "btnSelectPerson";
            this.btnSelectPerson.Size = new System.Drawing.Size(128, 37);
            this.btnSelectPerson.TabIndex = 39;
            this.btnSelectPerson.TabStop = false;
            this.btnSelectPerson.Text = "SELECT";
            this.btnSelectPerson.UseVisualStyleBackColor = false;
            this.btnSelectPerson.Click += new System.EventHandler(this.btnSelectPerson_Click);
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
            this.btnUserEditPerson.Click += new System.EventHandler(this.btnUserEditPerson_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(467, 422);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 37);
            this.btnClose.TabIndex = 37;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.filterOptionsUC);
            this.panelMain.Controls.Add(this.selectPersonCardGridView);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Controls.Add(this.btnSelectPerson);
            this.panelMain.Controls.Add(this.pbPersonImage);
            this.panelMain.Controls.Add(this.btnUserEditPerson);
            this.panelMain.Controls.Add(this.btnClose);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(905, 479);
            this.panelMain.TabIndex = 4;
            this.panelMain.TabStop = true;
            // 
            // filterOptionsUC
            // 
            this.filterOptionsUC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterOptionsUC.Location = new System.Drawing.Point(348, 82);
            this.filterOptionsUC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterOptionsUC.Name = "filterOptionsUC";
            this.filterOptionsUC.Size = new System.Drawing.Size(551, 64);
            this.filterOptionsUC.TabIndex = 41;
            // 
            // PersonSelectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonSelectCard";
            this.Size = new System.Drawing.Size(905, 479);
            ((System.ComponentModel.ISupportInitialize)(this.selectPersonCardGridView)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView selectPersonCardGridView;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbCloseCard;
        private System.Windows.Forms.Label lblSelectPerson;
        private System.Windows.Forms.Button btnSelectPerson;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Button btnUserEditPerson;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panelMain;
        private FilterOptionsUC filterOptionsUC;
        private System.Windows.Forms.Button btnClose;
    }
}
