using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using Datos;

namespace Negocio
{
    public class nLogin
    {
        //ConnectionDBLocal cnn = new ConnectionDBLocal();
        ConnectionDBAzure cnn = new ConnectionDBAzure();
        public DataTable login(eLogin login)
        {
            DataTable Login = new DataTable();

            Login = cnn.Select(string.Format(@"SELECT * FROM USUARIO_1 WHERE usuario = '{0}'", login.user));
            return Login;
        }

        public bool InsertUser(eRegisterUser user)
         {
            try
             {
               //  string query = string.Format(@"INSERT INTO USUARIO_1 VALUES({0},'{1}','{2}',{3},'{4}','{5}')", user.rol, user.user, user.password, user.status, user.pregunta, user.respuesta);
                 cnn.Insert(string.Format(@"INSERT INTO USUARIO_1 VALUES({0},'{1}','{2}',{3},'{4}','{5}')", user.rol, user.user, user.password, user.status, user.pregunta, user.respuesta));
                 return true;
             }
             catch (Exception)
            {
 
                 return false;
             }
         }
    }
}
