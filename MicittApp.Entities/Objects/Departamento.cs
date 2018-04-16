using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicittApp.Entities.Objects
{
    public class Departamento : BaseEntity
    {
        public int Id_Dtpo { get; set; }
        public string Nombre_Dtpo { get; set; }
        public string Descrip_Dtpo { get; set; }
        
        public int Id_Direccion { get; set; }
        public string Descrip_Dir { get; set; }
        

        public Departamento()
        {
            Id_Dtpo = 0;
            Nombre_Dtpo = "N/A";
            Descrip_Dtpo = "N/A";
            Id_Direccion = 0;
        }
        public Departamento(int pId_Dtpo, string pNombre_Dpto,string pDescrip_Dtpo, int pId_Direccion)
        {
            this.Id_Dtpo = pId_Dtpo;
            this.Nombre_Dtpo = pNombre_Dpto;
            this.Descrip_Dtpo = pDescrip_Dtpo;
            this.Id_Direccion = pId_Direccion;
        }
        public Departamento(int pId_Dtpo, string pNombre_Dpto, string pDescrip_Dtpo, string pDescrip_Dir)
        {
            this.Id_Dtpo = pId_Dtpo;
            this.Nombre_Dtpo = pNombre_Dpto;
            this.Descrip_Dtpo = pDescrip_Dtpo;
            this.Descrip_Dir = pDescrip_Dir;
        }
        public Departamento(int pId_Dtpo, string pNombre_Dpto, string pDescrip_Dtpo, int pId_Direccion, bool pState, 
            string pCreateby, string pUpdateby, DateTime pCreateDate)
        {
            this.Id_Dtpo = pId_Dtpo;
            this.Nombre_Dtpo = pNombre_Dpto;
            this.Descrip_Dtpo = pDescrip_Dtpo;
            this.Id_Direccion = pId_Direccion;
            this.State = pState;
            this.Createby = pCreateby;
            this.Updateby = pUpdateby;
            this.Createdate = pCreateDate;
        }
    }
}
