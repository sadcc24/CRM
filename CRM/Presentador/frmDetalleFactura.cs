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
            detFac.preciounitario = tbPrecio.Text;
            detFac.comision = Convert.ToInt16(tbComision.Text);
            
            detFac.idbodega = Convert.ToInt32(cbBodega.SelectedValue);
            detFac.idproducto = 1;

            nDetalleFactura insertDetFac = new nDetalleFactura();
            bool result = insertDetFac.insertDetalle(detFac, idfactura);

            if (result != false)
            {
                MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eliminacion Fallida", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
