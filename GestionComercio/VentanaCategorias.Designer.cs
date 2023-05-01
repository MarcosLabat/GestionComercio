namespace GestionComercio
{
    partial class VentanaCategorias
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.tbxBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnResetCategoria = new System.Windows.Forms.Button();
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.lblBusqueda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "CATEGORIAS";
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(39, 109);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(260, 278);
            this.dgvCategorias.TabIndex = 12;
            // 
            // tbxBuscador
            // 
            this.tbxBuscador.Location = new System.Drawing.Point(39, 49);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(153, 20);
            this.tbxBuscador.TabIndex = 14;
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Location = new System.Drawing.Point(198, 47);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(48, 23);
            this.btnBuscarCategoria.TabIndex = 15;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnResetCategoria
            // 
            this.btnResetCategoria.Location = new System.Drawing.Point(251, 47);
            this.btnResetCategoria.Name = "btnResetCategoria";
            this.btnResetCategoria.Size = new System.Drawing.Size(48, 23);
            this.btnResetCategoria.TabIndex = 16;
            this.btnResetCategoria.Text = "Reset";
            this.btnResetCategoria.UseVisualStyleBackColor = true;
            this.btnResetCategoria.Click += new System.EventHandler(this.btnResetCategoria_Click);
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.Location = new System.Drawing.Point(224, 403);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCategoria.TabIndex = 17;
            this.btnActualizarCategoria.Text = "Actualizar";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(36, 81);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lblBusqueda.TabIndex = 18;
            // 
            // VentanaCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 441);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.btnResetCategoria);
            this.Controls.Add(this.btnBuscarCategoria);
            this.Controls.Add(this.tbxBuscador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCategorias);
            this.MaximumSize = new System.Drawing.Size(365, 480);
            this.MinimumSize = new System.Drawing.Size(365, 480);
            this.Name = "VentanaCategorias";
            this.Text = "VentanaCategorias";
            this.Load += new System.EventHandler(this.VentanaCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.TextBox tbxBuscador;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Button btnResetCategoria;
        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.Label lblBusqueda;
    }
}