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
    public partial class frmRegCampania : Form
    {
        public frmRegCampania()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConnectionDBLocal conlocal = new ConnectionDBLocal();
            conlocal.Insert("INSERT INTO dbo.CAMPANIA(idtipocampania,nomcampania,costcampania) VALUES ('1','VentaProducto','1500')");
        }
    }
}
