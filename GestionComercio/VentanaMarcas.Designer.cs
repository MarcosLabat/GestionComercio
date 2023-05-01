namespace GestionComercio
{
    partial class VentanaMarcas
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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.btnActualizarMarca = new System.Windows.Forms.Button();
            this.btnResetMarca = new System.Windows.Forms.Button();
            this.btnBuscarMarca = new System.Windows.Forms.Button();
            this.tbxBuscador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(32, 82);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lblBusqueda.TabIndex = 25;
            // 
            // btnActualizarMarca
            // 
            this.btnActualizarMarca.Location = new System.Drawing.Point(220, 404);
            this.btnActualizarMarca.Name = "btnActualizarMarca";
            this.btnActualizarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarMarca.TabIndex = 24;
            this.btnActualizarMarca.Text = "Actualizar";
            this.btnActualizarMarca.UseVisualStyleBackColor = true;
            this.btnActualizarMarca.Click += new System.EventHandler(this.btnActualizarMarca_Click);
            // 
            // btnResetMarca
            // 
            this.btnResetMarca.Location = new System.Drawing.Point(247, 48);
            this.btnResetMarca.Name = "btnResetMarca";
            this.btnResetMarca.Size = new System.Drawing.Size(48, 23);
            this.btnResetMarca.TabIndex = 23;
            this.btnResetMarca.Text = "Reset";
            this.btnResetMarca.UseVisualStyleBackColor = true;
            this.btnResetMarca.Click += new System.EventHandler(this.btnResetMarca_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Location = new System.Drawing.Point(194, 48);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(48, 23);
            this.btnBuscarMarca.TabIndex = 22;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // tbxBuscador
            // 
            this.tbxBuscador.Location = new System.Drawing.Point(35, 50);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(153, 20);
            this.tbxBuscador.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "MARCAS";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(35, 110);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(260, 278);
            this.dgvMarcas.TabIndex = 19;
            // 
            // VentanaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 441);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnActualizarMarca);
            this.Controls.Add(this.btnResetMarca);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.tbxBuscador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMarcas);
            this.MaximumSize = new System.Drawing.Size(365, 480);
            this.MinimumSize = new System.Drawing.Size(365, 480);
            this.Name = "VentanaMarcas";
            this.Text = "VentanaMarcas";
            this.Load += new System.EventHandler(this.VentanaMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Button btnActualizarMarca;
        private System.Windows.Forms.Button btnResetMarca;
        private System.Windows.Forms.Button btnBuscarMarca;
        private System.Windows.Forms.TextBox tbxBuscador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}