namespace Presentador
{
    partial class frmDetalleFactura
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
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBodega = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComision = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(373, 24);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 91;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.BackgroundImage = global::Presentador.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(109, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 49);
            this.btnEditar.TabIndex = 90;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(319, 24);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 49);
            this.btnActualizar.TabIndex = 89;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = global::Presentador.Properties.Resources.cancelar_1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(269, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 49);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.BackgroundImage = global::Presentador.Properties.Resources.guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(216, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(51, 49);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImage = global::Presentador.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(161, 24);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 49);
            this.btnEliminar.TabIndex = 86;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(57, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 85;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 92;
            this.label1.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            this.tbCantidad.Enabled = false;
            this.tbCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(430, 182);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(121, 27);
            this.tbCantidad.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "Bodega:";
            // 
            // cbBodega
            // 
            this.cbBodega.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBodega.FormattingEnabled = true;
            this.cbBodega.Location = new System.Drawing.Point(135, 182);
            this.cbBodega.Name = "cbBodega";
            this.cbBodega.Size = new System.Drawing.Size(121, 27);
            this.cbBodega.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(353, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 96;
            this.label3.Text = "Precio:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Enabled = false;
            this.tbPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(425, 232);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(126, 27);
            this.tbPrecio.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 98;
            this.label4.Text = "Comision:";
            // 
            // tbComision
            // 
            this.tbComision.Enabled = false;
            this.tbComision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbComision.Location = new System.Drawing.Point(135, 235);
            this.tbComision.Name = "tbComision";
            this.tbComision.Size = new System.Drawing.Size(121, 27);
            this.tbComision.TabIndex = 99;
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(57, 89);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(367, 70);
            this.dgvProductos.TabIndex = 100;
            // 
            // frmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 299);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.tbComision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBodega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmDetalleFactura";
            this.Text = "frmDetalleFactura";
            this.Load += new System.EventHandler(this.frmDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbBodega;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbComision;
        private System.Windows.Forms.DataGridView dgvProductos;
    }
}