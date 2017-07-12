namespace Presentador
{
    partial class frmCatalogoComision
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
            this.dgvcomision = new System.Windows.Forms.DataGridView();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnUltimoReg = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimerReg = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcomision
            // 
            this.dgvcomision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcomision.Location = new System.Drawing.Point(26, 81);
            this.dgvcomision.Name = "dgvcomision";
            this.dgvcomision.Size = new System.Drawing.Size(607, 274);
            this.dgvcomision.TabIndex = 128;
            this.dgvcomision.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcomision_CellClick);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(429, 12);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 127;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnactualizar
            // 
            this.btnactualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnactualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnactualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnactualizar.Location = new System.Drawing.Point(165, 12);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(51, 49);
            this.btnactualizar.TabIndex = 126;
            this.btnactualizar.UseVisualStyleBackColor = false;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnUltimoReg
            // 
            this.btnUltimoReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimoReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_last;
            this.btnUltimoReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimoReg.Location = new System.Drawing.Point(375, 12);
            this.btnUltimoReg.Name = "btnUltimoReg";
            this.btnUltimoReg.Size = new System.Drawing.Size(51, 49);
            this.btnUltimoReg.TabIndex = 125;
            this.btnUltimoReg.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguiente.BackgroundImage = global::Presentador.Properties.Resources.go_next;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(325, 12);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(51, 49);
            this.btnSiguiente.TabIndex = 124;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.BackgroundImage = global::Presentador.Properties.Resources.anterior;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Location = new System.Drawing.Point(272, 12);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 49);
            this.btnAnterior.TabIndex = 123;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPrimerReg
            // 
            this.btnPrimerReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimerReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_first;
            this.btnPrimerReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimerReg.Location = new System.Drawing.Point(217, 12);
            this.btnPrimerReg.Name = "btnPrimerReg";
            this.btnPrimerReg.Size = new System.Drawing.Size(51, 49);
            this.btnPrimerReg.TabIndex = 122;
            this.btnPrimerReg.UseVisualStyleBackColor = false;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnnuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(113, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(51, 49);
            this.btnnuevo.TabIndex = 121;
            this.btnnuevo.UseVisualStyleBackColor = false;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // frmCatalogoComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 377);
            this.Controls.Add(this.dgvcomision);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnUltimoReg);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimerReg);
            this.Controls.Add(this.btnnuevo);
            this.Name = "frmCatalogoComision";
            this.Text = "frmCatalogoComision";
            this.Load += new System.EventHandler(this.frmCatalogoComision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcomision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcomision;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnUltimoReg;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimerReg;
        private System.Windows.Forms.Button btnnuevo;
    }
}