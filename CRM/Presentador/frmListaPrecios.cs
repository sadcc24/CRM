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
using Datos;

namespace Presentador
{
    public partial class frmListaPrecios : Form
    {
        public frmListaPrecios()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmListaPreciosReg PreciosReg = new frmListaPreciosReg();
            PreciosReg.MdiParent = this.ParentForm;
            PreciosReg.Show();
        }

        

        private void dgvListaPrecios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmListaPreciosReg reglistaPrecios = new frmListaPreciosReg();
            string idtipolistaPecio = this.dgvListaPrecios.CurrentRow.Cells[0].Value.ToString();
            reglistaPrecios.txtIdListaPrecio.Text = idtipolistaPecio;

            string descripcion = this.dgvListaPrecios.CurrentRow.Cells[1].Value.ToString();
            reglistaPrecios.txtDescripcion.Text = descripcion;

            string precioUnitario = this.dgvListaPrecios.CurrentRow.Cells[2].Value.ToString();
            reglistaPrecios.txtPrecio.Text = precioUnitario;

            string estado = this.dgvListaPrecios.CurrentRow.Cells[3].Value.ToString();
            reglistaPrecios.cbEstado.Text = estado;

            string nombreEmpresa = this.dgvListaPrecios.CurrentRow.Cells[4].Value.ToString();
            reglistaPrecios.cbEmpresa.Text = nombreEmpresa;

            string producto = this.dgvListaPrecios.CurrentRow.Cells[5].Value.ToString();
            reglistaPrecios.cbProducto.Text = producto;

            string ListaPrecio = this.dgvListaPrecios.CurrentRow.Cells[6].Value.ToString();
            reglistaPrecios.cbTipoLista.Text = ListaPrecio;

            //string idProducto = this.dgvListaPrecios.CurrentRow.Cells[4].Value.ToString();
            //reglistaPrecios.txtProducto.Text = idProducto;

            reglistaPrecios.MdiParent = this.ParentForm;
            reglistaPrecios.Show();


        }

        private void frmListaPrecios_Load(object sender, EventArgs e)
        {
            nListaPrecio ListaPrecios = new nListaPrecio();
            dgvListaPrecios.DataSource = ListaPrecios.getAllListaPrecio();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nListaPrecio ListaPrecios = new nListaPrecio();
            dgvListaPrecios.DataSource = ListaPrecios.getAllListaPrecio();
        }
    }
}
