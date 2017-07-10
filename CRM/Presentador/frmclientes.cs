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
using Datos;
using Negocio;


namespace Presentador
{
    public partial class frmClientes : Form
    {

     

        public frmClientes()
        {
            InitializeComponent();
        }

        private void Nombre_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            nCClientes getest = new nCClientes();
            nCClientes getemp = new nCClientes();
            nCClientes clientes = new nCClientes();

            cbestado.DataSource = getest.getAllTypEstado();
            cbestado.ValueMember = "idestado";
            cbestado.DisplayMember = "estado";

            cbempresa.DataSource = getemp.getAllCompanies();
            cbempresa.ValueMember = "idempresa";
            cbempresa.DisplayMember = "nombre_empresa";

            cbsexo.DataSource = getemp.getAllTypSexo();
            cbsexo.ValueMember = "idsexo";
            cbsexo.DisplayMember = "descripcion";


            cbtipodocumento.DataSource = getemp.getAllTypoDoc();
            cbtipodocumento.ValueMember = "idtipodocumento";
            cbtipodocumento.DisplayMember = "nombre";

            cbnacionalidad.DataSource = getemp.getAllNac();
            cbnacionalidad.ValueMember = "idnacionalidad";
            cbnacionalidad.DisplayMember = "descripcion";

            cbocupacion.DataSource = getemp.getAllOcu();
            cbocupacion.ValueMember = "idocupacion";
            cbocupacion.DisplayMember = "nombre";



            




        }

        private void btnguardar_Click(object sender, EventArgs e)

        {


       //      public DateTime Fechanac { get; set; }
      //  public int estado { get; set; }
      ///  public string pnombre { get; set; }
       // public string snombre { get; set; }
       // public string papellido { get; set; }
       // public string sapellido { get; set; }
      //  public int telefono { get; set; }
      //  public string direccion { get; set; }
      //  public string email { get; set; }
      //  public int Edad { get; set; }
      //  public int Empresa { get; set; }
      //  public int Nacionalidad { get; set; }
      //  public int Sexo { get; set; }
      //  public int Ocupacion { get; set; }
       // public int TipoDoc { get; set; }





        eCClientes datosclientes = new eCClientes();
            datosclientes.Fechanac = dtpfechanac.Value;
            datosclientes.estado = Convert.ToInt16(cbestado.SelectedValue);
            datosclientes.pnombre = txtprimernombre.Text;
            datosclientes.snombre = txtsegundonombre.Text;
            datosclientes.papellido = txtprimerapellido.Text;
            datosclientes.sapellido = txtsegundoapellido.Text;
            datosclientes.telefono = Convert.ToInt32(txttelefono.Text);
            datosclientes.direccion = txtdireccion.Text;
            datosclientes.email = txtemail.Text;
            datosclientes.Edad = Convert.ToInt16(txtedad.Text);
            datosclientes.Nacionalidad = Convert.ToInt16(cbnacionalidad.SelectedValue);
            datosclientes.Sexo = Convert.ToInt16(cbsexo.SelectedValue);
            datosclientes.Ocupacion = Convert.ToInt16(cbocupacion.SelectedValue);
            datosclientes.TipoDoc = Convert.ToInt16(cbtipodocumento.SelectedValue);
            datosclientes.Empresa = Convert.ToInt16(cbempresa.SelectedValue);



            //   MessageBox.Show(cbestado.SelectedValue + " " + txtnombre.Text + " " + txtapellido.Text + " " + txttelefono.Text + " " + txtdireccion.Text + " " + txtemail.Text + " " + txtsaldo.Text + " " + cbempresa.SelectedValue, "Actualizacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);






            nCClientes insclientes = new nCClientes();

            bool result = insclientes.insertClientes(datosclientes);

            if (result != false)
            {
                MessageBox.Show("Registro Insertado", "Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

              //  nCClientes ccclientes = new nCClientes();
              //  frmCatalogClientes frmCli = new frmCatalogClientes();

             //    frmCli.dgvclientes.DataSource = ccclientes.getAllClientes();
                //txtnombre.Clear();
               // txtdescripcion.Clear();

            }
            else
            {
                MessageBox.Show("Fallo Registro Insertado", "Fallo Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
          
            //LIMPIA LOS CAMPOS

            txtprimernombre.Clear();
          //  txtapellido.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
           // txtsaldo.Clear();
        

            




          
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //nCClientes clientes = new nCClientes();
          //  ConnectionDBLocal cnn = new ConnectionDBLocal();

           //   cnn.Delete("DELETE dbo.CLIENTE WHERE idcliente ='" + cbidcliente.Text + "'");

        ////  /  string idcliente = cbidcliente.Text;
            //  nCClientes eliminarcli = new nCClientes();
            // bool result = Delete(idcliente);


            //  if (result != false)
            // {
           /// MessageBox.Show("Eliminacion Exitosa", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //dgvmostrarclientes.DataSource = clientes.getAllClientes();

            //
            // nCClientes ccclientes = new nCClientes();
            // frmCatalogClientes frmCli = new frmCatalogClientes();
            //frmdev.dgvDevoluciones.DataSource = allDev.getAllDev();

            //txtmotivodev.Clear();
            //}
            //  else
            //  {
            //   MessageBox.Show("Eliminacion Fallida", "Eliminacion Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // }















                 nCClientes delete = new nCClientes();
               bool result = delete.deleteClientes(txtidcliente.Text);

               if (result != false)
               {
            MessageBox.Show("Registro Eliminado", "Eliminacion Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtidcliente.Clear();
        //        txtnombre.Clear();
       //         txtapellido.Clear();
        //        txttelefono.Clear();
              //  txtnit.Clear();
                txtdireccion.Clear();
                txtemail.Clear();
                //txtsaldo.Clear();
       //       //  txtsubtotal.Clear();
            }
            else
            {
               MessageBox.Show("Fallo Eliminacion Reigstro", "Fallo Eliminacion Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txttelefono.Text))
            {
                MessageBox.Show("Rellene los Datos Requeridos: Telefono", "Campos Requeridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                eCClientes datoscliente = new eCClientes();
            //    datoscliente.nombre = txtprimernombre.Text;
              //  datoscliente.apellido = txtapellido.Text;
                datoscliente.telefono = Convert.ToInt32(txttelefono.Text);
               // datoscliente.nit = Convert.ToInt32(txtnit.Text);
                datoscliente.direccion = txtdireccion.Text;
                datoscliente.email = txtemail.Text;
             //   datoscliente.saldo = Convert.ToInt32(txtsaldo.Text);
             //   datoscliente.subtotal = Convert.ToInt32(txtsubtotal.Text);





                nCClientes clientes = new nCClientes();

                bool result = clientes.insertClientes(datoscliente);

                if (result != false)
                {
                    MessageBox.Show("Registro Insertado", "Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo Registro Insertado", "Fallo Insercion cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }




            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //cbidcliente.Visible = false;
            lblidcliente.Visible = false;
            cbempresa.Enabled = true;
            txtprimernombre.Enabled = true;
        //    txtapellido.Enabled = true;
            txttelefono.Enabled = true;
            txtdireccion.Enabled = true;
            txtemail.Enabled = true;
          //  txtsaldo.Enabled = true;
            cbestado.Enabled = true;

            txtprimernombre.Clear();
          //  txtapellido.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
           // txtsaldo.Clear();


        }

       

        private void cbempresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seleccione el cliente que desea editar", "Funcion editar activado", MessageBoxButtons.OK, MessageBoxIcon.Information);

         //   cbidcliente.Visible = true;
            lblidcliente.Visible = true;


          //  dgvmostrarclientes.Visible = true;
            ConnectionDBLocal cnn = new ConnectionDBLocal();

          //  dgvmostrarclientes.DataSource = cnn.Select("select * from CLIENTE");

            cbempresa.Enabled = true;
            txtprimernombre.Enabled = true;
          //  txtapellido.Enabled = true;
            txttelefono.Enabled = true;
            txtdireccion.Enabled = true;
            txtemail.Enabled = true;
          //  txtsaldo.Enabled = true;
            cbestado.Enabled = true;



        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

          //  cbidcliente.Visible = true;
            lblidcliente.Visible = true;

          //  dgvmostrarclientes.Visible = true;
            ConnectionDBLocal cnn = new ConnectionDBLocal();

          //  dgvmostrarclientes.DataSource = cnn.Select("select * from CLIENTE");

        }

        private void dgvmostrarclientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // DataGridViewRow dgv = dgvmostrarclientes.Rows[e.RowIndex];
           // cbidcliente.Text = dgv.Cells[0].Value.ToString();
           // cbestado.Text = dgv.Cells[1].Value.ToString();
           // txtprimernombre.Text = dgv.Cells[2].Value.ToString();
         //  / txtapellido.Text = dgv.Cells[3].Value.ToString();
           // txttelefono.Text = dgv.Cells[4].Value.ToString();
          //  txtdireccion.Text = dgv.Cells[5].Value.ToString();
           // txtemail.Text = dgv.Cells[6].Value.ToString();
         //   txtsaldo.Text = dgv.Cells[7].Value.ToString();
          //  cbempresa.Text = dgv.Cells[8].Value.ToString();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          //  cbidcliente.Visible = false;
            lblidcliente.Visible = false;
            cbempresa.Enabled = true;
            txtprimernombre.Enabled = true;
          //  txtapellido.Enabled = true;
            txttelefono.Enabled = true;
            txtdireccion.Enabled = true;
            txtemail.Enabled = true;
         //   txtsaldo.Enabled = true;
            cbestado.Enabled = true;


            txtprimernombre.Clear();
          //  txtapellido.Clear();
            txttelefono.Clear();
            txtdireccion.Clear();
            txtemail.Clear();
         //   txtsaldo.Clear();

        }

        private void txtsegundonombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}








