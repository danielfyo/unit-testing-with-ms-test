using System;
using Microsoft.EntityFrameworkCore;
using SCOM.Infraestructure.Core.Entities;

namespace SCOM.Infraestructure.Core
{
    internal class Context: DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }

        internal DbSet<Persona> Persona { get; set; }
        internal DbSet<Producto> Producto { get; set; }
        internal DbSet<TipoProducto> TipoProducto { get; set; }
        internal DbSet<Usuario> Usuario { get; set; }

    }
}
