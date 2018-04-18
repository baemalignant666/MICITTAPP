namespace MicittApp.UI.OnPromises.Panels
{
    partial class pnlDpts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabDocs = new MetroFramework.Controls.MetroTabPage();
            this.dgvDpt = new MetroFramework.Controls.MetroGrid();
            this.ID_DPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_DPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIP_DPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDir = new MetroFramework.Controls.MetroComboBox();
            this.lblDirDpt = new MetroFramework.Controls.MetroLabel();
            this.txtDescripDpt = new MetroFramework.Controls.MetroTextBox();
            this.lbDescripDpt = new MetroFramework.Controls.MetroLabel();
            this.txtNameDpt = new MetroFramework.Controls.MetroTextBox();
            this.lblNameDpt = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.TabDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDpt)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.lblSearch);
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.btnCreate);
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Controls.Add(this.btnUpdate);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(626, 71);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(479, 40);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(143, 23);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(426, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 19);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Buscar";
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(181, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(3, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 60);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Agregar";
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(270, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(92, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.TabDocs);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTabControl.Location = new System.Drawing.Point(0, 72);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(626, 397);
            this.metroTabControl.TabIndex = 12;
            this.metroTabControl.UseSelectable = true;
            // 
            // TabDocs
            // 
            this.TabDocs.Controls.Add(this.dgvDpt);
            this.TabDocs.Controls.Add(this.cbDir);
            this.TabDocs.Controls.Add(this.lblDirDpt);
            this.TabDocs.Controls.Add(this.txtDescripDpt);
            this.TabDocs.Controls.Add(this.lbDescripDpt);
            this.TabDocs.Controls.Add(this.txtNameDpt);
            this.TabDocs.Controls.Add(this.lblNameDpt);
            this.TabDocs.HorizontalScrollbarBarColor = true;
            this.TabDocs.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDocs.HorizontalScrollbarSize = 10;
            this.TabDocs.Location = new System.Drawing.Point(4, 38);
            this.TabDocs.Name = "TabDocs";
            this.TabDocs.Size = new System.Drawing.Size(618, 355);
            this.TabDocs.TabIndex = 0;
            this.TabDocs.Text = "Departamentos";
            this.TabDocs.VerticalScrollbarBarColor = true;
            this.TabDocs.VerticalScrollbarHighlightOnWheel = false;
            this.TabDocs.VerticalScrollbarSize = 10;
            // 
            // dgvDpt
            // 
            this.dgvDpt.AllowUserToResizeRows = false;
            this.dgvDpt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDpt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDpt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDpt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDpt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDpt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DPTO,
            this.NOMBRE_DPT,
            this.DESCRIP_DPT,
            this.ID_DIRECCION});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDpt.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDpt.EnableHeadersVisualStyles = false;
            this.dgvDpt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDpt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDpt.Location = new System.Drawing.Point(-4, 135);
            this.dgvDpt.Name = "dgvDpt";
            this.dgvDpt.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDpt.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDpt.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDpt.Size = new System.Drawing.Size(626, 224);
            this.dgvDpt.TabIndex = 17;
            this.dgvDpt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDpt_CellClick);
            // 
            // ID_DPTO
            // 
            this.ID_DPTO.HeaderText = "ID_DPTO";
            this.ID_DPTO.Name = "ID_DPTO";
            this.ID_DPTO.Visible = false;
            // 
            // NOMBRE_DPT
            // 
            this.NOMBRE_DPT.HeaderText = "Nombre";
            this.NOMBRE_DPT.Name = "NOMBRE_DPT";
            // 
            // DESCRIP_DPT
            // 
            this.DESCRIP_DPT.HeaderText = "Descripción";
            this.DESCRIP_DPT.Name = "DESCRIP_DPT";
            // 
            // ID_DIRECCION
            // 
            this.ID_DIRECCION.HeaderText = "Direccion";
            this.ID_DIRECCION.Name = "ID_DIRECCION";
            // 
            // cbDir
            // 
            this.cbDir.FormattingEnabled = true;
            this.cbDir.ItemHeight = 23;
            this.cbDir.Location = new System.Drawing.Point(104, 71);
            this.cbDir.Name = "cbDir";
            this.cbDir.Size = new System.Drawing.Size(143, 29);
            this.cbDir.TabIndex = 14;
            this.cbDir.UseSelectable = true;
            // 
            // lblDirDpt
            // 
            this.lblDirDpt.AutoSize = true;
            this.lblDirDpt.Location = new System.Drawing.Point(6, 81);
            this.lblDirDpt.Name = "lblDirDpt";
            this.lblDirDpt.Size = new System.Drawing.Size(63, 19);
            this.lblDirDpt.TabIndex = 13;
            this.lblDirDpt.Text = "Dirección";
            // 
            // txtDescripDpt
            // 
            // 
            // 
            // 
            this.txtDescripDpt.CustomButton.Image = null;
            this.txtDescripDpt.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtDescripDpt.CustomButton.Name = "";
            this.txtDescripDpt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripDpt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripDpt.CustomButton.TabIndex = 1;
            this.txtDescripDpt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripDpt.CustomButton.UseSelectable = true;
            this.txtDescripDpt.CustomButton.Visible = false;
            this.txtDescripDpt.Lines = new string[0];
            this.txtDescripDpt.Location = new System.Drawing.Point(104, 42);
            this.txtDescripDpt.MaxLength = 32767;
            this.txtDescripDpt.Name = "txtDescripDpt";
            this.txtDescripDpt.PasswordChar = '\0';
            this.txtDescripDpt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripDpt.SelectedText = "";
            this.txtDescripDpt.SelectionLength = 0;
            this.txtDescripDpt.SelectionStart = 0;
            this.txtDescripDpt.ShortcutsEnabled = true;
            this.txtDescripDpt.Size = new System.Drawing.Size(143, 23);
            this.txtDescripDpt.TabIndex = 5;
            this.txtDescripDpt.UseSelectable = true;
            this.txtDescripDpt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripDpt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbDescripDpt
            // 
            this.lbDescripDpt.AutoSize = true;
            this.lbDescripDpt.Location = new System.Drawing.Point(6, 46);
            this.lbDescripDpt.Name = "lbDescripDpt";
            this.lbDescripDpt.Size = new System.Drawing.Size(76, 19);
            this.lbDescripDpt.TabIndex = 4;
            this.lbDescripDpt.Text = "Descripción";
            // 
            // txtNameDpt
            // 
            // 
            // 
            // 
            this.txtNameDpt.CustomButton.Image = null;
            this.txtNameDpt.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtNameDpt.CustomButton.Name = "";
            this.txtNameDpt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameDpt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameDpt.CustomButton.TabIndex = 1;
            this.txtNameDpt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameDpt.CustomButton.UseSelectable = true;
            this.txtNameDpt.CustomButton.Visible = false;
            this.txtNameDpt.Lines = new string[0];
            this.txtNameDpt.Location = new System.Drawing.Point(104, 13);
            this.txtNameDpt.MaxLength = 32767;
            this.txtNameDpt.Name = "txtNameDpt";
            this.txtNameDpt.PasswordChar = '\0';
            this.txtNameDpt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameDpt.SelectedText = "";
            this.txtNameDpt.SelectionLength = 0;
            this.txtNameDpt.SelectionStart = 0;
            this.txtNameDpt.ShortcutsEnabled = true;
            this.txtNameDpt.Size = new System.Drawing.Size(143, 23);
            this.txtNameDpt.TabIndex = 3;
            this.txtNameDpt.UseSelectable = true;
            this.txtNameDpt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameDpt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNameDpt
            // 
            this.lblNameDpt.AutoSize = true;
            this.lblNameDpt.Location = new System.Drawing.Point(6, 17);
            this.lblNameDpt.Name = "lblNameDpt";
            this.lblNameDpt.Size = new System.Drawing.Size(59, 19);
            this.lblNameDpt.TabIndex = 2;
            this.lblNameDpt.Text = "Nombre";
            // 
            // pnlDpts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.metroPanel1);
            this.Name = "pnlDpts";
            this.Size = new System.Drawing.Size(626, 469);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.TabDocs.ResumeLayout(false);
            this.TabDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDpt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage TabDocs;
        private MetroFramework.Controls.MetroGrid dgvDpt;
        private MetroFramework.Controls.MetroComboBox cbDir;
        private MetroFramework.Controls.MetroLabel lblDirDpt;
        private MetroFramework.Controls.MetroTextBox txtDescripDpt;
        private MetroFramework.Controls.MetroLabel lbDescripDpt;
        private MetroFramework.Controls.MetroTextBox txtNameDpt;
        private MetroFramework.Controls.MetroLabel lblNameDpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_DPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_DPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DIRECCION;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel lblSearch;
    }
}
