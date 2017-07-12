namespace Presentador
{
    partial class frmHistoricoGeneralCxC
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
            this.dgvgenhaber = new System.Windows.Forms.DataGridView();
            this.dgvgendebe = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totsaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ldebe = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lhaber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgenhaber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgendebe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvgenhaber
            // 
            this.dgvgenhaber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgenhaber.Location = new System.Drawing.Point(584, 57);
            this.dgvgenhaber.Name = "dgvgenhaber";
            this.dgvgenhaber.Size = new System.Drawing.Size(529, 433);
            this.dgvgenhaber.TabIndex = 71;
            this.dgvgenhaber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dgvgendebe
            // 
            this.dgvgendebe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvgendebe.Location = new System.Drawing.Point(22, 57);
            this.dgvgendebe.Name = "dgvgendebe";
            this.dgvgendebe.Size = new System.Drawing.Size(529, 433);
            this.dgvgendebe.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(733, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Saldo Haber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 68;
            this.label4.Text = "Saldo Debe";
            // 
            // totsaldo
            // 
            this.totsaldo.AutoSize = true;
            this.totsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totsaldo.Location = new System.Drawing.Point(602, 535);
            this.totsaldo.Name = "totsaldo";
            this.totsaldo.Size = new System.Drawing.Size(0, 29);
            this.totsaldo.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 66;
            this.label1.Text = "Saldo total:";
            // 
            // ldebe
            // 
            this.ldebe.AutoSize = true;
            this.ldebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldebe.Location = new System.Drawing.Point(223, 512);
            this.ldebe.Name = "ldebe";
            this.ldebe.Size = new System.Drawing.Size(0, 29);
            this.ldebe.TabIndex = 73;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 512);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 72;
            this.label6.Text = "Saldo debe:";
            // 
            // lhaber
            // 
            this.lhaber.AutoSize = true;
            this.lhaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhaber.Location = new System.Drawing.Point(966, 512);
            this.lhaber.Name = "lhaber";
            this.lhaber.Size = new System.Drawing.Size(0, 29);
            this.lhaber.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(803, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 74;
            this.label8.Text = "Saldo haber:";
            // 
            // frmHistoricoGeneralCxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 595);
            this.Controls.Add(this.lhaber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ldebe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvgenhaber);
            this.Controls.Add(this.dgvgendebe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totsaldo);
            this.Controls.Add(this.label1);
            this.Name = "frmHistoricoGeneralCxC";
            this.Text = "Cuentas por Cobrar";
            this.Load += new System.EventHandler(this.frmHistoricoGeneralCxC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgenhaber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgendebe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvgenhaber;
        private System.Windows.Forms.DataGridView dgvgendebe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totsaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ldebe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lhaber;
        private System.Windows.Forms.Label label8;
    }
}