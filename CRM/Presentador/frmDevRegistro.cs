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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dtpfechadev.Enabled = true;
            txtmotivodev.Enabled = true;
            cbtipodev.Enabled = true;
            cbempresa.Enabled = true;
            cbsede.Enabled = true;
            cbproveedor.Enabled = true;
            cbproducto.Enabled = true;
            cbfactura.Enabled = true;
            txtmotivodev.Clear();
            txtiddev.Clear();
            btnGuardar.Enabled = true;
        }

        private void frmDevRegistro_Load(object sender, EventArgs e)
        {
            nDevoluciones getprov = new nDevoluciones();

            cbproveedor.DataSource = getprov.getAllProveedor();
            cbproveedor.ValueMember = "idproveedor";
            cbproveedor.DisplayMember = "nombre_proveedor";


            cbtipodev.DataSource = getprov.getAllTypeDev();
            cbtipodev.ValueMember = "idtipodevolucion";
            cbtipodev.DisplayMember = "tipodevolucion";


            cbfactura.DataSource = getprov.getAllFacturas();
            cbfactura.ValueMember = "idencabezadofact";
            cbfactura.DisplayMember = "idfactura";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtmotivodev.Text))
            {
                MessageBox.Show("Rellene los Datos Requeridos: Motivo Devolucion", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eDevoluciones dev = new eDevoluciones();
                dev.fechaDevolucion = dtpfechadev.Value;
                dev.motivodev = txtmotivodev.Text;
                dev.tipodev = Convert.ToInt16(cbtipodev.SelectedValue);
                dev.empresa = Convert.ToInt16(cbempresa.SelectedValue);
                dev.sede = Convert.ToInt16(cbsede.SelectedValue);
                dev.proveedor = Convert.ToInt16(cbproveedor.SelectedValue);
                dev.producto = Convert.ToInt16(cbproducto.SelectedValue);
                dev.factura = Convert.ToInt16(cbfactura.SelectedValue);

                nDevoluciones insertDev = new nDevoluciones();
                bool result = insertDev.insertDevolucion(dev);

                if(result != false)
                {
                    MessageBox.Show("Ingreso Exitoso", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
             
                    nDevoluciones allDev = new nDevoluciones();
                    frmDevoluciones frmdev = new frmDevoluciones();
                    frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();
                    txtmotivodev.Clear();
                }
                else
                {
                    MessageBox.Show("Ingreso Fallido", "Ingreso Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dtpfechadev.Enabled = false;
            txtmotivodev.Enabled = false;
            txtmotivodev.Clear();
            txtiddev.Clear();
            cbtipodev.Enabled = false;
            cbempresa.Enabled = false;
            cbsede.Enabled = false;
            cbproveedor.Enabled = false;
            cbproducto.Enabled = false;
            cbfactura.Enabled = false;

        }

        private void cbfactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            nDevoluciones getprov = new nDevoluciones();
            DataTable filter = new DataTable();

            dynamic select = cbfactura.SelectedItem;
            string value = select[1];

            filter = getprov.getFilterFactura(value);

            cbempresa.DataSource = filter;
            cbempresa.ValueMember = "idempresa";
            cbempresa.DisplayMember = "nombre_empresa";

            cbsede.DataSource = filter;
            cbsede.ValueMember = "id_sede";
            cbsede.DisplayMember = "nombre_sede";

            cbproducto.DataSource = filter;
            cbproducto.ValueMember = "idproducto";
            cbproducto.DisplayMember = "descripcion";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            eDevoluciones dev = new eDevoluciones();
            string iddev = txtiddev.Text;
            dev.fechaDevolucion = dtpfechadev.Value;
            dev.motivodev = txtmotivodev.Text;
            dev.tipodev = Convert.ToInt16(cbtipodev.SelectedValue);
            dev.empresa = Convert.ToInt16(cbempresa.SelectedValue);
            dev.sede = Convert.ToInt16(cbsede.SelectedValue);
            dev.proveedor = Convert.ToInt16(cbproveedor.SelectedValue);
            dev.producto = Convert.ToInt16(cbproducto.SelectedValue);
            dev.factura = Convert.ToInt16(cbfactura.SelectedValue);

            nDevoluciones updatedev = new nDevoluciones();
            bool result = updatedev.updateDevolucion(dev, iddev);


            if (result != false)
            {
                MessageBox.Show("Actualizacion Exitosa", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nDevoluciones allDev = new nDevoluciones();
                frmDevoluciones frmdev = new frmDevoluciones();
                frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();

                txtmotivodev.Clear();
            }
            else
            {
                MessageBox.Show("Actualizacion Fallida", "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string iddev = txtiddev.Text;
            nDevoluciones updatedev = new nDevoluciones();
            bool result = updatedev.deletedevolucion(iddev);


            if (result != false)
            {
                MessageBox.Show("Eliminacion Exitosa", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nDevoluciones allDev = new nDevoluciones();
                frmDevoluciones frmdev = new frmDevoluciones();
                frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();

                txtmotivodev.Clear();
            }
            else
            {
                MessageBox.Show("Eliminacion Fallida", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
