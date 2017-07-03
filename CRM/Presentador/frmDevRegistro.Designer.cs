namespace Presentador
{
    partial class frmDevRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevRegistro));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfechadev = new System.Windows.Forms.DateTimePicker();
            this.txtiddev = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttipodevolucion = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.txtnMoneda = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoFactura = new System.Windows.Forms.TextBox();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalPartida = new System.Windows.Forms.TextBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtnVendedor = new System.Windows.Forms.TextBox();
            this.txtnCliente = new System.Windows.Forms.TextBox();
            this.txtntipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoDevolucion = new System.Windows.Forms.ComboBox();
            this.txtFacturadev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Fecha Devolucion:";
            // 
            // dtpfechadev
            // 
            this.dtpfechadev.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechadev.Location = new System.Drawing.Point(546, 76);
            this.dtpfechadev.Name = "dtpfechadev";
            this.dtpfechadev.Size = new System.Drawing.Size(255, 27);
            this.dtpfechadev.TabIndex = 78;
            this.dtpfechadev.ValueChanged += new System.EventHandler(this.dtpfechadev_ValueChanged);
            // 
            // txtiddev
            // 
            this.txtiddev.Location = new System.Drawing.Point(112, 41);
            this.txtiddev.Name = "txtiddev";
            this.txtiddev.Size = new System.Drawing.Size(40, 20);
            this.txtiddev.TabIndex = 89;
            this.txtiddev.Visible = false;
            this.txtiddev.TextChanged += new System.EventHandler(this.txtiddev_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 90;
            this.label9.Text = "Devolucion:";
            // 
            // txttipodevolucion
            // 
            this.txttipodevolucion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipodevolucion.FormattingEnabled = true;
            this.txttipodevolucion.Items.AddRange(new object[] {
            "Factura"});
            this.txttipodevolucion.Location = new System.Drawing.Point(112, 79);
            this.txttipodevolucion.Name = "txttipodevolucion";
            this.txttipodevolucion.Size = new System.Drawing.Size(132, 27);
            this.txttipodevolucion.TabIndex = 91;
            this.txttipodevolucion.SelectedIndexChanged += new System.EventHandler(this.txttipodevolucion_SelectedIndexChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(112, 131);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(60, 27);
            this.txtCliente.TabIndex = 92;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 19);
            this.label10.TabIndex = 93;
            this.label10.Text = "Cliente:";
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(546, 128);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(132, 27);
            this.txtFactura.TabIndex = 94;
            this.txtFactura.Visible = false;
            this.txtFactura.TextChanged += new System.EventHandler(this.txtFactura_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(478, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 19);
            this.label11.TabIndex = 95;
            this.label11.Text = "Factura:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(32, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 96;
            this.label12.Text = "Vendedor:";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVendedor.Location = new System.Drawing.Point(112, 172);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(60, 27);
            this.txtVendedor.TabIndex = 97;
            this.txtVendedor.TextChanged += new System.EventHandler(this.txtVendedor_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(34, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 19);
            this.label13.TabIndex = 98;
            this.label13.Text = "Moneda:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Enabled = false;
            this.txtMoneda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoneda.Location = new System.Drawing.Point(112, 212);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(60, 27);
            this.txtMoneda.TabIndex = 99;
            this.txtMoneda.TextChanged += new System.EventHandler(this.txtMoneda_TextChanged);
            // 
            // txtnMoneda
            // 
            this.txtnMoneda.Enabled = false;
            this.txtnMoneda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnMoneda.Location = new System.Drawing.Point(178, 212);
            this.txtnMoneda.Name = "txtnMoneda";
            this.txtnMoneda.Size = new System.Drawing.Size(222, 27);
            this.txtnMoneda.TabIndex = 100;
            this.txtnMoneda.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 101;
            this.label2.Text = "Tipo Pago:";
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura.Enabled = false;
            this.txtTipoFactura.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoFactura.Location = new System.Drawing.Point(546, 167);
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.Size = new System.Drawing.Size(51, 27);
            this.txtTipoFactura.TabIndex = 102;
            this.txtTipoFactura.TextChanged += new System.EventHandler(this.txtTipoFactura_TextChanged);
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(112, 258);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(689, 215);
            this.dgvDetalleFactura.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 104;
            this.label3.Text = "Total Partida:";
            this.label3.Visible = false;
            // 
            // txtTotalPartida
            // 
            this.txtTotalPartida.Enabled = false;
            this.txtTotalPartida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPartida.Location = new System.Drawing.Point(546, 479);
            this.txtTotalPartida.Name = "txtTotalPartida";
            this.txtTotalPartida.Size = new System.Drawing.Size(140, 27);
            this.txtTotalPartida.TabIndex = 105;
            this.txtTotalPartida.Visible = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(553, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 69;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.BackgroundImage = global::Presentador.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(336, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 49);
            this.btnEditar.TabIndex = 68;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = global::Presentador.Properties.Resources.cancelar_1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(496, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 49);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.BackgroundImage = global::Presentador.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(443, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 49);
            this.btnGuardar.TabIndex = 65;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImage = global::Presentador.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(388, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 49);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtnVendedor
            // 
            this.txtnVendedor.Enabled = false;
            this.txtnVendedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnVendedor.Location = new System.Drawing.Point(178, 172);
            this.txtnVendedor.Name = "txtnVendedor";
            this.txtnVendedor.Size = new System.Drawing.Size(222, 27);
            this.txtnVendedor.TabIndex = 106;
            // 
            // txtnCliente
            // 
            this.txtnCliente.Enabled = false;
            this.txtnCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnCliente.Location = new System.Drawing.Point(178, 131);
            this.txtnCliente.Name = "txtnCliente";
            this.txtnCliente.Size = new System.Drawing.Size(222, 27);
            this.txtnCliente.TabIndex = 107;
            // 
            // txtntipo
            // 
            this.txtntipo.Enabled = false;
            this.txtntipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtntipo.Location = new System.Drawing.Point(603, 167);
            this.txtntipo.Name = "txtntipo";
            this.txtntipo.Size = new System.Drawing.Size(222, 27);
            this.txtntipo.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(450, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 109;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(545, 212);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 27);
            this.txtDescripcion.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 111;
            this.label5.Text = "Tipo Devolucion:";
            // 
            // cbTipoDevolucion
            // 
            this.cbTipoDevolucion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDevolucion.FormattingEnabled = true;
            this.cbTipoDevolucion.Items.AddRange(new object[] {
            "Factura"});
            this.cbTipoDevolucion.Location = new System.Drawing.Point(178, 479);
            this.cbTipoDevolucion.Name = "cbTipoDevolucion";
            this.cbTipoDevolucion.Size = new System.Drawing.Size(222, 27);
            this.cbTipoDevolucion.TabIndex = 112;
            // 
            // txtFacturadev
            // 
            this.txtFacturadev.Enabled = false;
            this.txtFacturadev.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFacturadev.Location = new System.Drawing.Point(545, 128);
            this.txtFacturadev.Name = "txtFacturadev";
            this.txtFacturadev.Size = new System.Drawing.Size(132, 27);
            this.txtFacturadev.TabIndex = 113;
            this.txtFacturadev.Visible = false;
            // 
            // frmDevRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(904, 515);
            this.Controls.Add(this.txtFacturadev);
            this.Controls.Add(this.cbTipoDevolucion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtntipo);
            this.Controls.Add(this.txtnCliente);
            this.Controls.Add(this.txtnVendedor);
            this.Controls.Add(this.txtTotalPartida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.txtTipoFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnMoneda);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txttipodevolucion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtiddev);
            this.Controls.Add(this.dtpfechadev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolucines - Registro";
            this.Load += new System.EventHandler(this.frmDevRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyuda;
        public System.Windows.Forms.DateTimePicker dtpfechadev;
        public System.Windows.Forms.TextBox txtiddev;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox txttipodevolucion;
        public System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtMoneda;
        public System.Windows.Forms.TextBox txtnMoneda;
        public System.Windows.Forms.TextBox txtTipoFactura;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtTotalPartida;
        public System.Windows.Forms.TextBox txtnVendedor;
        public System.Windows.Forms.TextBox txtnCliente;
        public System.Windows.Forms.TextBox txtntipo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbTipoDevolucion;
        public System.Windows.Forms.TextBox txtFacturadev;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnCancelar;
    }
}