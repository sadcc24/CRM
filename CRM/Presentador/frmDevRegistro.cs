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
    public partial class frmDevRegistro : Form
    {
        public frmDevRegistro()
        {
            InitializeComponent();
        }


        private void frmDevRegistro_Load(object sender, EventArgs e)
        {
            dgvDetalleFactura.AllowUserToAddRows = false;

            nDevoluciones dev = new nDevoluciones();
            cbTipoDevolucion.DataSource = dev.getTipoDev();
            cbTipoDevolucion.ValueMember = "idtipodevolucion";
            cbTipoDevolucion.DisplayMember = "nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Rellene los Datos Requeridos: Motivo Devolucion", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eDevoluciones dev = new eDevoluciones();
                dev.fechaDevolucion = dtpfechadev.Value;
                dev.motivodev = txtDescripcion.Text;
                dev.idcliente = Convert.ToInt16(txtCliente.Text);
                dev.idvendedor = Convert.ToInt16(txtVendedor.Text);
                dev.idmoneda = Convert.ToInt16(txtMoneda.Text);
                dev.idfactura = Convert.ToInt16(txtFactura.Text);
                dev.idestado = 1;
                dev.tipodev = Convert.ToInt32(cbTipoDevolucion.SelectedValue);
                dev.tipodocumento = "FACTURA";

                nDevoluciones insertDev = new nDevoluciones();
                bool result = insertDev.insertDevolucion(dev);

                if(result != false)
                {
                    DataTable id = new DataTable();
                    nDevoluciones getid = new nDevoluciones();
                    id = getid.getDevolucionid(txtDescripcion.Text, txtFactura.Text);
                    bool result2 = false;
                    for (int i = 0; i < dgvDetalleFactura.RowCount; i++)
                    {
                        if (this.dgvDetalleFactura.CurrentRow.Cells[0].Value.ToString() != "0")
                        {
                            eInsertDevolucion idev = new eInsertDevolucion();
                            idev.iddevolucion = Convert.ToInt32(id.Rows[0][0].ToString());
                            idev.cantidad = Convert.ToInt32(this.dgvDetalleFactura.Rows[i].Cells[0].Value.ToString());
                            idev.idbodega = Convert.ToInt32(this.dgvDetalleFactura.Rows[i].Cells[1].Value.ToString());
                            idev.idproducto = Convert.ToInt32(this.dgvDetalleFactura.Rows[i].Cells[2].Value.ToString());
                            idev.preciounitario = this.dgvDetalleFactura.Rows[i].Cells[4].Value.ToString();
                            idev.comision = this.dgvDetalleFactura.Rows[i].Cells[5].Value.ToString();
                            idev.impuesto = this.dgvDetalleFactura.Rows[i].Cells[6].Value.ToString();


                            //INSERCION DE MOVIMIENTO INVENTARIO DE DEVOLUCION VENTA
                            //eMovimientoDev movdev = new eMovimientoDev();
                            //movdev.cantidad = idev.cantidad;
                            //movdev.idproducto = idev.idproducto;
                            //movdev.precio = idev.preciounitario;


                            //nDevoluciones dmov = new nDevoluciones();
                            //dmov.insertMovimientoInventario(movdev)


                            DataTable cantidad = new DataTable();

                            nDevoluciones compare = new nDevoluciones();
                            cantidad = compare.compareCantidadFact(txtFactura.Text);
                            if (cantidad.Rows[i]["cantidad"].ToString() == idev.cantidad.ToString())
                            {
                                 compare.deleteProductoDetalle(this.dgvDetalleFactura.Rows[i].Cells[2].Value.ToString(), txtFactura.Text);
                            }
                            else
                            {
                                 compare.editProductoDetalle(this.dgvDetalleFactura.Rows[i].Cells[0].Value.ToString(), this.dgvDetalleFactura.Rows[i].Cells[2].Value.ToString(), txtFactura.Text);
                            }

                            nDevoluciones insert = new nDevoluciones();
                            result2 = insert.insertDetatalleDev(idev);
                        }
                      

                    }

                    if (result2 != false)
                    {
                        MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCliente.ResetText();
                        txtnCliente.ResetText();
                        txtVendedor.ResetText();
                        txtnVendedor.ResetText();
                        txtMoneda.ResetText();
                        txtnMoneda.ResetText();
                        txtFactura.ResetText();
                        txtTipoFactura.ResetText();
                        txtntipo.ResetText();
                        txtDescripcion.ResetText();
                        txtTotalPartida.ResetText();
                        dtpfechadev.Refresh();
                        txttipodevolucion.ResetText();
                        txttipodevolucion.Enabled = true;
                        dgvDetalleFactura.DataSource = null;
                        txtFacturadev.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCliente.ResetText();
                        txtnCliente.ResetText();
                        txtVendedor.ResetText();
                        txtnVendedor.ResetText();
                        txtMoneda.ResetText();
                        txtnMoneda.ResetText();
                        txtFactura.ResetText();
                        txtTipoFactura.ResetText();
                        txtntipo.ResetText();
                        txtDescripcion.ResetText();
                        txtTotalPartida.ResetText();
                        dtpfechadev.Refresh();
                        txttipodevolucion.ResetText();
                        txttipodevolucion.Enabled = true;
                        dgvDetalleFactura.DataSource = null;
                    }


                }


                
            }

            //if(String.IsNullOrEmpty(txtmotivodev.Text))
            //{
            //    MessageBox.Show("Rellene los Datos Requeridos: Motivo Devolucion", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    eDevoluciones dev = new eDevoluciones();
            //    dev.fechaDevolucion = dtpfechadev.Value;
            //    dev.motivodev = txtmotivodev.Text;
            //    dev.tipodev = Convert.ToInt16(cbtipodev.SelectedValue);
            //    dev.empresa = Convert.ToInt16(cbempresa.SelectedValue);
            //    dev.sede = Convert.ToInt16(cbsede.SelectedValue);
            //    dev.proveedor = Convert.ToInt16(cbproveedor.SelectedValue);
            //    dev.producto = Convert.ToInt16(cbproducto.SelectedValue);
            //    dev.factura = Convert.ToInt16(cbfactura.SelectedValue);

            //    nDevoluciones insertDev = new nDevoluciones();
            //    bool result = insertDev.insertDevolucion(dev);

            //    if(result != false)
            //    {
            //        MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        nDevoluciones allDev = new nDevoluciones();
            //        frmDevoluciones frmdev = new frmDevoluciones();
            //        frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();
            //        txtmotivodev.Clear();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }


            //}


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCliente.ResetText();
            txtnCliente.ResetText();
            txtVendedor.ResetText();
            txtnVendedor.ResetText();
            txtMoneda.ResetText();
            txtnMoneda.ResetText();
            txtFactura.ResetText();
            txtTipoFactura.ResetText();
            txtntipo.ResetText();
            txtDescripcion.ResetText();
            txtTotalPartida.ResetText();
            dtpfechadev.Refresh();
            txttipodevolucion.ResetText();
            txttipodevolucion.Enabled = true;
            dgvDetalleFactura.DataSource = null;
            txtFacturadev.ResetText();
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;

        }

        private void cbfactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nDevoluciones getprov = new nDevoluciones();
            //DataTable filter = new DataTable();

            //dynamic select = cbfactura.SelectedItem;
            //string value = select[1];

            //filter = getprov.getFilterFactura(value);

            //cbempresa.DataSource = filter;
            //cbempresa.ValueMember = "idempresa";
            //cbempresa.DisplayMember = "nombre_empresa";

            //cbsede.DataSource = filter;
            //cbsede.ValueMember = "id_sede";
            //cbsede.DisplayMember = "nombre_sede";

            //cbproducto.DataSource = filter;
            //cbproducto.ValueMember = "idproducto";
            //cbproducto.DisplayMember = "descripcion";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool result = false;

            for (int i = 0; i < dgvDetalleFactura.RowCount; i++)
            {
                if (this.dgvDetalleFactura.CurrentRow.Cells[0].Value.ToString() != "0")
                {
                    eInsertDevolucion idev = new eInsertDevolucion();
                    idev.iddevolucion = Convert.ToInt32(txtiddev.Text);
                    idev.cantidad = Convert.ToInt32(this.dgvDetalleFactura.Rows[i].Cells[0].Value.ToString());
                    idev.idbodega = Convert.ToInt32(this.dgvDetalleFactura.Rows[i].Cells[1].Value.ToString());
                    idev.idproducto = Convert.ToInt32(this.dgvDetalleFactura.Rows[i].Cells[2].Value.ToString());
                    idev.preciounitario = this.dgvDetalleFactura.Rows[i].Cells[4].Value.ToString();
                    idev.comision = this.dgvDetalleFactura.Rows[i].Cells[5].Value.ToString();
                    idev.impuesto = this.dgvDetalleFactura.Rows[i].Cells[6].Value.ToString();

                    DataTable cantidad = new DataTable();
                    nDevoluciones edit = new nDevoluciones();
   
                    
                    result = edit.editDetalleDevo(this.dgvDetalleFactura.Rows[i].Cells[0].Value.ToString(), this.dgvDetalleFactura.Rows[i].Cells[2].Value.ToString(), txtiddev.Text);
                    


                }
            }
                if (result != false)
                {
                    MessageBox.Show("Edicion Exitosa", "Edicion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCliente.ResetText();
                    txtnCliente.ResetText();
                    txtVendedor.ResetText();
                    txtnVendedor.ResetText();
                    txtMoneda.ResetText();
                    txtnMoneda.ResetText();
                    txtFactura.ResetText();
                    txtTipoFactura.ResetText();
                    txtntipo.ResetText();
                    txtDescripcion.ResetText();
                    txtTotalPartida.ResetText();
                    dtpfechadev.Refresh();
                    txttipodevolucion.ResetText();
                    txttipodevolucion.Enabled = true;
                    dgvDetalleFactura.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Edicion Fallida", "Edicion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCliente.ResetText();
                    txtnCliente.ResetText();
                    txtVendedor.ResetText();
                    txtnVendedor.ResetText();
                    txtMoneda.ResetText();
                    txtnMoneda.ResetText();
                    txtFactura.ResetText();
                    txtTipoFactura.ResetText();
                    txtntipo.ResetText();
                    txtDescripcion.ResetText();
                    txtTotalPartida.ResetText();
                    dtpfechadev.Refresh();
                    txttipodevolucion.ResetText();
                    txttipodevolucion.Enabled = true;
                    dgvDetalleFactura.DataSource = null;
                }

                //eDevoluciones dev = new eDevoluciones();
                //string iddev = txtiddev.Text;
                //dev.fechaDevolucion = dtpfechadev.Value;
                //dev.motivodev = txtmotivodev.Text;
                //dev.tipodev = Convert.ToInt16(cbtipodev.SelectedValue);
                //dev.empresa = Convert.ToInt16(cbempresa.SelectedValue);
                //dev.sede = Convert.ToInt16(cbsede.SelectedValue);
                //dev.proveedor = Convert.ToInt16(cbproveedor.SelectedValue);
                //dev.producto = Convert.ToInt16(cbproducto.SelectedValue);
                //dev.factura = Convert.ToInt16(cbfactura.SelectedValue);

                //nDevoluciones updatedev = new nDevoluciones();
                //bool result = updatedev.updateDevolucion(dev, iddev);


                //if (result != false)
                //{
                //    MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //    nDevoluciones allDev = new nDevoluciones();
                //    frmDevoluciones frmdev = new frmDevoluciones();
                //    frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();

                //    txtmotivodev.Clear();
                //}
                //else
                //{
                //    MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultM = MessageBox.Show("Desea Eliminar la Devolucion?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resultM != DialogResult.No)
            {
                string iddev = txtiddev.Text;
                nDevoluciones updatedev = new nDevoluciones();
                bool result = updatedev.deletedevolucion(iddev);


                if (result != false)
                {
                    MessageBox.Show("Eliminacion Exitosa", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCliente.ResetText();
                    txtnCliente.ResetText();
                    txtVendedor.ResetText();
                    txtnVendedor.ResetText();
                    txtMoneda.ResetText();
                    txtnMoneda.ResetText();
                    txtFactura.ResetText();
                    txtTipoFactura.ResetText();
                    txtntipo.ResetText();
                    txtDescripcion.ResetText();
                    txtTotalPartida.ResetText();
                    dtpfechadev.Refresh();
                    txttipodevolucion.ResetText();
                    txttipodevolucion.Enabled = true;
                    dgvDetalleFactura.DataSource = null;

                }
                else
                {
                    MessageBox.Show("Eliminacion Fallida", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }


        }

        private void txttipodevolucion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txttipodevolucion.SelectedItem.ToString() == "Factura")
            {
                SelectingClient clientes = new SelectingClient();
                clientes.MdiParent = this.ParentForm;
                clientes.Show();
                this.Hide();
             
            }
        }




        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if(txtCliente.Text != "")
            {
                nDevoluciones cliente = new nDevoluciones();
                DataTable nombre = new DataTable();
                nombre = cliente.Cliente(txtCliente.Text);

                txtnCliente.Text = nombre.Rows[0]["Nombre Cliente"].ToString();
            }


           
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpfechadev_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFactura_TextChanged(object sender, EventArgs e)
        {
            if (txtFactura.Text != "")
            {
                nDevoluciones devFacturas = new nDevoluciones();
                dgvDetalleFactura.DataSource = devFacturas.detalleFactura(txtFactura.Text);
            }
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            if (txtVendedor.Text != "")
            {
                nDevoluciones cliente = new nDevoluciones();
                DataTable nombre = new DataTable();
                nombre = cliente.nombreVendedor(txtVendedor.Text);

                txtnVendedor.Text = nombre.Rows[0]["Nombre Vendedor"].ToString();
            }
        }

        private void txtMoneda_TextChanged(object sender, EventArgs e)
        {
            if (txtMoneda.Text != "")
            {
                nDevoluciones moneda = new nDevoluciones();
                DataTable nombre = new DataTable();
                nombre = moneda.nombreMoneda(txtMoneda.Text);

                txtnMoneda.Text = nombre.Rows[0]["Moneda"].ToString();
            }
            
        }

        private void txtTipoFactura_TextChanged(object sender, EventArgs e)
        {
            if (txtTipoFactura.Text != "")
            {
                nDevoluciones moneda = new nDevoluciones();
                DataTable nombre = new DataTable();
                nombre = moneda.nombretipopago(txtTipoFactura.Text);

                txtntipo.Text = nombre.Rows[0]["nombre"].ToString();
            }
        }

        private void txtiddev_TextChanged(object sender, EventArgs e)
        {
            if (txtiddev.Text != "")
            {
                nDevoluciones devFacturas = new nDevoluciones();
                dgvDetalleFactura.DataSource = devFacturas.detalleDevolucion(txtiddev.Text);
            }
        }

        private void cbempresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbtipodev_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbproveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbsede_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
