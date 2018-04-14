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
        //Validation Methods
        private void CleanFields()
        {
            txtDescripDir.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var NameDir = txtDescripDir.Text;
            if (NameDir.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameDir + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripDir.Focus();
            }
            else
            {
                try
                {
                    ObjDir.Descrip_Dir = NameDir;
                    ObjDir.Createby = IdSession;
                    ApiAccess.CreateDireccion(ObjDir);
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
            var NameDir = txtDescripDir.Text;
            if (NameDir.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Nombre -" + NameDir + "- no es Valido. \n Favor Digite un Nombre Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripDir.Focus();
            }
            else
            {
                try
                {
                    int Row = dgvDir.CurrentRow.Index;
                    ObjDir.Id_Dir = Convert.ToInt32(dgvDir[0, Row].Value);
                    ObjDir.Descrip_Dir = NameDir;
                    ObjDir.Updateby = IdSession;
                    ApiAccess.CreateDireccion(ObjDir);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            CleanFields();
            LoadDataGrid();
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
    }
}
