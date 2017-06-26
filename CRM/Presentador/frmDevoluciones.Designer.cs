namespace Presentador
{
    partial class frmDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevoluciones));
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnUltimoReg = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimerReg = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvDevoluciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(365, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 56;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.Location = new System.Drawing.Point(101, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 49);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnUltimoReg
            // 
            this.btnUltimoReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimoReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_last;
            this.btnUltimoReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimoReg.Location = new System.Drawing.Point(311, 5);
            this.btnUltimoReg.Name = "btnUltimoReg";
            this.btnUltimoReg.Size = new System.Drawing.Size(51, 49);
            this.btnUltimoReg.TabIndex = 54;
            this.btnUltimoReg.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguiente.BackgroundImage = global::Presentador.Properties.Resources.go_next;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(261, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(51, 49);
            this.btnSiguiente.TabIndex = 53;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.BackgroundImage = global::Presentador.Properties.Resources.anterior;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Location = new System.Drawing.Point(208, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 49);
            this.btnAnterior.TabIndex = 52;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPrimerReg
            // 
            this.btnPrimerReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimerReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_first;
            this.btnPrimerReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimerReg.Location = new System.Drawing.Point(153, 5);
            this.btnPrimerReg.Name = "btnPrimerReg";
            this.btnPrimerReg.Size = new System.Drawing.Size(51, 49);
            this.btnPrimerReg.TabIndex = 51;
            this.btnPrimerReg.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(49, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 50;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvDevoluciones
            // 
            this.dgvDevoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevoluciones.Location = new System.Drawing.Point(33, 60);
            this.dgvDevoluciones.Name = "dgvDevoluciones";
            this.dgvDevoluciones.Size = new System.Drawing.Size(836, 305);
            this.dgvDevoluciones.TabIndex = 23;
            this.dgvDevoluciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevoluciones_CellDoubleClick);
            // 
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 377);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnUltimoReg);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimerReg);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvDevoluciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevoluciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnUltimoReg;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimerReg;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.DataGridView dgvDevoluciones;
    }
}