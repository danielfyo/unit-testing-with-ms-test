using SCOM.Infraestructure.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCOM.Infraestructure.Core
{
    internal class ProductoRepository : IProductoRepository
    {
        private readonly Context context;
        public ProductoRepository(Context context)
        {
            this.context = context;
        }
        public bool Agregar(Producto producto)
        {
            context.Producto.Add(producto);
            context.SaveChanges();
            return true;
        }
        public Producto Consultar(int id)
        {
            Producto producto = context.Producto.Find(id);
            return producto;
        }
        public IEnumerable<Producto> ConsultarTodos()
        {
            IEnumerable<Producto> productos = context.Producto.ToList();
            return productos;
        }
        public bool Eliminar(Producto producto)
        {
            context.Producto.Remove(producto);
            context.SaveChanges();
            return true;
        }
        public bool Modificar(Producto producto)
        {
            context.Update(producto);
            context.SaveChanges();
            return true;
        }
    }
}
