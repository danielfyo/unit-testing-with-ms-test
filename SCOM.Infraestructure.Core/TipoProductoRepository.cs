using SCOM.Infraestructure.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCOM.Infraestructure.Core
{
    internal class TipoProductoRepository : ITipoProductoRepository
    {
        private readonly Context context;
        public TipoProductoRepository(Context context)
        {
            this.context = context;
        }
        public bool Agregar(TipoProducto tipoProducto)
        {
            context.TipoProducto.Add(tipoProducto);
            context.SaveChanges();
            return true;
        }
        public TipoProducto Consultar(int id)
        {
            TipoProducto tipoProducto = context.TipoProducto.Find(id);
            return tipoProducto;
        }
        public IEnumerable<TipoProducto> ConsultarTodos()
        {
            IEnumerable<TipoProducto> tiposProducto = context.TipoProducto.ToList();
            return tiposProducto;
        }
        public bool Eliminar(TipoProducto tipoProducto)
        {
            context.TipoProducto.Remove(tipoProducto);
            context.SaveChanges();
            return true;
        }
        public bool Modificar(TipoProducto tipoProducto)
        {
            context.Update(tipoProducto);
            context.SaveChanges();
            return true;
        }
    }
}
