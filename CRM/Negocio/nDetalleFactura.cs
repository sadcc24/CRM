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
        //ConnectionDBLocal cnn = new ConnectionDBLocal();
        ConnectionDBAzure cnn = new ConnectionDBAzure();


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
                cnn.Insert(string.Format("INSERT INTO DETALLE_FACTURA VALUES({0},{1},{2},{3},{4},{5},{6} )", idfact, det.cantidad,det.idbodega, det.idproducto, det.comision , det.impuesto , det.preciounitario));
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
            //SELECT dbo.PRODUCTO.idproducto, dbo.PRODUCTO.descripcion, dbo.BODEGA.nombre_bodega, dbo.EXISTENCIA.CANTIDAD FROM dbo.EXISTENCIA INNER JOIN dbo.PRODUCTO ON dbo.EXISTENCIA.idproducto = dbo.PRODUCTO.idproducto INNER JOIN dbo.BODEGA ON dbo.EXISTENCIA.idbodega = dbo.BODEGA.idbodega WHERE dbo.PRODUCTO.activo = 1
            typeDev = cnn.Select("SELECT dbo.PRODUCTO.idproducto,  dbo.PRODUCTO.descripcion,  dbo.EXISTENCIA.CANTIDAD, dbo.BODEGA.nombre_bodega ,dbo.BODEGA.idbodega  FROM dbo.EXISTENCIA INNER JOIN dbo.PRODUCTO ON dbo.EXISTENCIA.idproducto = dbo.PRODUCTO.idproducto INNER JOIN dbo.BODEGA ON dbo.EXISTENCIA.idbodega = dbo.BODEGA.idbodega WHERE dbo.PRODUCTO.activo = 1");
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

        public bool updateProducto(double cantidad, int idproducto , int idbodega)
        {
            try
            {
                //string query = string.Format("INSERT INTO DETALLE_FACTURA VALUES({0},{1},{2},{3},{4},{5},{6})", idfact, det.cantidad, det.idbodega, det.idproducto, det.preciounitario, det.comision,det.impuesto);
                cnn.Insert(string.Format("UPDATE EXISTENCIA SET cantidad = {0} WHERE idproducto = {1}  AND idbodega = {2}", cantidad, idproducto ,idbodega));
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
