using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class nComision
    {
        ConnectionDBAzure cnn = new ConnectionDBAzure();
        public DataTable getComision()
        {
            DataTable comision = new DataTable();
            comision = cnn.Select(@"SELECT idcomision,com.idvendedor, VEND.nombre, porcentajecomosion,com.idempresa,EMP.nombre_empresa, ISNULL(com.idmarca,com.idproducto) as [ID producto], ISNULL(MARC.descripcion, PROD.descripcion) AS Producto   FROM COMISION as com
            LEFT join VENDEDOR AS VEND
            ON VEND.idvendedor = com.idvendedor
            LEFT JOIN EMPRESA AS EMP
            ON EMP.idempresa = com.idempresa
            LEFT JOIN MARCA AS MARC
            ON MARC.idmarca = com.idmarca
            LEFT JOIN PRODUCTO AS PROD
            ON PROD.idproducto = com.idproducto");
            return comision;
        }

        public DataTable vendedores()
        {
            DataTable vend = new DataTable();
            vend = cnn.Select("SELECT idvendedor, nombre +' ' + apellido as Nombre FROM VENDEDOR");
            return vend;
        }

        public DataTable producto()
        {
            DataTable PROD = new DataTable();
            PROD = cnn.Select("SELECT idproducto,descripcion FROM PRODUCTO");
            return PROD;
        }
        public DataTable marca()
        {
            DataTable MARCA = new DataTable();
            MARCA = cnn.Select("SELECT idmarca,descripcion FROM MARCA");
            return MARCA;
        }

        public bool insertcomision(eComision comision)
        {
            try
            {
                string query = string.Format(@"INSERT INTO COMISION VALUES({0},{1},{2},{3},{4},{5})", comision.vendedor, comision.estado, comision.comision,comision.producto,comision.marca, comision.empresa);
                cnn.Insert(string.Format(@"INSERT INTO COMISION VALUES({0},{1},{2},{3},{4},{5})", comision.vendedor, comision.estado, comision.comision, comision.producto, comision.marca, comision.empresa));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public DataTable empresa()
        {
            DataTable empresa = new DataTable();
            empresa = cnn.Select("SELECT idempresa,nombre_empresa FROM EMPRESA");
            return empresa;
        }

        public bool deletecom(string idcomision)
        {
            try
            {
                cnn.Delete(string.Format(@"DELETE FROM COMISION WHERE idcomision ={0}", idcomision));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


        public bool updatecom(eComision comision, string idcomision)
        {
            try
            {
                string query = string.Format(@"UPDATE COMISION SET idvendedor ={0},idempresa = {1},idproducto ={2}, idmarca ={3}, porcentajecomision = {4} where idcomision = {5}", comision.vendedor, comision.empresa, comision.producto, comision.marca, Convert.ToDouble(comision.comision), idcomision);
                cnn.Update(string.Format(@"UPDATE COMISION SET idvendedor ={0},idempresa = {1},idproducto ={2}, idmarca ={3}, porcentajecomosion={4} where idcomision = {5}", comision.vendedor, comision.empresa, comision.producto, comision.marca, comision.comision, idcomision));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
