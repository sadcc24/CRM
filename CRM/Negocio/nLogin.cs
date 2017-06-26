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
        ConnectionDBLocal cnn = new ConnectionDBLocal();
        public DataTable login(eLogin login)
        {
            DataTable Login = new DataTable();

            Login = cnn.Select(string.Format(@"SELECT * FROM USUARIO_1 WHERE usuario = '{0}' AND password = '{1}'", login.user, login.password));
            return Login;
        }
    }
}
