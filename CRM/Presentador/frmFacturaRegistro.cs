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
    public partial class frmFacturaRegistro : Form
    {
        public frmFacturaRegistro()
        {
            InitializeComponent();
        }

        private void frmFacturaRegistro_Load(object sender, EventArgs e)
        {
            nFactura getFac = new nFactura();
            dgvDetalleFactura.AllowUserToAddRows = false;
            dgvCliente.DataSource = getFac.getAllCliente();

            //cbCliente.DataSource = getFac.getAllCliente();
            //cbCliente.ValueMember = "idcliente";
            //cbCliente.DisplayMember = "nombre";

            


            cbVendedor.DataSource = getFac.getAllVendedor();
            cbVendedor.ValueMember = "idvendedor";
            cbVendedor.DisplayMember = "nombre";

            cbTipoPago.DataSource = getFac.getAllTipoPago();
            cbTipoPago.ValueMember = "idtipopago";
            cbTipoPago.DisplayMember = "nombre";


            cbEstado.DataSource = getFac.getAllEstado();
            cbEstado.ValueMember = "idestado";
            cbEstado.DisplayMember = "estado";

            cbMoneda.DataSource = getFac.getAllMoneda();
            cbMoneda.ValueMember = "idmoneda";
            cbMoneda.DisplayMember = "nombre_moneda";

            nDetalleFactura nDetlleFac = new nDetalleFactura();
            dgvDetalleFactura.DataSource = nDetlleFac.getAllDetalleFac(tbIdFac.Text);
            


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //cbCliente.Enabled = true;
            cbVendedor.Enabled = true;
            cbTipoPago.Enabled = true;
            cbEstado.Enabled = true;
            cbMoneda.Enabled = true;
            //tbTipoDocumento.Enabled = true;
            dtpFecha.Enabled = true;
            cbTipoDoc.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eFactura datosFac = new eFactura ();
            datosFac.idcliente = Convert.ToInt16(this.dgvCliente.CurrentRow.Cells[0].Value.ToString());
            datosFac.idvendedor = Convert.ToInt16(cbVendedor.SelectedValue);
            datosFac.idmoneda = Convert.ToInt16(cbMoneda.SelectedValue);
            //datosFac.total = Convert.ToInt16(tbTotal.Text);
            //datosFac.subtotal = Convert.ToInt16(tbTotal.Text);
            //datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.fecha = dtpFecha.Value.ToShortDateString();
            datosFac.tipodocumento = cbTipoDoc.Text;
            //datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.idestado = Convert.ToInt16(cbEstado.SelectedValue);
            datosFac.idtipopago = Convert.ToInt16(cbTipoPago.SelectedValue);

            nFactura listaFac = new nFactura();
            bool result = listaFac.insertFactura(datosFac);
            

            if (result != false)
            {

                dgvFac.DataSource = listaFac.getLastIdFactura();
                string idfac = this.dgvFac.CurrentRow.Cells[0].Value.ToString();
                tbIdFac.Text = idfac;
                if (cbTipoDoc.Text.Equals("Factura"))
                {
                    eCuentaXCobrar cuentaxcobrar = new eCuentaXCobrar();
                    //cuentaxcobrar.idtipocxc = 1;
                    cuentaxcobrar.idvendedor = Convert.ToInt16(cbVendedor.SelectedValue);
                    cuentaxcobrar.idfactura = Convert.ToInt16(idfac);
                    cuentaxcobrar.fecha = dtpFecha.Value.ToShortDateString();
                    cuentaxcobrar.idmoneda = Convert.ToInt16(cbMoneda.SelectedValue);
                    cuentaxcobrar.total = 1;
                    cuentaxcobrar.subtotal = 1;
                    if (cbTipoPago.Text.Equals("Credito"))
                    {
                        cuentaxcobrar.cantidadCuotas = Convert.ToInt16(cbCantidadCuotas.Text);
                    }
                    else
                    {
                        cuentaxcobrar.cantidadCuotas = 1;
                    }
                    
                    cuentaxcobrar.cantidadPago = 1;
                    cuentaxcobrar.idcliente = Convert.ToInt16(this.dgvCliente.CurrentRow.Cells[0].Value.ToString());
                    cuentaxcobrar.idestado = Convert.ToInt16(cbEstado.SelectedValue);

                    nCuentaXCobrar cuenxcobr = new nCuentaXCobrar();
                    bool result1 = cuenxcobr.insertCuentaxCobrar(cuentaxcobrar);
                    dgvCXC.DataSource = cuenxcobr.getLastIdCXC();
                    tbCxC.Text =  this.dgvCXC.CurrentRow.Cells[0].Value.ToString();


                }

                

                //if (result1 != false)
                //{
                //    MessageBox.Show("Registro Insertado ", "Insercion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //else
                //{
                //    MessageBox.Show("Fallo Registro Insertado cuentaxcobrar", "Fallo Insercion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}


                //DataTable id = new DataTable();                
                //id = getid.getFacturaid();
                //eDetalleFactura idet = new eDetalleFactura();
                //idet.idfactura = Convert.ToInt32(id.Rows[0].ToString());

                MessageBox.Show("Registro Insertado ", "Insercion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fallo Registro Insertado factura", "Fallo Insercion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //tbFecha.Clear();
            //tbTipoDocumento.Clear();
            tbTotal.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nFactura deleteFac = new nFactura();
            bool result = deleteFac.deleteFactura(tbIdFac.Text);

            if (result != false)
            {
                MessageBox.Show("Registro Eliminado", "Eliminacion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //tbFecha.Clear();
                //tbTipoDocumento.Clear();
                tbTotal.Clear();
            }
            else
            {
                MessageBox.Show("Fallo Eliminacion Reigstro", "Fallo Eliminacion Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            eFactura datosFac = new eFactura();
            string idfac = tbIdFac.Text;
            datosFac.idcliente = Convert.ToInt16(this.dgvCliente.CurrentRow.Cells[0].Value.ToString());
            datosFac.idvendedor = Convert.ToInt16(cbVendedor.SelectedValue);
            datosFac.idmoneda = Convert.ToInt16(cbMoneda.SelectedValue);
            datosFac.total = Convert.ToInt16(tbTotal.Text);
            datosFac.subtotal = Convert.ToInt16(tbTotal.Text);
            datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.fecha = dtpFecha.Value.ToShortDateString();
            datosFac.tipodocumento = cbTipoDoc.Text;
            datosFac.impuesto = Convert.ToInt16(tbTotal.Text);
            datosFac.idestado = Convert.ToInt16(cbEstado.SelectedValue);
            datosFac.idtipopago = Convert.ToInt16(cbTipoPago.SelectedValue);

            nFactura listaFac = new nFactura();
            bool result = listaFac.updateFactura(datosFac, idfac);


            if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nDevoluciones allDev = new nDevoluciones();
                frmDevoluciones frmdev = new frmDevoluciones();
                frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();

                
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            frmDetalleFactura detalleFactura = new frmDetalleFactura();
            eDetalleFactura detFac = new eDetalleFactura();
            detalleFactura.MdiParent = this.ParentForm;

            //detFac.idfactura = Convert.ToInt16(this.dgvFac.CurrentRow.Cells[0].Value.ToString());
            //tbIdFac.Text = Convert.ToString(detFac.idfactura);
            detalleFactura.idfactura = Convert.ToInt16(tbIdFac.Text);
            detalleFactura.Show();
            
            
        }

        

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string saldo = this.dgvCliente.CurrentRow.Cells[5].Value.ToString();
            double saldototal = Convert.ToDouble(saldo);
            if (saldototal >= 1000)
            {
                MessageBox.Show("El cliente debe mas de 1000, no se le dara credito", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGuardar.Enabled = false;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            nDetalleFactura nDetlleFac = new nDetalleFactura();
            //string idFac = this.dgvFac.CurrentRow.Cells[0].Value.ToString();
            //tbIdFac.Text = idFac;
            dgvDetalleFactura.DataSource = nDetlleFac.getAllDetalleFac(tbIdFac.Text);
            double precio = 0;
            double cantidad = 0;
            double total = 0;
            double total1 = 0;
            for (int i = 0; i < dgvDetalleFactura.RowCount; i++)
            {

                
                precio = Convert.ToDouble(this.dgvDetalleFactura.Rows[i].Cells[3].Value.ToString());
                cantidad = Convert.ToDouble(this.dgvDetalleFactura.Rows[i].Cells[2].Value.ToString());
                total = precio * cantidad;
                total1 = total1 + total;

                //total = 0;
                MessageBox.Show("" + total1, "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                


            }
            double iva =  1- (1 / 1.12);
            double subtotal = (total1 / 1.12);
            double impu = (total1 * iva);

            eFactura efac = new eFactura();
            efac.total = total1;
            efac.subtotal = subtotal;
            efac.impuesto = impu;

            nFactura nfactur =new nFactura();
            string fac =  tbIdFac.Text;
            nfactur.updateSaldo(efac, fac);
            tbTotal.Text = Convert.ToString(total1);

            



            if (cbTipoDoc.Text.Equals("Factura"))
            {
                //Se le modifica el saldo al cliente si es factura
                double idcliente = Convert.ToDouble(this.dgvCliente.CurrentRow.Cells[0].Value.ToString());
                double saldoCliente = Convert.ToDouble(this.dgvCliente.CurrentRow.Cells[5].Value.ToString());
                double totalSaldo = saldoCliente + total1;
                double cantPagos = total1 / Convert.ToInt16(cbCantidadCuotas.Text);
                tbCantidadPago.Text = Convert.ToString(cantPagos);
                int cliente = Convert.ToInt16(idcliente);
                nfactur.updateClienteSaldo(totalSaldo, cliente);

                dgvCliente.DataSource = nfactur.getAllCliente();


                //Actualizar cuentas por cobrar
                nCuentaXCobrar cuentaxc = new nCuentaXCobrar();
                dgvCXC.DataSource = cuentaxc.getidcuentasxcobrar(fac);
                if(tbCxC.Text.Equals(""))
                {
                    tbCxC.Text = this.dgvCXC.CurrentRow.Cells[0].Value.ToString();
                }

                

                productodetail.insertMovimientoInventario(movimiento);

                int idcue = Convert.ToInt16(tbCxC.Text);
                cuentaxc.updateSaldoCuenta(total1, subtotal, cantPagos ,idcue );
            }
            










        }

        private void cbTipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPago.Text.Equals("Contado"))
            {
                cbCantidadCuotas.Visible = false;
                tbCantidadPago.Visible = false;
                lbCantidadCuotas.Visible = false;
                lbCantidadPago.Visible = false;
            }
            else
            {
                cbCantidadCuotas.Visible = true;
                tbCantidadPago.Visible = true;
                lbCantidadCuotas.Visible = true;
                lbCantidadPago.Visible = true;
            }
            
        }
    }
}
