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
   public class nCXC
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();

        public DataTable datatcxc() {
            DataTable tcxc = new DataTable();

            tcxc = cnn.Select(@"SELECT idtipocxc AS [No Documento], nombre AS [Nombre Doc], descripcion AS [Descripcion], cuotamaxima AS [Cuota Maxima], compraminima [Compra Minima] FROM TIPO_CXC WHERE estado = 'ACTIVO' ");

            return tcxc;
            
            }

        public bool inserttcxc(eCXC cxctipo)
        {
            try
            {
               //string query = string.Format("INSERT INTO TIPO_CXC VALUES('{0}','{1}','{2}','{3}',{4}", cxctipo.nombre, cxctipo.cuotaminima, cxctipo.cuotamaxima, cxctipo.compraminima, cxctipo.idtipopago);
                cnn.Insert(string.Format("INSERT INTO TIPO_CXC VALUES('{0}','{1}','{2}','{3}',{4},'{5}')", cxctipo.nombre, cxctipo.cuotaminima, cxctipo.cuotamaxima, cxctipo.compraminima,cxctipo.idtipopago, cxctipo.estado));


              return true;

            }
            catch (Exception ex)
            {
               string message = ex.Message;
                return false;
            }
        }
        public bool updateconcepto(eCXC concepto, string idcxc)
        {
            try
            {
            //string query = string.Format("UPDATE TIPO_CXC SET nombre = '{0}', descripcion = '{1}',cuotamaxima = '{2}',compraminima = '{3}', idtipopago= {4}, estado = '{5}' WHERE idtipocxc = {5}", concepto.nombre, concepto.cuotaminima, concepto.cuotamaxima, concepto.compraminima, concepto.idtipopago, concepto.estado, concepto.idtipocxc);
            cnn.Update(string.Format("UPDATE TIPO_CXC SET nombre = '{0}', descripcion = '{1}',cuotamaxima = '{2}',compraminima = '{3}', idtipopago= {4}, estado='{5}' WHERE idtipocxc = '{6}'", concepto.nombre,concepto.cuotaminima,concepto.cuotamaxima,concepto.compraminima,concepto.idtipopago,concepto.estado,concepto.idtipocxc));
                return true;
            }
            catch (Exception ex)
            {
                
                return false;
            }
        }

        public bool deleteconcepto(eCXC conceptos, string iddelete)
        {
            string query = string.Format("UPDATE TIPO_CXC SET estado = 'INACTIVO' WHERE idtipocxc = {0}", conceptos.idtipocxc);
             cnn.Update(string.Format("UPDATE TIPO_CXC SET estado = 'INACTIVO' WHERE idtipocxc = {0}",conceptos.idtipocxc ));


            return true;
        }

    }
}
