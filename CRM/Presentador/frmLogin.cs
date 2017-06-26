using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentador
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingreso Usuario/Contraseña", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Clear();
                txtUser.Clear();
            }
            else
            {
                DataTable result = new DataTable();
                eLogin elogin = new eLogin();
                elogin.user = txtUser.Text;
                elogin.password = txtPassword.Text;

                nLogin login = new nLogin();
                result = login.login(elogin);

                if (result.Rows.Count != 0)
                {
                    frmCRM crm = new frmCRM();
                    crm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error en Usuario/Contraseña, verifique datos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUser.Clear();
                }
            }
        }
    }
}
