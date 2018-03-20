using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicittApp.Entities.Objects
{
    public class Documento : BaseEntity
    {
        public int Id_doc { get; set; }
        public int Id_Identificador { get; set; }
        public string Titulo_doc { get; set; }
        public string Emisor_doc { get; set; } //Id_User Emisior
        public string Destinatario_doc { get; set; } //Id_User Destinatario
        public DateTime Fecha_doc { get; set; }
        public string Prioridad_doc { get; set; }
        public string Ubicacion_doc { get; set; }
        public Documento()
        {
            Id_doc = 0;
            Id_Identificador = 0;
            Titulo_doc = "N/A";
            Emisor_doc = "N/A";
            Destinatario_doc = "N/A";
            Fecha_doc = DateTime.Today; //default
            Prioridad_doc = "N/A";
            Ubicacion_doc = "N/A";
        }
        public Documento(int pId_doc, int pId_Identificador, string pTitulo_doc, 
            string pEmisor_doc, string pDestinatario_doc, DateTime pFecha_doc, string pPrioridad_doc, string pUbicacion_doc)
        {
            this.Id_doc = pId_doc;
            this.Id_Identificador = pId_Identificador;
            this.Titulo_doc = pTitulo_doc;
            this.Emisor_doc = pEmisor_doc;
            this.Destinatario_doc = pDestinatario_doc;
            this.Fecha_doc = pFecha_doc;
            this.Prioridad_doc = pPrioridad_doc;
            this.Ubicacion_doc = pUbicacion_doc;
        }
        public Documento(int pId_doc, int pId_Identificador, string pTitulo_doc,
            string pEmisor_doc, string pDestinatario_doc, DateTime pFecha_doc, string pPrioridad_doc, string pUbicacion_doc, bool pState,
            string pCreateby, string pUpdateby, DateTime pCreateDate)
        {
            this.Id_doc = pId_doc;
            this.Id_Identificador = pId_Identificador;
            this.Titulo_doc = pTitulo_doc;
            this.Emisor_doc = pEmisor_doc;
            this.Destinatario_doc = pDestinatario_doc;
            this.Fecha_doc = pFecha_doc;
            this.Prioridad_doc = pPrioridad_doc;
            this.Ubicacion_doc = pUbicacion_doc;
            this.State = pState;
            this.Createby = pCreateby;
            this.Updateby = pUpdateby;
            this.Createdate = pCreateDate;

        }

    }
}
