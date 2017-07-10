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
        ConnectionDBLocal cnn = new ConnectionDBLocal();
        public bool insertCuentaxCobrar(eCuentaXCobrar cxc)
        {
            try
            {
                //string query = string.Format("INSERT INTO FACTURA(idcliente,idvendedor,idmoneda,total,subtotal,fechafactura,tipodocumento,idestado,idtipopago) VALUES({0},{1},{2},{3},{4},'{5}','{6}',{7},{8})", fac.idcliente, fac.idvendedor, fac.idmoneda, fac.total, fac.subtotal, fac.fecha, fac.tipodocumento, fac.idestado, fac.idtipopago);
                cnn.Insert(string.Format("INSERT INTO CUENTAS_POR_COBRAR(idtipocxc,idvendedor,idfactura,fecha,idmoneda,total,subtotal,idcliente,idestado) VALUES({0},{1},{2},'{3}',{4},{5},{6},{7},{8})", cxc.idtipocxc, cxc.idvendedor, cxc.idfactura, cxc.fecha, cxc.idmoneda, cxc.total, cxc.subtotal, cxc.idcliente, cxc.idestado));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
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

        public bool updateSaldoCuenta(double saldocuenta,double subtotalcuenta, int idcuentaxcobrar)
        {
            try
            {

                //string query = string.Format("UPDATE CUENTAS_POR_COBRAR SET total = {0}, subtotal = {1} WHERE idcuentaporcobrar = {2}", saldocuenta, subtotalcuenta, idcuentaxcobrar);
                cnn.Update(string.Format("UPDATE CUENTAS_POR_COBRAR SET total = {0}, subtotal = {1} WHERE idcuentaporcobrar = {2}", saldocuenta, subtotalcuenta, idcuentaxcobrar));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
