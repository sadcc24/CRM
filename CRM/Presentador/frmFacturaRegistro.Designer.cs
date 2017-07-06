namespace Presentador
{
    partial class frmFacturaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaRegistro));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.tbIdFac = new System.Windows.Forms.TextBox();
            this.cbLastIndex = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvFac = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Vendedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Estado Factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 95;
            this.label6.Text = "Moneda:";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(151, 386);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(276, 27);
            this.tbTotal.TabIndex = 100;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 99;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "Fecha:";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(562, 96);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(410, 312);
            this.dgvDetalleFactura.TabIndex = 104;
            // 
            // cbCliente
            // 
            this.cbCliente.Enabled = false;
            this.cbCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(151, 96);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 27);
            this.cbCliente.TabIndex = 105;
            // 
            // cbVendedor
            // 
            this.cbVendedor.Enabled = false;
            this.cbVendedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(147, 140);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(121, 27);
            this.cbVendedor.TabIndex = 106;
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.Enabled = false;
            this.cbTipoPago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(147, 183);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(121, 27);
            this.cbTipoPago.TabIndex = 107;
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(152, 227);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 27);
            this.cbEstado.TabIndex = 108;
            // 
            // cbMoneda
            // 
            this.cbMoneda.Enabled = false;
            this.cbMoneda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(152, 263);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(121, 27);
            this.cbMoneda.TabIndex = 109;
            // 
            // tbIdFac
            // 
            this.tbIdFac.Location = new System.Drawing.Point(29, 70);
            this.tbIdFac.Name = "tbIdFac";
            this.tbIdFac.Size = new System.Drawing.Size(33, 20);
            this.tbIdFac.TabIndex = 110;
            this.tbIdFac.Visible = false;
            // 
            // cbLastIndex
            // 
            this.cbLastIndex.FormattingEnabled = true;
            this.cbLastIndex.Location = new System.Drawing.Point(332, 90);
            this.cbLastIndex.Name = "cbLastIndex";
            this.cbLastIndex.Size = new System.Drawing.Size(121, 21);
            this.cbLastIndex.TabIndex = 111;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(152, 351);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(275, 27);
            this.dtpFecha.TabIndex = 112;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProductos.BackgroundImage = global::Presentador.Properties.Resources.compras_2;
            this.btnAgregarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProductos.Location = new System.Drawing.Point(562, 12);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(51, 49);
            this.btnAgregarProductos.TabIndex = 103;
            this.btnAgregarProductos.UseVisualStyleBackColor = false;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(390, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 84;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.BackgroundImage = global::Presentador.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(126, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 49);
            this.btnEditar.TabIndex = 83;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(336, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 49);
            this.btnActualizar.TabIndex = 82;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = global::Presentador.Properties.Resources.cancelar_1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(286, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 49);
            this.btnCancelar.TabIndex = 81;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.BackgroundImage = global::Presentador.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(233, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 49);
            this.btnGuardar.TabIndex = 80;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImage = global::Presentador.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(178, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 49);
            this.btnEliminar.TabIndex = 79;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(74, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 78;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvFac
            // 
            this.dgvFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFac.Location = new System.Drawing.Point(361, 205);
            this.dgvFac.Name = "dgvFac";
            this.dgvFac.Size = new System.Drawing.Size(166, 85);
            this.dgvFac.TabIndex = 113;
            // 
            // frmFacturaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1016, 437);
            this.Controls.Add(this.dgvFac);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cbLastIndex);
            this.Controls.Add(this.tbIdFac);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.cbVendedor);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.dgvDetalleFactura);
            this.Controls.Add(this.btnAgregarProductos);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFacturaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura - Registro";
            this.Load += new System.EventHandler(this.frmFacturaRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        public System.Windows.Forms.TextBox tbTotal;
        public System.Windows.Forms.ComboBox cbCliente;
        public System.Windows.Forms.ComboBox cbVendedor;
        public System.Windows.Forms.ComboBox cbTipoPago;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.ComboBox cbMoneda;
        public System.Windows.Forms.TextBox tbIdFac;
        public System.Windows.Forms.ComboBox cbLastIndex;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        public System.Windows.Forms.DataGridView dgvFac;
    }
}