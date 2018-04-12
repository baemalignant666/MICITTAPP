using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.Entities.Objects;

namespace MicittApp.DataAccess.Crud
{
    public class CrudDepartamento : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Departamento)entity;
            Context.SP_CRUD_DPTO((int)CrudActionEnum.Create,Obj.Createby,Obj.Id_Dtpo,Obj.Nombre_Dtpo,Obj.Descrip_Dtpo,Obj.Id_Direccion);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Departamento)entity;
            Context.SP_CRUD_DPTO((int)CrudActionEnum.Delete, Obj.Createby, Obj.Id_Dtpo, Obj.Nombre_Dtpo, Obj.Descrip_Dtpo, Obj.Id_Direccion);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var Obj = new Departamento();
            var lst = new List<T>();
            List<Departamento> MyList = new List<Departamento>();
            var Query = Context.SP_CRUD_DPTO((int)CrudActionEnum.Retrieve, Obj.Createby, Obj.Id_Dtpo, Obj.Nombre_Dtpo, Obj.Descrip_Dtpo, 
                Obj.Id_Direccion).ToList();
            foreach (SP_CRUD_DPTOResult Element in Query)
            {
                Departamento ObjDpto = new Departamento(Element.ID_DPTO,Element.NOMBRE_DPT,Element.DESCRIP,Element.ID_DIRECCION);
                MyList.Add(ObjDpto);
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
            var Obj = (Departamento)entity;
            Context.SP_CRUD_DPTO((int)CrudActionEnum.Update, Obj.Updateby, Obj.Id_Dtpo, Obj.Nombre_Dtpo, Obj.Descrip_Dtpo, Obj.Id_Direccion);
            return true;
        }
    }
}
