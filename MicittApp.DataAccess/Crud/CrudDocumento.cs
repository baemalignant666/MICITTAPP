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
        public override bool Create(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public override bool Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
