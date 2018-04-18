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
        DocumentoManagement ApiAccessDocs = new DocumentoManagement();
        Documento ObjDoc = new Documento();
        string IdSession = MystaticValues.IdSession;
        public pnlDocs(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
