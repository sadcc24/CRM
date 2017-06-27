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
    public class nTipoLista
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();

        public DataTable getAllTipoLista()
        {
            DataTable DataTipoLista = new DataTable();

            DataTipoLista = cnn.Select(@"select idtipolista as IDTipo, nombretipolista as nombreLista from TIPO_LISTAPRECIO");

            return DataTipoLista;
        }
        public bool insertTipoLista(eTipoLista tipoLista)
        {
            try
            {
                //string query = string.Format("INSERT INTO DETALLE_DEVOLUCIONES VALUES({0},'{1}',{2},{3},{4},{5},{6},{7})", dev.fechaDevolucion, dev.motivodev, dev.tipodev, dev.empresa, dev.sede, dev.proveedor, dev.producto, dev.factura);
                cnn.Insert(string.Format("INSERT INTO TIPO_LISTAPRECIO(nombretipolista) VALUES('{0}')", tipoLista.nombreTipoLista));
                return true;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return false;
            }
        }

        public bool deleteTipoLista(string iddev)
        {
            try
            {
                cnn.Delete(string.Format(@"DELETE TIPO_LISTAPRECIO WHERE idtipolista = {0}", iddev));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool updateTipoLista(eTipoLista tipoLista, string idTipoLista)
        {
            try
            {
                cnn.Update(string.Format("UPDATE TIPO_LISTAPRECIO SET nombretipolista = '{0}' WHERE idtipolista = {1}", tipoLista.nombreTipoLista, idTipoLista));
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
