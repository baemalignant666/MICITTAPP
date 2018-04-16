using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.Entities.Objects;

namespace MicittApp.DataAccess.Crud
{
    public class CrudConsecutivo : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Consecutivo)entity;
            Context.SP_CRUD_CONS_DPT((int)CrudActionEnum.Create,Obj.Createby, Obj.Id_Identificador, Obj.Id_Dpto);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Consecutivo)entity;
            Context.SP_CRUD_CONS_DPT((int)CrudActionEnum.Delete, Obj.Createby, Obj.Id_Identificador, Obj.Id_Dpto);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var Obj = new Consecutivo();
            var lst = new List<T>();
            List<Consecutivo> MyList = new List<Consecutivo>();
            var Query = Context.SP_CRUD_CONS_DPT((int)CrudActionEnum.Retrieve, Obj.Updateby, Obj.Id_Identificador, 
                Obj.Id_Dpto).ToList();
            foreach(SP_CRUD_CONS_DPTResult Element in Query)
            {

                Consecutivo ObjConsecutivo = new Consecutivo(Element.ID_IDENTIFICADOR,Element.DESCRIP);
                MyList.Add(ObjConsecutivo);
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
            var Obj = (Consecutivo)entity;
            Context.SP_CRUD_CONS_DPT((int)CrudActionEnum.Update, Obj.Updateby, Obj.Id_Identificador, Obj.Id_Dpto);
            return true;
        }
    }
}
