namespace DVLD_UI.UserControls.SubItems
{
    partial class ApplicationsSubItemsControl
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
            this.SuspendLayout();
            // 
            // btnAddPeople
            // 
            this.btnAddPeople.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAddPeople.Location = new System.Drawing.Point(48, 3);
            this.btnAddPeople.Name = "btnAddPeople";
            this.btnAddPeople.Size = new System.Drawing.Size(79, 44);
            this.btnAddPeople.TabIndex = 0;
            this.btnAddPeople.Text = "ADD NEW";
            this.btnAddPeople.UseVisualStyleBackColor = false;
            this.btnAddPeople.Click += new System.EventHandler(this.btnAddPeople_Click);
            // 
           
           
            // ApplicationsSubItemsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.btnAddPeople);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ApplicationsSubItemsControl";
            this.Size = new System.Drawing.Size(917, 50);
            this.Load += new System.EventHandler(this.ApplicationsSubItemsControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPeople;
    }
}
