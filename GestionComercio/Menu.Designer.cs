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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsLabelArticulo = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnArticulos = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNuevoArt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLabelMarca = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnMarcas = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNuevaMarca = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLabelCategoria = new System.Windows.Forms.ToolStripLabel();
            this.tsBtnCategoria = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNuevaCategoria = new System.Windows.Forms.ToolStripButton();
            this.tsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelArticulo,
            this.tsBtnArticulos,
            this.tsBtnNuevoArt,
            this.toolStripSeparator1,
            this.tsLabelMarca,
            this.tsBtnMarcas,
            this.tsBtnNuevaMarca,
            this.toolStripSeparator2,
            this.tsLabelCategoria,
            this.tsBtnCategoria,
            this.tsBtnNuevaCategoria});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(984, 25);
            this.tsPrincipal.TabIndex = 19;
            this.tsPrincipal.Text = "toolStrip1";
            // 
            // tsLabelArticulo
            // 
            this.tsLabelArticulo.Name = "tsLabelArticulo";
            this.tsLabelArticulo.Size = new System.Drawing.Size(54, 22);
            this.tsLabelArticulo.Text = "Articulos";
            // 
            // tsBtnArticulos
            // 
            this.tsBtnArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnArticulos.Image")));
            this.tsBtnArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnArticulos.Name = "tsBtnArticulos";
            this.tsBtnArticulos.Size = new System.Drawing.Size(23, 22);
            this.tsBtnArticulos.Text = "Articulos";
            this.tsBtnArticulos.Click += new System.EventHandler(this.tsBtnListadoArt_Click);
            // 
            // tsBtnNuevoArt
            // 
            this.tsBtnNuevoArt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNuevoArt.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNuevoArt.Image")));
            this.tsBtnNuevoArt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNuevoArt.Name = "tsBtnNuevoArt";
            this.tsBtnNuevoArt.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNuevoArt.Text = "Nuevo articulo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLabelMarca
            // 
            this.tsLabelMarca.Name = "tsLabelMarca";
            this.tsLabelMarca.Size = new System.Drawing.Size(45, 22);
            this.tsLabelMarca.Text = "Marcas";
            // 
            // tsBtnMarcas
            // 
            this.tsBtnMarcas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnMarcas.Image")));
            this.tsBtnMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnMarcas.Name = "tsBtnMarcas";
            this.tsBtnMarcas.Size = new System.Drawing.Size(23, 22);
            this.tsBtnMarcas.Text = "Marcas";
            this.tsBtnMarcas.Click += new System.EventHandler(this.tsBtnListaMarcas_Click);
            // 
            // tsBtnNuevaMarca
            // 
            this.tsBtnNuevaMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNuevaMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNuevaMarca.Image")));
            this.tsBtnNuevaMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNuevaMarca.Name = "tsBtnNuevaMarca";
            this.tsBtnNuevaMarca.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNuevaMarca.Text = "Nueva Marca";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLabelCategoria
            // 
            this.tsLabelCategoria.Name = "tsLabelCategoria";
            this.tsLabelCategoria.Size = new System.Drawing.Size(58, 22);
            this.tsLabelCategoria.Text = "Categoria";
            // 
            // tsBtnCategoria
            // 
            this.tsBtnCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCategoria.Image")));
            this.tsBtnCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCategoria.Name = "tsBtnCategoria";
            this.tsBtnCategoria.Size = new System.Drawing.Size(23, 22);
            this.tsBtnCategoria.Text = "Categorias";
            this.tsBtnCategoria.Click += new System.EventHandler(this.tsBtnListaCategoria_Click);
            // 
            // tsBtnNuevaCategoria
            // 
            this.tsBtnNuevaCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNuevaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNuevaCategoria.Image")));
            this.tsBtnNuevaCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNuevaCategoria.Name = "tsBtnNuevaCategoria";
            this.tsBtnNuevaCategoria.Size = new System.Drawing.Size(23, 22);
            this.tsBtnNuevaCategoria.Text = "Nueva Categoria";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tsPrincipal);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del comercio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripLabel tsLabelArticulo;
        private System.Windows.Forms.ToolStripButton tsBtnArticulos;
        private System.Windows.Forms.ToolStripButton tsBtnNuevoArt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tsLabelMarca;
        private System.Windows.Forms.ToolStripButton tsBtnMarcas;
        private System.Windows.Forms.ToolStripButton tsBtnNuevaMarca;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tsLabelCategoria;
        private System.Windows.Forms.ToolStripButton tsBtnCategoria;
        private System.Windows.Forms.ToolStripButton tsBtnNuevaCategoria;
    }
}

