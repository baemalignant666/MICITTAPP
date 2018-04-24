using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicittApp.Entities.Objects
{
    public class TipoDocumento : BaseEntity
    {
        public int Id_TDoc { get; set; }
        public string Name_TDoc { get; set; }
        public TipoDocumento()
        {
            Id_TDoc = 0;
            Name_TDoc = "N/A";
        }
        public TipoDocumento(int pId_TDoc, string pName_TDoc)
        {
            this.Id_TDoc = pId_TDoc;
            this.Name_TDoc = pName_TDoc;
        }
        public TipoDocumento(int pId_TDoc, string pName_TDoc, bool pState,
            string pCreateby, string pUpdateby, DateTime pCreateDate)
        {
            this.Id_TDoc = pId_TDoc;
            this.Name_TDoc = pName_TDoc;
            this.State = pState;
            this.Createby = pCreateby;
            this.Updateby = pUpdateby;
            this.Createdate = pCreateDate;
        }
    }
}
