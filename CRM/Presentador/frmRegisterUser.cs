using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador
{
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            eRegisterUser user = new eRegisterUser();
            user.user = txtuser.Text;
            user.password = Seguridad.Encriptar(txtpass.Text);
            user.pregunta = "CRM";
            user.rol = "1";
            user.status = 1;

            nLogin login = new nLogin();
            bool result = login.InsertUser(user);



            if (result != false)
            {
                MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Ingreso Fallido", "Ingreso Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            }
    }
}
