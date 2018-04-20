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
    public partial class pnlConsDpt : pnlSlider
    {
        ConsecutivoManagement ApiAccess = new ConsecutivoManagement();
        DepartamentoManagement ApiAccessDpt = new DepartamentoManagement();
        Consecutivo ObjCons = new Consecutivo();
        string IdSession = MystaticValues.IdSession;
        public pnlConsDpt(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadPanel();
            btnActivate.Enabled = false;
            btnUpdate.Enabled = false;
            btnInactive.Enabled = false;
            btnDelete.Enabled = false;
        }
        //Managament Methods
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var Cons = txtCons.Text;
            var Id_Dpto = GetIdDptCb();
            if (CheckFields() != true && CheckFieldsDuplicate() != true)
            {

            }
                try
                {
                    ObjCons.Id_Identificador = Cons;
                    ObjCons.Id_Dpto = Id_Dpto;
                    ObjCons.Createby = IdSession;
                    ApiAccess.CreateConsecutivo(ObjCons);
                }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CleanFields();
                LoadDataGrid();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Cons = txtCons.Text;
            var Id_Dpto = GetIdDptCb();
            if (Cons.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Consecutivo -" + Cons + "- no es Valido. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCons.Focus();
            }
            if (cbDpto.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar un Departamento. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDpto.Focus();
            }
            else
            {
                try
                {
                    ObjCons.Id_Identificador = Cons;
                    ObjCons.Id_Dpto = Id_Dpto;
                    ObjCons.Updateby = IdSession;
                    ApiAccess.UpdateConsecutivo(ObjCons);
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
            var Cons = txtCons.Text;
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar la Cons: " + Cons + "?",
                "Confirmación de Acción",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int Row = dgvCons.CurrentRow.Index;
                    ObjCons.Id_Identificador = dgvCons[0, Row].Value.ToString();
                    ObjCons.Updateby = IdSession;
                    ApiAccess.DeleteConsecutivo(ObjCons);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                     "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void dgvCons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                int Row = dgvCons.CurrentRow.Index;
                txtCons.Text = dgvCons[0, Row].Value.ToString();
                cbDpto.Text = dgvCons[1, Row].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            CleanFields();
        }
        private void LoadPanel()
        {
            LoadDataGrid();
            LoadCbDpt(cbDpto);
        }
        private void LoadDataGrid()
        {
            try
            {
                dgvCons.Rows.Clear();
                var ListCons = ApiAccess.RetrieveAllConsecutivo<Consecutivo>();
                foreach (Consecutivo element in ListCons)
                {
                    string[] Row;
                    Row = new string[] { element.Id_Identificador, element.Name_Dpto};
                    dgvCons.Rows.Add(Row);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private int GetIdDptCb() // Get the Id of Dpt in the Combo Box while Crud
        {
            int IdDpt = 0;
            try
            {
                var NameDpt = cbDpto.Text;
                var ListDpt = ApiAccessDpt.RetrieveAllDepartamento<Departamento>();
                foreach (Departamento element in ListDpt)
                {
                    if (NameDpt == element.Nombre_Dtpo)
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
        //Validation Methods
        private void CleanFields()
        {
            txtCons.Text = "";
            cbDpto.Text = "";
            btnActivate.Enabled = false;
            btnUpdate.Enabled = false;
            btnInactive.Enabled = false;
            btnDelete.Enabled = false;
        }
        private bool CheckFields()
        {
            var Cons = txtCons.Text;
            bool finded = false;
            if (Cons.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Consecutivo -" + Cons + "- no es Valido. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCons.Focus();
                finded = true;
            }
            if (cbDpto.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar un Departamento. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDpto.Focus();
                finded = true;
            }
            return finded;
        }
        private bool CheckFieldsDuplicate()
        {
            var IdCons = txtCons.Text;
            bool finded = false;
            var ListCons = ApiAccess.RetrieveAllConsecutivo<Consecutivo>();
            foreach (Consecutivo element in ListCons)
            {
                if (element.Id_Identificador == IdCons)
                {
                    MetroMessageBox.Show(this, "El Consecutivo: -" + IdCons + "- no es Valido. \n No se aceptan valores duplicados", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    finded = true;
                    if (finded == true)
                    {
                        break;
                    }
                   if (element.Id_Dpto == GetIdDptCb())
                    {
                        MetroMessageBox.Show(this, "El Departamento: -" + cbDpto.Text + "- no es Valido. \n Ya se posee Consecutivo Asignado", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        finded = true;
                        if (finded == true)
                        {
                            break;
                        }
                    }
                }
            }
            return finded;
        }

    }
}
