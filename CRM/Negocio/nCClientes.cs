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




        public DataTable getAllCampanias()
        {
            DataTable Campanias = new DataTable();
            Campanias = cnn.Select(@"SELECT
                                           dbo.CAMPANIA.idcampania as ID_Campania,                                
                                    dbo.TIPOCAMPANIA.nombre AS Tipo_campania,
                                    dbo.CAMPANIA.nombre as Nombre_Campania,
                                    dbo.CAMPANIA.descripcion as Descripcion,
                                    dbo.CAMPANIA.fechainicial as fecha_inicial,
                                    dbo.CAMPANIA.fechafinal as fecha_final,
                                    dbo.EMPRESA.nombre_empresa as Empresa
                                  
                                    FROM dbo.CAMPANIA
                                    INNER JOIN dbo.EMPRESA ON dbo.CAMPANIA.idempresa = dbo.EMPRESA.idempresa
                                    INNER JOIN dbo.TIPOCAMPANIA ON dbo.CAMPANIA.idtipocampania = dbo.TIPOCAMPANIA.idtipocampania");
            return Campanias;
        }








        public DataTable getAllClientes()
        {
            DataTable Cclientes = new DataTable();
            Cclientes = cnn.Select(@"SELECT 
                                        
                                                dbo.CLIENTE.idcliente AS ID,
                                                dbo.CLIENTE.fechanacimiento AS FECHA_NACIMIENTO,
                                                dbo.NACIONALIDAD.descripcion,
                                                dbo.SEXO.descripcion AS GENERO, 
                                                dbo.ESTADO.estado AS ESTAD_CLIENTE,
                                                dbo.EMPRESA.nombre_empresa AS EMPRESA,
                                                dbo.CLIENTE.segundonombre AS SEGUNDO_NOMBRE,
                                                dbo.CLIENTE.segundoapellido AS SEGUNDO_APELLIDO,
                                                dbo.CLIENTE.telefono AS TELEFONO,
                                                dbo.CLIENTE.direccion AS DIRECCION,
                                                dbo.CLIENTE.email AS CORREO,
                                                dbo.CLIENTE.edad AS EDAD,
                                                dbo.OCUPACION.nombre AS OCUPACION,
                                                dbo.TIPO_DOCUMENTO.nombre AS TIPO_IDENTIFICACION,
                                                dbo.CLIENTE.primernombre AS PRIMER_NOMBRE,
                                                dbo.CLIENTE.primerapellido AS PRIMER_APELLIDO

                                                FROM
                                                dbo.CLIENTE
                                                INNER JOIN dbo.ESTADO ON dbo.CLIENTE.idestado = dbo.ESTADO.idestado
                                                INNER JOIN dbo.EMPRESA ON dbo.CLIENTE.idempresa = dbo.EMPRESA.idempresa
                                                INNER JOIN dbo.NACIONALIDAD ON dbo.CLIENTE.idnacionalidad = dbo.NACIONALIDAD.idnacionalidad
                                                INNER JOIN dbo.SEXO ON dbo.CLIENTE.idsexo = dbo.SEXO.idsexo
                                                INNER JOIN dbo.OCUPACION ON dbo.CLIENTE.idocupacion = dbo.OCUPACION.idocupacion
                                                INNER JOIN dbo.TIPO_DOCUMENTO ON dbo.CLIENTE.idtipodocumento = dbo.TIPO_DOCUMENTO.idtipodocumento
");
            return Cclientes;
        }
        public bool insertClientes(eCClientes clien)
        {
            try
            {
                //cnn.Insert(string.Format("INSERT INTO dbo.CLIENTE VALUES({0},'{1}','{2}',{3},'{4}','{5}',{6},{7})", clien.estado, clien.nombre, clien.apellido, clien.telefono, clien.direccion, clien.email, clien.saldo, clien.iempresa));
                // return true;

                //                string query = string.Format("UPDATE DETALLE_DEVOLUCION SET cantidad = {0} WHERE idproducto = {1} AND iddevolucion = {2}", cantidad, uuidProducto, uuiddev);
                //string query = string.Format("INSERT INTO dbo.CLIENTE VALUES('{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}',{8},{9},{10},{11},{12},'{13}','{14}')", clien.Fechanac, clien.estado, clien.snombre, clien.sapellido, clien.telefono, clien.direccion, clien.email, clien.Edad, clien.Empresa, clien.Nacionalidad, clien.Sexo, clien.Ocupacion, clien.TipoDoc, clien.pnombre, clien.papellido);


                cnn.Insert(string.Format("INSERT INTO dbo.CLIENTE VALUES('{0}',{1},'{2}','{3}','{4}','{5}','{6}','{7}',{8},{9},{10},{11},{12},'{13}','{14}')", clien.Fechanac, clien.estado, clien.snombre, clien.sapellido,  clien.telefono, clien.direccion, clien.email, clien.Edad, clien.Empresa, clien.Nacionalidad, clien.Sexo, clien.Ocupacion, clien.TipoDoc, clien.pnombre, clien.papellido ));
                return true;

                // cnn.Insert(string.Format("INSERT INTO CLIENTES VALUES('{0}','{1}',{2},{3},'{4}','{5}',{6},{7})", clien.nombre, clien.apellido, clien.telefono, clien.nit, clien.direccion, clien.email, clien.saldo, clien.subtotal));
                 //public DateTime Fechanac { get; set; }
        //public int estado { get; set; }
        //public string pnombre { get; set; }
        //public string snombre { get; set; }
        //p/ublic string papellido { get; set; }
        //public string sapellido { get; set; }
        //public int telefono { get; set; }
        //public string direccion { get; set; }
        //public string email { get; set; }
        //public int Edad { get; set; }
        //public int Empresa { get; set; }
        //public int Nacionalidad { get; set; }
        //public int Sexo { get; set; }
        //public int Ocupacion { get; set; }
        //public int TipoDoc { get; set; }
        //return true;

        //  cnn.Insert(string.Format("INSERT INTO VENDEDOR VALUES('{0}','{1}','{2}',{3})", vend.nombre, vend.apellido, vend.email, vend.telefono));
        //  return true;
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



        public DataTable getAllTypSexo()
        {
            DataTable sexo = new DataTable();
            sexo = cnn.Select("SELECT idsexo,descripcion FROM SEXO");
            return sexo;

        }

        public DataTable getAllTypoDoc()
        {
            DataTable TipDoc = new DataTable();
            TipDoc = cnn.Select("SELECT idtipodocumento,nombre FROM TIPO_DOCUMENTO");
            return TipDoc;


        }

        public DataTable getAllNac()
        {
            DataTable Nac = new DataTable();
            Nac = cnn.Select("SELECT idnacionalidad,descripcion FROM NACIONALIDAD");
            return Nac;


        }


        public DataTable getAllOcu()
        {
            DataTable Ocu = new DataTable();
            Ocu = cnn.Select("SELECT idocupacion,nombre FROM OCUPACION");
            return Ocu;


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
