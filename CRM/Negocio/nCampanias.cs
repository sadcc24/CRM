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
    public class nCampanias
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

    



    public bool deletecampania(string idcam)
    {
        try
        {
            cnn.Delete(string.Format(@"DELETE CAMPANIA WHERE idcampania = {0}", idcam));
            return true;
        }
        catch (Exception ex)
        {

            return false;
        }
    }


    public DataTable getAllTipoCampanias()
        {
            DataTable tipocamapanias = new DataTable();
            tipocamapanias = cnn.Select("SELECT idtipocampania as ID_Campanias,nombre,descripcion FROM TIPOCAMPANIA");
            return tipocamapanias;
        }

        //INSERTAR CAMPANIAS

        public bool insertCampa(eCamapnias campa)
        {
            try
            {
                cnn.Insert(string.Format("INSERT INTO dbo.CAMPANIA VALUES({0},'{1}','{2}','{3}','{4}',{5})", campa.TipoCampania, campa.nombre, campa.descripcion,campa.fechainicial,campa.fechafinal, campa.Empresa));
                return true;


         

        // cnn.Insert(string.Format("INSERT INTO CLIENTES VALUES('{0}','{1}',{2},{3},'{4}','{5}',{6},{7})", clien.nombre, clien.apellido, clien.telefono, clien.nit, clien.direccion, clien.email, clien.saldo, clien.subtotal));
        //return true;

        //  cnn.Insert(string.Format("INSERT INTO VENDEDOR VALUES('{0}','{1}','{2}',{3})", vend.nombre, vend.apellido, vend.email, vend.telefono));
        //  return true;
    }
            catch (Exception)
            {

                return false;
            }
        }



    }
}
