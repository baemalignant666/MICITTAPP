using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicittApp.Entities.Objects;
using MicittApp.ApiCore.Management;
using MetroFramework;
using static MicittApp.UI.OnPromises.Program;

namespace MicittApp.UI.OnPromises.Panels
{
    public partial class pnlUsers : pnlSlider
    {
        DepartamentoManagement ApiAccessDpt = new DepartamentoManagement();
        UsuarioManagement ApiAccess = new UsuarioManagement();
        Usuario ObjUser = new Usuario();
        string IdSession = MystaticValues.IdSession;
        public pnlUsers(Form owner) : base(owner)
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadCbDpt(cbDpto);
            LoadDataGrid();
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvUser.Rows.Clear();
                var ListUser = ApiAccess.RetrieveAllUsuario<Usuario>();
                foreach (Usuario element in ListUser)
                {
                    string[] Row;
                    Row = new string[] { element.Nombrec_User, element.Apellido1_User, element.Id_User,
                    element.Nombre_Dtpo,element.Correo_User,element.Pass_User, element.Telefono_User, element.Role};
                    dgvUser.Rows.Add(Row);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var NameUser = txtNameUser.Text;
            var Lastname = txtLastname.Text;
            var EmailUser = txtEmail.Text;
            var Id_User = txtIdUser.Text;
            var PhoneUser = txtPhoneUser.Text;
            var Role = cbRole.Text;
            var Id_Dpto = GetIDDpt();
            var Pass = txtPassword.Text;
            if (CheckFields() != true && CheckFieldsDuplicate() != true)
            {
                try
                {
                    ObjUser.Nombrec_User = NameUser;
                    ObjUser.Apellido1_User = Lastname;
                    ObjUser.Correo_User = EmailUser;
                    ObjUser.Id_User = Id_User;
                    ObjUser.Telefono_User = PhoneUser;
                    ObjUser.Role = Role;
                    ObjUser.Id_Dpto = Id_Dpto;
                    ObjUser.Pass_User = Pass;
                    ObjUser.Createby = IdSession;
                    ApiAccess.CreateUsuario(ObjUser);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var NameUser = txtNameUser.Text;
            var Lastname = txtLastname.Text;
            var EmailUser = txtEmail.Text;
            var Id_User = txtIdUser.Text;
            var PhoneUser = txtPhoneUser.Text;
            var Role = cbRole.Text;
            var Id_Dpto = GetIDDpt();
            var Pass = txtPassword.Text;
            if (CheckFields() != true)
            {
                try
                {
                    ObjUser.Nombrec_User = NameUser;
                    ObjUser.Apellido1_User = Lastname;
                    ObjUser.Correo_User = EmailUser;
                    ObjUser.Telefono_User = PhoneUser;
                    ObjUser.Role = Role;
                    ObjUser.Id_Dpto = Id_Dpto;
                    ObjUser.Pass_User = Pass;
                    ObjUser.Updateby = IdSession;
                    ApiAccess.UpdateUsuario(ObjUser);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var NameUser = txtNameUser.Text;
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar El Usuario: " + NameUser + "?", "Confirmación de Acción",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int Row = dgvUser.CurrentRow.Index;
                    ObjUser.Id_User = dgvUser[0, Row].Value.ToString() ;
                    ObjUser.Updateby = IdSession;
                    ApiAccess.DeleteDUsuario(ObjUser);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CleanFields();
            LoadDataGrid();
        }
        private int GetIDDpt()
        {
            int IdDpt = 0;
            try
            {
                var Dpt = cbDpto.Text;

                var ListDir = ApiAccessDpt.RetrieveAllDepartamento<Departamento>();
                foreach (Departamento element in ListDir)
                {
                    if (Dpt == element.Nombre_Dtpo)
                    {
                        IdDpt = element.Id_Dtpo;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdDpt;
        }
        private bool CheckFields()
        {
            var NameUser = txtNameUser.Text;
            var Lastname = txtLastname.Text;
            var EmailUser = txtEmail.Text;
            var Id_User = txtIdUser.Text;
            var PhoneUser = txtPhoneUser.Text;
            var Role = cbRole.Text;
            var CheckDpto = cbDpto.Text;
            var Pass = txtPassword.Text;
            bool finded = false;
            if (NameUser.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameUser + "- no es Valido. \n Favor Digite un Nombres Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameUser.Focus();
                finded = true;
            }
            if (Lastname.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Apellido -" + Lastname + "- no es Valido. \n Favor Digite un Apellido Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLastname.Focus();
                finded = true;
            }
            if (EmailUser.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Correo -" + EmailUser + "- no es Valido. \n Favor Digite un Correo Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                finded = true;
            }
            if (Id_User.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "La Cédula -" + Id_User + "- no es Valida. \n Favor Digite un Cédula Valida", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdUser.Focus();
                finded = true;
            }
            if (PhoneUser.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Teléfono -" + PhoneUser + "- no es Valida. \n Favor Digite un Teléfono Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneUser.Focus();
                finded = true;
            }
            if (Role.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Rol -" + Role + "- no es Valido. \n Favor Seleccione un Rol Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbRole.Focus();
                finded = true;
            }
            if (CheckDpto.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Departamento -" + CheckDpto + "- no es Valido. \n Favor Seleccione un Departamento Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDpto.Focus();
                finded = true;
            }
            if (Pass.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "La Contraseña no es Valida. \n Favor Digite una Contraseña Valida", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                finded = true;
            }
            return finded;
        }
        private void CleanFields()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtIdUser.Enabled = true;
            txtNameUser.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtIdUser.Text = "";
            txtPhoneUser.Text = "";
            cbRole.Text = "";
            cbDpto.Text = "";
            txtPassword.Text = "";
        }
        private bool CheckFieldsDuplicate()
        {
            var IdUser = txtIdUser.Text;
            bool finded = false;
            var ListDpt = ApiAccess.RetrieveAllUsuario<Usuario>();
            foreach (Usuario element in ListDpt)
            {
                if (element.Id_User == IdUser)
                {
                    MetroMessageBox.Show(this, "La Cédula -" + IdUser + "- no es Valida. \n No se aceptan valores duplicados", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    finded = true;
                    if (finded == true)
                    {
                        break;
                    }
                }
            }
            return finded;
        }
        private void LoadCbDpt(ComboBox cb)
        {
            try
            {
                var ListDpt = ApiAccessDpt.RetrieveAllDepartamento<Departamento>();
                foreach (Departamento element in ListDpt)
                {
                    cb.Items.Add(element.Nombre_Dtpo);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtEmail_Click(object sender, EventArgs e)
        {

        }
        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txtIdUser.Enabled = false;
            try
            {
                int Row = dgvUser.CurrentRow.Index;
                txtNameUser.Text = dgvUser[0, Row].Value.ToString();
                txtLastname.Text = dgvUser[1, Row].Value.ToString();
                txtIdUser.Text = dgvUser[2, Row].Value.ToString();
                cbDpto.Text = dgvUser[3, Row].Value.ToString();
                txtEmail.Text = dgvUser[4, Row].Value.ToString();
                txtPassword.Text = dgvUser[5, Row].Value.ToString();
                txtPhoneUser.Text = dgvUser[6, Row].Value.ToString();
                cbRole.Text = dgvUser[7, Row].Value.ToString();

                //element.Nombrec_User, element.Apellido1_User, element.Id_User,
                //    element.Nombre_Dtpo,element.Correo_User,element.Pass_User, element.Telefono_User, element.Role};

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
