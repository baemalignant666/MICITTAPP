using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MicittApp.DataAccess.Crud;
using MicittApp.Entities.Objects;
using System.Threading.Tasks;

namespace MicittApp.ApiCore.Management
{
    public class UsuarioManagement : BaseManagement
    {
        public UsuarioManagement()
        {
            _factory = new CrudUsuario();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateUsuario(Usuario Obj)
        {
            try
            {
                _factory.Create(Obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<T> RetrieveAllUsuario<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Usuario>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;

            }
            return lst;
        }
        public void UpdateUsuario(Usuario Obj)
        {
            try
            {
                _factory.Update(Obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeleteDUsuario(Usuario Obj)
        {
            try
            {
                _factory.Delete(Obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
