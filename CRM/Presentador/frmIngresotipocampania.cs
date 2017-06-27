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


namespace Presentador
{
    public partial class frmIngresotipocampania : Form
    {
        public frmIngresotipocampania()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            ConnectionDBLocal conlocal = new ConnectionDBLocal();
            conlocal.Insert("INSERT INTO dbo.TIPO_CAMPANIA(nomtipocampania) VALUES ('"+ txtnomtipocampania.Text+"')");
            dtvtipocampanias.DataSource = conlocal.Select("select * from TIPO_CAMPANIA");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            ConnectionDBLocal conlocal = new ConnectionDBLocal();
            dtvtipocampanias.DataSource = conlocal.Select("select * from TIPO_CAMPANIA");
            conlocal.Delete("DELETE dbo.TIPO_CAMPANIA WHERE idtipocampania ='"+ txtnomtipocampania.Text + "'");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
        }
    }
}
