namespace MicittApp.UI.OnPromises.Panels
{
    partial class pnlTDocs
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
            this.dgvTDoc = new MetroFramework.Controls.MetroGrid();
            this.ID_TDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME_TDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNameUser = new MetroFramework.Controls.MetroTextBox();
            this.lblTDoc = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.TabDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDoc)).BeginInit();
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
            this.metroPanel1.Size = new System.Drawing.Size(696, 71);
            this.metroPanel1.TabIndex = 12;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
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
            this.metroTabControl.Location = new System.Drawing.Point(0, 72);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(696, 437);
            this.metroTabControl.TabIndex = 13;
            this.metroTabControl.UseSelectable = true;
            // 
            // TabDocs
            // 
            this.TabDocs.Controls.Add(this.dgvTDoc);
            this.TabDocs.Controls.Add(this.txtNameUser);
            this.TabDocs.Controls.Add(this.lblTDoc);
            this.TabDocs.HorizontalScrollbarBarColor = true;
            this.TabDocs.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDocs.HorizontalScrollbarSize = 10;
            this.TabDocs.Location = new System.Drawing.Point(4, 38);
            this.TabDocs.Name = "TabDocs";
            this.TabDocs.Size = new System.Drawing.Size(688, 395);
            this.TabDocs.TabIndex = 0;
            this.TabDocs.Text = "Tipo de Documentos";
            this.TabDocs.VerticalScrollbarBarColor = true;
            this.TabDocs.VerticalScrollbarHighlightOnWheel = false;
            this.TabDocs.VerticalScrollbarSize = 10;
            // 
            // dgvTDoc
            // 
            this.dgvTDoc.AllowUserToAddRows = false;
            this.dgvTDoc.AllowUserToDeleteRows = false;
            this.dgvTDoc.AllowUserToResizeRows = false;
            this.dgvTDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTDoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTDoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TDOC,
            this.NAME_TDOC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTDoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTDoc.EnableHeadersVisualStyles = false;
            this.dgvTDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTDoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTDoc.Location = new System.Drawing.Point(-4, 164);
            this.dgvTDoc.Name = "dgvTDoc";
            this.dgvTDoc.ReadOnly = true;
            this.dgvTDoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTDoc.Size = new System.Drawing.Size(696, 238);
            this.dgvTDoc.TabIndex = 17;
            this.dgvTDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTDoc_CellClick);
            // 
            // ID_TDOC
            // 
            this.ID_TDOC.HeaderText = "ID";
            this.ID_TDOC.Name = "ID_TDOC";
            this.ID_TDOC.ReadOnly = true;
            this.ID_TDOC.Visible = false;
            // 
            // NAME_TDOC
            // 
            this.NAME_TDOC.HeaderText = "Nombre del Documento";
            this.NAME_TDOC.Name = "NAME_TDOC";
            this.NAME_TDOC.ReadOnly = true;
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
            this.txtNameUser.Location = new System.Drawing.Point(88, 13);
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
            // lblTDoc
            // 
            this.lblTDoc.AutoSize = true;
            this.lblTDoc.Location = new System.Drawing.Point(5, 17);
            this.lblTDoc.Name = "lblTDoc";
            this.lblTDoc.Size = new System.Drawing.Size(59, 19);
            this.lblTDoc.TabIndex = 2;
            this.lblTDoc.Text = "Nombre";
            // 
            // pnlTDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.metroPanel1);
            this.Name = "pnlTDocs";
            this.Size = new System.Drawing.Size(696, 512);
            this.metroPanel1.ResumeLayout(false);
            this.metroTabControl.ResumeLayout(false);
            this.TabDocs.ResumeLayout(false);
            this.TabDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTDoc)).EndInit();
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
        private MetroFramework.Controls.MetroGrid dgvTDoc;
        private MetroFramework.Controls.MetroTextBox txtNameUser;
        private MetroFramework.Controls.MetroLabel lblTDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME_TDOC;
    }
}
