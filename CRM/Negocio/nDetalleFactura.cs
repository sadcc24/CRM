using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Data;

namespace Negocio
{
    public class nDetalleFactura
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();

        public DataTable getAllDetalleFac(string detalleFact)
        {
            DataTable DataDev = new DataTable();

            DataDev = cnn.Select(string.Format(@"SSELECT
                                dbo.PRODUCTO.descripcion,
                                dbo.BODEGA.nombre_bodega,
                                dbo.DETALLE_FACTURA.cantidad,
                                dbo.DETALLE_FACTURA.preciounitario
                                FROM dbo.DETALLE_FACTURA
                                INNER JOIN dbo.BODEGA ON dbo.DETALLE_FACTURA.idbodega = dbo.BODEGA.idbodega
                                INNER JOIN dbo.PRODUCTO ON dbo.DETALLE_FACTURA.idproducto = dbo.PRODUCTO.idproducto
                                WHERE
                                dbo.DETALLE_FACTURA.idfactura = '{0}'", detalleFact));

            return DataDev;
        }
    }
}
