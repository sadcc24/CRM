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
    public class nListaPrecio
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();
        public DataTable getAllListaPrecio()
        {
            DataTable ListaPrecio = new DataTable();
            ListaPrecio = cnn.Select(@"SELECT
                        dbo.LISTAPRECIOS.idlistaprecio as [Id Lista],
                        dbo.LISTAPRECIOS.descripcion as [Descripcion],
                        dbo.LISTAPRECIOS.preciounitario as [Precio Unitario],
                        dbo.ESTADO.estado as [Estado],
                        dbo.EMPRESA.nombre_empresa as [Nombre Empresa],
                        dbo.PRODUCTO.descripcion as [Producto],
                        dbo.TIPOLISTAPRECIO.nombre as [Lista Precios]
                        FROM dbo.LISTAPRECIOS
                        INNER JOIN dbo.ESTADO ON dbo.LISTAPRECIOS.idestado = dbo.ESTADO.idestado
                        INNER JOIN dbo.EMPRESA ON dbo.LISTAPRECIOS.idempresa = dbo.EMPRESA.idempresa
                        INNER JOIN dbo.PRODUCTO ON dbo.PRODUCTO.idempresa = dbo.EMPRESA.idempresa AND dbo.LISTAPRECIOS.idproducto = dbo.PRODUCTO.idproducto
                        INNER JOIN dbo.TIPOLISTAPRECIO ON dbo.LISTAPRECIOS.idtipolistaprecio = dbo.TIPOLISTAPRECIO.idtipolistaprecio");
            return ListaPrecio;
        }

        public bool insertLisaPrecio(eListaPrecio precios)
        {
            try
            {
                cnn.Insert(string.Format("INSERT INTO LISTAPRECIOS(descripcion,preciounitario,idproducto,idtipolistaprecio,idestado,idempresa) VALUES('{0}',{1},{2},{3},{4},{5})", precios.descripcion, precios.precio, precios.producto,precios.idtipolista,precios.estado, precios.empresa));
                
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public bool deleteListaPrecio(string uuidlistaPrecio)
        {
            try
            {
                cnn.Delete(string.Format("DELETE FROM LISTAPRECIOS WHERE idlistaprecio = {0}", uuidlistaPrecio));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool updateListaPrecio(eListaPrecio listaPrecio, string idLP)
        {
            try
            {
                cnn.Update(string.Format("UPDATE LISTAPRECIOS SET idtipolistaprecio = {0}, descripcion = '{1}', preciounitario = {2}, idproducto={3}, idestado = {4}, idempresa ={5}  WHERE idlistaprecio = {6}", listaPrecio.idtipolista, listaPrecio.descripcion, listaPrecio.precio, listaPrecio.producto, listaPrecio.estado,listaPrecio.empresa, idLP));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public DataTable getFilterProducto()
        {
            DataTable getFacturasbyid = new DataTable();

            getFacturasbyid = cnn.Select(string.Format(@"SELECT idproducto,descripcion FROM PRODUCTO"));
            return getFacturasbyid;
        }

        public DataTable getFilterTipoLista()
        {
            DataTable getFacturasbyid = new DataTable();

            getFacturasbyid = cnn.Select(string.Format(@"SELECT idtipolistaprecio,nombre FROM TIPOLISTAPRECIO"));
            return getFacturasbyid;
        }

        public DataTable getFilterEstado()
        {
            DataTable getFacturasbyid = new DataTable();

            getFacturasbyid = cnn.Select(string.Format(@"SELECT idestado,estado FROM ESTADO"));
            return getFacturasbyid;
        }

        public DataTable getFilterEmpresa()
        {
            DataTable getFacturasbyid = new DataTable();

            getFacturasbyid = cnn.Select(string.Format(@"SELECT idempresa,nombre_empresa FROM EMPRESA"));
            return getFacturasbyid;
        }


    }
    
}
