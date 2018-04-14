namespace MicittApp.UI.OnPromises.Forms
{
    partial class frmDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnConsDocs = new MetroFramework.Controls.MetroTile();
            this.btnUsers = new MetroFramework.Controls.MetroTile();
            this.btnDocs = new MetroFramework.Controls.MetroTile();
            this.btnDpts = new MetroFramework.Controls.MetroTile();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.BtnDirs = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnConsDocs);
            this.metroPanel1.Controls.Add(this.btnUsers);
            this.metroPanel1.Controls.Add(this.btnDocs);
            this.metroPanel1.Controls.Add(this.btnDpts);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(119, 469);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnConsDocs
            // 
            this.btnConsDocs.ActiveControl = null;
            this.btnConsDocs.Location = new System.Drawing.Point(0, 340);
            this.btnConsDocs.Name = "btnConsDocs";
            this.btnConsDocs.Size = new System.Drawing.Size(119, 79);
            this.btnConsDocs.TabIndex = 7;
            this.btnConsDocs.Text = "Consecutivos";
            this.btnConsDocs.UseSelectable = true;
            this.btnConsDocs.Click += new System.EventHandler(this.btnConsDocs_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.ActiveControl = null;
            this.btnUsers.Location = new System.Drawing.Point(0, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(119, 79);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseSelectable = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnDocs
            // 
            this.btnDocs.ActiveControl = null;
            this.btnDocs.Location = new System.Drawing.Point(0, 255);
            this.btnDocs.Name = "btnDocs";
            this.btnDocs.Size = new System.Drawing.Size(119, 79);
            this.btnDocs.TabIndex = 6;
            this.btnDocs.Text = "Documentos";
            this.btnDocs.UseSelectable = true;
            this.btnDocs.Click += new System.EventHandler(this.btnDocs_Click);
            // 
            // btnDpts
            // 
            this.btnDpts.ActiveControl = null;
            this.btnDpts.Location = new System.Drawing.Point(0, 85);
            this.btnDpts.Name = "btnDpts";
            this.btnDpts.Size = new System.Drawing.Size(119, 79);
            this.btnDpts.TabIndex = 5;
            this.btnDpts.Text = "Departamentos";
            this.btnDpts.UseSelectable = true;
            this.btnDpts.Click += new System.EventHandler(this.btnDpts_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(139, 60);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(626, 469);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // BtnDirs
            // 
            this.BtnDirs.ActiveControl = null;
            this.BtnDirs.Location = new System.Drawing.Point(20, 230);
            this.BtnDirs.Name = "BtnDirs";
            this.BtnDirs.Size = new System.Drawing.Size(119, 79);
            this.BtnDirs.TabIndex = 6;
            this.BtnDirs.Text = "Direcciones";
            this.BtnDirs.UseSelectable = true;
            this.BtnDirs.Click += new System.EventHandler(this.BtnDirs_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 549);
            this.Controls.Add(this.BtnDirs);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile btnConsDocs;
        private MetroFramework.Controls.MetroTile btnDocs;
        private MetroFramework.Controls.MetroTile btnDpts;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTile btnUsers;
        private MetroFramework.Controls.MetroTile BtnDirs;
    }
}