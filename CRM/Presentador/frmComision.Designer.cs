namespace Presentador
{
    partial class frmComision
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
            this.label5 = new System.Windows.Forms.Label();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.cbmarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcomision = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbvendedor = new System.Windows.Forms.ComboBox();
            this.txtidcomision = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.rdMarca = new System.Windows.Forms.RadioButton();
            this.rbProducto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 130;
            this.label5.Text = "Producto:";
            // 
            // cbproducto
            // 
            this.cbproducto.Enabled = false;
            this.cbproducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.Items.AddRange(new object[] {
            "Factura"});
            this.cbproducto.Location = new System.Drawing.Point(449, 303);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(174, 27);
            this.cbproducto.TabIndex = 129;
            this.cbproducto.SelectedIndexChanged += new System.EventHandler(this.cbproducto_SelectedIndexChanged);
            // 
            // cbmarca
            // 
            this.cbmarca.Enabled = false;
            this.cbmarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmarca.FormattingEnabled = true;
            this.cbmarca.Items.AddRange(new object[] {
            "Factura"});
            this.cbmarca.Location = new System.Drawing.Point(102, 300);
            this.cbmarca.Name = "cbmarca";
            this.cbmarca.Size = new System.Drawing.Size(174, 27);
            this.cbmarca.TabIndex = 128;
            this.cbmarca.SelectedIndexChanged += new System.EventHandler(this.cbmarca_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 127;
            this.label4.Text = "Marca:";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "Factura"});
            this.cbEmpresa.Location = new System.Drawing.Point(253, 209);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(174, 27);
            this.cbEmpresa.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 125;
            this.label3.Text = "Empresa:";
            // 
            // txtcomision
            // 
            this.txtcomision.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomision.Location = new System.Drawing.Point(253, 149);
            this.txtcomision.Name = "txtcomision";
            this.txtcomision.Size = new System.Drawing.Size(174, 27);
            this.txtcomision.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 123;
            this.label2.Text = "Comision %:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 122;
            this.label1.Text = "Vendedor:";
            // 
            // cbvendedor
            // 
            this.cbvendedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvendedor.FormattingEnabled = true;
            this.cbvendedor.Items.AddRange(new object[] {
            "Factura"});
            this.cbvendedor.Location = new System.Drawing.Point(253, 96);
            this.cbvendedor.Name = "cbvendedor";
            this.cbvendedor.Size = new System.Drawing.Size(174, 27);
            this.cbvendedor.TabIndex = 121;
            // 
            // txtidcomision
            // 
            this.txtidcomision.Location = new System.Drawing.Point(12, 96);
            this.txtidcomision.Name = "txtidcomision";
            this.txtidcomision.Size = new System.Drawing.Size(100, 20);
            this.txtidcomision.TabIndex = 131;
            this.txtidcomision.Visible = false;
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.SystemColors.Control;
            this.btnReporte.BackgroundImage = global::Presentador.Properties.Resources.reporte_0;
            this.btnReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReporte.Location = new System.Drawing.Point(470, 12);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(51, 49);
            this.btnReporte.TabIndex = 120;
            this.btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.BackgroundImage = global::Presentador.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(413, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(51, 49);
            this.btnEliminar.TabIndex = 119;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(356, 12);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 49);
            this.btnActualizar.TabIndex = 118;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnguardar.BackgroundImage = global::Presentador.Properties.Resources.buscar;
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguardar.Image = global::Presentador.Properties.Resources.guardar;
            this.btnguardar.Location = new System.Drawing.Point(189, 12);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(51, 49);
            this.btnguardar.TabIndex = 117;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelar.BackgroundImage = global::Presentador.Properties.Resources.cancelar_1;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(299, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(51, 49);
            this.btnCancelar.TabIndex = 116;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar.BackgroundImage = global::Presentador.Properties.Resources.editar;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Location = new System.Drawing.Point(242, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(51, 49);
            this.btnEditar.TabIndex = 115;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(136, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 114;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // rdMarca
            // 
            this.rdMarca.AutoSize = true;
            this.rdMarca.Location = new System.Drawing.Point(265, 261);
            this.rdMarca.Name = "rdMarca";
            this.rdMarca.Size = new System.Drawing.Size(68, 17);
            this.rdMarca.TabIndex = 135;
            this.rdMarca.Text = "Producto";
            this.rdMarca.UseVisualStyleBackColor = true;
            this.rdMarca.CheckedChanged += new System.EventHandler(this.rdMarca_CheckedChanged);
            // 
            // rbProducto
            // 
            this.rbProducto.AutoSize = true;
            this.rbProducto.Location = new System.Drawing.Point(339, 261);
            this.rbProducto.Name = "rbProducto";
            this.rbProducto.Size = new System.Drawing.Size(55, 17);
            this.rbProducto.TabIndex = 134;
            this.rbProducto.Text = "Marca";
            this.rbProducto.UseVisualStyleBackColor = true;
            this.rbProducto.CheckedChanged += new System.EventHandler(this.rbProducto_CheckedChanged);
            // 
            // frmComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 354);
            this.Controls.Add(this.rdMarca);
            this.Controls.Add(this.rbProducto);
            this.Controls.Add(this.txtidcomision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbproducto);
            this.Controls.Add(this.cbmarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcomision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbvendedor);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "frmComision";
            this.Text = "frmComision";
            this.Load += new System.EventHandler(this.frmComision_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cbproducto;
        public System.Windows.Forms.ComboBox cbmarca;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcomision;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbvendedor;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.TextBox txtidcomision;
        private System.Windows.Forms.RadioButton rdMarca;
        private System.Windows.Forms.RadioButton rbProducto;
    }
}