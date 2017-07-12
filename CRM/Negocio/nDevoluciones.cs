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
        ConnectionDBAzure cnn = new ConnectionDBAzure();

        public DataTable getExistenciaProd(string uuidbodega, string uuidproducto)
        {
            DataTable exist = new DataTable();
            exist = cnn.Select(string.Format(@"SELECT * FROM EXISTENCIA WHERE idbodega = {0} AND idproducto={1}",uuidbodega,uuidproducto));
            return exist;
        }

        public void updateFactura (string uuidFactura)
        {
            cnn.Update(string.Format(@"UPDATE FACTURA SET idestado = 0 where idfactura ={0}",uuidFactura));
        }

        public void insertMovimiento(eMovimientoDev mov)
        {
            cnn.Insert(string.Format(@"INSERT INTO DETALLEMOVIMIENTOINVENTARIO VALUES({0},{1},{2},{3},{4},)",mov.idbodega,mov.idmovimiento,mov.idproducto,mov.cantidad,mov.costo,mov.precio));
        }

        public DataTable getMovimiento()
        {
            DataTable exist = new DataTable();
            exist = cnn.Select(string.Format(@"SELECT idmovimiento FROM MOVIMIENTOSINVENTARIO AS MI
            INNER JOIN TIPOMOVIMIENTO AS TM
            ON TM.idtipomovimiento = MI.idtipomovimiento
            WHERE TM.descripcion ='Devolucion por Ventas'"));
            return exist;
        }

        public DataTable getMovimientoVentas()
        {
            DataTable exist = new DataTable();
            exist = cnn.Select(string.Format(@"SELECT idmovimiento FROM MOVIMIENTOSINVENTARIO AS MI
            INNER JOIN TIPOMOVIMIENTO AS TM
            ON TM.idtipomovimiento = MI.idtipomovimiento
            WHERE TM.descripcion ='Ventas'"));
            return exist;
        }

        public void updateExistencia(string uuidbodega, string uuidproducto, string candidad)
        {
            cnn.Update(string.Format(@"UPDATE EXISTENCIA SET CANTIDAD = {0} WHERE idbodega = {1} AND idproducto ={2}",candidad,uuidbodega,uuidproducto));
        }

        public DataTable getProductDetail(string uuidProducto)
        {
            DataTable detail = new DataTable();
            detail = cnn.Select(string.Format(@"SELECT precio,costo FROM PRODUCTO WHERE idproducto={0}",uuidProducto));
            return detail;
        }


        public DataTable getAllDev()
        {
            DataTable DataDev = new DataTable();
          
            DataDev = cnn.Select(@"SELECT DEV.iddevolucion AS [ID], 
            DEV.fechadevolucion AS [FECHA], 
            DEV.descripcion AS [DESCRIPCION],TDEV.nombre AS [TIPO DEVOLUCION], 
            DEV.tipodocumento AS [DOCUMENTO],CL.idcliente AS [ID CLIENTE], CL.primernombre +' '+CL.segundonombre AS [NOMBRE CLIENTE],
            MON.idmoneda AS [ID MONEDA],MON.nombre_moneda AS [MONEDA],VEND.idvendedor AS [ID VENDEDOR], VEND.nombre AS [VENDEDOR] ,
            DEV.idfactura [FACTURA] FROM DEVOLUCIONES AS DEV
            INNER JOIN TIPODEVOLUCION AS TDEV
            ON TDEV.idtipodevolucion = DEV.idtipodevolucion
            INNER JOIN CLIENTE AS CL
            ON CL.idcliente = DEV.idcliente 
            INNER JOIN MONEDA AS MON
            ON MON.idmoneda = DEV.idmoneda 
            INNER JOIN VENDEDOR AS VEND
            ON VEND.idvendedor = DEV.idvendedor
            WHERE DEV.idestado = 1");
            return DataDev;
        } 

        public DataTable getTipocxc()
        {
            DataTable cliente = new DataTable();
            cliente = cnn.Select(@"select idtipocxc,nombre from TIPO_CXC");

            return cliente;
        }

        public DataTable getEstado()
        {
            DataTable estado = new DataTable();
            estado = cnn.Select("SELECT idestado,estado FROM ESTADO");
            return estado;
        }

        public DataTable transacciones()
        {
            DataTable trx = new DataTable();
            trx = cnn.Select("SELECT idtransaccion,docref FROM TRANSACCION");
            return trx;
        }

        public bool insertTransaccion(string uuidEstado, string uuidTrx)
        {
            try
            {
                cnn.Insert(string.Format("INSERT INTO CAJA VALUES({0},NULL,{1})",uuidEstado,uuidTrx));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool updateTrx(string uuidCaja,string uuidEstado)
        {
            try
            {
                cnn.Update(string.Format(@"UPDATE CAJA SET idestado = {0} where idcaja = {1}",uuidEstado,uuidCaja));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public DataTable getClients()
        {
            DataTable cliente = new DataTable();
            cliente = cnn.Select(@"SELECT idcliente as ID, primernombre as Nombre ,primerapellido as Apellido, EMP.nombre_empresa as Empresa FROM CLIENTE 
            INNER JOIN EMPRESA AS EMP
            ON EMP.idempresa = CLIENTE.idempresa 
			WHERE primernombre is not null ");

            return cliente;
        }

        public DataTable getFacturas(string idCliente)
        {
            DataTable facturas = new DataTable();
            facturas = cnn.Select(string.Format(@"SELECT idfactura AS [Factura],total AS [Total Factura],
            fechafactura AS [Fecha Factura] FROM FACTURA WHERE idcliente = {0} AND idestado = 1",idCliente));
            return facturas;
        }

        public DataTable getCXC(string idCliente)
        {
            DataTable cxc = new DataTable();
            cxc = cnn.Select(string.Format(@"SELECT idcuentaporcobrar,CXC.idcliente, 
            CLI.primernombre, cantidadCuotas,cantidadPago FROM CUENTAS_POR_COBRAR AS CXC
            INNER JOIN CLIENTE AS CLI
            ON CLI.idcliente = CXC.idcliente 
            WHERE CXC.idcliente = {0}", idCliente));
            return cxc;
        }

        public DataTable getDetailFacturas(string idCliente)
        {
            DataTable detailFacturas = new DataTable();
            detailFacturas = cnn.Select(string.Format(@"SELECT idfactura,idcliente,idvendedor,
            idmoneda,total,idtipopago FROM FACTURA WHERE idfactura = {0} and idestado = 1",idCliente));

            return detailFacturas;
        }

        public DataTable detalleFactura(string uuidfactura)
        {
            DataTable detalle = new DataTable();
            detalle = cnn.Select(string.Format(@"SELECT DFACT.cantidad AS [Cantidad],[idbodega] AS [Bodega],
              PROD.idproducto as [ID Producto],PROD.descripcion AS [Producto],[preciounitario] AS [Precio Unitario],[comision] AS [Comision],
              [impuesto] AS [Impuesto]
              FROM [DETALLE_FACTURA] AS DFACT
              INNER JOIN PRODUCTO AS PROD
              ON PROD.idproducto = DFACT.idproducto
              WHERE DFACT.idfactura = {0}",uuidfactura));

            return detalle;
        }



        public DataTable compareCantidadFact(string uuidFactura)
        {
            DataTable detalle = new DataTable();
            detalle = cnn.Select(string.Format(@"SELECT cantidad FROM DETALLE_FACTURA where idfactura = {0}", uuidFactura));

            return detalle;
        }

        public DataTable detalleDevolucion(string uuidDevolucion)
        {
            DataTable detalle = new DataTable();
            detalle = cnn.Select(string.Format(@"SELECT DDEV.cantidad AS [Cantidad],[idbodega] AS [Bodega],
              PROD.idproducto as [ID Producto],PROD.descripcion AS [Producto],[preciounitario] AS [Precio Unitario],[comision] AS [Comision],
              [impuesto] AS [Impuesto]
              FROM [DETALLE_DEVOLUCION] AS DDEV
              INNER JOIN PRODUCTO AS PROD
              ON PROD.idproducto = DDEV.idproducto
              WHERE DDEV.iddevolucion = {0}", uuidDevolucion));

            return detalle;
        }



        public DataTable Cliente (string uuidCliente)
        {
            DataTable cl = new DataTable();
            cl = cnn.Select(string.Format("SELECT primernombre + ' '+ primerapellido as [Nombre Cliente] FROM CLIENTE where idcliente ={0}", uuidCliente));
            return cl;
        }

        public DataTable nombreVendedor (string uuidVendedor)
        {
            DataTable nvendedor = new DataTable();
            nvendedor = cnn.Select(string.Format("SELECT nombre + ' '+ apellido as [Nombre Vendedor] FROM VENDEDOR WHERE idvendedor = {0}",uuidVendedor));
            return nvendedor;
        }

        public DataTable nombreMoneda (string uuidMoneda)
        {
            DataTable data = new DataTable();
            data = cnn.Select(string.Format("SELECT nombre_moneda AS Moneda FROM MONEDA where idmoneda = {0}",uuidMoneda));
            return data;
        }

        public DataTable nombretipopago (string uuidTpago)
        {
            DataTable data = new DataTable();
            data = cnn.Select(string.Format("SELECT nombre FROM TIPOPAGOFACTURA WHERE idtipopago = {0}", uuidTpago));
            return data;
        }

        public DataTable getTipoDev()
        {
            DataTable data = new DataTable();
            data = cnn.Select("SELECT idtipodevolucion,nombre from TIPODEVOLUCION");
            return data;
        }

        public DataTable getDevolucionid(string descripcion, string idfactura)
        {
            DataTable id = new DataTable();
            id = cnn.Select(string.Format("select iddevolucion from DEVOLUCIONES WHERE descripcion = '{0}' and idfactura = '{1}'", descripcion, idfactura));
            return id;
        }

        public void deleteProductoDetalle(string uuidProducto, string uuidfactura)
        {
            cnn.Delete(string.Format("DELETE FROM DETALLE_FACTURA where idproducto = {0} AND idfactura = {1} ", uuidProducto, uuidfactura));
        }

        public void editProductoDetalle(string cantidad,string uuidProducto, string uuidfactura)
        {
            cnn.Update(string.Format("UPDATE DETALLE_FACTURA SET cantidad = {0} WHERE idproducto = {1} AND idfactura = {2}", cantidad, uuidProducto,uuidfactura));
        }

        public bool editDetalleDevo(string cantidad, string uuidProducto, string uuiddev)
        {
            try
            {
                string query = string.Format("UPDATE DETALLE_DEVOLUCION SET cantidad = {0} WHERE idproducto = {1} AND iddevolucion = {2}", cantidad, uuidProducto, uuiddev);
                cnn.Update(string.Format("UPDATE DETALLE_DEVOLUCION SET cantidad = {0} WHERE idproducto = {1} AND iddevolucion = {2}", cantidad, uuidProducto, uuiddev));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }

        public DataTable historicocxc(string uuiddoc, string idcliente)
        {
            DataTable historico = new DataTable();
            historico = cnn.Select(string.Format(@"SELECT hcxc.idhistoricocxc as [ID], 
            hcxc.idcuentaporcobrar as [ID Cuenta por Cobrar],
            CXC.descripcion as [Cuenta por Cobrar], hcxc.idcliente as [ID Cliente],

            hcxc.idtipocxc as ID,
            tcxc.nombre as [TIPO],
            hcxc.fechapago as Fecha,
            hcxc.cantidadpagada as [Cantidad Pagada],
            hcxc.saldorestante as Saldo
            from HISTORICA_CXC as hcxc
            inner join CUENTAS_POR_COBRAR as CXC
            on CXC.idcuentaporcobrar = hcxc.idcuentaporcobrar
            inner join TIPO_CXC as tcxc
            on tcxc.idtipocxc = hcxc.idtipocxc
            WHERE hcxc.idcuentaporcobrar = {0} AND hcxc.idcliente = {1} order by fechapago ASC ", uuiddoc, idcliente));
            return historico;
        }

        public bool deleteHistorico (string uuidHistorico)
        {
            try
            {
                cnn.Delete(string.Format(@"DELETE HISTORICA_CXC WHERE idhistoricocxc = {0}",uuidHistorico));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public void insertMovimientoInventario(eMovimientoDev mdev)
        {
            cnn.Insert(string.Format("INSERT INTO DETALLEMOVIMIENTOINVENTARIO VALUES({0},{1},{2},{3},{4},{5})", mdev.idbodega,mdev.idmovimiento,mdev.idproducto,mdev.cantidad,mdev.costo,mdev.precio));
        }



        public DataTable checkdatacxc(string uuidFactura)
        {
            DataTable check = new DataTable();
            check = cnn.Select(string.Format(@"
                IF EXISTS (SELECT * FROM CUENTAS_POR_COBRAR WHERE  idfactura = {0})
                BEGIN
                  SELECT 'TRUE' AS RESULT
                END
                ELSE
                BEGIN
                  SELECT 'FALSE' AS RESULT 
                END",uuidFactura));
            return check;
        }


        public bool devolucioncxc(string uuidFactura, string uuidDevolucion)
        {
            try
            {
                cnn.Update(string.Format(@"UPDATE CUENTAS_POR_COBRAR SET iddevolucion={0} WHERE idfactura ={1}", uuidDevolucion, uuidFactura));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public DataTable checkSaldo(string uuidCliente)
        {
            DataTable saldo = new DataTable();
            saldo = cnn.Select(string.Format(@"SELECT TOP(1) saldorestante, fechapago,idcliente,cantidadpagada From HISTORICA_CXC where idcliente = {0} order by fechapago DESC", uuidCliente));
            return saldo;
        }

        public DataTable getidcxc(string uuidFactura, string uuidDevolucion)
        {
            DataTable result = new DataTable();
            result = cnn.Select(string.Format(@"SELECT idcuentaporcobrar,idcliente FROM CUENTAS_POR_COBRAR WHERE  idfactura ={0} AND iddevolucion ={1}", uuidFactura, uuidDevolucion));
            return result;
        }

        public void updateHistorico(eDevHistorico d,string fecha, string uuidCliente)
        {
            cnn.Update(string.Format(@"UPDATE HISTORICA_CXC SET saldorestante = {0} WHERE idcliente = {1} AND fechapago = '{2}'",d.saldorestante,uuidCliente,fecha));
        }

        public void insertHistorico(eDevHistorico dev)
        {
            //string query = (string.Format(@"INSERT INTO HISTORICA_CXC VALUES({0},{1},{2},{3},{4},{5})", dev.idcuentaporcobrar, dev.idcliente, dev.idtipocxc, dev.fechapago, dev.cantidadpagada, dev.saldorestante));
            cnn.Insert(string.Format(@"INSERT INTO HISTORICA_CXC VALUES({0},{1},{2},'{3}',{4},{5})",dev.idcuentaporcobrar,dev.idcliente,dev.idtipocxc,dev.fechapago,dev.cantidadpagada,dev.saldorestante));
        }
        //public DataTable getAllProveedor()
        //{
        //    DataTable proveedor = new DataTable();
        //    proveedor = cnn.Select("SELECT idproveedor,nombre_proveedor FROM Proveedor");
        //    return proveedor;
        //}

        //public DataTable getAllTypeDev()
        //{
        //    DataTable typeDev = new DataTable();
        //    typeDev = cnn.Select("SELECT idtipodevolucion,tipodevolucion FROM TIPO_DEVOLUCION");
        //    return typeDev;


        //}

        //public DataTable getAllCompanies()
        //{
        //    DataTable companies = new DataTable();
        //    companies = cnn.Select("SELECT idempresa,nombre_empresa FROM Empresa WHERE activo =  1");
        //    return companies;
        //}

        //public DataTable getAllsedes()
        //{
        //    DataTable companies = new DataTable();
        //    companies = cnn.Select("SELECT id_sede,nombre_sede FROM Sede WHERE activo = 1");
        //    return companies;
        //}

        //public DataTable getAllProducts()
        //{
        //    DataTable companies = new DataTable();
        //    companies = cnn.Select("SELECT idproducto,descripcion FROM Producto ");
        //    return companies;
        //}

        //public DataTable getAllFacturas()
        //{
        //    DataTable companies = new DataTable();
        //    companies = cnn.Select("SELECT idencabezadofact,idfactura FROM DETALLE_FACTURA");
        //    return companies;
        //}

        //public DataTable getFilterFactura(string uuidFactura)
        //{
        //    DataTable getFacturasbyid = new DataTable();

        //    getFacturasbyid = cnn.Select(string.Format(@"SELECT DFACTURA.idempresa,EMPRESA.nombre_empresa,DFACTURA.id_sede, 
        //                SEDE.nombre_sede, DFACTURA.idproducto,PRODUCTO.descripcion 
        //                FROM DETALLE_FACTURA AS DFACTURA
        //                INNER JOIN Empresa AS EMPRESA
        //                ON DFACTURA.idempresa = EMPRESA.idempresa
        //                INNER JOIN Sede AS SEDE
        //                ON SEDE.id_sede = DFACTURA.id_sede
        //                INNER JOIN Producto AS PRODUCTO
        //                ON PRODUCTO.idproducto = DFACTURA.idproducto
        //                WHERE idfactura = '{0}'", uuidFactura));
        //    return getFacturasbyid;
        //}




        public bool insertDevolucion(eDevoluciones dev)
        {
            try
            {
                string query = string.Format("INSERT INTO DEVOLUCIONES VALUES('{0}','{1}',{2},{3},{4},{5},{6},{7},{8})", dev.fechaDevolucion, dev.motivodev, dev.tipodev, dev.tipodocumento, dev.idcliente, dev.idmoneda, dev.idvendedor, dev.idfactura, dev.idestado);
                cnn.Insert(string.Format("INSERT INTO DEVOLUCIONES VALUES('{0}','{1}',{2},'{3}',{4},{5},{6},{7},{8},{9})", dev.fechaDevolucion, dev.motivodev, dev.tipodev, dev.tipodocumento, dev.idcliente, dev.idmoneda, dev.idvendedor, dev.idfactura, dev.idestado,dev.totaldevolucion));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }

        public bool insertDetatalleDev(eInsertDevolucion idev)
        {
            try
            {
                //string query = string.Format("INSERT INTO DETALLE_DEVOLUCION VALUES({0},{1},{2},{3},{4},{5},{6})", idev.iddevolucion, idev.idbodega, idev.idproducto, idev.impuesto, idev.cantidad, idev.comision, idev.preciounitario);
                cnn.Insert(string.Format("INSERT INTO DETALLE_DEVOLUCION VALUES({0},{1},{2},{3},{4},{5},{6})", idev.iddevolucion,idev.idbodega,idev.idproducto,idev.impuesto,idev.cantidad,idev.comision,idev.preciounitario));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }

        //public bool updateDevolucion(eDevoluciones dev, string iddev)
        //{
        //    try
        //    {
        //        cnn.Update(string.Format("UPDATE DETALLE_DEVOLUCIONES SET fechadevolucion = '{0}', motivodevolucion = '{1}', idtipodevolucion = {2},idempresa={3} , id_sede = {4}, idproveedor = {5}, idproducto = {6}, idencabezadofact = {7} WHERE iddevolucion = {8}", dev.fechaDevolucion, dev.motivodev, dev.tipodev, dev.empresa, dev.sede, dev.proveedor, dev.producto, dev.factura, iddev));
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }
        //}


        public bool deletedevolucion(string iddev, string uuidFactura)
        {
            try
            {
                string query = string.Format(@"UPDATE CUENTAS_POR_COBRAR SET iddevolucion= NULL WHERE idfactura ={0}", uuidFactura);
                cnn.Update(string.Format(@"UPDATE CUENTAS_POR_COBRAR SET iddevolucion= NULL WHERE idfactura ={0}", uuidFactura));
                cnn.Delete(string.Format(@"DELETE DETALLE_DEVOLUCION WHERE iddevolucion = {0}", iddev));
                cnn.Delete(string.Format(@"DELETE DEVOLUCIONES WHERE iddevolucion = {0}", iddev));
                

                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
