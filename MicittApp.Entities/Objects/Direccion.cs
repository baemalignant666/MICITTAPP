using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicittApp.Entities.Objects
{
    public class Direccion : BaseEntity
    {
        public int Id_Dir { get; set; }
        public string Descrip_Dir { get; set; }
        
        public Direccion()
        {
            Id_Dir = 0;
            Descrip_Dir = "N/A";
        }
        public Direccion(int pId_Dir, string pDescrip_Dir)
        {
            this.Id_Dir = pId_Dir;
            this.Descrip_Dir = pDescrip_Dir;
        }
        public Direccion(int pId_Dir, string pDescrip_Dir, bool pState,
            string pCreateby, string pUpdateby, DateTime pCreateDate)
        {
            this.Id_Dir = pId_Dir;
            this.Descrip_Dir = pDescrip_Dir;
            this.State = pState;
            this.Createby = pCreateby;
            this.Updateby = pUpdateby;
            this.Createdate = pCreateDate;
        }
    }
}
