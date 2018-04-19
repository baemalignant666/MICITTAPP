namespace MicittApp.UI.OnPromises.Panels
{
    partial class pnlUsers
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
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.TabUsers = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.lblIDUser = new MetroFramework.Controls.MetroLabel();
            this.dgvUser = new MetroFramework.Controls.MetroGrid();
            this.NOMBREC_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_DPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAILUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASSWOORD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONEUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLUSER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.cbDpto = new MetroFramework.Controls.MetroComboBox();
            this.lblDpto = new MetroFramework.Controls.MetroLabel();
            this.cbRole = new MetroFramework.Controls.MetroComboBox();
            this.lblRole = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.lblphone = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.lblLastname = new MetroFramework.Controls.MetroLabel();
            this.txtNameUser = new MetroFramework.Controls.MetroTextBox();
            this.lblNameUser = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnActivate = new MetroFramework.Controls.MetroTile();
            this.btnInactive = new MetroFramework.Controls.MetroTile();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblSearch = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl.SuspendLayout();
            this.TabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(448, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 60);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseSelectable = true;
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.TabUsers);
            this.metroTabControl.Location = new System.Drawing.Point(0, 72);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 0;
            this.metroTabControl.Size = new System.Drawing.Size(696, 437);
            this.metroTabControl.TabIndex = 9;
            this.metroTabControl.UseSelectable = true;
            // 
            // TabUsers
            // 
            this.TabUsers.Controls.Add(this.metroTextBox2);
            this.TabUsers.Controls.Add(this.lblIDUser);
            this.TabUsers.Controls.Add(this.dgvUser);
            this.TabUsers.Controls.Add(this.txtPassword);
            this.TabUsers.Controls.Add(this.lblPassword);
            this.TabUsers.Controls.Add(this.cbDpto);
            this.TabUsers.Controls.Add(this.lblDpto);
            this.TabUsers.Controls.Add(this.cbRole);
            this.TabUsers.Controls.Add(this.lblRole);
            this.TabUsers.Controls.Add(this.metroTextBox1);
            this.TabUsers.Controls.Add(this.lblphone);
            this.TabUsers.Controls.Add(this.txtEmail);
            this.TabUsers.Controls.Add(this.lblEmail);
            this.TabUsers.Controls.Add(this.txtLastname);
            this.TabUsers.Controls.Add(this.lblLastname);
            this.TabUsers.Controls.Add(this.txtNameUser);
            this.TabUsers.Controls.Add(this.lblNameUser);
            this.TabUsers.HorizontalScrollbarBarColor = true;
            this.TabUsers.HorizontalScrollbarHighlightOnWheel = false;
            this.TabUsers.HorizontalScrollbarSize = 10;
            this.TabUsers.Location = new System.Drawing.Point(4, 38);
            this.TabUsers.Name = "TabUsers";
            this.TabUsers.Size = new System.Drawing.Size(688, 395);
            this.TabUsers.TabIndex = 0;
            this.TabUsers.Text = "Usuarios";
            this.TabUsers.VerticalScrollbarBarColor = true;
            this.TabUsers.VerticalScrollbarHighlightOnWheel = false;
            this.TabUsers.VerticalScrollbarSize = 10;
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
            // lblIDUser
            // 
            this.lblIDUser.AutoSize = true;
            this.lblIDUser.Location = new System.Drawing.Point(5, 75);
            this.lblIDUser.Name = "lblIDUser";
            this.lblIDUser.Size = new System.Drawing.Size(50, 19);
            this.lblIDUser.TabIndex = 18;
            this.lblIDUser.Text = "Cédula";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBREC_USER,
            this.LASTNAME,
            this.ID_USER,
            this.ID_DPTO,
            this.EMAILUSER,
            this.PASSWOORD,
            this.PHONEUSER,
            this.ROLUSER});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.EnableHeadersVisualStyles = false;
            this.dgvUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUser.Location = new System.Drawing.Point(-4, 135);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(696, 267);
            this.dgvUser.TabIndex = 17;
            // 
            // NOMBREC_USER
            // 
            this.NOMBREC_USER.HeaderText = "Nombre";
            this.NOMBREC_USER.Name = "NOMBREC_USER";
            this.NOMBREC_USER.ReadOnly = true;
            // 
            // LASTNAME
            // 
            this.LASTNAME.HeaderText = "Apellidos";
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.ReadOnly = true;
            // 
            // ID_USER
            // 
            this.ID_USER.HeaderText = "Cédula";
            this.ID_USER.Name = "ID_USER";
            this.ID_USER.ReadOnly = true;
            this.ID_USER.Width = 75;
            // 
            // ID_DPTO
            // 
            this.ID_DPTO.HeaderText = "Departamento";
            this.ID_DPTO.Name = "ID_DPTO";
            this.ID_DPTO.ReadOnly = true;
            this.ID_DPTO.Width = 80;
            // 
            // EMAILUSER
            // 
            this.EMAILUSER.HeaderText = "Correo";
            this.EMAILUSER.Name = "EMAILUSER";
            this.EMAILUSER.ReadOnly = true;
            this.EMAILUSER.Width = 80;
            // 
            // PASSWOORD
            // 
            this.PASSWOORD.HeaderText = "Contraseña";
            this.PASSWOORD.Name = "PASSWOORD";
            this.PASSWOORD.ReadOnly = true;
            this.PASSWOORD.Visible = false;
            this.PASSWOORD.Width = 75;
            // 
            // PHONEUSER
            // 
            this.PHONEUSER.HeaderText = "Teléfono";
            this.PHONEUSER.Name = "PHONEUSER";
            this.PHONEUSER.ReadOnly = true;
            this.PHONEUSER.Width = 75;
            // 
            // ROLUSER
            // 
            this.ROLUSER.HeaderText = "Rol";
            this.ROLUSER.Name = "ROLUSER";
            this.ROLUSER.ReadOnly = true;
            this.ROLUSER.Width = 50;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(367, 42);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(143, 23);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(266, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Contraseña";
            // 
            // cbDpto
            // 
            this.cbDpto.FormattingEnabled = true;
            this.cbDpto.ItemHeight = 23;
            this.cbDpto.Location = new System.Drawing.Point(104, 100);
            this.cbDpto.Name = "cbDpto";
            this.cbDpto.Size = new System.Drawing.Size(143, 29);
            this.cbDpto.TabIndex = 14;
            this.cbDpto.UseSelectable = true;
            // 
            // lblDpto
            // 
            this.lblDpto.AutoSize = true;
            this.lblDpto.Location = new System.Drawing.Point(5, 110);
            this.lblDpto.Name = "lblDpto";
            this.lblDpto.Size = new System.Drawing.Size(95, 19);
            this.lblDpto.TabIndex = 13;
            this.lblDpto.Text = "Departamento";
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.ItemHeight = 23;
            this.cbRole.Location = new System.Drawing.Point(367, 100);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(143, 29);
            this.cbRole.TabIndex = 12;
            this.cbRole.UseSelectable = true;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(267, 110);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(28, 19);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Rol";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(367, 71);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(143, 23);
            this.metroTextBox1.TabIndex = 9;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Location = new System.Drawing.Point(267, 75);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(58, 19);
            this.lblphone.TabIndex = 8;
            this.lblphone.Text = "Télefono";
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
            this.txtEmail.Location = new System.Drawing.Point(367, 13);
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(267, 17);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 19);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Correo";
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
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(5, 46);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(63, 19);
            this.lblLastname.TabIndex = 4;
            this.lblLastname.Text = "Apellidos";
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
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(5, 17);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(59, 19);
            this.lblNameUser.TabIndex = 2;
            this.lblNameUser.Text = "Nombre";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnActivate);
            this.metroPanel1.Controls.Add(this.btnInactive);
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
            this.metroPanel1.Size = new System.Drawing.Size(696, 71);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnActivate
            // 
            this.btnActivate.ActiveControl = null;
            this.btnActivate.Location = new System.Drawing.Point(270, 0);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(83, 60);
            this.btnActivate.TabIndex = 14;
            this.btnActivate.Text = "Activar";
            this.btnActivate.UseSelectable = true;
            // 
            // btnInactive
            // 
            this.btnInactive.ActiveControl = null;
            this.btnInactive.Location = new System.Drawing.Point(359, 0);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(83, 60);
            this.btnInactive.TabIndex = 13;
            this.btnInactive.Text = "Inactivar";
            this.btnInactive.UseSelectable = true;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(80, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(590, 37);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(102, 23);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(537, 41);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(47, 19);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Buscar";
            // 
            // pnlUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl);
            this.Name = "pnlUsers";
            this.Size = new System.Drawing.Size(696, 512);
            this.metroTabControl.ResumeLayout(false);
            this.TabUsers.ResumeLayout(false);
            this.TabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroTabPage TabUsers;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroComboBox cbDpto;
        private MetroFramework.Controls.MetroLabel lblDpto;
        private MetroFramework.Controls.MetroComboBox cbRole;
        private MetroFramework.Controls.MetroLabel lblRole;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel lblphone;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroLabel lblLastname;
        private MetroFramework.Controls.MetroTextBox txtNameUser;
        private MetroFramework.Controls.MetroLabel lblNameUser;
        private MetroFramework.Controls.MetroGrid dgvUser;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel lblIDUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBREC_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_DPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASSWOORD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONEUSER;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLUSER;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel lblSearch;
        private MetroFramework.Controls.MetroTile btnActivate;
        private MetroFramework.Controls.MetroTile btnInactive;
    }
}
