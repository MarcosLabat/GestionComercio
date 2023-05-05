namespace GestionComercio
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListArticulos = new System.Windows.Forms.Button();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnDetalleArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListArticulos
            // 
            this.btnListArticulos.AccessibleName = "";
            this.btnListArticulos.Location = new System.Drawing.Point(420, 192);
            this.btnListArticulos.Name = "btnListArticulos";
            this.btnListArticulos.Size = new System.Drawing.Size(193, 39);
            this.btnListArticulos.TabIndex = 0;
            this.btnListArticulos.Text = "Listado de Artículos";
            this.btnListArticulos.UseVisualStyleBackColor = true;
            this.btnListArticulos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.Location = new System.Drawing.Point(420, 237);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(193, 40);
            this.btnBuscarArticulos.TabIndex = 2;
            this.btnBuscarArticulos.Text = "Busqueda de Articulos";
            this.btnBuscarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(420, 283);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(193, 43);
            this.btnEliminarArticulo.TabIndex = 4;
            this.btnEliminarArticulo.Text = "Eliminar Artículo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnDetalleArticulo
            // 
            this.btnDetalleArticulo.Location = new System.Drawing.Point(420, 332);
            this.btnDetalleArticulo.Name = "btnDetalleArticulo";
            this.btnDetalleArticulo.Size = new System.Drawing.Size(193, 41);
            this.btnDetalleArticulo.TabIndex = 5;
            this.btnDetalleArticulo.Text = "Ver Detalle de Artículo";
            this.btnDetalleArticulo.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnDetalleArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnBuscarArticulos);
            this.Controls.Add(this.btnListArticulos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del comercio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListArticulos;
        private System.Windows.Forms.Button btnBuscarArticulos;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnDetalleArticulo;
    }
}

