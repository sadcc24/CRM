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

namespace Presentador
{
    
    public partial class frmDetalleFactura : Form
    {
        public int idfactura { get; set; }
        
        public frmDetalleFactura()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eDetalleFactura detFac = new eDetalleFactura();
            detFac.cantidad = tbCantidad.Text;
            detFac.preciounitario = this.dgvListaPrecio.CurrentRow.Cells[2].Value.ToString();

            double imp = Convert.ToDouble(detFac.preciounitario) * 0.12;
            detFac.impuesto = imp;
            detFac.comision = Convert.ToDouble(tbComision.Text) * Convert.ToDouble(detFac.preciounitario);
            
            detFac.idbodega = Convert.ToInt32(cbBodega.SelectedValue);
            string producto = this.dgvProductos.CurrentRow.Cells[0].Value.ToString();
            detFac.idproducto = Convert.ToInt16(producto);

            nDetalleFactura insertDetFac = new nDetalleFactura();
            bool result = insertDetFac.insertDetalle(detFac, idfactura);

            if (result != false)
            {
                MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingreso Faallida", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frmDetalleFactura_Load(object sender, EventArgs e)
        {
            
            nDetalleFactura DetFact = new nDetalleFactura();

            cbBodega.DataSource = DetFact.getAllBodega();
            cbBodega.ValueMember = "idbodega";
            cbBodega.DisplayMember = "nombre_bodega";

            dgvProductos.DataSource = DetFact.getAllProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tbCantidad.Enabled = true;
            tbComision.Enabled = true;
            
            cbBodega.Enabled = true;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string idProd = this.dgvProductos.CurrentRow.Cells[0].Value.ToString();
            tbIdProducto.Text = idProd;
        }

        private void tbIdProducto_TextChanged(object sender, EventArgs e)
        {
            nDetalleFactura detFac = new nDetalleFactura();
            dgvListaPrecio.DataSource = detFac.getListaPrecios(tbIdProducto.Text);
            dgvComision.DataSource = detFac.getComision(tbIdProducto.Text);

            string Comision = this.dgvComision.CurrentRow.Cells[0].Value.ToString();
            tbComision.Text = Comision;
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            if (tbCantidad.Text.Equals(""))
            {
                
            }
            else
            {
                double total = Convert.ToDouble(tbCantidad.Text) * Convert.ToDouble(this.dgvListaPrecio.CurrentRow.Cells[2].Value.ToString());
                tbTotal.Text = Convert.ToString(total);
            }
            
        }
    }
}
