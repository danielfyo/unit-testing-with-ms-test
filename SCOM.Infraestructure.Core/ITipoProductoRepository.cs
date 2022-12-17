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
        bool AgregarTipoProducto(TipoProducto producto);
        bool ModificarTipoProducto(TipoProducto producto);
        bool EliminarTipoProducto(TipoProducto producto);
        TipoProducto ConsultarTipoProducto(TipoProducto producto);
        IEnumerable<TipoProducto> ConsultarTipoProductos(TipoProducto producto);
    }
}
