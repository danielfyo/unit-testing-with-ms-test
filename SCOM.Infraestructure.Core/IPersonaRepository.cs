using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCOM.Infraestructure.Core.Entities;

namespace SCOM.Infraestructure.Core
{
    internal interface IPersonaRepository
    {
        bool Agregar(Persona persona);
        bool Modificar(Persona persona);
        bool Eliminar(int id);
        Persona Consultar(int id);
        IEnumerable<Persona> ConsultarTodos();
    }
}
