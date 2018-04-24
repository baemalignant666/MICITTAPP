using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.DataAccess.Crud;
using MicittApp.Entities.Objects;


namespace MicittApp.ApiCore.Management
{
    public class TipoDocumentoManagement : BaseManagement
    {
        public TipoDocumentoManagement()
        {
            _factory = new CrudTipoDocumento();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateTipoDocumento(TipoDocumento Obj)
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
        public List<T> RetrieveAllTipoDocumento<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<TipoDocumento>();
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
        public void UpdateTipoDocumento(TipoDocumento Obj)
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
        public void DeleteTipoDocumento(TipoDocumento Obj)
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
