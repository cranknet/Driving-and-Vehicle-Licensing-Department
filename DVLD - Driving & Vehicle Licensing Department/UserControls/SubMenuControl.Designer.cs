namespace DVLD_UI.UserControls.SubItems
{
    partial class SubMenuControl
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
            this.btnAddPeople = new System.Windows.Forms.Button();
            this.btnEditPeople = new System.Windows.Forms.Button();
            this.btnDeletePeople = new System.Windows.Forms.Button();
            this.btnListRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddPeople.FlatAppearance.BorderSize = 0;
            this.btnAddPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeople.ForeColor = System.Drawing.Color.White;
            this.btnAddPeople.Image = global::DVLD_UI.Properties.Resources.DVLD_Add_People__32;
            this.btnAddPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPeople.Location = new System.Drawing.Point(247, 9);
            this.btnAddPeople.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(165, 46);
            this.btnAddPeople.TabIndex = 1;
            this.btnAddPeople.Text = "ADD NEW";
            this.btnAddPeople.UseVisualStyleBackColor = false;
            // 
            // btnEditPeople
            // 
            this.btnEditPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEditPeople.FlatAppearance.BorderSize = 0;
            this.btnEditPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPeople.ForeColor = System.Drawing.Color.White;
            this.btnEditPeople.Image = global::DVLD_UI.Properties.Resources.DVLD_Add_People__32;
            this.btnEditPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPeople.Location = new System.Drawing.Point(443, 9);
            this.btnEditPeople.Margin = new System.Windows.Forms.Padding(0);
            this.btnEditPeople.Name = "btnEditPeople";
            this.btnEditPeople.Size = new System.Drawing.Size(165, 46);
            this.btnEditPeople.TabIndex = 2;
            this.btnEditPeople.Text = "EDIT";
            this.btnEditPeople.UseVisualStyleBackColor = false;
            // 
            // btnDeletePeople
            // 
            this.btnDeletePeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDeletePeople.FlatAppearance.BorderSize = 0;
            this.btnDeletePeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePeople.ForeColor = System.Drawing.Color.White;
            this.btnDeletePeople.Image = global::DVLD_UI.Properties.Resources.DVLD_Add_People__32;
            this.btnDeletePeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePeople.Location = new System.Drawing.Point(639, 9);
            this.btnDeletePeople.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeletePeople.Name = "btnDeletePeople";
            this.btnDeletePeople.Size = new System.Drawing.Size(165, 46);
            this.btnDeletePeople.TabIndex = 3;
            this.btnDeletePeople.Text = "DELETE";
            this.btnDeletePeople.UseVisualStyleBackColor = false;
            // 
            // btnListRefresh
            // 
            this.btnListRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnListRefresh.FlatAppearance.BorderSize = 0;
            this.btnListRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListRefresh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListRefresh.ForeColor = System.Drawing.Color.White;
            this.btnListRefresh.Image = global::DVLD_UI.Properties.Resources.DVLD_Add_People__32;
            this.btnListRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListRefresh.Location = new System.Drawing.Point(51, 9);
            this.btnListRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.btnListRefresh.Name = "btnListRefresh";
            this.btnListRefresh.Size = new System.Drawing.Size(165, 46);
            this.btnListRefresh.TabIndex = 4;
            this.btnListRefresh.Text = "DETAILS";
            this.btnListRefresh.UseVisualStyleBackColor = false;
            // 
            // SubMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnListRefresh);
            this.Controls.Add(this.btnDeletePeople);
            this.Controls.Add(this.btnEditPeople);
            this.Controls.Add(this.btnAddPeople);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SubMenuControl";
            this.Size = new System.Drawing.Size(854, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPeople;
        private System.Windows.Forms.Button btnEditPeople;
        private System.Windows.Forms.Button btnDeletePeople;
        private System.Windows.Forms.Button btnListRefresh;
    }
}
