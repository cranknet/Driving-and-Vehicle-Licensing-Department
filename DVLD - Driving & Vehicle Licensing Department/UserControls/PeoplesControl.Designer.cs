namespace DVLD_UI.UserControls
{
    partial class PeoplesControl
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
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPeople = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuPeopleCardShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorPeople = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuIPeopleEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPeopleDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbFilterOptions = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.panelFilterOptions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.contextMenuStripPeople.SuspendLayout();
            this.panelFilterOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.AllowUserToAddRows = false;
            this.dataGridViewPeople.AllowUserToDeleteRows = false;
            this.dataGridViewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPeople.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.ContextMenuStrip = this.contextMenuStripPeople;
            this.dataGridViewPeople.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPeople.GridColor = System.Drawing.Color.White;
            this.dataGridViewPeople.Location = new System.Drawing.Point(0, 113);
            this.dataGridViewPeople.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            this.dataGridViewPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeople.Size = new System.Drawing.Size(917, 598);
            this.dataGridViewPeople.TabIndex = 0;
            this.dataGridViewPeople.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeople_CellContentDoubleClick);
            // 
            // contextMenuStripPeople
            // 
            this.contextMenuStripPeople.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuPeopleCardShow,
            this.toolStripSeparatorPeople,
            this.toolStripMenuIPeopleEdit,
            this.toolStripMenuPeopleDelete});
            this.contextMenuStripPeople.Name = "contextMenuStripPeople";
            this.contextMenuStripPeople.Size = new System.Drawing.Size(110, 76);
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
            // cmbFilterOptions
            // 
            this.cmbFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterOptions.FormattingEnabled = true;
            this.cmbFilterOptions.Location = new System.Drawing.Point(302, 14);
            this.cmbFilterOptions.Name = "cmbFilterOptions";
            this.cmbFilterOptions.Size = new System.Drawing.Size(158, 29);
            this.cmbFilterOptions.TabIndex = 1;
            this.cmbFilterOptions.SelectedIndexChanged += new System.EventHandler(this.cmbFilterOptions_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(230, 16);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(57, 25);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(475, 14);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(212, 29);
            this.txtFilterValue.TabIndex = 3;
            this.txtFilterValue.Visible = false;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // panelFilterOptions
            // 
            this.panelFilterOptions.Controls.Add(this.cmbFilterOptions);
            this.panelFilterOptions.Controls.Add(this.lblFilter);
            this.panelFilterOptions.Controls.Add(this.txtFilterValue);
            this.panelFilterOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilterOptions.Location = new System.Drawing.Point(0, 0);
            this.panelFilterOptions.Name = "panelFilterOptions";
            this.panelFilterOptions.Size = new System.Drawing.Size(917, 56);
            this.panelFilterOptions.TabIndex = 4;
            // 
            // PeoplesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelFilterOptions);
            this.Controls.Add(this.dataGridViewPeople);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PeoplesControl";
            this.Size = new System.Drawing.Size(917, 711);
            this.Load += new System.EventHandler(this.PeoplesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.contextMenuStripPeople.ResumeLayout(false);
            this.panelFilterOptions.ResumeLayout(false);
            this.panelFilterOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleCardShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIPeopleEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleDelete;
        private System.Windows.Forms.ComboBox cmbFilterOptions;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Panel panelFilterOptions;
    }
}
