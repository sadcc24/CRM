﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentador
{
    public partial class frmPrincipalConceptosCxC : Form
    {
        public frmPrincipalConceptosCxC()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmConceptos conceptos = new frmConceptos();
            conceptos.Show();
        }
    }
}
