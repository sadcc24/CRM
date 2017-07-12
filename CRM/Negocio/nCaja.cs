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
    public class nCaja
    {
        ConnectionDBLocal cnn = new ConnectionDBLocal();

        public DataTable Caja()
        {
            DataTable caja = new DataTable();
            caja = cnn.Select(@"SELECT C.idcaja AS ID, E.estado,ISNULL(CXC.idcuentaporcobrar,TRANS.idtransaccion) AS [ID DOCUMENTOS], ISNULL(CXC.descripcion,TRANS.docref) AS Documentos FROM CAJA AS C
            LEFT JOIN CUENTAS_POR_COBRAR AS CXC
            ON CXC.idcuentaporcobrar = C.idcuentaporcobrar
            LEFT JOIN TRANSACCION AS TRANS
            ON TRANS.idtransaccion = C.idtransaccion
            INNER JOIN ESTADO AS E
            ON E.idestado = C.idestado");
            return caja;
        }

        public bool insertHistorico(eHistorico historico)
        {
            try
            {
                string query = string.Format(@"INSERT INTO HISTORICA_CXC VALUES({0},{1},{2},'{3}',{4},{5})",historico.idcuentacxc,historico.idcliente,historico.idtipocxc,historico.Fecha,historico.cantidadPagada,historico.saldo);
                cnn.Insert(string.Format(@"INSERT INTO HISTORICA_CXC VALUES({0},{1},{2},'{3}',{4},{5})", historico.idcuentacxc, historico.idcliente, historico.idtipocxc, historico.Fecha, historico.cantidadPagada, historico.saldo));
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
