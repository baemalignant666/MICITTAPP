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
    public partial class pnlDir : pnlSlider
    {
        // Panel Variables
        DireccionManagement ApiAccess = new DireccionManagement();
        Direccion ObjDir = new Direccion();
        string IdSession = MystaticValues.IdSession;
       
        public pnlDir(Form owner) : base(owner)
        {
            InitializeComponent();
            LoadDataGrid();
            btnActivate.Enabled = false;
            btnUpdate.Enabled = false;
            btnInactive.Enabled = false;
            btnDelete.Enabled = false;
        }
        //Managament Methods
        private void LoadDataGrid()
        {
            try
            {
                dgvDir.Rows.Clear();
                var ListDir = ApiAccess.RetrieveAllDireccion<Direccion>();
                foreach (Direccion element in ListDir)
                {
                    string[] Row;
                    Row = new string[] { element.Id_Dir.ToString(), element.Descrip_Dir };
                    dgvDir.Rows.Add(Row);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var NameDir = txtDescripDir.Text;
            if (CheckFields() != true && CheckFieldsDuplicate() != true) // Validation
            {
                try
                {
                    ObjDir.Descrip_Dir = NameDir;
                    ObjDir.Createby = IdSession;
                    ApiAccess.CreateDireccion(ObjDir);
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
            var NameDir = txtDescripDir.Text;
            if (CheckFields() != true && CheckFieldsDuplicate() != true)
            {
                try
                {
                    int Row = dgvDir.CurrentRow.Index;
                    ObjDir.Id_Dir = Convert.ToInt32(dgvDir[0, Row].Value);
                    ObjDir.Descrip_Dir = NameDir;
                    ObjDir.Updateby = IdSession;
                    ApiAccess.UpdateDireccion(ObjDir);
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
            var NameDir = txtDescripDir.Text;
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar la Dirección: " + NameDir + "?", "Confirmación de Acción",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int Row = dgvDir.CurrentRow.Index;
                    ObjDir.Id_Dir = Convert.ToInt32(dgvDir[0, Row].Value);
                    ObjDir.Updateby = IdSession;
                    ApiAccess.DeleteDireccion(ObjDir);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void dgvDir_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActivate.Enabled = true;
            btnUpdate.Enabled = true;
            btnInactive.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                int Row = dgvDir.CurrentRow.Index;
                var IdDir = dgvDir[0, Row].Value;
                txtDescripDir.Text = dgvDir[1, Row].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
            CleanFields();
        }
        //Validation Methods
        private void CleanFields()
        {
            txtDescripDir.Text = "";
            btnActivate.Enabled = false;
            btnUpdate.Enabled = false;
            btnInactive.Enabled = false;
            btnDelete.Enabled = false;
        }
        private bool CheckFields()
        {
            var NameDir = txtDescripDir.Text;
            bool finded = false;
            if (NameDir.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameDir + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripDir.Focus();
                finded = true;
            }
            return finded;
        }
        private bool CheckFieldsDuplicate()
        {
            var NameDir = txtDescripDir.Text;
            bool finded = false;
            var ListDir = ApiAccess.RetrieveAllDireccion<Direccion>();
            foreach (Direccion element in ListDir)
            {
                if (element.Descrip_Dir == NameDir)
                {
                    MetroMessageBox.Show(this, "El Nombre -" + NameDir + "- no es Valido. \n No se aceptan valores duplicados", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    finded = true;
                    if (finded == true)
                    {
                        break;
                    }
                }
            }
            return finded;
        }
    }
}
