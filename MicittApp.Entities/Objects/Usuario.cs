using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicittApp.Entities.Objects
{
    public class Usuario : BaseEntity
    {
        public string Id_User { get; set; }
        public string Nombrec_User { get; set; }
        public string Apellido1_User { get; set; }
        public string Apellido2_User { get; set; }
        public string Correo_User { get; set; }
        public string Telefono_User { get; set; }
        public int Id_Role { get; set; }
        public int Id_Dpto { get; set; }
        public string Pass_User { get; set; }

        public Usuario()
        {
            Id_User = "N/A";
            Nombrec_User = "N/A";
            Apellido1_User = "N/A";
            Apellido2_User = "N/A";
            Correo_User = "N/A";
            Telefono_User = "N/A";
            Id_Role = 0;
            Id_Dpto = 0;
            Pass_User = "N/A";
        }
        public Usuario(string pId_User, string pNombrec_User, string pApellido1_User, string pApellido2_User, string pCorreo_User, 
            string pTelefono_User, int pId_Role, int pId_Dpto, string pPass_User)
        {
            this.Id_User = pId_User;
            this.Nombrec_User = pNombrec_User;
            this.Apellido1_User = pApellido1_User;
            this.Apellido2_User = pApellido1_User;
            this.Correo_User = pCorreo_User;
            this.Telefono_User = pTelefono_User;
            this.Id_Role = pId_Role;
            this.Id_Dpto = pId_Dpto;
            this.Pass_User = pPass_User;
        }
        public Usuario(string pId_User, string pNombrec_User, string pApellido1_User, string pApellido2_User, string pCorreo_User,
            string pTelefono_User, int pId_Role, int pId_Dpto, bool pState, string pCreateby, string pUpdateby, 
            DateTime pCreateDate, string pPass_User)
        {
            this.Id_User = pId_User;
            this.Nombrec_User = pNombrec_User;
            this.Apellido1_User = pApellido1_User;
            this.Apellido2_User = pApellido1_User;
            this.Correo_User = pCorreo_User;
            this.Telefono_User = pTelefono_User;
            this.Id_Role = pId_Role;
            this.Id_Dpto = pId_Dpto;
            this.Pass_User = pPass_User;
            this.State = pState;
            this.Createby = pCreateby;
            this.Updateby = pUpdateby;
            this.Createdate = pCreateDate;

        }
    }
}
