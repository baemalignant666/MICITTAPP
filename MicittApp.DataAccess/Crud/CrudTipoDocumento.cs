using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.Entities.Objects;

namespace MicittApp.DataAccess.Crud
{
    public class CrudTipoDocumento : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (TipoDocumento)entity;
            Context.SP_CRUD_TDOC((int)CrudActionEnum.Create, Obj.Createby, Obj.Id_TDoc, Obj.Name_TDoc);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (TipoDocumento)entity;
            Context.SP_CRUD_TDOC((int)CrudActionEnum.Delete, Obj.Createby, Obj.Id_TDoc, Obj.Name_TDoc);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var Obj = new TipoDocumento();
            var lst = new List<T>();
            List<TipoDocumento> MyList = new List<TipoDocumento>();
            var Query = Context.SP_CRUD_TDOC((int)CrudActionEnum.Retrieve, Obj.Createby, Obj.Id_TDoc, Obj.Name_TDoc).ToList();
            foreach (SP_CRUD_TDOCResult Element in Query)
            {
                TipoDocumento ObjTDOC = new TipoDocumento(Element.ID_TDOC, Element.NAME_TDOC);
                MyList.Add(ObjTDOC);
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
            var Obj = (TipoDocumento)entity;
            Context.SP_CRUD_TDOC((int)CrudActionEnum.Update, Obj.Createby, Obj.Id_TDoc, Obj.Name_TDoc);
            return true;
        }
    }
}
