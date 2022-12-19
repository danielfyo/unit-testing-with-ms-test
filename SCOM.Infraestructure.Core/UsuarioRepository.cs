using SCOM.Infraestructure.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCOM.Infraestructure.Core
{
    internal class UsuarioRepository : IUsuarioRepository
    {
        private readonly Context context;
        public UsuarioRepository(Context context)
        {
            this.context = context;
        }
        public bool Agregar(Usuario usuario)
        {
            context.Usuario.Add(usuario);
            context.SaveChanges();
            return true;
        }
        public Usuario Consultar(int id)
        {
            Usuario usuario = context.Usuario.Find(id);
            return usuario;
        }
        public IEnumerable<Usuario> ConsultarTodos()
        {
            IEnumerable<Usuario> usuarios = context.Usuario.ToList();
            return usuarios;
        }
        public bool Eliminar(Usuario usuario)
        {
            context.Usuario.Remove(usuario);
            context.SaveChanges();
            return true;
        }
        public bool Modificar(Usuario usuario)
        {
            context.Update(usuario);
            context.SaveChanges();
            return true;
        }
    }
}
