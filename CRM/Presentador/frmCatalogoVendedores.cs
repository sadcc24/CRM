using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;
using Datos;

namespace Presentador
{
    public partial class frmCatalogoVendedores : Form
    {
        public frmCatalogoVendedores()
        {
            InitializeComponent();
        }

        private void frmCatalogoVendedores_Load(object sender, EventArgs e)
        {
            nVendedores vendedor = new nVendedores();
            dgvVendedores.DataSource = vendedor.getAllVendedores(); 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmvendoresc regVendedor = new frmvendoresc();
            regVendedor.MdiParent = this.ParentForm;
            regVendedor.Show();
        }

        private void dgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmvendoresc regvend = new frmvendoresc();
            string idvendedor = this.dgvVendedores.CurrentRow.Cells[0].Value.ToString();
            regvend.txtidvendedor.Text = idvendedor;

            string nombre = this.dgvVendedores.CurrentRow.Cells[1].Value.ToString();
            regvend.txtnombre.Text = nombre;
            string apellido = this.dgvVendedores.CurrentRow.Cells[2].Value.ToString();
            regvend.txtapellido.Text = apellido;
            string email = this.dgvVendedores.CurrentRow.Cells[3].Value.ToString();
            regvend.txtemail.Text = email;
            string telefono = this.dgvVendedores.CurrentRow.Cells[4].Value.ToString();
            regvend.txttelefono.Text = telefono;

            regvend.MdiParent = this.ParentForm;
            regvend.Show();


        }
    }
}
