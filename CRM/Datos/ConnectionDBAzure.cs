using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConnectionDBAzure
    {
       // MRP_BD cnn = new MRP_BD(@"adminseminario", @"S@dseminario", @"ERPSeminario", @"erpseminario.database.windows.net");

        public void Delete(string queryDelete)
        {
          //  cnn.deleteSQL(queryDelete);
        }

        public void Insert(string queryInsert)
        {
         //   cnn.insertSQL(queryInsert);
        }

       // public DataTable Select(string querySelect)
     //   {
           // DataTable consulta = cnn.getSQL(querySelect);
           // return consulta;
      //  }

        public void Update(string update)
        {
          ////  cnn.updateSQL(update);
        }
    }
}
