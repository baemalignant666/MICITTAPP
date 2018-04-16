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
    public partial class pnlDpts : pnlSlider
    {
        DepartamentoManagement ApiAccess = new DepartamentoManagement();
        DireccionManagement ApiAccessDir = new DireccionManagement();
        Departamento ObjDpto = new Departamento();
        string IdSession = MystaticValues.IdSession;
        public pnlDpts(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadPanel();
        }
        //Managament Methods
        private void LoadDataGrid()
        {
            try
            {
                dgvDpt.Rows.Clear();
                var ListDpto = ApiAccess.RetrieveAllDepartamento<Departamento>();
                foreach (Departamento element in ListDpto)
                {
                    string[] Row;
                    Row = new string[] { element.Id_Dtpo.ToString(), element.Nombre_Dtpo,element.Descrip_Dtpo,element.Descrip_Dir};
                    dgvDpt.Rows.Add(Row);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var NameDpt = txtNameDpt.Text;
            var DescripDpt = txtDescripDpt.Text;
            var IdDir = GetIDDir();
            if (NameDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + Name + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameDpt.Focus();
            }
            if (DescripDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "La Descripción -" + Name + "- no es Valida. \n Favor Digite una Descripción Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameDpt.Focus();
            }
            if (cbDir.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar una Dirección. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDir.Focus();
            }
            else
            {
                try
                {

                    ObjDpto.Nombre_Dtpo = NameDpt;
                    ObjDpto.Descrip_Dtpo = DescripDpt;
                    ObjDpto.Id_Direccion = IdDir;
                    ObjDpto.Createby = IdSession;
                    ApiAccess.CreateDepartamento(ObjDpto);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var NameDpt = txtNameDpt.Text;
            var DescripDpt = txtDescripDpt.Text;
            var IdDir = GetIDDir();
            if (NameDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + Name + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameDpt.Focus();
            }
            if (DescripDpt.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "La Descripción -" + Name + "- no es Valida. \n Favor Digite una Descripción Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameDpt.Focus();
            }
            if (cbDir.Text == string.Empty)
            {
                MetroMessageBox.Show(this, "Debe Seleccionar una Dirección. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbDir.Focus();
            }
            else
            {
                try
                {
                    int Row = dgvDpt.CurrentRow.Index;
                    ObjDpto.Id_Dtpo = Convert.ToInt32(dgvDpt[0, Row].Value);
                    ObjDpto.Nombre_Dtpo = NameDpt;
                    ObjDpto.Descrip_Dtpo = DescripDpt;
                    ObjDpto.Id_Direccion = IdDir;
                    ObjDpto.Updateby = IdSession;
                    ApiAccess.UpdateDepartamento(ObjDpto);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var NameDpto = txtNameDpt.Text;
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar El Departamento: " + NameDpto + "?", "Confirmación de Acción",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int Row = dgvDpt.CurrentRow.Index;
                    ObjDpto.Id_Dtpo= Convert.ToInt32(dgvDpt[0, Row].Value);
                    ObjDpto.Updateby = IdSession;
                    ApiAccess.DeleteDepartamento(ObjDpto);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        //Rutines
        private void LoadCbDpt(ComboBox cb)
        {
            try
            {
                var ListDir = ApiAccessDir.RetrieveAllDireccion<Direccion>();
                foreach (Direccion element in ListDir)
                {
                    cb.Items.Add(element.Descrip_Dir);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void LoadPanel()
        {
            LoadCbDpt(cbDir);
            LoadDataGrid();
        }
        private int GetIDDir()
        {
            try
            {
                var DescripDir = cbDir.Text;
                int IdDir = 0;
                var ListDir = ApiAccessDir.RetrieveAllDireccion<Direccion>();
                foreach (Direccion element in ListDir)
                {
                    if (DescripDir == element.Descrip_Dir)
                    {
                        IdDir = element.Id_Dir;
                        break;
                    }
                }
                return IdDir;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CleanFields()
        {
            txtDescripDpt.Text = "";
            txtNameDpt.Text = "";
            txtSearch.Text = "";
        }

        private void dgvDpt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                int Row = dgvDpt.CurrentRow.Index;
                var IdDpto = dgvDpt[0, Row].Value;
                txtNameDpt.Text = dgvDpt[1, Row].Value.ToString();
                txtDescripDpt.Text = dgvDpt[2, Row].Value.ToString();
                cbDir.Text = dgvDpt[3, Row].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
