namespace Presentador
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnUltimoReg = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimerReg = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 305);
            this.dataGridView1.TabIndex = 47;
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(403, 5);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 49;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizar.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnActualizar.Location = new System.Drawing.Point(139, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 49);
            this.btnActualizar.TabIndex = 48;
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnUltimoReg
            // 
            this.btnUltimoReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimoReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_last;
            this.btnUltimoReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimoReg.Location = new System.Drawing.Point(349, 5);
            this.btnUltimoReg.Name = "btnUltimoReg";
            this.btnUltimoReg.Size = new System.Drawing.Size(51, 49);
            this.btnUltimoReg.TabIndex = 45;
            this.btnUltimoReg.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguiente.BackgroundImage = global::Presentador.Properties.Resources.go_next;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(299, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(51, 49);
            this.btnSiguiente.TabIndex = 44;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.BackgroundImage = global::Presentador.Properties.Resources.anterior;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Location = new System.Drawing.Point(246, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 49);
            this.btnAnterior.TabIndex = 43;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPrimerReg
            // 
            this.btnPrimerReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimerReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_first;
            this.btnPrimerReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimerReg.Location = new System.Drawing.Point(191, 5);
            this.btnPrimerReg.Name = "btnPrimerReg";
            this.btnPrimerReg.Size = new System.Drawing.Size(51, 49);
            this.btnPrimerReg.TabIndex = 42;
            this.btnPrimerReg.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(87, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 36;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 377);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUltimoReg);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimerReg);
            this.Controls.Add(this.btnNuevo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUltimoReg;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimerReg;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAyuda;
    }
}