namespace Presentador
{
    partial class frmConsultaVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaVendedores));
            this.grdCliente = new System.Windows.Forms.DataGridView();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUltimoReg = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimerReg = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCliente
            // 
            this.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCliente.Location = new System.Drawing.Point(19, 116);
            this.grdCliente.Name = "grdCliente";
            this.grdCliente.Size = new System.Drawing.Size(439, 373);
            this.grdCliente.TabIndex = 81;
            this.grdCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCliente_CellContentClick);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.Control;
            this.btnAyuda.BackgroundImage = global::Presentador.Properties.Resources.help;
            this.btnAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAyuda.Location = new System.Drawing.Point(352, 34);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(51, 49);
            this.btnAyuda.TabIndex = 95;
            this.btnAyuda.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::Presentador.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(88, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 49);
            this.button1.TabIndex = 94;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnUltimoReg
            // 
            this.btnUltimoReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnUltimoReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_last;
            this.btnUltimoReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUltimoReg.Location = new System.Drawing.Point(298, 34);
            this.btnUltimoReg.Name = "btnUltimoReg";
            this.btnUltimoReg.Size = new System.Drawing.Size(51, 49);
            this.btnUltimoReg.TabIndex = 93;
            this.btnUltimoReg.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.Control;
            this.btnSiguiente.BackgroundImage = global::Presentador.Properties.Resources.go_next;
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSiguiente.Location = new System.Drawing.Point(248, 34);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(51, 49);
            this.btnSiguiente.TabIndex = 92;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnAnterior.BackgroundImage = global::Presentador.Properties.Resources.anterior;
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnterior.Location = new System.Drawing.Point(195, 34);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(51, 49);
            this.btnAnterior.TabIndex = 91;
            this.btnAnterior.UseVisualStyleBackColor = false;
            // 
            // btnPrimerReg
            // 
            this.btnPrimerReg.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrimerReg.BackgroundImage = global::Presentador.Properties.Resources.go_to_first;
            this.btnPrimerReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrimerReg.Location = new System.Drawing.Point(140, 34);
            this.btnPrimerReg.Name = "btnPrimerReg";
            this.btnPrimerReg.Size = new System.Drawing.Size(51, 49);
            this.btnPrimerReg.TabIndex = 90;
            this.btnPrimerReg.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Location = new System.Drawing.Point(36, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 49);
            this.button2.TabIndex = 89;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmConsultaVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 512);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUltimoReg);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimerReg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grdCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaVendedores";
            this.Text = "Vendedores";
            ((System.ComponentModel.ISupportInitialize)(this.grdCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdCliente;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUltimoReg;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimerReg;
        private System.Windows.Forms.Button button2;
    }
}