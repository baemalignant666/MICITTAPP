using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicittApp.Entities.Objects;
using MicittApp.ApiCore.Management;
using MetroFramework;
using static MicittApp.UI.OnPromises.Program;

namespace MicittApp.UI.OnPromises.Forms
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        UsuarioManagement ApiAccess = new UsuarioManagement();
        Usuario ObjUser = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string ID = txtUserID.Text;
            if (GetLogin() == true)
            {
                MystaticValues.IdSession = ID;
                Program.SetMainForm(new frmDashboard());
                Program.ShowMainForm();
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "El Id o la Contraseña son Erroneos",
                    "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }

        private bool GetLogin()
        {
            string ID = txtUserID.Text;
            string Pass = txtPass.Text;
            bool finded = false;
            
            try
            {


                var ListUser = ApiAccess.RetrieveAllUsuario<Usuario>();
                foreach (Usuario element in ListUser)
                {
                    if (ID == element.Id_User && Pass == element.Pass_User)
                    {
                        finded = true;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return finded;
        }

        
    }
}
