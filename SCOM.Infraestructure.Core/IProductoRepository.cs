using SCOM.Infraestructure.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCOM.Infraestructure.Core
{
    internal interface IProductoRepository
    {
        bool Agregar(Producto producto);
        bool Modificar(Producto producto);
        bool Eliminar(Producto producto);
        Producto Consultar(int id);
        IEnumerable<Producto> ConsultarTodos();
    }
}
