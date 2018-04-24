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
    public partial class pnlDocs : pnlSlider
    {
        ConsecutivoManagement ApiAccessCons = new ConsecutivoManagement();
        DocumentoManagement ApiAccess = new DocumentoManagement();
        TipoDocumentoManagement ApiAccessTDoc = new TipoDocumentoManagement();
        Documento ObjDoc = new Documento();
        string IdSession = MystaticValues.IdSession;
        public pnlDocs(Form owner) : base(owner)
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            LoadCbCons(cbCons);
            LoadCbTDoc(cbType);
            LoadDataGrid();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var Titulo_Doc = txtTitulo_DOC.Text;
            var Emisor_Doc = txtEmisor_DOC.Text;
            var Dest_Doc = txtDest_DOC.Text;
            var Ubi_Doc = txtUbi_DOC.Text;
            var TDOC = cbType.Text;
            var Prioridad_Doc = cbPrio_Doc.Text;
            var Identi_Doc = cbCons.Text;
            var Fecha_Doc = dtpDateDoc.Text;
            var Result = GetlastIdDoc();
            if (CheckFields() != true)
            {
                try
                {
                    ObjDoc.Cons_Doc = "MICITT-" + Identi_Doc + "-" + TDOC + "-" + Result + "-" + Fecha_Doc;
                    //MICITT-RH-OF-01-2018
                    ObjDoc.Titulo_doc = Titulo_Doc;
                    ObjDoc.Emisor_doc = Emisor_Doc;
                    ObjDoc.Destinatario_doc = Dest_Doc;
                    ObjDoc.Ubicacion_doc = Ubi_Doc;
                    ObjDoc.Id_TDoc = GetIDTDoc();
                    ObjDoc.Prioridad_doc = Prioridad_Doc;
                    ObjDoc.Id_Identificador = Identi_Doc;
                    ObjDoc.Fecha_doc = Convert.ToDateTime(Fecha_Doc);
                    ObjDoc.Createby = IdSession;
                    ApiAccess.CreateDocumento(ObjDoc);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                LoadDataGrid();
                CleanFields();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var Titulo_Doc = txtTitulo_DOC.Text;
            var Emisor_Doc = txtEmisor_DOC.Text;
            var Dest_Doc = txtDest_DOC.Text;
            var Ubi_Doc = txtUbi_DOC.Text;
            var TDOC = cbType.Text;
            var Prioridad_Doc = cbPrio_Doc.Text;
            var Identi_Doc = cbCons.Text;
            var Fecha_Doc = dtpDateDoc.Text;
            var Result = GetlastIdDoc();
            if (CheckFields() != true) // Validation
            {
                try
                {
                    //ObjDoc.Cons_Doc = "MICITT-" + Identi_Doc + "-" + TDOC + "-" + Result + "-" + Fecha_Doc;
                    //MICITT-RH-OF-01-2018
                    ObjDoc.Titulo_doc = Titulo_Doc;
                    ObjDoc.Emisor_doc = Emisor_Doc;
                    ObjDoc.Destinatario_doc = Dest_Doc;
                    ObjDoc.Ubicacion_doc = Ubi_Doc;
                    ObjDoc.Id_TDoc = GetIDTDoc();
                    ObjDoc.Prioridad_doc = Prioridad_Doc;
                    ObjDoc.Id_Identificador = Identi_Doc;
                    ObjDoc.Fecha_doc = Convert.ToDateTime(Fecha_Doc);
                    ObjDoc.Updateby = IdSession;
                    ApiAccess.UpdateDocumento(ObjDoc);
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
        private void LoadDataGrid()
        {
            try
            {
                dgvDoc.Rows.Clear();
                var ListDoc = ApiAccess.RetrieveAllDocumento<Documento>();
                foreach (Documento element in ListDoc)
                {
                    string[] Row;
                    Row = new string[] { element.Id_doc.ToString(), element.Cons_Doc, element.Titulo_doc, element. Emisor_doc
                    ,element.Destinatario_doc, element.Ubicacion_doc, element.Name_TDoc, element.Prioridad_doc,
                        element.Id_Identificador, element.Fecha_doc.ToString()};
                    dgvDoc.Rows.Add(Row);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int GetIDTDoc()
        {
            int IdTDoc= 0;
            try
            {
                var TDoc = cbType.Text;

                var ListDir = ApiAccessTDoc.RetrieveAllTipoDocumento<TipoDocumento>();
                foreach (TipoDocumento element in ListDir)
                {
                    if (TDoc == element.Name_TDoc)
                    {
                        IdTDoc = element.Id_TDoc;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return IdTDoc;
        }
        private void LoadCbCons(ComboBox cb)
        {
            try
            {
                var ListCons = ApiAccessCons.RetrieveAllConsecutivo<Consecutivo>();
                foreach (Consecutivo element in ListCons)
                {
                    cb.Items.Add(element.Id_Identificador);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void LoadCbTDoc(ComboBox cb)
        {
            try
            {
                var ListTDoc = ApiAccessTDoc.RetrieveAllTipoDocumento<TipoDocumento>();
                foreach (TipoDocumento element in ListTDoc)
                {
                    cb.Items.Add(element.Name_TDoc);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvDoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            try
            {
                int Row = dgvDoc.CurrentRow.Index;
                var IdDoc = dgvDoc[0, Row].Value;
                txtTitulo_DOC.Text = dgvDoc[2, Row].Value.ToString();
                txtEmisor_DOC.Text = dgvDoc[3, Row].Value.ToString();
                txtDest_DOC.Text = dgvDoc[4, Row].Value.ToString();
                txtUbi_DOC.Text = dgvDoc[5, Row].Value.ToString();
                cbType.Text = dgvDoc[6, Row].Value.ToString();
                cbPrio_Doc.Text = dgvDoc[7, Row].Value.ToString();
                cbCons.Text = dgvDoc[8, Row].Value.ToString();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Ha ocurrido un error:" + ex + "Favor Comunicarse con el equipo de Sistemas",
                    "Error en Acción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckFields()
        {
            var Titulo_Doc = txtTitulo_DOC.Text;
            var Emisor_Doc = txtEmisor_DOC.Text;
            var Dest_Doc = txtDest_DOC.Text;
            var Ubi_Doc = txtUbi_DOC.Text;
            var TDOC = cbType.Text;
            var Prioridad_Doc = cbPrio_Doc.Text;
            var Identi_Doc = cbCons.Text;
            var Fecha_Doc = dtpDateDoc.Text;
            bool finded = false;
            if (Titulo_Doc.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Titulo -" + Titulo_Doc + "- no es Valido. \n Favor Digite un Titulo Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitulo_DOC.Focus();
                finded = true;
            }
            if (Emisor_Doc.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Emisor -" + Emisor_Doc + "- no es Valido. \n Favor Digite un Emisor Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmisor_DOC.Focus();
                finded = true;
            }
            if (Dest_Doc.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Destinatario -" + Dest_Doc + "- no es Valido. \n Favor Digite un Destinatario Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDest_DOC.Focus();
                finded = true;
            }
            if (Ubi_Doc.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "La Ubicación -" + Ubi_Doc + "- no es Valida. \n Favor Digite un Ubicación Valida", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUbi_DOC.Focus();
                finded = true;
            }
            if (TDOC.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Tipo de Documento -" + TDOC + "- no es Valida. \n Favor Seleccione un Tipo Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbType.Focus();
                finded = true;
            }
            if (Prioridad_Doc.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "La Prioridad -" + Prioridad_Doc + "- no es Valida. \n Favor Seleccione una Prioridad Valida", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbPrio_Doc.Focus();
                finded = true;
            }
            if (Identi_Doc.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Consecutivo -" + Identi_Doc + "- no es Valido. \n Favor Seleccione un Consecutivo Valido", "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbPrio_Doc.Focus();
                finded = true;
            }
            return finded;
        }
        private void CleanFields()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtTitulo_DOC.Text = "";
            txtEmisor_DOC.Text = "";
            txtDest_DOC.Text = "";
            txtUbi_DOC.Text = "";
            cbType.Text = "";
            cbPrio_Doc.Text = "";
            cbCons.Text = "";
            dtpDateDoc.Text = "";
        }
        public int GetlastIdDoc()
        {
            int pId_Doc = 0;
            try
            {
                
                var ListDoc = ApiAccess.RetrieveAllDocumento<Documento>();
                foreach (Documento element in ListDoc)
                {
                    pId_Doc = element.Id_doc;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return pId_Doc + 1;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Row = dgvDoc.CurrentRow.Index;
            var Cons = dgvDoc[1, Row].Value;
            if (MetroFramework.MetroMessageBox.Show(this, "¿Desea Eliminar El Consecutivo: " + Cons + "?", "Confirmación de Acción",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ObjDoc.Id_doc= Convert.ToInt32(dgvDoc[0, Row].Value);
                    ApiAccess.DeleteDDocumento(ObjDoc);
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
            LoadDataGrid();
            CleanFields();
        }
    }
}
