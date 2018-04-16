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

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

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
            LoadCbDpt(cbDpto);
            LoadDataGrid();
        }

    }
}
