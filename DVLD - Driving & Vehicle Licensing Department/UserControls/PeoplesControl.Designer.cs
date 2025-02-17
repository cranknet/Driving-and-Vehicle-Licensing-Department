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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.contextMenuStripPeople.SuspendLayout();
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
            this.dataGridViewPeople.Location = new System.Drawing.Point(0, 53);
            this.dataGridViewPeople.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.ReadOnly = true;
            this.dataGridViewPeople.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPeople.Size = new System.Drawing.Size(917, 658);
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
            this.contextMenuStripPeople.Size = new System.Drawing.Size(181, 98);
            // 
            // toolStripMenuPeopleCardShow
            // 
            this.toolStripMenuPeopleCardShow.Name = "toolStripMenuPeopleCardShow";
            this.toolStripMenuPeopleCardShow.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuPeopleCardShow.Text = "Details";
            this.toolStripMenuPeopleCardShow.Click += new System.EventHandler(this.toolStripMenuPeopleCardShow_Click);
            // 
            // toolStripSeparatorPeople
            // 
            this.toolStripSeparatorPeople.Name = "toolStripSeparatorPeople";
            this.toolStripSeparatorPeople.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripMenuIPeopleEdit
            // 
            this.toolStripMenuIPeopleEdit.Name = "toolStripMenuIPeopleEdit";
            this.toolStripMenuIPeopleEdit.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuIPeopleEdit.Text = "Edit";
            this.toolStripMenuIPeopleEdit.Click += new System.EventHandler(this.toolStripMenuIPeopleEdit_Click);
            // 
            // toolStripMenuPeopleDelete
            // 
            this.toolStripMenuPeopleDelete.Name = "toolStripMenuPeopleDelete";
            this.toolStripMenuPeopleDelete.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuPeopleDelete.Text = "Delete";
            this.toolStripMenuPeopleDelete.Click += new System.EventHandler(this.toolStripMenuPeopleDelete_Click);
            // 
            // PeoplesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewPeople);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PeoplesControl";
            this.Size = new System.Drawing.Size(917, 711);
            this.Load += new System.EventHandler(this.PeoplesControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.contextMenuStripPeople.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleCardShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparatorPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuIPeopleEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeopleDelete;
    }
}
