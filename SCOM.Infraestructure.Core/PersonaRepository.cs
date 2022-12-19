using SCOM.Infraestructure.Core.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SCOM.Infraestructure.Core
{
    internal class PersonaRepository : IPersonaRepository
    {
        private readonly Context context;
        public PersonaRepository(Context context)
        {
            this.context = context;
        }
        public bool Agregar(Persona persona)
        {
            context.Persona.Add(persona);
            context.SaveChanges();
            return true;
        }
        public Persona Consultar(int id)
        {
            Persona persona = context.Persona.Find(id);
            return persona;
        }
        public IEnumerable<Persona> ConsultarTodos()
        {
            IEnumerable<Persona> personas = context.Persona.ToList();
            return personas;
        }
        public bool Eliminar(Persona persona)
        {
            context.Persona.Remove(persona);
            context.SaveChanges();
            return true;
        }
        public bool Modificar(Persona persona)
        {
            context.Update(persona);
            context.SaveChanges();
            return true;
        }
    }
}