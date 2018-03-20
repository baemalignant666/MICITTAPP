using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicittApp.Entities.Objects
{
    public class Consecutivo : BaseEntity
    {
        public string Id_Identificador { get; set; }
        public int Id_Dpto { get; set; }
        public Consecutivo()
        {
            Id_Identificador = "N/A";
            Id_Dpto = 0;
        }
        public Consecutivo(string pId_Identificador, int pId_Dpto)
        {
            this.Id_Identificador = pId_Identificador;
            this.Id_Dpto = pId_Dpto;
        }
        public Consecutivo(string pId_Identificador, int pId_Dpto, bool pState,
            string pCreateby, string pUpdateby, DateTime pCreateDate)
        {
            this.Id_Identificador = pId_Identificador;
            this.Id_Dpto = pId_Dpto;
            this.State = pState;
            this.Createby = pCreateby;
            this.Updateby = pUpdateby;
            this.Createdate = pCreateDate;
        }
    }
}
