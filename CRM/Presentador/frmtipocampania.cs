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
    public partial class frmtipocampania : Form
    {
        public frmtipocampania()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRegCampania CRegistro = new frmRegCampania();
            CRegistro.MdiParent = this.ParentForm;
            CRegistro.Show();

        }

        private void frmtipocampania_Load(object sender, EventArgs e)
        {
            nCampanias campanias = new nCampanias();
            dgvcampanias.DataSource = campanias.getAllCampanias();
        }

        private void dgvcampanias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmRegCampania regcam = new frmRegCampania();

            string id = this.dgvcampanias.CurrentRow.Cells[0].Value.ToString();
            regcam.txtidcampania.Text = id;
            string tipocampana = this.dgvcampanias.CurrentRow.Cells[1].Value.ToString();
            regcam.cbtipocampania.Text = tipocampana;
            string nombre = this.dgvcampanias.CurrentRow.Cells[2].Value.ToString();
            regcam.txtnombre.Text = nombre;
            string descripcion = this.dgvcampanias.CurrentRow.Cells[3].Value.ToString();
            regcam.txtdescripcion.Text = descripcion;
            string fechainicial = this.dgvcampanias.CurrentRow.Cells[4].Value.ToString();
            regcam.dtpfechainicial.Text = fechainicial;
            string fechafinal = this.dgvcampanias.CurrentRow.Cells[5].Value.ToString();
            regcam.dtpfechafinal.Text = fechafinal;
            string empresa = this.dgvcampanias.CurrentRow.Cells[6].Value.ToString();
            regcam.cbempresa.Text = empresa;




            regcam.txtidcampania.Visible = true;

            //  regdev.dtpfechadev.Enabled = true;
            //  regdev.txtmotivodev.Enabled = true;
            //  regdev.cbtipodev.Enabled = true;
            // regdev.cbempresa.Enabled = true;
            // regdev.cbsede.Enabled = true;
            // regdev.cbproveedor.Enabled = true;
            // regdev.cbproducto.Enabled = true;
            // regdev.cbfactura.Enabled = true;
            //  regdev.btnEditar.Enabled = true;
            //  regdev.btnEliminar.Enabled = true;
            // regdev.btnNuevo.Enabled = false;


            regcam.MdiParent = this.ParentForm;
            regcam.Show();
        }

        private void dgvcampanias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nCampanias campanias = new nCampanias();
            dgvcampanias.DataSource = campanias.getAllCampanias();
        }
    }
}
