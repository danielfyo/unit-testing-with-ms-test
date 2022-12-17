using SCOM.Infraestructure.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCOM.Infraestructure.Core
{
    internal interface IUsuarioRepository
    {
        bool AgregarUsuario(Usuario producto);
        bool ModificarUsuario(Usuario producto);
        bool EliminarUsuario(Usuario producto);
        Usuario ConsultarUsuario(Usuario producto);
        IEnumerable<Usuario> ConsultarUsuarios(Usuario producto);
        bool IniciarSesion(string username, string password);
    }
}
