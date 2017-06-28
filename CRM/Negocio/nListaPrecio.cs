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
            ListaPrecio = cnn.Select(@"SELECT idlistaprecio as ID_Lista_Precio, idtipolista as Id_TIpo_Lista, descripcion as Descripcion, precio as Precio, idproducto as Id_Producto FROM LISTA_PRECIO");
            return ListaPrecio;
        }

        public bool insertLisaPrecio(eListaPrecio precios)
        {
            try
            {
                cnn.Insert(string.Format("INSERT INTO LISTA_PRECIO VALUES('{0}','{1}','{2}',{3})", precios.idtipolista, precios.descripcion, precios.precio, precios.idproducto));
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
                cnn.Delete(string.Format("DELETE FROM LISTA_PRECIO WHERE idlistaprecio = {0}", uuidlistaPrecio));
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
                cnn.Update(string.Format("UPDATE LISTA_PRECIO SET idtipolista = '{0}', descripcion = '{1}', precio = {2}, idproducto={3}  WHERE idlistaprecio = {4}", listaPrecio.idtipolista, listaPrecio.descripcion, listaPrecio.precio, listaPrecio.idproducto, idLP));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }


    }
    
}
