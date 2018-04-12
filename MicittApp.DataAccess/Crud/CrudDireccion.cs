using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.Entities.Objects;

namespace MicittApp.DataAccess.Crud
{
    public class CrudDireccion : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Direccion)entity;
            Context.SP_CRUD_DIRECCION((int)CrudActionEnum.Create, Obj.Createby, Obj.Id_Dir, Obj.Descrip_Dir);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Direccion)entity;
            Context.SP_CRUD_DIRECCION((int)CrudActionEnum.Delete, Obj.Updateby, Obj.Id_Dir, Obj.Descrip_Dir);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var Obj = new Direccion();
            var lst = new List<T>();
            List<Direccion> MyList = new List<Direccion>();
            var Query = Context.SP_CRUD_DIRECCION((int)CrudActionEnum.Retrieve, Obj.Createby, Obj.Id_Dir, Obj.Descrip_Dir).ToList();
            foreach (SP_CRUD_DIRECCIONResult Element in Query)
            {
                Direccion ObjDir = new Direccion(Element.ID_DIRECCION, Element.DESCRIP_DIR);
                MyList.Add(ObjDir);
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
            var Obj = (Direccion)entity;
            Context.SP_CRUD_DIRECCION((int)CrudActionEnum.Update, Obj.Updateby, Obj.Id_Dir, Obj.Descrip_Dir);
            return true;
        }
    }
}
