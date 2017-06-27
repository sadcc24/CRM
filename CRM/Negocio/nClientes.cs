using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class nDevoluciones
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();
        public DataTable getAllDev()
        {
            DataTable DataDev = new DataTable();
          
            DataDev = cnn.Select(@"SELECT DEV.iddevolucion AS [ID],DEV.fechadevolucion AS [Fecha Devolucion],
            DEV.motivodevolucion AS [Motivo Devolucion],TDEV.tipodevolucion AS [Tipo Devolucion], 
            EMPRESA.nombre_empresa AS [Empresa],SEDE.nombre_sede AS [Sede], 
            PROV.nombre_proveedor AS [Nombre Proveedor], PROD.descripcion AS [Producto],
            DETFACT.idfactura AS [Factura] 
            FROM DETALLE_DEVOLUCIONES AS DEV
            INNER JOIN TIPO_DEVOLUCION AS TDEV
            ON TDEV.idtipodevolucion = DEV.idtipodevolucion
            INNER JOIN Empresa AS EMPRESA
            ON EMPRESA.idempresa = DEV.idempresa
            INNER JOIN Sede AS SEDE
            ON SEDE.id_sede = DEV.id_sede
            INNER JOIN Proveedor AS PROV
            ON PROV.idproveedor = DEV.idproveedor
            INNER JOIN Producto AS PROD
            ON PROD.idproducto = DEV.idproducto
            INNER JOIN DETALLE_FACTURA AS DETFACT
            ON DETFACT.idencabezadofact = DEV.idencabezadofact");

            return DataDev;
        } 

        public DataTable getAllProveedor()
        {
            DataTable proveedor = new DataTable();
            proveedor = cnn.Select("SELECT idproveedor,nombre_proveedor FROM Proveedor");
            return proveedor;
        }

        public DataTable getAllTypeDev()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT idtipodevolucion,tipodevolucion FROM TIPO_DEVOLUCION");
            return typeDev;


        }

        public DataTable getAllCompanies()
        {
            DataTable companies = new DataTable();
            companies = cnn.Select("SELECT idempresa,nombre_empresa FROM Empresa WHERE activo =  1");
            return companies;
        }

        public DataTable getAllsedes()
        {
            DataTable companies = new DataTable();
            companies = cnn.Select("SELECT id_sede,nombre_sede FROM Sede WHERE activo = 1");
            return companies;
        }

        public DataTable getAllProducts()
        {
            DataTable companies = new DataTable();
            companies = cnn.Select("SELECT idproducto,descripcion FROM Producto ");
            return companies;
        }

        public DataTable getAllFacturas()
        {
            DataTable companies = new DataTable();
            companies = cnn.Select("SELECT idencabezadofact,idfactura FROM DETALLE_FACTURA");
            return companies;
        }

        public DataTable getFilterFactura(string uuidFactura)
        {
            DataTable getFacturasbyid = new DataTable();

            getFacturasbyid = cnn.Select(string.Format(@"SELECT DFACTURA.idempresa,EMPRESA.nombre_empresa,DFACTURA.id_sede, 
                        SEDE.nombre_sede, DFACTURA.idproducto,PRODUCTO.descripcion 
                        FROM DETALLE_FACTURA AS DFACTURA
                        INNER JOIN Empresa AS EMPRESA
                        ON DFACTURA.idempresa = EMPRESA.idempresa
                        INNER JOIN Sede AS SEDE
                        ON SEDE.id_sede = DFACTURA.id_sede
                        INNER JOIN Producto AS PRODUCTO
                        ON PRODUCTO.idproducto = DFACTURA.idproducto
                        WHERE idfactura = '{0}'", uuidFactura));
            return getFacturasbyid;
        }


        public bool insertDevolucion(eDevoluciones dev)
        {
            try
            {
                //string query = string.Format("INSERT INTO DETALLE_DEVOLUCIONES VALUES({0},'{1}',{2},{3},{4},{5},{6},{7})", dev.fechaDevolucion, dev.motivodev, dev.tipodev, dev.empresa, dev.sede, dev.proveedor, dev.producto, dev.factura);
                cnn.Insert(string.Format("INSERT INTO DETALLE_DEVOLUCIONES VALUES('{0}','{1}',{2},{3},{4},{5},{6},{7})",dev.fechaDevolucion,dev.motivodev,dev.tipodev,dev.empresa,dev.sede,dev.proveedor,dev.producto,dev.factura));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }

        public bool updateDevolucion(eDevoluciones dev, string iddev)
        {
            try
            {
                cnn.Update(string.Format("UPDATE DETALLE_DEVOLUCIONES SET fechadevolucion = '{0}', motivodevolucion = '{1}', idtipodevolucion = {2},idempresa={3} , id_sede = {4}, idproveedor = {5}, idproducto = {6}, idencabezadofact = {7} WHERE iddevolucion = {8}", dev.fechaDevolucion, dev.motivodev, dev.tipodev, dev.empresa, dev.sede, dev.proveedor, dev.producto, dev.factura, iddev));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public bool deletedevolucion(string iddev)
        {
            try
            {
                cnn.Delete(string.Format(@"DELETE DETALLE_DEVOLUCIONES WHERE iddevolucion = {0}",iddev));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
