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
            vendedores = cnn.Select(@"SELECT * FROM VENDEDOR");
            return vendedores;
        }

        public bool insertVendedores(eVendedor vend)
        {
            try
            {
                cnn.Insert(string.Format("INSERT INTO VENDEDOR VALUES('{0}','{1}','{2}',{3})", vend.nombre, vend.apellido, vend.email, vend.telefono));
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
    }
}
