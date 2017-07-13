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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.tbIdFac = new System.Windows.Forms.TextBox();
            this.cbLastIndex = new System.Windows.Forms.ComboBox();
            this.dgvFac = new System.Windows.Forms.DataGridView();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCXC = new System.Windows.Forms.DataGridView();
            this.tbCxC = new System.Windows.Forms.TextBox();
            this.cbCantidadCuotas = new System.Windows.Forms.ComboBox();
            this.lbCantidadCuotas = new System.Windows.Forms.Label();
            this.tbCantidadPago = new System.Windows.Forms.TextBox();
            this.lbCantidadPago = new System.Windows.Forms.Label();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCXC)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 91;
            this.label4.Text = "Tipo Pago:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 86;
            this.label2.Text = "Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Estado Factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 95;
            this.label6.Text = "Moneda:";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(150, 270);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(276, 27);
            this.tbTotal.TabIndex = 100;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(94, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 99;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 97;
            this.label7.Text = "Fecha:";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(28, 26);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(472, 473);
            this.dgvDetalleFactura.TabIndex = 104;
            // 
            // cbVendedor
            // 
            this.cbVendedor.Enabled = false;
            this.cbVendedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Location = new System.Drawing.Point(147, 60);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(121, 27);
            this.cbVendedor.TabIndex = 106;
            // 
            // cbTipoPago
            // 
            //this.cbTipoPago.Enabled = false;
            //this.cbTipoPago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.cbTipoPago.FormattingEnabled = true;
            //this.cbTipoPago.Location = new System.Drawing.Point(147, 100);
            //this.cbTipoPago.Name = "cbTipoPago";
            //this.cbTipoPago.Size = new System.Drawing.Size(121, 27);
            //this.cbTipoPago.TabIndex = 107;
            //this.cbTipoPago.SelectedIndexChanged += new System.EventHandler(this.cbTipoPago_SelectedIndexChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.Enabled = false;
            this.cbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(147, 145);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 27);
            this.cbEstado.TabIndex = 108;
            // 
            // cbMoneda
            // 
            this.cbMoneda.Enabled = false;
            this.cbMoneda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(147, 189);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(121, 27);
            this.cbMoneda.TabIndex = 109;
            // 
            // tbIdFac
            // 
            this.tbIdFac.Location = new System.Drawing.Point(12, 27);
            this.tbIdFac.Name = "tbIdFac";
            this.tbIdFac.Size = new System.Drawing.Size(33, 20);
            this.tbIdFac.TabIndex = 110;
            this.tbIdFac.Visible = false;
            // 
            // cbLastIndex
            // 
            this.cbLastIndex.FormattingEnabled = true;
            this.cbLastIndex.Location = new System.Drawing.Point(1167, 103);
            this.cbLastIndex.Name = "cbLastIndex";
            this.cbLastIndex.Size = new System.Drawing.Size(121, 21);
            this.cbLastIndex.TabIndex = 111;
            this.cbLastIndex.Visible = false;
            // 
            // dgvFac
            // 
            this.dgvFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFac.Location = new System.Drawing.Point(1167, 12);
            this.dgvFac.Name = "dgvFac";
            this.dgvFac.Size = new System.Drawing.Size(166, 85);
            this.dgvFac.TabIndex = 113;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(30, 26);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(472, 151);
            this.dgvCliente.TabIndex = 114;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.Enabled = false;
            this.cbTipoDoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "Factura",
            "Cotizacion"});
            this.cbTipoDoc.Location = new System.Drawing.Point(148, 15);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(121, 27);
            this.cbTipoDoc.TabIndex = 115;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 116;
            this.label3.Text = "Tipo Documento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(147, 236);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(277, 27);
            this.dtpFecha.TabIndex = 117;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCantidadPago);
            this.groupBox1.Controls.Add(this.tbCantidadPago);
            this.groupBox1.Controls.Add(this.lbCantidadCuotas);
            this.groupBox1.Controls.Add(this.cbCantidadCuotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbTipoDoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbTotal);
            this.groupBox1.Controls.Add(this.cbVendedor);
            this.groupBox1.Controls.Add(this.cbMoneda);
            this.groupBox1.Controls.Add(this.cbTipoPago);
            this.groupBox1.Controls.Add(this.cbEstado);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(48, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 319);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCliente);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(48, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 201);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion de Cliente:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDetalleFactura);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(578, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(532, 526);
            this.groupBox3.TabIndex = 122;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Producto:";
            // 
            // dgvCXC
            // 
            this.dgvCXC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCXC.Enabled = false;
            this.dgvCXC.Location = new System.Drawing.Point(1167, 144);
            this.dgvCXC.Name = "dgvCXC";
            this.dgvCXC.Size = new System.Drawing.Size(262, 63);
            this.dgvCXC.TabIndex = 123;
            // 
            // tbCxC
            // 
            this.tbCxC.Location = new System.Drawing.Point(1167, 213);
            this.tbCxC.Name = "tbCxC";
            this.tbCxC.Size = new System.Drawing.Size(100, 20);
            this.tbCxC.TabIndex = 124;
            // 
            // cbCantidadCuotas
            // 
            this.cbCantidadCuotas.FormattingEnabled = true;
            this.cbCantidadCuotas.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cbCantidadCuotas.Location = new System.Drawing.Point(381, 45);
            this.cbCantidadCuotas.Name = "cbCantidadCuotas";
            this.cbCantidadCuotas.Size = new System.Drawing.Size(121, 27);
            this.cbCantidadCuotas.TabIndex = 118;
            // 
            // lbCantidadCuotas
            // 
            this.lbCantidadCuotas.AutoSize = true;
            this.lbCantidadCuotas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadCuotas.Location = new System.Drawing.Point(377, 23);
            this.lbCantidadCuotas.Name = "lbCantidadCuotas";
            this.lbCantidadCuotas.Size = new System.Drawing.Size(120, 19);
            this.lbCantidadCuotas.TabIndex = 119;
            this.lbCantidadCuotas.Text = "Cantidad Cuotas:";
            // 
            // tbCantidadPago
            // 
            this.tbCantidadPago.Enabled = false;
            this.tbCantidadPago.Location = new System.Drawing.Point(381, 100);
            this.tbCantidadPago.Name = "tbCantidadPago";
            this.tbCantidadPago.Size = new System.Drawing.Size(121, 27);
            this.tbCantidadPago.TabIndex = 120;
            // 
            // lbCantidadPago
            // 
            this.lbCantidadPago.AutoSize = true;
            this.lbCantidadPago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidadPago.Location = new System.Drawing.Point(377, 75);
            this.lbCantidadPago.Name = "lbCantidadPago";
            this.lbCantidadPago.Size = new System.Drawing.Size(107, 19);
            this.lbCantidadPago.TabIndex = 121;
            this.lbCantidadPago.Text = "Cantidad Pago:";
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProductos.BackgroundImage = global::Presentador.Properties.Resources.compras_2;
            this.btnAgregarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProductos.Location = new System.Drawing.Point(604, 12);
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
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            // frmFacturaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1184, 620);
            this.Controls.Add(this.tbCxC);
            this.Controls.Add(this.dgvCXC);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvFac);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbLastIndex);
            this.Controls.Add(this.tbIdFac);
            this.Controls.Add(this.btnAgregarProductos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCXC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
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
        public System.Windows.Forms.ComboBox cbVendedor;
        public System.Windows.Forms.ComboBox cbTipoPago;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.ComboBox cbMoneda;
        public System.Windows.Forms.TextBox tbIdFac;
        public System.Windows.Forms.ComboBox cbLastIndex;
        public System.Windows.Forms.DataGridView dgvFac;
        public System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.ComboBox cbTipoDoc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCXC;
        public System.Windows.Forms.TextBox tbCxC;
        private System.Windows.Forms.Label lbCantidadCuotas;
        private System.Windows.Forms.Label lbCantidadPago;
        public System.Windows.Forms.ComboBox cbCantidadCuotas;
        public System.Windows.Forms.TextBox tbCantidadPago;
    }
}