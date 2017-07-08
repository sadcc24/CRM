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
    public class nVendedores
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();
        public DataTable getAllVendedores()
        {
            DataTable vendedores = new DataTable();
            vendedores = cnn.Select(@"SELECT idvendedor,nombre,apellido,vend.telefono,
            vend.direccion,email,emp.nombre_empresa FROM VENDEDOR as vend
            inner join EMPRESA as emp
            on emp.idempresa = vend.idempresa");
            return vendedores;
        }

        public bool insertVendedores(eVendedor vend)
        {
            try
            {
                cnn.Insert(string.Format("INSERT INTO VENDEDOR VALUES({0},'{1}','{2}',{3},'{4}','{5}',{6})", 1, vend.nombre, vend.apellido, vend.telefono, vend.direcccion,vend.email,vend.idempersa));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool editVendedor(eVendedor editv, string uuidvendedor)
        {
            try
            {
                string query = string.Format(@"UPDATE VENDEDOR SET nombre = '{0}',apellido='{1}',telefono={2},direccion='{3}',email='{4}',idempresa={5} where idvendedor={6}", editv.nombre, editv.apellido, editv.telefono, editv.direcccion, editv.email,editv.idempersa, uuidvendedor);
                cnn.Update(string.Format(@"UPDATE VENDEDOR SET nombre = '{0}',apellido='{1}',telefono={2},direccion='{3}',email='{4}',idempresa={5} where idvendedor={6}",editv.nombre,editv.apellido,editv.telefono,editv.direcccion,editv.email, editv.idempersa,uuidvendedor));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool deleteVendedores(string uuidVendedor)
        {
            try
            {
                cnn.Delete(string.Format("DELETE FROM VENDEDOR WHERE idvendedor = {0}", uuidVendedor));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public DataTable getEmpresas()
        {
            DataTable empresas = new DataTable();
            empresas = cnn.Select("SELECT idempresa,nombre_empresa FROM EMPRESA WHERE activo = 1");
            return empresas;
        }
    }
}
