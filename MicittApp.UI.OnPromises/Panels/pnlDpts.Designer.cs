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
            this.cbDpto = new MetroFramework.Controls.MetroComboBox();
            this.lblDirDpt = new MetroFramework.Controls.MetroLabel();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.lbDescripDpt = new MetroFramework.Controls.MetroLabel();
            this.txtNameUser = new MetroFramework.Controls.MetroTextBox();
            this.lblNameDpt = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.TabDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDpt)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
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
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(181, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 60);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseSelectable = true;
            // 
            // btnCreate
            // 
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
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
            this.btnRefresh.Location = new System.Drawing.Point(270, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Location = new System.Drawing.Point(92, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 60);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
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
            this.TabDocs.Controls.Add(this.cbDpto);
            this.TabDocs.Controls.Add(this.lblDirDpt);
            this.TabDocs.Controls.Add(this.txtLastname);
            this.TabDocs.Controls.Add(this.lbDescripDpt);
            this.TabDocs.Controls.Add(this.txtNameUser);
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
            // cbDpto
            // 
            this.cbDpto.FormattingEnabled = true;
            this.cbDpto.ItemHeight = 23;
            this.cbDpto.Location = new System.Drawing.Point(104, 71);
            this.cbDpto.Name = "cbDpto";
            this.cbDpto.Size = new System.Drawing.Size(143, 29);
            this.cbDpto.TabIndex = 14;
            this.cbDpto.UseSelectable = true;
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
            // txtLastname
            // 
            // 
            // 
            // 
            this.txtLastname.CustomButton.Image = null;
            this.txtLastname.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtLastname.CustomButton.Name = "";
            this.txtLastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastname.CustomButton.TabIndex = 1;
            this.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastname.CustomButton.UseSelectable = true;
            this.txtLastname.CustomButton.Visible = false;
            this.txtLastname.Lines = new string[0];
            this.txtLastname.Location = new System.Drawing.Point(104, 42);
            this.txtLastname.MaxLength = 32767;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.ShortcutsEnabled = true;
            this.txtLastname.Size = new System.Drawing.Size(143, 23);
            this.txtLastname.TabIndex = 5;
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // txtNameUser
            // 
            // 
            // 
            // 
            this.txtNameUser.CustomButton.Image = null;
            this.txtNameUser.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtNameUser.CustomButton.Name = "";
            this.txtNameUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameUser.CustomButton.TabIndex = 1;
            this.txtNameUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameUser.CustomButton.UseSelectable = true;
            this.txtNameUser.CustomButton.Visible = false;
            this.txtNameUser.Lines = new string[0];
            this.txtNameUser.Location = new System.Drawing.Point(104, 13);
            this.txtNameUser.MaxLength = 32767;
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.PasswordChar = '\0';
            this.txtNameUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameUser.SelectedText = "";
            this.txtNameUser.SelectionLength = 0;
            this.txtNameUser.SelectionStart = 0;
            this.txtNameUser.ShortcutsEnabled = true;
            this.txtNameUser.Size = new System.Drawing.Size(143, 23);
            this.txtNameUser.TabIndex = 3;
            this.txtNameUser.UseSelectable = true;
            this.txtNameUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
        private MetroFramework.Controls.MetroComboBox cbDpto;
        private MetroFramework.Controls.MetroLabel lblDirDpt;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroLabel lbDescripDpt;
        private MetroFramework.Controls.MetroTextBox txtNameUser;
        private MetroFramework.Controls.MetroLabel lblNameDpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_DPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIP_DPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DIRECCION;
    }
}
