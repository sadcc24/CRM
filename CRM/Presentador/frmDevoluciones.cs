using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;

namespace Presentador
{
    public partial class frmDevoluciones : Form
    {
        public frmDevoluciones()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDevRegistro devRegistro = new frmDevRegistro();
            devRegistro.MdiParent = this.ParentForm;
            devRegistro.Show();

            devRegistro.txtFacturadev.Visible = false;
            devRegistro.txtFactura.Visible = true;
        }

        private void frmDevoluciones_Load(object sender, EventArgs e)
        {
            nDevoluciones allDev = new nDevoluciones(); 
            dgvDevoluciones.DataSource = allDev.getAllDev();


        }

        private void dgvDevoluciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDevRegistro regdev = new frmDevRegistro();
            string id = this.dgvDevoluciones.CurrentRow.Cells[0].Value.ToString();
            regdev.txtiddev.Text = id;
            string fechaDev = this.dgvDevoluciones.CurrentRow.Cells[1].Value.ToString();
            regdev.dtpfechadev.Text = fechaDev;
            string motivoDev = this.dgvDevoluciones.CurrentRow.Cells[2].Value.ToString();
            regdev.txtDescripcion.Text = motivoDev;
            string tipodev = this.dgvDevoluciones.CurrentRow.Cells[3].Value.ToString();
<<<<<<< HEAD
            regdev.cbtipodev.Text = tipodev;
            string empresa = this.dgvDevoluciones.CurrentRow.Cells[4].Value.ToString();
            regdev.cbtipodev.Text = empresa;
            string sede = this.dgvDevoluciones.CurrentRow.Cells[5].Value.ToString();
            regdev.cbsede.Text = sede;
            string proveed = this.dgvDevoluciones.CurrentRow.Cells[6].Value.ToString();
            regdev.cbproveedor.Text = proveed;

            string prod = this.dgvDevoluciones.CurrentRow.Cells[7].Value.ToString();
            regdev.cbproducto.Text = prod;

            string factura = this.dgvDevoluciones.CurrentRow.Cells[8].Value.ToString();
            regdev.cbfactura.Text = factura;

            


            regdev.dtpfechadev.Enabled = true;
            regdev.txtmotivodev.Enabled = true;
            regdev.cbtipodev.Enabled = true;
            regdev.cbempresa.Enabled = true;
            regdev.cbsede.Enabled = true;
            regdev.cbproveedor.Enabled = true;
            regdev.cbproducto.Enabled = true;
            regdev.cbfactura.Enabled = true;
            regdev.btnEditar.Enabled = true;
=======
            regdev.cbTipoDevolucion.Text = tipodev;
            string doc = this.dgvDevoluciones.CurrentRow.Cells[4].Value.ToString();
            regdev.txttipodevolucion.Text = doc+ ".";
            regdev.txttipodevolucion.Enabled = false;
            string cliente = this.dgvDevoluciones.CurrentRow.Cells[5].Value.ToString();
            regdev.txtCliente.Text = cliente;
            string moneda = this.dgvDevoluciones.CurrentRow.Cells[7].Value.ToString();
            regdev.txtMoneda.Text = moneda;
            string vendedor = this.dgvDevoluciones.CurrentRow.Cells[9].Value.ToString();
            regdev.txtVendedor.Text = vendedor;
            string fact = this.dgvDevoluciones.CurrentRow.Cells[11].Value.ToString();
            regdev.txtFacturadev.Text = fact;
            regdev.txtFactura.Visible = false;
            regdev.txtFacturadev.Visible = true;
            regdev.btnGuardar.Enabled = false;
>>>>>>> 41210a513aab4cdfab31185f5a9b36835ef7dcbb
            regdev.btnEliminar.Enabled = true;
            regdev.btnEditar.Enabled = true;

            regdev.txtTipoFactura.Visible = false;
            regdev.txtntipo.Visible = false;
            regdev.label2.Visible = false;



            //regdev.dtpfechadev.Enabled = true;
            //regdev.txtmotivodev.Enabled = true;
            //regdev.cbtipodev.Enabled = true;
            //regdev.cbempresa.Enabled = true;
            //regdev.cbsede.Enabled = true;
            //regdev.cbproveedor.Enabled = true;
            //regdev.cbproducto.Enabled = true;
            //regdev.cbfactura.Enabled = true;
            //regdev.btnEditar.Enabled = true;
            //regdev.btnEliminar.Enabled = true;
            //regdev.btnNuevo.Enabled = false;


            regdev.MdiParent = this.ParentForm;
            regdev.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nDevoluciones allDev = new nDevoluciones();
            dgvDevoluciones.DataSource = allDev.getAllDev();
        }

        private void dgvDevoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
