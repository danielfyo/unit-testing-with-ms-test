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
        bool Agregar(Usuario usuario);
        bool Modificar(Usuario usuario);
        bool Eliminar(Usuario usuario);
        Usuario Consultar(int id);
        IEnumerable<Usuario> ConsultarTodos();
    }
}
