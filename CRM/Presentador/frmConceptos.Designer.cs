namespace Presentador
{
    partial class frmConceptos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcuotas = new System.Windows.Forms.TextBox();
            this.txtnombrecxc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttipopago = new System.Windows.Forms.TextBox();
            this.txtidconcepto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.cmbMovimientos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.Control;
            this.btnReporte.BackgroundImage = global::Presentador.Properties.Resources.reporte_0;
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporte.Location = new System.Drawing.Point(349, 12);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(51, 49);
            this.btnReporte.TabIndex = 62;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImage = global::Presentador.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(292, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 49);
            this.btnEliminar.TabIndex = 61;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(235, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 49);
            this.btnActualizar.TabIndex = 60;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = global::Presentador.Properties.Resources.cancelar_1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(178, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 49);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.BackgroundImage = global::Presentador.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(121, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 49);
            this.btnEditar.TabIndex = 57;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(15, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 56;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::Presentador.Properties.Resources.buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Image = global::Presentador.Properties.Resources.guardar;
            this.btnBuscar.Location = new System.Drawing.Point(68, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 49);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Descripcion:";
            // 
            // txtcuotas
            // 
            this.txtcuotas.Enabled = false;
            this.txtcuotas.Location = new System.Drawing.Point(166, 141);
            this.txtcuotas.Name = "txtcuotas";
            this.txtcuotas.Size = new System.Drawing.Size(175, 20);
            this.txtcuotas.TabIndex = 70;
            // 
            // txtnombrecxc
            // 
            this.txtnombrecxc.Enabled = false;
            this.txtnombrecxc.Location = new System.Drawing.Point(166, 99);
            this.txtnombrecxc.Name = "txtnombrecxc";
            this.txtnombrecxc.Size = new System.Drawing.Size(175, 20);
            this.txtnombrecxc.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txttipopago
            // 
            this.txttipopago.Location = new System.Drawing.Point(390, 100);
            this.txttipopago.Name = "txttipopago";
            this.txttipopago.Size = new System.Drawing.Size(10, 20);
            this.txttipopago.TabIndex = 71;
            this.txttipopago.Text = "1";
            this.txttipopago.Visible = false;
            // 
            // txtidconcepto
            // 
            this.txtidconcepto.Location = new System.Drawing.Point(390, 126);
            this.txtidconcepto.Name = "txtidconcepto";
            this.txtidconcepto.Size = new System.Drawing.Size(10, 20);
            this.txtidconcepto.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Movimiento:";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(381, 209);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(10, 20);
            this.txtestado.TabIndex = 77;
            this.txtestado.Text = "ACTIVO";
            this.txtestado.Visible = false;
            // 
            // cmbMovimientos
            // 
            this.cmbMovimientos.FormattingEnabled = true;
            this.cmbMovimientos.Items.AddRange(new object[] {
            "DEBE",
            "HABER"});
            this.cmbMovimientos.Location = new System.Drawing.Point(166, 179);
            this.cmbMovimientos.Name = "cmbMovimientos";
            this.cmbMovimientos.Size = new System.Drawing.Size(177, 21);
            this.cmbMovimientos.TabIndex = 78;
            this.cmbMovimientos.SelectedIndexChanged += new System.EventHandler(this.cmbMovimientos_SelectedIndexChanged);
            // 
            // frmConceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(428, 285);
            this.Controls.Add(this.cmbMovimientos);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidconcepto);
            this.Controls.Add(this.txttipopago);
            this.Controls.Add(this.txtcuotas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombrecxc);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmConceptos";
            this.Text = "Conceptos";
            this.Load += new System.EventHandler(this.frmConceptos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttipopago;
        public System.Windows.Forms.TextBox txtcuotas;
        public System.Windows.Forms.TextBox txtnombrecxc;
        public System.Windows.Forms.TextBox txtidconcepto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtestado;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbMovimientos;
    }
}