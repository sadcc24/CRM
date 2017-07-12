namespace Presentador
{
    partial class frmHistoricoClienteCxC
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
            this.label1 = new System.Windows.Forms.Label();
            this.saldos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDebe = new System.Windows.Forms.DataGridView();
            this.dgvHaber = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdClientecxc = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombreclientecxc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labeldebe = new System.Windows.Forms.Label();
            this.labelhaber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saldo total:";
            // 
            // saldos
            // 
            this.saldos.AutoSize = true;
            this.saldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldos.Location = new System.Drawing.Point(561, 589);
            this.saldos.Name = "saldos";
            this.saldos.Size = new System.Drawing.Size(0, 29);
            this.saldos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Saldo Debe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(796, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 63;
            this.label5.Text = "Saldo Haber";
            // 
            // dgvDebe
            // 
            this.dgvDebe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebe.Location = new System.Drawing.Point(26, 195);
            this.dgvDebe.Name = "dgvDebe";
            this.dgvDebe.Size = new System.Drawing.Size(550, 330);
            this.dgvDebe.TabIndex = 64;
            // 
            // dgvHaber
            // 
            this.dgvHaber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHaber.Location = new System.Drawing.Point(582, 195);
            this.dgvHaber.Name = "dgvHaber";
            this.dgvHaber.Size = new System.Drawing.Size(550, 330);
            this.dgvHaber.TabIndex = 65;
            this.dgvHaber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHaber_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id:";
            // 
            // txtIdClientecxc
            // 
            this.txtIdClientecxc.Location = new System.Drawing.Point(434, 62);
            this.txtIdClientecxc.Name = "txtIdClientecxc";
            this.txtIdClientecxc.Size = new System.Drawing.Size(125, 20);
            this.txtIdClientecxc.TabIndex = 4;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuevo.BackgroundImage = global::Presentador.Properties.Resources.nuevo;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Image = global::Presentador.Properties.Resources.buscar;
            this.btnNuevo.Location = new System.Drawing.Point(513, 107);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 49);
            this.btnNuevo.TabIndex = 60;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.BackgroundImage = global::Presentador.Properties.Resources.cancelar_1;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Image = global::Presentador.Properties.Resources.cancelar_1;
            this.btnBuscar.Location = new System.Drawing.Point(566, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(51, 49);
            this.btnBuscar.TabIndex = 61;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Buscar Cliente:";
            // 
            // txtnombreclientecxc
            // 
            this.txtnombreclientecxc.Location = new System.Drawing.Point(639, 62);
            this.txtnombreclientecxc.Name = "txtnombreclientecxc";
            this.txtnombreclientecxc.Size = new System.Drawing.Size(125, 20);
            this.txtnombreclientecxc.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(571, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 544);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 29);
            this.label8.TabIndex = 69;
            this.label8.Text = "Saldo debe:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(827, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 29);
            this.label9.TabIndex = 70;
            this.label9.Text = "Saldo haber:";
            // 
            // labeldebe
            // 
            this.labeldebe.AutoSize = true;
            this.labeldebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldebe.Location = new System.Drawing.Point(171, 544);
            this.labeldebe.Name = "labeldebe";
            this.labeldebe.Size = new System.Drawing.Size(0, 29);
            this.labeldebe.TabIndex = 71;
            // 
            // labelhaber
            // 
            this.labelhaber.AutoSize = true;
            this.labelhaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhaber.Location = new System.Drawing.Point(983, 544);
            this.labelhaber.Name = "labelhaber";
            this.labelhaber.Size = new System.Drawing.Size(0, 29);
            this.labelhaber.TabIndex = 72;
            // 
            // frmHistoricoClienteCxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 623);
            this.Controls.Add(this.labelhaber);
            this.Controls.Add(this.labeldebe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtnombreclientecxc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvHaber);
            this.Controls.Add(this.dgvDebe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtIdClientecxc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saldos);
            this.Controls.Add(this.label1);
            this.Name = "frmHistoricoClienteCxC";
            this.Text = "frmHistoricoCxC";
            this.Load += new System.EventHandler(this.frmHistoricoCxC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHaber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label saldos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdClientecxc;
        private System.Windows.Forms.Button btnNuevo;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombreclientecxc;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DataGridView dgvDebe;
        public System.Windows.Forms.DataGridView dgvHaber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labeldebe;
        private System.Windows.Forms.Label labelhaber;
    }
}