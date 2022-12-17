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
        bool AgregarProducto(Producto producto);
        bool ModificarProducto(Producto producto);
        bool EliminarProducto(Producto producto);
        Producto ConsultarProducto(Producto producto);
        IEnumerable<Producto> ConsultarProductos(Producto producto);
    }
}
