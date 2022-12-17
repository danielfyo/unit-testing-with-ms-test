using SCOM.Infraestructure.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCOM.Infraestructure.Core
{
    internal interface ITipoProductoRepository
    {
        bool Agregar(TipoProducto tipoProducto);
        bool Modificar(TipoProducto tipoProducto);
        bool Eliminar(TipoProducto tipoProducto);
        TipoProducto Consultar(int id);
        IEnumerable<TipoProducto> ConsultarTodos();
    }
}
