using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using System.Linq;
using Entidades;



namespace Negocio
{
    public class nCClientes
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();
        public DataTable getAllClientes()
        {
            DataTable clientes = new DataTable();
            clientes = cnn.Select(@"SELECT * FROM CLIENTES");
            return clientes;
        }
        public bool insertClientes(eCClientes clien)
        {
            try
            {
                cnn.Insert(string.Format("INSERT INTO CLIENTES VALUES('{0}','{1}',{2},{3},'{4}','{5}',{6},{7})", clien.nombre, clien.apellido, clien.telefono, clien.nit, clien.direccion, clien.email, clien.saldo, clien.subtotal));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
