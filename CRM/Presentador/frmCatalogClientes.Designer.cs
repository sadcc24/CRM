﻿namespace Presentador
{
    partial class frmCatalogClientes
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnUltimoReg = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimerReg = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(405, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 111;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(141, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 110;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUltimoReg
            // 
            this.btnUltimoReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimoReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_last;
            this.btnUltimoReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimoReg.Location = new System.Drawing.Point(351, 12);
            this.btnUltimoReg.Name = "btnUltimoReg";
            this.btnUltimoReg.Size = new System.Drawing.Size(51, 49);
            this.btnUltimoReg.TabIndex = 109;
            this.btnUltimoReg.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguiente.BackgroundImage = global::Presentador.Properties.Resources.go_next;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(301, 12);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(51, 49);
            this.btnSiguiente.TabIndex = 108;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.BackgroundImage = global::Presentador.Properties.Resources.anterior;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Location = new System.Drawing.Point(248, 12);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 49);
            this.btnAnterior.TabIndex = 107;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPrimerReg
            // 
            this.btnPrimerReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimerReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_first;
            this.btnPrimerReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimerReg.Location = new System.Drawing.Point(193, 12);
            this.btnPrimerReg.Name = "btnPrimerReg";
            this.btnPrimerReg.Size = new System.Drawing.Size(51, 49);
            this.btnPrimerReg.TabIndex = 106;
            this.btnPrimerReg.UseVisualStyleBackColor = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(89, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(51, 49);
            this.btnnuevo.TabIndex = 105;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvclientes
            // 
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Location = new System.Drawing.Point(32, 89);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.Size = new System.Drawing.Size(897, 272);
            this.dgvclientes.TabIndex = 113;
            this.dgvclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientes_CellContentClick);
            this.dgvclientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclientes_CellDoubleClick_1);
            // 
            // frmCatalogClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(997, 706);
            this.Controls.Add(this.dgvclientes);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUltimoReg);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimerReg);
            this.Controls.Add(this.btnnuevo);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmCatalogClientes";
            this.Text = "Catalogo de Clientes";
            this.Load += new System.EventHandler(this.frmCatalogClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUltimoReg;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimerReg;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dgvclientes;
    }
}