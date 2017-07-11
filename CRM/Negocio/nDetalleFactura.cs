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

            DataDev = cnn.Select(string.Format(@"SELECT
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

        public DataTable getFacturaid()
        {
            DataTable id = new DataTable();
            id = cnn.Select(string.Format("SELECT SCOPE_IDENTITY()"));
            return id;
        }

        public bool insertDetalle(eDetalleFactura det,int idfact)
        {
            try
            {
                //string query = string.Format("INSERT INTO DETALLE_FACTURA VALUES({0},{1},{2},{3},{4},{5},{6})", idfact, det.cantidad, det.idbodega, det.idproducto, det.preciounitario, det.comision,det.impuesto);
                cnn.Insert(string.Format("INSERT INTO DETALLE_FACTURA VALUES({0},{1},{2},{3},{4},{5},{6} )", idfact, det.cantidad,det.idbodega, det.idproducto, det.preciounitario, det.comision , det.impuesto));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }

        public DataTable getAllBodega()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT idbodega, nombre_bodega FROM BODEGA WHERE activo = 1");
            return typeDev;

        }

        public DataTable getAllProductos()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT idproducto,descripcion,cantidad FROM PRODUCTO where activo = 1");
            return typeDev;

        }

        public DataTable getListaPrecios(string listPreci)
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select(string.Format("SELECT idlistaprecio,descripcion,preciounitario FROM LISTAPRECIOS where idproducto = {0}", listPreci));
            return typeDev;

        }

        public DataTable getComision(string idProd)
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select(string.Format("SELECT porcentajecomosion FROM PRODUCTO INNER JOIN COMISION ON COMISION.idproducto = PRODUCTO.idproducto WHERE COMISION.idproducto = {0}", idProd));
            return typeDev;

        }

        public bool updateProducto(int cantidad, int idproducto)
        {
            try
            {
                //string query = string.Format("INSERT INTO DETALLE_FACTURA VALUES({0},{1},{2},{3},{4},{5},{6})", idfact, det.cantidad, det.idbodega, det.idproducto, det.preciounitario, det.comision,det.impuesto);
                cnn.Insert(string.Format("UPDATE PRODUCTO SET cantidad = {0} WHERE idproducto = {1}", cantidad, idproducto));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }
    }
}
