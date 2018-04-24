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
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabDocs = new MetroFramework.Controls.MetroTabPage();
            this.cbType = new MetroFramework.Controls.MetroComboBox();
            this.lblTipo = new MetroFramework.Controls.MetroLabel();
            this.cbCons = new MetroFramework.Controls.MetroComboBox();
            this.lblCons = new MetroFramework.Controls.MetroLabel();
            this.dtpDateDoc = new MetroFramework.Controls.MetroDateTime();
            this.txtDest_DOC = new MetroFramework.Controls.MetroTextBox();
            this.lblDestinatario = new MetroFramework.Controls.MetroLabel();
            this.dgvDoc = new MetroFramework.Controls.MetroGrid();
            this.ID_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONS_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMISOR_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESTINO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBI_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRIORIDAD_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONS_TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldatedoc = new MetroFramework.Controls.MetroLabel();
            this.cbPrio_Doc = new MetroFramework.Controls.MetroComboBox();
            this.lblPriority = new MetroFramework.Controls.MetroLabel();
            this.txtUbi_DOC = new MetroFramework.Controls.MetroTextBox();
            this.lblUbicacion = new MetroFramework.Controls.MetroLabel();
            this.txtEmisor_DOC = new MetroFramework.Controls.MetroTextBox();
            this.lblEmisor = new MetroFramework.Controls.MetroLabel();
            this.txtTitulo_DOC = new MetroFramework.Controls.MetroTextBox();
            this.lblTitulo = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroTabControl.SuspendLayout();
            this.TabDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
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
            this.metroPanel1.TabIndex = 11;
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.metroTabControl.TabIndex = 12;
            this.metroTabControl.UseSelectable = true;
            // 
            // TabDocs
            // 
            this.TabDocs.Controls.Add(this.cbType);
            this.TabDocs.Controls.Add(this.lblTipo);
            this.TabDocs.Controls.Add(this.cbCons);
            this.TabDocs.Controls.Add(this.lblCons);
            this.TabDocs.Controls.Add(this.dtpDateDoc);
            this.TabDocs.Controls.Add(this.txtDest_DOC);
            this.TabDocs.Controls.Add(this.lblDestinatario);
            this.TabDocs.Controls.Add(this.dgvDoc);
            this.TabDocs.Controls.Add(this.lbldatedoc);
            this.TabDocs.Controls.Add(this.cbPrio_Doc);
            this.TabDocs.Controls.Add(this.lblPriority);
            this.TabDocs.Controls.Add(this.txtUbi_DOC);
            this.TabDocs.Controls.Add(this.lblUbicacion);
            this.TabDocs.Controls.Add(this.txtEmisor_DOC);
            this.TabDocs.Controls.Add(this.lblEmisor);
            this.TabDocs.Controls.Add(this.txtTitulo_DOC);
            this.TabDocs.Controls.Add(this.lblTitulo);
            this.TabDocs.HorizontalScrollbarBarColor = true;
            this.TabDocs.HorizontalScrollbarHighlightOnWheel = false;
            this.TabDocs.HorizontalScrollbarSize = 10;
            this.TabDocs.Location = new System.Drawing.Point(4, 38);
            this.TabDocs.Name = "TabDocs";
            this.TabDocs.Size = new System.Drawing.Size(688, 395);
            this.TabDocs.TabIndex = 0;
            this.TabDocs.Text = "Documentos";
            this.TabDocs.VerticalScrollbarBarColor = true;
            this.TabDocs.VerticalScrollbarHighlightOnWheel = false;
            this.TabDocs.VerticalScrollbarSize = 10;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 23;
            this.cbType.Location = new System.Drawing.Point(351, 7);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(143, 29);
            this.cbType.TabIndex = 25;
            this.cbType.UseSelectable = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(266, 17);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(35, 19);
            this.lblTipo.TabIndex = 24;
            this.lblTipo.Text = "Tipo";
            // 
            // cbCons
            // 
            this.cbCons.FormattingEnabled = true;
            this.cbCons.ItemHeight = 23;
            this.cbCons.Location = new System.Drawing.Point(351, 71);
            this.cbCons.Name = "cbCons";
            this.cbCons.Size = new System.Drawing.Size(143, 29);
            this.cbCons.TabIndex = 23;
            this.cbCons.UseSelectable = true;
            // 
            // lblCons
            // 
            this.lblCons.AutoSize = true;
            this.lblCons.Location = new System.Drawing.Point(266, 81);
            this.lblCons.Name = "lblCons";
            this.lblCons.Size = new System.Drawing.Size(79, 19);
            this.lblCons.TabIndex = 22;
            this.lblCons.Text = "Consecutivo";
            // 
            // dtpDateDoc
            // 
            this.dtpDateDoc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDoc.Location = new System.Drawing.Point(351, 104);
            this.dtpDateDoc.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new System.Drawing.Size(143, 29);
            this.dtpDateDoc.TabIndex = 21;
            // 
            // txtDest_DOC
            // 
            // 
            // 
            // 
            this.txtDest_DOC.CustomButton.Image = null;
            this.txtDest_DOC.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtDest_DOC.CustomButton.Name = "";
            this.txtDest_DOC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDest_DOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDest_DOC.CustomButton.TabIndex = 1;
            this.txtDest_DOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDest_DOC.CustomButton.UseSelectable = true;
            this.txtDest_DOC.CustomButton.Visible = false;
            this.txtDest_DOC.Lines = new string[0];
            this.txtDest_DOC.Location = new System.Drawing.Point(104, 71);
            this.txtDest_DOC.MaxLength = 32767;
            this.txtDest_DOC.Name = "txtDest_DOC";
            this.txtDest_DOC.PasswordChar = '\0';
            this.txtDest_DOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDest_DOC.SelectedText = "";
            this.txtDest_DOC.SelectionLength = 0;
            this.txtDest_DOC.SelectionStart = 0;
            this.txtDest_DOC.ShortcutsEnabled = true;
            this.txtDest_DOC.Size = new System.Drawing.Size(143, 23);
            this.txtDest_DOC.TabIndex = 19;
            this.txtDest_DOC.UseSelectable = true;
            this.txtDest_DOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDest_DOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.dgvDoc.AllowUserToAddRows = false;
            this.dgvDoc.AllowUserToDeleteRows = false;
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
            this.CONS_DOC,
            this.TITULO_DOC,
            this.EMISOR_DOC,
            this.DESTINO_DOC,
            this.UBI_DOC,
            this.TIPO_DOC,
            this.PRIORIDAD_DOC,
            this.CONS_TIPO,
            this.FECHA_DOC});
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
            this.dgvDoc.Location = new System.Drawing.Point(-4, 164);
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.ReadOnly = true;
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
            this.dgvDoc.Size = new System.Drawing.Size(696, 238);
            this.dgvDoc.TabIndex = 17;
            this.dgvDoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_CellClick);
            // 
            // ID_DOC
            // 
            this.ID_DOC.HeaderText = "ID_DOC";
            this.ID_DOC.Name = "ID_DOC";
            this.ID_DOC.ReadOnly = true;
            this.ID_DOC.Visible = false;
            // 
            // CONS_DOC
            // 
            this.CONS_DOC.HeaderText = "Consecutivo_Doc";
            this.CONS_DOC.Name = "CONS_DOC";
            this.CONS_DOC.ReadOnly = true;
            // 
            // TITULO_DOC
            // 
            this.TITULO_DOC.HeaderText = "Titulo";
            this.TITULO_DOC.Name = "TITULO_DOC";
            this.TITULO_DOC.ReadOnly = true;
            // 
            // EMISOR_DOC
            // 
            this.EMISOR_DOC.HeaderText = "Emisor";
            this.EMISOR_DOC.Name = "EMISOR_DOC";
            this.EMISOR_DOC.ReadOnly = true;
            // 
            // DESTINO_DOC
            // 
            this.DESTINO_DOC.HeaderText = "Destinatario";
            this.DESTINO_DOC.Name = "DESTINO_DOC";
            this.DESTINO_DOC.ReadOnly = true;
            // 
            // UBI_DOC
            // 
            this.UBI_DOC.HeaderText = "Ubicación";
            this.UBI_DOC.Name = "UBI_DOC";
            this.UBI_DOC.ReadOnly = true;
            // 
            // TIPO_DOC
            // 
            this.TIPO_DOC.HeaderText = "Tipo Doc";
            this.TIPO_DOC.Name = "TIPO_DOC";
            this.TIPO_DOC.ReadOnly = true;
            // 
            // PRIORIDAD_DOC
            // 
            this.PRIORIDAD_DOC.HeaderText = "Prioridad";
            this.PRIORIDAD_DOC.Name = "PRIORIDAD_DOC";
            this.PRIORIDAD_DOC.ReadOnly = true;
            // 
            // CONS_TIPO
            // 
            this.CONS_TIPO.HeaderText = "Identificador";
            this.CONS_TIPO.Name = "CONS_TIPO";
            this.CONS_TIPO.ReadOnly = true;
            // 
            // FECHA_DOC
            // 
            this.FECHA_DOC.HeaderText = "Fecha";
            this.FECHA_DOC.Name = "FECHA_DOC";
            this.FECHA_DOC.ReadOnly = true;
            // 
            // lbldatedoc
            // 
            this.lbldatedoc.AutoSize = true;
            this.lbldatedoc.Location = new System.Drawing.Point(266, 114);
            this.lbldatedoc.Name = "lbldatedoc";
            this.lbldatedoc.Size = new System.Drawing.Size(43, 19);
            this.lbldatedoc.TabIndex = 13;
            this.lbldatedoc.Text = "Fecha";
            // 
            // cbPrio_Doc
            // 
            this.cbPrio_Doc.FormattingEnabled = true;
            this.cbPrio_Doc.ItemHeight = 23;
            this.cbPrio_Doc.Items.AddRange(new object[] {
            "Normal",
            "Media",
            "Alta"});
            this.cbPrio_Doc.Location = new System.Drawing.Point(351, 40);
            this.cbPrio_Doc.Name = "cbPrio_Doc";
            this.cbPrio_Doc.Size = new System.Drawing.Size(143, 29);
            this.cbPrio_Doc.TabIndex = 12;
            this.cbPrio_Doc.UseSelectable = true;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(266, 50);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(64, 19);
            this.lblPriority.TabIndex = 10;
            this.lblPriority.Text = "Prioridad";
            // 
            // txtUbi_DOC
            // 
            // 
            // 
            // 
            this.txtUbi_DOC.CustomButton.Image = null;
            this.txtUbi_DOC.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtUbi_DOC.CustomButton.Name = "";
            this.txtUbi_DOC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUbi_DOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUbi_DOC.CustomButton.TabIndex = 1;
            this.txtUbi_DOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUbi_DOC.CustomButton.UseSelectable = true;
            this.txtUbi_DOC.CustomButton.Visible = false;
            this.txtUbi_DOC.Lines = new string[0];
            this.txtUbi_DOC.Location = new System.Drawing.Point(104, 100);
            this.txtUbi_DOC.MaxLength = 32767;
            this.txtUbi_DOC.Name = "txtUbi_DOC";
            this.txtUbi_DOC.PasswordChar = '\0';
            this.txtUbi_DOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUbi_DOC.SelectedText = "";
            this.txtUbi_DOC.SelectionLength = 0;
            this.txtUbi_DOC.SelectionStart = 0;
            this.txtUbi_DOC.ShortcutsEnabled = true;
            this.txtUbi_DOC.Size = new System.Drawing.Size(143, 23);
            this.txtUbi_DOC.TabIndex = 7;
            this.txtUbi_DOC.UseSelectable = true;
            this.txtUbi_DOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUbi_DOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(5, 104);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(66, 19);
            this.lblUbicacion.TabIndex = 6;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // txtEmisor_DOC
            // 
            // 
            // 
            // 
            this.txtEmisor_DOC.CustomButton.Image = null;
            this.txtEmisor_DOC.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtEmisor_DOC.CustomButton.Name = "";
            this.txtEmisor_DOC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmisor_DOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmisor_DOC.CustomButton.TabIndex = 1;
            this.txtEmisor_DOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmisor_DOC.CustomButton.UseSelectable = true;
            this.txtEmisor_DOC.CustomButton.Visible = false;
            this.txtEmisor_DOC.Lines = new string[0];
            this.txtEmisor_DOC.Location = new System.Drawing.Point(104, 42);
            this.txtEmisor_DOC.MaxLength = 32767;
            this.txtEmisor_DOC.Name = "txtEmisor_DOC";
            this.txtEmisor_DOC.PasswordChar = '\0';
            this.txtEmisor_DOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmisor_DOC.SelectedText = "";
            this.txtEmisor_DOC.SelectionLength = 0;
            this.txtEmisor_DOC.SelectionStart = 0;
            this.txtEmisor_DOC.ShortcutsEnabled = true;
            this.txtEmisor_DOC.Size = new System.Drawing.Size(143, 23);
            this.txtEmisor_DOC.TabIndex = 5;
            this.txtEmisor_DOC.UseSelectable = true;
            this.txtEmisor_DOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmisor_DOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            // txtTitulo_DOC
            // 
            // 
            // 
            // 
            this.txtTitulo_DOC.CustomButton.Image = null;
            this.txtTitulo_DOC.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtTitulo_DOC.CustomButton.Name = "";
            this.txtTitulo_DOC.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTitulo_DOC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitulo_DOC.CustomButton.TabIndex = 1;
            this.txtTitulo_DOC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitulo_DOC.CustomButton.UseSelectable = true;
            this.txtTitulo_DOC.CustomButton.Visible = false;
            this.txtTitulo_DOC.Lines = new string[0];
            this.txtTitulo_DOC.Location = new System.Drawing.Point(104, 13);
            this.txtTitulo_DOC.MaxLength = 32767;
            this.txtTitulo_DOC.Name = "txtTitulo_DOC";
            this.txtTitulo_DOC.PasswordChar = '\0';
            this.txtTitulo_DOC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitulo_DOC.SelectedText = "";
            this.txtTitulo_DOC.SelectionLength = 0;
            this.txtTitulo_DOC.SelectionStart = 0;
            this.txtTitulo_DOC.ShortcutsEnabled = true;
            this.txtTitulo_DOC.Size = new System.Drawing.Size(143, 23);
            this.txtTitulo_DOC.TabIndex = 3;
            this.txtTitulo_DOC.UseSelectable = true;
            this.txtTitulo_DOC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitulo_DOC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(696, 512);
            this.metroPanel1.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTextBox txtDest_DOC;
        private MetroFramework.Controls.MetroLabel lblDestinatario;
        private MetroFramework.Controls.MetroGrid dgvDoc;
        private MetroFramework.Controls.MetroLabel lbldatedoc;
        private MetroFramework.Controls.MetroComboBox cbPrio_Doc;
        private MetroFramework.Controls.MetroLabel lblPriority;
        private MetroFramework.Controls.MetroTextBox txtUbi_DOC;
        private MetroFramework.Controls.MetroLabel lblUbicacion;
        private MetroFramework.Controls.MetroTextBox txtEmisor_DOC;
        private MetroFramework.Controls.MetroLabel lblEmisor;
        private MetroFramework.Controls.MetroTextBox txtTitulo_DOC;
        private MetroFramework.Controls.MetroLabel lblTitulo;
        private MetroFramework.Controls.MetroDateTime dtpDateDoc;
        private MetroFramework.Controls.MetroComboBox cbCons;
        private MetroFramework.Controls.MetroLabel lblCons;
        private MetroFramework.Controls.MetroComboBox cbType;
        private MetroFramework.Controls.MetroLabel lblTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONS_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMISOR_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESTINO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBI_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRIORIDAD_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONS_TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_DOC;
    }
}
