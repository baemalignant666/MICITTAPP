using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.Entities.Objects;

namespace MicittApp.DataAccess.Crud
{
    public class CrudUsuario : CrudFactory
    {
        sqlConnectionDataContext Context = new sqlConnectionDataContext();
        public override bool Create(BaseEntity entity)
        {
            var Obj = (Usuario)entity;
            Context.SP_CRUD_USUARIO((int)CrudActionEnum.Create, Obj.Createby, Obj.Id_User, Obj.Nombrec_User,
                Obj.Apellido1_User, Obj.Apellido2_User,Obj.Correo_User,Obj.Telefono_User,Obj.Role,Obj.Id_Dpto,
                Obj.Pass_User);
            return true;
        }
        public override bool Delete(BaseEntity entity)
        {
            var Obj = (Usuario)entity;
            Context.SP_CRUD_USUARIO((int)CrudActionEnum.Delete, Obj.Createby, Obj.Id_User, Obj.Nombrec_User,
                Obj.Apellido1_User, Obj.Apellido2_User, Obj.Correo_User, Obj.Telefono_User, Obj.Role, Obj.Id_Dpto,
                Obj.Pass_User);
            return true;
        }
        public override List<T> RetrieveAll<T>()
        {
            var Obj = new Usuario();
            var lst = new List<T>();
            List<Usuario> MyList = new List<Usuario>();
            var Query = Context.SP_CRUD_USUARIO((int)CrudActionEnum.Retrieve, Obj.Createby, Obj.Id_User, Obj.Nombrec_User,
                Obj.Apellido1_User, Obj.Apellido2_User, Obj.Correo_User, Obj.Telefono_User, Obj.Role, Obj.Id_Dpto,
                Obj.Pass_User).ToList();
            foreach (SP_CRUD_USUARIOResult Element in Query)
            {
                Usuario ObjUser = new Usuario(Element.NOMBREC_USER, Element.APELLIDO1_USER, Element.APELLIDO2_USER, Element.ID_USER
                    , Element.NOMBRE_DPT, Element.CORREO_USER,Element.PASSWORD_USER,Element.TELEFONO_USER,Element.ROLE);
                //element.Nombrec_User, element.Apellido1_User + element.Apellido2_User, element.Id_User,
                   // element.Nombre_Dtpo,element.Correo_User,element.Pass_User, element.Telefono_User, element.Role
                MyList.Add(ObjUser);
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
            var Obj = (Usuario)entity;
            Context.SP_CRUD_USUARIO((int)CrudActionEnum.Update, Obj.Createby, Obj.Id_User, Obj.Nombrec_User,
                Obj.Apellido1_User, Obj.Apellido2_User, Obj.Correo_User, Obj.Telefono_User, Obj.Role, Obj.Id_Dpto,
                Obj.Pass_User);
            return true;
        }
    }
}
