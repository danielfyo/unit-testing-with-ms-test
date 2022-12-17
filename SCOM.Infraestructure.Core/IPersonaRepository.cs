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
        bool AgregarPersona(Persona persona);
        bool ModificarPersona(Persona persona);
        bool EliminarPersona(Persona persona);
        Persona ConsultarPersona(Persona persona);
        IEnumerable<Persona> ConsultarPersonas(Persona persona);
    }
}
