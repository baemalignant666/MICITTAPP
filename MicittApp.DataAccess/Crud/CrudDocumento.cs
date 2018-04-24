using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MicittApp.Entities.Objects;
using System.Threading.Tasks;

namespace MicittApp.DataAccess.Crud
{
    public class CrudDocumento : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Documento)entity;
            Context.SP_CRUD_DOC((int)CrudActionEnum.Create, Obj.Id_doc, Obj.Cons_Doc ,Obj.Createby, Obj.Id_Identificador, Obj.Titulo_doc,
                Obj.Emisor_doc, Obj.Destinatario_doc, Obj.Fecha_doc, Obj.Prioridad_doc, Obj.Ubicacion_doc, Obj.Id_TDoc);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Documento)entity;
            Context.SP_CRUD_DOC((int)CrudActionEnum.Update, Obj.Id_doc, Obj.Cons_Doc, Obj.Createby, Obj.Id_Identificador, Obj.Titulo_doc,
                Obj.Emisor_doc, Obj.Destinatario_doc, Obj.Fecha_doc, Obj.Prioridad_doc, Obj.Ubicacion_doc, Obj.Id_TDoc);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var Obj = new Documento();
            var lst = new List<T>();
            List<Documento> MyList = new List<Documento>();
            var Query = Context.SP_CRUD_DOC((int)CrudActionEnum.Retrieve, Obj.Id_doc, Obj.Cons_Doc, Obj.Createby, Obj.Id_Identificador, Obj.Titulo_doc,
                Obj.Emisor_doc, Obj.Destinatario_doc, Obj.Fecha_doc, Obj.Prioridad_doc, Obj.Ubicacion_doc, Obj.Id_TDoc).ToList();
            foreach (SP_CRUD_DOCResult Element in Query)
            {
                Documento ObjDoc = new Documento(Element.ID_DOC, Element.CONS_DOC, Element.TITULO_DOC, Element.EMISOR_DOC, Element.DESTINATARIO_DOC, Element.UBICACION_DOC,
                    Element.ID_TDOC, Element.PRIORIDAD_DOC, Element.ID_IDENTIFICADOR, Element.FECHA_DOC);
                MyList.Add(ObjDoc);
            }
            if (MyList.Count > 0)
            {
                foreach (var obj in MyList)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            return lst;
        }
        public override bool Update(BaseEntity entity)
        {
            var Obj = (Documento)entity;
            Context.SP_CRUD_DOC((int)CrudActionEnum.Update, Obj.Id_doc, Obj.Cons_Doc, Obj.Createby, Obj.Id_Identificador, Obj.Titulo_doc,
                Obj.Emisor_doc, Obj.Destinatario_doc, Obj.Fecha_doc, Obj.Prioridad_doc, Obj.Ubicacion_doc, Obj.Id_TDoc);
            return true;
        }
    }
}
