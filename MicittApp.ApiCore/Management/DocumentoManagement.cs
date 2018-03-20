using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MicittApp.DataAccess.Crud;
using MicittApp.Entities.Objects;
using System.Threading.Tasks;

namespace MicittApp.ApiCore.Management
{
    public class DocumentoManagement : BaseManagement
    {
        public DocumentoManagement()
        {
            _factory = new CrudDocumento();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateDocumento(Documento Obj)
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
        public List<T> RetrieveAllDocumento<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Documento>();
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
        public void UpdateDocumento(Documento Obj)
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
        public void DeleteDDocumento(Documento Obj)
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
