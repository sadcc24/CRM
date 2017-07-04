using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

using Entidades;



namespace Negocio
{
    public class nCClientes
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();


        public DataTable getAllClientes()
        {
            DataTable Cclientes = new DataTable();
            Cclientes = cnn.Select(@"SELECT idcliente as ID_Cliente, idestado as Id_Estado, nombre as Nombre, apellido as Apellido, direccion as Direccion, email as Correo_Electronico, saldo as Saldo,idempresa as Id_Empresa FROM CLIENTE");
            return Cclientes;
        }
        public bool insertClientes(eCClientes clien)
        {
            try
            {
                 cnn.Insert(string.Format("INSERT INTO dbo.CLIENTE VALUES({0},'{1}','{2}',{3},'{4}','{5}',{6},{7})", clien.estado, clien.nombre, clien.apellido, clien.telefono, clien.direccion, clien.email, clien.saldo, clien.iempresa));
                return true;


            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool deleteClientes(string uuidcliente)
        {
            try
            {
                cnn.Delete(string.Format("DELETE CLIENTES WHERE idcliente = {0}", uuidcliente));

                //  cnn.Delete(string.Format(@"DELETE DETALLE_DEVOLUCIONES WHERE iddevolucion = {0}",iddev));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
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

        public DataTable getAllTypEstado()
        {
            DataTable typeest = new DataTable();
            typeest = cnn.Select("SELECT idestado,estado FROM ESTADO");
            return typeest;


        } 


        public DataTable getFilterEstados(string uuidEstado)
        {
            DataTable getestadosbyid = new DataTable();

            getestadosbyid = cnn.Select(string.Format(@"SELECT DFACTURA.idempresa,EMPRESA.nombre_empresa,DFACTURA.id_sede, 
                        SEDE.nombre_sede, DFACTURA.idproducto,PRODUCTO.descripcion 
                        FROM DETALLE_FACTURA AS DFACTURA
                        INNER JOIN Empresa AS EMPRESA
                        ON DFACTURA.idempresa = EMPRESA.idempresa
                        INNER JOIN Sede AS SEDE
                        ON SEDE.id_sede = DFACTURA.id_sede
                        INNER JOIN Producto AS PRODUCTO
                        ON PRODUCTO.idproducto = DFACTURA.idproducto
                        WHERE idfactura = '{0}'", uuidEstado));
            return getestadosbyid;
        }
        public bool deleteclientes(string idcliente)
        {
            try
            {
                cnn.Delete(string.Format(@"DELETE CLIENTE WHERE idcliente = {0}", idcliente));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

    }

}
