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
    public class nCuentaXCobrar
    {
        //ConnectionDBLocal cnn = new ConnectionDBLocal();
        ConnectionDBAzure cnn = new ConnectionDBAzure();
        public bool insertCuentaxCobrar(eCuentaXCobrar cxc)
        {
            try
            {
                string query = string.Format("INSERT INTO CUENTAS_POR_COBRAR(idvendedor,idfactura,fecha,idmoneda,total,subtotal,idcliente,idestado,cantidadCuotas,cantidadPago) VALUES({0},{1},'{2}',{3},{4},{5},{6},{7},{8},{9})", cxc.idvendedor, cxc.idfactura, cxc.fecha, cxc.idmoneda, cxc.total, cxc.subtotal, cxc.idcliente, cxc.idestado ,cxc.cantidadCuotas , cxc.cantidadPago);
                cnn.Insert(string.Format("INSERT INTO CUENTAS_POR_COBRAR(idvendedor,idfactura,fecha,idmoneda,total,subtotal,idcliente,idestado,cantidadCuotas,cantidadPago) VALUES({0},{1},'{2}',{3},{4},{5},{6} ,{7},{8},{9} )", cxc.idvendedor, cxc.idfactura, cxc.fecha, cxc.idmoneda, cxc.total, cxc.subtotal, cxc.idcliente, cxc.idestado ,cxc.cantidadCuotas , cxc.cantidadPago));
                return true;
            }
            catch (Exception ex)
            {
                //string message = ex.Message;
                return false;
            }
        }

        public DataTable getLastIdCXC()
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select("SELECT IDENT_CURRENT('CUENTAS_POR_COBRAR') as IDCXC;");
            return typeDev;
        }

        public DataTable getidcuentasxcobrar(string idcuentaxcobrar)
        {
            DataTable typeDev = new DataTable();
            typeDev = cnn.Select(string.Format("SELECT idcuentaporcobrar FROM CUENTAS_POR_COBRAR WHERE idfactura = {0}", idcuentaxcobrar));
            return typeDev;
        }

        public bool updateSaldoCuenta(double saldocuenta,double subtotalcuenta, double cantPagos, int idcuentaxcobrar )
        {
            try
            {

                //string query = string.Format("UPDATE CUENTAS_POR_COBRAR SET total = {0}, subtotal = {1} WHERE idcuentaporcobrar = {2}", saldocuenta, subtotalcuenta, idcuentaxcobrar);
                cnn.Update(string.Format("UPDATE CUENTAS_POR_COBRAR SET total = {0}, subtotal = {1}, cantidadPago = {2} WHERE idcuentaporcobrar = {3}", saldocuenta, subtotalcuenta, cantPagos , idcuentaxcobrar));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }


        }

        public bool updateCantidadPago(double cantidadPago,  int idcuentaxcobrar)
        {
            try
            {

                //string query = string.Format("UPDATE CUENTAS_POR_COBRAR SET total = {0}, subtotal = {1} WHERE idcuentaporcobrar = {2}", saldocuenta, subtotalcuenta, idcuentaxcobrar);
                cnn.Update(string.Format("UPDATE CUENTAS_POR_COBRAR SET cantidadPago = {0} WHERE idcuentaporcobrar = {}", cantidadPago, idcuentaxcobrar));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
