namespace MicittApp.UI.OnPromises.Panels
{
    partial class pnlDocs
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
            this.cbCons = new MetroFramework.Controls.MetroComboBox();
            this.lblCons = new MetroFramework.Controls.MetroLabel();
            this.dtpDateDoc = new MetroFramework.Controls.MetroDateTime();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.lblDestinatario = new MetroFramework.Controls.MetroLabel();
            this.dgvDoc = new MetroFramework.Controls.MetroGrid();
            this.ID_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMISOR_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEST_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBI_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONS_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldatedoc = new MetroFramework.Controls.MetroLabel();
            this.cbRole = new MetroFramework.Controls.MetroComboBox();
            this.lblPriority = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblUbicacion = new MetroFramework.Controls.MetroLabel();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.lblEmisor = new MetroFramework.Controls.MetroLabel();
            this.txtNameUser = new MetroFramework.Controls.MetroTextBox();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.TabDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
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
            this.txtSearch.Location = new System.Drawing.Point(480, 40);
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
            this.lblSearch.Location = new System.Drawing.Point(427, 44);
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
            this.TabDocs.Controls.Add(this.cbCons);
            this.TabDocs.Controls.Add(this.lblCons);
            this.TabDocs.Controls.Add(this.dtpDateDoc);
            this.TabDocs.Controls.Add(this.metroTextBox2);
            this.TabDocs.Controls.Add(this.lblDestinatario);
            this.TabDocs.Controls.Add(this.dgvDoc);
            this.TabDocs.Controls.Add(this.lbldatedoc);
            this.TabDocs.Controls.Add(this.cbRole);
            this.TabDocs.Controls.Add(this.lblPriority);
            this.TabDocs.Controls.Add(this.txtEmail);
            this.TabDocs.Controls.Add(this.lblUbicacion);
            this.TabDocs.Controls.Add(this.txtLastname);
            this.TabDocs.Controls.Add(this.lblEmisor);
            this.TabDocs.Controls.Add(this.txtNameUser);
            this.TabDocs.Controls.Add(this.lblTitulo);
            this.TabDocs.HorizontalScrollbarBarColor = true;
            this.TabDocs.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDocs.HorizontalScrollbarSize = 10;
            this.TabDocs.Location = new System.Drawing.Point(4, 38);
            this.TabDocs.Name = "TabDocs";
            this.TabDocs.Size = new System.Drawing.Size(618, 355);
            this.TabDocs.TabIndex = 0;
            this.TabDocs.Text = "Documentos";
            this.TabDocs.VerticalScrollbarBarColor = true;
            this.TabDocs.VerticalScrollbarHighlightOnWheel = false;
            this.TabDocs.VerticalScrollbarSize = 10;
            // 
            // cbCons
            // 
            this.cbCons.FormattingEnabled = true;
            this.cbCons.ItemHeight = 23;
            this.cbCons.Location = new System.Drawing.Point(351, 81);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(143, 29);
            this.cbCons.TabIndex = 23;
            this.cbCons.UseSelectable = true;
            // 
            // lblCons
            // 
            this.lblCons.AutoSize = true;
            this.lblCons.Location = new System.Drawing.Point(266, 87);
            this.lblCons.Name = "lblCons";
            this.lblCons.Size = new System.Drawing.Size(79, 19);
            this.lblCons.TabIndex = 22;
            this.lblCons.Text = "Consecutivo";
            // 
            // dtpDateDoc
            // 
            this.dtpDateDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDoc.Location = new System.Drawing.Point(104, 100);
            this.dtpDateDoc.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new System.Drawing.Size(143, 29);
            this.dtpDateDoc.TabIndex = 21;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(104, 71);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(143, 23);
            this.metroTextBox2.TabIndex = 19;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(5, 75);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(78, 19);
            this.lblDestinatario.TabIndex = 18;
            this.lblDestinatario.Text = "Destinatario";
            // 
            // dgvDoc
            // 
            this.dgvDoc.AllowUserToResizeRows = false;
            this.dgvDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_DOC,
            this.TITULO_DOC,
            this.EMISOR_DOC,
            this.DEST_DOC,
            this.DATE_DOC,
            this.UBI_DOC,
            this.PRIO_DOC,
            this.CONS_DOC});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoc.EnableHeadersVisualStyles = false;
            this.dgvDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoc.Location = new System.Drawing.Point(-4, 135);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoc.Size = new System.Drawing.Size(626, 224);
            this.dgvDoc.TabIndex = 17;
            // 
            // ID_DOC
            // 
            this.ID_DOC.HeaderText = "ID";
            this.ID_DOC.Name = "ID_DOC";
            this.ID_DOC.Visible = false;
            // 
            // TITULO_DOC
            // 
            this.TITULO_DOC.HeaderText = "Titulo";
            this.TITULO_DOC.Name = "TITULO_DOC";
            // 
            // EMISOR_DOC
            // 
            this.EMISOR_DOC.HeaderText = "Emisor";
            this.EMISOR_DOC.Name = "EMISOR_DOC";
            // 
            // DEST_DOC
            // 
            this.DEST_DOC.HeaderText = "Destinatario";
            this.DEST_DOC.Name = "DEST_DOC";
            // 
            // DATE_DOC
            // 
            this.DATE_DOC.HeaderText = "Fecha";
            this.DATE_DOC.Name = "DATE_DOC";
            // 
            // UBI_DOC
            // 
            this.UBI_DOC.HeaderText = "Ubicación";
            this.UBI_DOC.Name = "UBI_DOC";
            // 
            // PRIO_DOC
            // 
            this.PRIO_DOC.HeaderText = "Prioridad";
            this.PRIO_DOC.Name = "PRIO_DOC";
            this.PRIO_DOC.Width = 75;
            // 
            // CONS_DOC
            // 
            this.CONS_DOC.HeaderText = "Consecutivo";
            this.CONS_DOC.Name = "CONS_DOC";
            this.CONS_DOC.Width = 80;
            // 
            // lbldatedoc
            // 
            this.lbldatedoc.AutoSize = true;
            this.lbldatedoc.Location = new System.Drawing.Point(5, 110);
            this.lbldatedoc.Name = "lbldatedoc";
            this.lbldatedoc.Size = new System.Drawing.Size(43, 19);
            this.lbldatedoc.TabIndex = 13;
            this.lbldatedoc.Text = "Fecha";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.ItemHeight = 23;
            this.cbRole.Location = new System.Drawing.Point(351, 46);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(143, 29);
            this.cbRole.TabIndex = 12;
            this.cbRole.UseSelectable = true;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(266, 52);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(64, 19);
            this.lblPriority.TabIndex = 10;
            this.lblPriority.Text = "Prioridad";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(351, 13);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(143, 23);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(266, 17);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(66, 19);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Ubicación";
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
            // lblEmisor
            // 
            this.lblEmisor.AutoSize = true;
            this.lblEmisor.Location = new System.Drawing.Point(5, 46);
            this.lblEmisor.Name = "lblEmisor";
            this.lblEmisor.Size = new System.Drawing.Size(49, 19);
            this.lblEmisor.TabIndex = 4;
            this.lblEmisor.Text = "Emisor";
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(5, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(45, 19);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo ";
            // 
            // pnlDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.metroPanel1);
            this.Name = "pnlDocs";
            this.Size = new System.Drawing.Size(626, 469);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroTabControl.ResumeLayout(false);
            this.TabDocs.ResumeLayout(false);
            this.TabDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel lblDestinatario;
        private MetroFramework.Controls.MetroGrid dgvDoc;
        private MetroFramework.Controls.MetroLabel lbldatedoc;
        private MetroFramework.Controls.MetroComboBox cbRole;
        private MetroFramework.Controls.MetroLabel lblPriority;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblUbicacion;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroLabel lblEmisor;
        private MetroFramework.Controls.MetroTextBox txtNameUser;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroDateTime dtpDateDoc;
        private MetroFramework.Controls.MetroComboBox cbCons;
        private MetroFramework.Controls.MetroLabel lblCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMISOR_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEST_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBI_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONS_DOC;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel lblSearch;
    }
}
