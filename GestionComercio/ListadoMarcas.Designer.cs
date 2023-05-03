namespace GestionComercio
{
    partial class ListadoMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.labelTituloMarcas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(225, 144);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(338, 228);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.Visible = false;
            this.dgvMarcas.VisibleChanged += new System.EventHandler(this.dgvMarcas_VisibleChanged);
            // 
            // labelTituloMarcas
            // 
            this.labelTituloMarcas.AutoSize = true;
            this.labelTituloMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMarcas.Location = new System.Drawing.Point(301, 64);
            this.labelTituloMarcas.Name = "labelTituloMarcas";
            this.labelTituloMarcas.Size = new System.Drawing.Size(178, 42);
            this.labelTituloMarcas.TabIndex = 1;
            this.labelTituloMarcas.Text = "MARCAS";
            // 
            // ListadoMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTituloMarcas);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "ListadoMarcas";
            this.Text = "ListadoMarcas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label labelTituloMarcas;
    }
}