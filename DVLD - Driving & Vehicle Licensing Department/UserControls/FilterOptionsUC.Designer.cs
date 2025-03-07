namespace DVLD_UI.UserControls
{
    partial class FilterOptionsUC
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
            this.panelFilterOptions = new System.Windows.Forms.Panel();
            this.cmbFilterOptions = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.panelFilterOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFilterOptions
            // 
            this.panelFilterOptions.Controls.Add(this.cmbFilterOptions);
            this.panelFilterOptions.Controls.Add(this.lblFilter);
            this.panelFilterOptions.Controls.Add(this.txtFilterValue);
            this.panelFilterOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilterOptions.Location = new System.Drawing.Point(0, 0);
            this.panelFilterOptions.Name = "panelFilterOptions";
            this.panelFilterOptions.Size = new System.Drawing.Size(478, 64);
            this.panelFilterOptions.TabIndex = 6;
            // 
            // cmbFilterOptions
            // 
            this.cmbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterOptions.FormattingEnabled = true;
            this.cmbFilterOptions.Location = new System.Drawing.Point(94, 12);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Size = new System.Drawing.Size(158, 29);
            this.cmbFilterOptions.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(3, 14);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(84, 25);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Filter By";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(259, 12);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(212, 29);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.Visible = false;
            // 
            // FilterOptionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFilterOptions);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FilterOptionsUC";
            this.Size = new System.Drawing.Size(478, 64);
            this.panelFilterOptions.ResumeLayout(false);
            this.panelFilterOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilterOptions;
        public System.Windows.Forms.ComboBox cmbFilterOptions;
        public System.Windows.Forms.Label lblFilter;
        public System.Windows.Forms.TextBox txtFilterValue;
    }
}
