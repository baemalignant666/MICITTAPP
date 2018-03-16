using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.DataAccess.Crud;
using MicittApp.Entities.Objects;

namespace MicittApp.ApiCore.Management
{
    public class DepartamentoManagement : BaseManagement
    {
        public DepartamentoManagement()
        {
            _factory = new CrudDepartamento();
        }

        public void CreateDepartamento(Departamento Obj)
        {
            try
            {
                _factory.Create(Obj);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

    }
}
