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

namespace Presentador
{
    public partial class frmCatalogClientes : Form
    {
        public frmCatalogClientes()
        {
            InitializeComponent();
        }

        private void frmCatalogClientes_Load(object sender, EventArgs e)
        {
            nCClientes clientes = new nCClientes();
            dgvclientes.DataSource = clientes.getAllClientes();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmClientes ClRegistro = new frmClientes();
            ClRegistro.MdiParent = this.ParentForm;
            ClRegistro.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvclientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            frmClientes regdev = new frmClientes();
            string id = this.dgvclientes.CurrentRow.Cells[0].Value.ToString();
            regdev.txtidcliente.Text = id;
            string estado = this.dgvclientes.CurrentRow.Cells[1].Value.ToString();
            regdev.cbestado.Text = estado;
            string nombre = this.dgvclientes.CurrentRow.Cells[2].Value.ToString();
            regdev.txtnombre.Text = nombre;
            string apellido = this.dgvclientes.CurrentRow.Cells[3].Value.ToString();
            regdev.txtapellido.Text = apellido;
            string telefono = this.dgvclientes.CurrentRow.Cells[4].Value.ToString();
            regdev.txttelefono.Text = telefono;
            string direccion = this.dgvclientes.CurrentRow.Cells[5].Value.ToString();
            regdev.txtdireccion.Text = direccion;
            string email = this.dgvclientes.CurrentRow.Cells[6].Value.ToString();
            regdev.txtemail.Text = email;
            string saldo = this.dgvclientes.CurrentRow.Cells[7].Value.ToString();
            regdev.txtsaldo.Text = saldo;
            string idempresa = this.dgvclientes.CurrentRow.Cells[8].Value.ToString();
            regdev.cbempresa.Text = idempresa;




            regdev.cbestado.Enabled = true;
            regdev.txtnombre.Enabled = true;
            regdev.txtapellido.Enabled = true;
            regdev.cbempresa.Enabled = true;
            regdev.txttelefono.Enabled = true;
            regdev.txtdireccion.Enabled = true;
            regdev.txtemail.Enabled = true;
            regdev.txtsaldo.Enabled = true;
            regdev.cbempresa.Enabled = true;
         //   regdev.btnnuev.Enabled = true;
          //  regdev.btnNuevo.Enabled = false;


            regdev.MdiParent = this.ParentForm;
            regdev.Show();




            //   frmClientes regcli = new frmClientes();






            //DataGridViewRow dgv = dgvmostrarclientes.Rows[e.RowIndex];
            //cbidcliente.Text = dgv.Cells[0].Value.ToString();
            //cbestado.Text = dgv.Cells[1].Value.ToString();
            // txtnombre.Text = dgv.Cells[2].Value.ToString();
            //regcli.txtapellido.Text = dgv.Cells[3].Value.ToString();
            // regcli.txttelefono.Text = dgv.Cells[4].Value.ToString();
            // regcli.txtdireccion.Text = dgv.Cells[5].Value.ToString();
            // txtemail.Text = dgv.Cells[6].Value.ToString();
            //txtsaldo.Text = dgv.Cells[7].Value.ToString();
            //cbempresa.Text = dgv.Cells[8].Value.ToString();











        }
    }
}
