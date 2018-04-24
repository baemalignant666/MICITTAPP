using MicittApp.UI.OnPromises.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MicittApp.UI.OnPromises.Program;
using MicittApp.Entities.Objects;
using MicittApp.ApiCore.Management;
using MetroFramework;

namespace MicittApp.UI.OnPromises.Forms
{
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        UsuarioManagement ApiAccess = new UsuarioManagement();
        Usuario ObjUser = new Usuario();
        string IdSession = MystaticValues.IdSession;
        public frmDashboard()
        {
            InitializeComponent();
            LoadPermissions();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlUsers _pnlUsers = new pnlUsers(this);
            this.metroPanel2.Controls.Add(_pnlUsers);
            _pnlUsers.swipe();
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlDocs _pnlDocs = new pnlDocs(this);
            this.metroPanel2.Controls.Add(_pnlDocs);
            _pnlDocs.swipe();
        }

        private void btnDpts_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlDpts _pnlDpts = new pnlDpts(this);
            this.metroPanel2.Controls.Add(_pnlDpts);
            _pnlDpts.swipe();
        }

        private void BtnDirs_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlDir _pnlDir = new pnlDir(this);
            this.metroPanel2.Controls.Add(_pnlDir);
            _pnlDir.swipe();
        }

        private void btnConsDocs_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlConsDpt _pnlConsDpt = new pnlConsDpt(this);
            this.metroPanel2.Controls.Add(_pnlConsDpt);
            _pnlConsDpt.swipe();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Program.SetMainForm(new frmLogin());
            Program.ShowMainForm();
            this.Close();
        }

        private void btnTDoc_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlTDocs _pnlTDocs = new pnlTDocs(this);
            this.metroPanel2.Controls.Add(_pnlTDocs);
            _pnlTDocs.swipe();
        }
        private void LoadPermissions()
        {
            if(GetRole() == "REGULAR")
            {
                btnDocs.Visible = true;
                btnDpts.Visible = false;
                BtnDirs.Visible = false;
                btnTDoc.Visible = false;
                btnConsDocs.Visible = false;
                btnUsers.Visible = false;
            }
        }
        private string GetRole()
        {
            string Role = "";
            try
            {
               

                var ListUser = ApiAccess.RetrieveAllUsuario<Usuario>();
                foreach (Usuario element in ListUser)
                {
                    if (IdSession == element.Id_User)
                    {
                        Role = element.Role;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Role;
        }
    }
}
