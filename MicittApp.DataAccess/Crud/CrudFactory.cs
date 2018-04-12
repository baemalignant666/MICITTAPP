using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.Entities.Objects;

namespace MicittApp.DataAccess.Crud
{
    public abstract class CrudFactory 
    {
        public abstract bool Create(BaseEntity entity);
        public abstract List<T> RetrieveAll<T>();
        public abstract bool Update(BaseEntity entity);
        public abstract bool Delete(BaseEntity entity);
    }
}
