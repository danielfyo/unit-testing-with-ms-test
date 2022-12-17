using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCOM.Infraestructure.Core.Entities
{
    internal class Usuario:BasePersona
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime LastSignIn { get; set; }
    }
}
