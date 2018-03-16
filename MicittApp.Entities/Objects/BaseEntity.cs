using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicittApp.Entities.Objects
{
    public class BaseEntity
    {
        public bool State { get; set; }
        public string Createby { get; set; }
        public string Updateby { get; set; }
        public DateTime Createdate { get; set; }
    }
}
