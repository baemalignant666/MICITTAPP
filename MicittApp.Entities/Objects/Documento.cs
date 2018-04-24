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
        public string Cons_Doc { get; set; }
        public string Id_Identificador { get; set; }
        public string Titulo_doc { get; set; }
        public string Emisor_doc { get; set; } //Id_User Emisior
        public string Destinatario_doc { get; set; } //Id_User Destinatario
        public DateTime Fecha_doc { get; set; }
        public string Prioridad_doc { get; set; }
        public string Ubicacion_doc { get; set; }
        public int Id_TDoc { get; set; }
        public Documento()
        {
            Id_doc = 0;
            Cons_Doc = "N/A";
            Id_Identificador = "N/A";
            Titulo_doc = "N/A";
            Emisor_doc = "N/A";
            Destinatario_doc = "N/A";
            Fecha_doc = DateTime.Today; //default
            Prioridad_doc = "N/A";
            Ubicacion_doc = "N/A";
            Id_TDoc = 0;
        }
        public Documento(int pId_doc, string pCons_Doc,  string pTitulo_doc, 
            string pEmisor_doc, string pDestinatario_doc, string pUbicacion_doc, int pId_TDoc, string pPrioridad_doc,string pId_Identificador, DateTime pFecha_doc)
        {
            this.Id_doc = pId_doc;
            this.Cons_Doc = pCons_Doc;
            this.Titulo_doc = pTitulo_doc;
            this.Emisor_doc = pEmisor_doc;
            this.Destinatario_doc = pDestinatario_doc;
            this.Ubicacion_doc = pUbicacion_doc;
            this.Id_TDoc = pId_TDoc;
            this.Prioridad_doc = pPrioridad_doc;
            this.Id_Identificador = pId_Identificador;
            this.Fecha_doc = pFecha_doc;
            
        }
        public Documento(int pId_doc, string pCons_Doc, string pId_Identificador, string pTitulo_doc,
            string pEmisor_doc, string pDestinatario_doc, DateTime pFecha_doc, string pPrioridad_doc, string pUbicacion_doc, int pId_TDoc, bool pState,
            string pCreateby, string pUpdateby, DateTime pCreateDate)
        {
            this.Id_doc = pId_doc;
            this.Cons_Doc = pCons_Doc;
            this.Id_Identificador = pId_Identificador;
            this.Titulo_doc = pTitulo_doc;
            this.Emisor_doc = pEmisor_doc;
            this.Destinatario_doc = pDestinatario_doc;
            this.Fecha_doc = pFecha_doc;
            this.Prioridad_doc = pPrioridad_doc;
            this.Ubicacion_doc = pUbicacion_doc;
            this.Id_TDoc = pId_TDoc;
            this.State = pState;
            this.Createby = pCreateby;
            this.Updateby = pUpdateby;
            this.Createdate = pCreateDate;

        }
    }
}
