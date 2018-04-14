﻿using System;
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
        Consecutivo ObjCons = new Consecutivo();
        string IdSession = MystaticValues.IdSession;
        public pnlConsDpt(Form owner) : base(owner)
        {
            InitializeComponent();
        }
        //Managament Methods
        private void LoadDataGrid()
        {
            try
            {
                dgvCons.Rows.Clear();
                var ListCons = ApiAccess.RetrieveAllConsecutivo<Consecutivo>();
                foreach (Consecutivo element in ListCons)
                {
                    string[] Row;
                    Row = new string[] { element.Id_Identificador, element.Id_Dpto.ToString()};
                    dgvCons.Rows.Add(Row);
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
            txtCons.Text = "";
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var Cons = txtCons.Text;
            var Id_Dpto = cbDpto.Text;
            if (Cons.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Consecutivo -" + Cons + "- no es Valido. \n Favor Digite un Nombre Valido", 
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCons.Focus();
            }
            if (Id_Dpto.Trim() == string.Empty)
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
                    ObjCons.Id_Dpto = Convert.ToInt32(Id_Dpto);
                    ObjCons.Createby = IdSession;
                    ApiAccess.CreateConsecutivo(ObjCons);
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
            var Cons = txtCons.Text;
            var Id_Dpto = cbDpto.Text;
            if (Cons.Trim() == string.Empty)
            {
                MetroMessageBox.Show(this, "El Consecutivo -" + Cons + "- no es Valido. \n Favor Digite un Nombre Valido",
                    "Error en Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCons.Focus();
            }
            if (Id_Dpto.Trim() == string.Empty)
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
                    ObjCons.Id_Dpto = Convert.ToInt32(Id_Dpto);
                    ObjCons.Updateby = IdSession;
                    ApiAccess.UpdateConsecutivo(ObjCons);
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
