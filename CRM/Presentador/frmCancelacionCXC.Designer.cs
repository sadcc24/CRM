namespace Presentador
{
    partial class frmCancelacionCXC
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
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtpfechadev = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvHistorico = new System.Windows.Forms.DataGridView();
            this.cbTipocxc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtidhistorico = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcliente
            // 
            this.txtcliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(181, 96);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(91, 27);
            this.txtcliente.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 121;
            this.label2.Text = "Cliente:";
            // 
            // txtdocumento
            // 
            this.txtdocumento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(181, 129);
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(40, 27);
            this.txtdocumento.TabIndex = 120;
            this.txtdocumento.TextChanged += new System.EventHandler(this.txtdocumento_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 119;
            this.label1.Text = "No. Documento:";
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundImage = global::Presentador.Properties.Resources.clientes_3;
            this.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCliente.Location = new System.Drawing.Point(278, 96);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(28, 27);
            this.btnCliente.TabIndex = 125;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImage = global::Presentador.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(369, 36);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 49);
            this.btnEliminar.TabIndex = 118;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(312, 36);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 49);
            this.btnActualizar.TabIndex = 117;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.BackgroundImage = global::Presentador.Properties.Resources.buscar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Image = global::Presentador.Properties.Resources.guardar;
            this.btnGuardar.Location = new System.Drawing.Point(202, 36);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 49);
            this.btnGuardar.TabIndex = 116;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = global::Presentador.Properties.Resources.cancelar_1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(255, 36);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 49);
            this.btnCancelar.TabIndex = 115;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(149, 36);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 113;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dtpfechadev
            // 
            this.dtpfechadev.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechadev.Location = new System.Drawing.Point(181, 168);
            this.dtpfechadev.Name = "dtpfechadev";
            this.dtpfechadev.Size = new System.Drawing.Size(255, 27);
            this.dtpfechadev.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 127;
            this.label3.Text = "Fecha Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 128;
            this.label4.Text = "Pago:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(181, 209);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(91, 27);
            this.txtCantidad.TabIndex = 129;
            // 
            // dgvHistorico
            // 
            this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorico.Location = new System.Drawing.Point(66, 288);
            this.dgvHistorico.Name = "dgvHistorico";
            this.dgvHistorico.Size = new System.Drawing.Size(411, 184);
            this.dgvHistorico.TabIndex = 132;
            this.dgvHistorico.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorico_CellDoubleClick);
            // 
            // cbTipocxc
            // 
            this.cbTipocxc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipocxc.FormattingEnabled = true;
            this.cbTipocxc.Items.AddRange(new object[] {
            "Factura"});
            this.cbTipocxc.Location = new System.Drawing.Point(181, 255);
            this.cbTipocxc.Name = "cbTipocxc";
            this.cbTipocxc.Size = new System.Drawing.Size(150, 27);
            this.cbTipocxc.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 134;
            this.label5.Text = "Cuenta:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(312, 209);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(91, 27);
            this.txtSaldo.TabIndex = 135;
            this.txtSaldo.Visible = false;
            // 
            // txtidhistorico
            // 
            this.txtidhistorico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidhistorico.Location = new System.Drawing.Point(30, 58);
            this.txtidhistorico.Name = "txtidhistorico";
            this.txtidhistorico.Size = new System.Drawing.Size(40, 27);
            this.txtidhistorico.TabIndex = 136;
            this.txtidhistorico.Visible = false;
            // 
            // frmCancelacionCXC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(534, 527);
            this.Controls.Add(this.txtidhistorico);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipocxc);
            this.Controls.Add(this.dgvHistorico);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpfechadev);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmCancelacionCXC";
            this.Text = "FRMCANCELACION";
            this.Load += new System.EventHandler(this.frmCancelacionCXC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCliente;
        public System.Windows.Forms.TextBox txtcliente;
        public System.Windows.Forms.TextBox txtdocumento;
        public System.Windows.Forms.DateTimePicker dtpfechadev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvHistorico;
        public System.Windows.Forms.ComboBox cbTipocxc;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtSaldo;
        public System.Windows.Forms.TextBox txtidhistorico;
    }
}