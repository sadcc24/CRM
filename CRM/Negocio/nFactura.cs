using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Data;

namespace Negocio
{
    public class nFactura
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();

        public DataTable getAllFactura()
        {
            DataTable ListaPrecio = new DataTable();
            ListaPrecio = cnn.Select(@"SELECT
                                dbo.FACTURA.idfactura,
                                dbo.CLIENTE.nombre as [Nombre Cliente],
                                dbo.FACTURA.total,
                                dbo.MONEDA.nombre_moneda as [Nombre Moneda],
                                dbo.VENDEDOR.nombre as [Nombre Vendedor],
                                dbo.ESTADO.estado,
                                dbo.TIPOPAGOFACTURA.nombre as [Tipo Pago Factura],
                                dbo.FACTURA.subtotal,
                                dbo.FACTURA.fechafactura as [Fecha Factura],
                                dbo.FACTURA.impuesto,
                                dbo.FACTURA.tipodocumento as [Tipo Documento]
                                FROM dbo.CLIENTE
                                INNER JOIN dbo.FACTURA ON dbo.FACTURA.idcliente = dbo.CLIENTE.idcliente
                                INNER JOIN dbo.MONEDA ON dbo.FACTURA.idmoneda = dbo.MONEDA.idmoneda
                                INNER JOIN dbo.VENDEDOR ON dbo.FACTURA.idvendedor = dbo.VENDEDOR.idvendedor
                                INNER JOIN dbo.ESTADO ON dbo.CLIENTE.idestado = dbo.ESTADO.idestado AND dbo.FACTURA.idestado = dbo.ESTADO.idestado AND dbo.VENDEDOR.idestado = dbo.ESTADO.idestado
                                INNER JOIN dbo.TIPOPAGOFACTURA ON dbo.FACTURA.idtipopago = dbo.TIPOPAGOFACTURA.idtipopago");
            return ListaPrecio;
        }

        public DataTable getAllCliente()
        {
            DataTable proveedor = new DataTable();
            proveedor = cnn.Select("SELECT idcliente,nombre FROM CLIENTE WHERE idestado = 1");
            return proveedor;
        }

        public DataTable getAllVendedor()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT idvendedor,nombre FROM VENDEDOR  WHERE idestado = 1");
            return typeDev;


        }

        public DataTable getAllTipoPago()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT idtipopago,nombre FROM TIPOPAGOFACTURA");
            return typeDev;
        }

        public DataTable getAllEstado()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT idestado,estado FROM ESTADO");
            return typeDev;
        }

        public DataTable getAllMoneda()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT idmoneda,nombre_moneda FROM MONEDA  WHERE activo = 1");
            return typeDev;
        }




        public bool insertFactura(eFactura fac)
        {
            try
            {
                //string query = string.Format("INSERT INTO DETALLE_DEVOLUCIONES VALUES({0},'{1}',{2},{3},{4},{5},{6},{7})", dev.fechaDevolucion, dev.motivodev, dev.tipodev, dev.empresa, dev.sede, dev.proveedor, dev.producto, dev.factura);
                cnn.Insert(string.Format("INSERT INTO FACTURA VALUES('{0}','{1}',{2},{3},{4},{5},{6},{7})", fac.idcliente, fac.idvendedor, fac.idmoneda, fac.total, fac.subtotal, fac.impuesto, fac.fecha, fac.tipodocumento , fac.idestado ,fac.idtipopago));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }

        public bool updateFactura(eFactura fac, string idfac)
        {
            try
            {
                cnn.Update(string.Format("UPDATE FACTURA SET idcliente = {0}, idvendedor = {1}, idmoneda = {2} , total = {3} , subtotal = {4}, impuesto = {5}, fechafactura = {6}, tipodocumento = '{7}' ,idestado = {8} , idtipopago = {9} WHERE idfactura = {10}", fac.idcliente, fac.idvendedor, fac.idmoneda, fac.total, fac.subtotal, fac.impuesto, fac.fecha, fac.tipodocumento, fac.idestado, fac.idtipopago, idfac));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool deleteFactura(string idfac)
        {
            try
            {
                cnn.Delete(string.Format(@"DELETE FACTURA WHERE idfactura = {0}", idfac));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }
}
