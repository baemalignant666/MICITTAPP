using MicittApp.UI.OnPromises.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicittApp.UI.OnPromises.Forms
{
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlUsers _pnlUsers = new pnlUsers(this);
            this.metroPanel2.Controls.Add(_pnlUsers);
            _pnlUsers.swipe();
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlDocs _pnlDocs = new pnlDocs(this);
            this.metroPanel2.Controls.Add(_pnlDocs);
            _pnlDocs.swipe();
        }

        private void btnDpts_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlDpts _pnlDpts = new pnlDpts(this);
            this.metroPanel2.Controls.Add(_pnlDpts);
            _pnlDpts.swipe();
        }

        private void BtnDirs_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlDir _pnlDir = new pnlDir(this);
            this.metroPanel2.Controls.Add(_pnlDir);
            _pnlDir.swipe();
        }

        private void btnConsDocs_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlConsDpt _pnlConsDpt = new pnlConsDpt(this);
            this.metroPanel2.Controls.Add(_pnlConsDpt);
            _pnlConsDpt.swipe();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTDoc_Click(object sender, EventArgs e)
        {
            this.metroPanel2.Controls.Clear();
            pnlTDocs _pnlTDocs = new pnlTDocs(this);
            this.metroPanel2.Controls.Add(_pnlTDocs);
            _pnlTDocs.swipe();
        }
    }
}
