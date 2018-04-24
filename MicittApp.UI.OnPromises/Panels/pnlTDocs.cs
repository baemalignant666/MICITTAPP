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
    public partial class pnlTDocs : pnlSlider
    {
        TipoDocumento ObjTDOC = new TipoDocumento();
        TipoDocumentoManagement ApiAccess = new TipoDocumentoManagement();
        string IdSession = MystaticValues.IdSession;
        public pnlTDocs(Form owner) : base(owner)
        {
            InitializeComponent();
            btnActivate.Enabled = false;
            btnUpdate.Enabled = false;
            btnInactivate.Enabled = false;
            btnDelete.Enabled = false;
            LoadDataGrid();
        }
        //Managament Methods
        private void LoadDataGrid()
        {
            try
            {
                dgvTDoc.Rows.Clear();
                var ListTDOC = ApiAccess.RetrieveAllTipoDocumento<TipoDocumento>();
                foreach (TipoDocumento element in ListTDOC)
                {
                    string[] Row;
                    Row = new string[] { element.Id_TDoc.ToString(), element.Name_TDoc };
                    dgvTDoc.Rows.Add(Row);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var NameTDOC = txtNameUser.Text;
            if (CheckFields() != true && CheckFieldsDuplicate() != true) // Validation
            {
                try
                {
                    ObjTDOC.Name_TDoc = NameTDOC;
                    ObjTDOC.Createby = IdSession;
                    ApiAccess.CreateTipoDocumento(ObjTDOC);
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
            var NameTDOC = txtNameUser.Text;
            if (CheckFields() != true && CheckFieldsDuplicate() != true) // Validation
            {
                try
                {
                    ObjTDOC.Name_TDoc = NameTDOC;
                    ObjTDOC.Createby = IdSession;
                    ApiAccess.UpdateTipoDocumento(ObjTDOC);
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
        //Validation Methods
        private void CleanFields()
        {
            txtNameUser.Text = "";
            btnActivate.Enabled = false;
            btnUpdate.Enabled = false;
            btnInactivate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private bool CheckFields()
        {
            var NameTDoc = txtNameUser.Text;
            bool finded = false;
            if (NameTDoc.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameTDoc + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameUser.Focus();
                finded = true;
            }
            return finded;
        }
        private bool CheckFieldsDuplicate()
        {
            var NameTDoc = txtNameUser.Text;
            bool finded = false;
            var ListTDOC = ApiAccess.RetrieveAllTipoDocumento<TipoDocumento>();
            foreach (TipoDocumento element in ListTDOC)
            {
                if (element.Name_TDoc == NameTDoc)
                {
                    MetroMessageBox.Show(this, "El Nombre -" + NameTDoc + "- no es Valido. \n No se aceptan valores duplicados", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    finded = true;
                    if (finded == true)
                    {
                        break;
                    }
                }
            }
            return finded;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var NameTDOC = txtNameUser.Text;
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar El tipo de Documento: " + NameTDOC + "?", "Confirmación de Acción",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int Row = dgvTDoc.CurrentRow.Index;
                    ObjTDOC.Id_TDoc = Convert.ToInt32(dgvTDoc[0, Row].Value);
                    ObjTDOC.Updateby = IdSession;
                    ApiAccess.DeleteTipoDocumento(ObjTDOC);
                }
                catch (Exception)
                {
                    throw;
                }
                CleanFields();
                LoadDataGrid();
            }
        }
        private void dgvTDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActivate.Enabled = true;
            btnUpdate.Enabled = true;
            btnInactivate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                int Row = dgvTDoc.CurrentRow.Index;
                var IdTDOC = dgvTDoc[0, Row].Value;
                txtNameUser.Text = dgvTDoc[1, Row].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
