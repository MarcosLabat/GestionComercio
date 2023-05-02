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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnArticulos = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnMarcas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnCategorias = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNuevaCategoria = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNuevaMarca = new System.Windows.Forms.ToolStripButton();
            this.tsbtnNuevoArticulo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ventanasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ventanasToolStripMenuItem
            // 
            this.ventanasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.ventanasToolStripMenuItem.Name = "ventanasToolStripMenuItem";
            this.ventanasToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.ventanasToolStripMenuItem.Text = "Ver";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.tsbtnArticulos,
            this.tsbtnNuevoArticulo,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tsbtnMarcas,
            this.tsbtnNuevaMarca,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tsbtnCategorias,
            this.tsbtnNuevaCategoria});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1041, 25);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(54, 22);
            this.toolStripLabel2.Text = "Articulos";
            // 
            // tsbtnArticulos
            // 
            this.tsbtnArticulos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnArticulos.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnArticulos.Image")));
            this.tsbtnArticulos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnArticulos.Name = "tsbtnArticulos";
            this.tsbtnArticulos.Size = new System.Drawing.Size(23, 22);
            this.tsbtnArticulos.Text = "VentanaArticulos";
            this.tsbtnArticulos.Click += new System.EventHandler(this.tsbtnArticulos_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel1.Text = "Marcas";
            // 
            // tsbtnMarcas
            // 
            this.tsbtnMarcas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnMarcas.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnMarcas.Image")));
            this.tsbtnMarcas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMarcas.Name = "tsbtnMarcas";
            this.tsbtnMarcas.Size = new System.Drawing.Size(23, 22);
            this.tsbtnMarcas.Text = "VentanaMarcas";
            this.tsbtnMarcas.Click += new System.EventHandler(this.tsbtnMarcas_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel3.Text = "Categorias";
            // 
            // tsbtnCategorias
            // 
            this.tsbtnCategorias.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCategorias.Image")));
            this.tsbtnCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCategorias.Name = "tsbtnCategorias";
            this.tsbtnCategorias.Size = new System.Drawing.Size(23, 22);
            this.tsbtnCategorias.Text = "VentanaCategorias";
            this.tsbtnCategorias.Click += new System.EventHandler(this.tsbtnCategorias_Click);
            // 
            // tsbtnNuevaCategoria
            // 
            this.tsbtnNuevaCategoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNuevaCategoria.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNuevaCategoria.Image")));
            this.tsbtnNuevaCategoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNuevaCategoria.Name = "tsbtnNuevaCategoria";
            this.tsbtnNuevaCategoria.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNuevaCategoria.Text = "NuevaCategoria";
            this.tsbtnNuevaCategoria.Click += new System.EventHandler(this.tsbtnNuevaCategoria_Click);
            // 
            // tsbtnNuevaMarca
            // 
            this.tsbtnNuevaMarca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNuevaMarca.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNuevaMarca.Image")));
            this.tsbtnNuevaMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNuevaMarca.Name = "tsbtnNuevaMarca";
            this.tsbtnNuevaMarca.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNuevaMarca.Text = "NuevaMarca";
            this.tsbtnNuevaMarca.Click += new System.EventHandler(this.tsbtnNuevaMarca_Click);
            // 
            // tsbtnNuevoArticulo
            // 
            this.tsbtnNuevoArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnNuevoArticulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnNuevoArticulo.Image")));
            this.tsbtnNuevoArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnNuevoArticulo.Name = "tsbtnNuevoArticulo";
            this.tsbtnNuevoArticulo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnNuevoArticulo.Text = "NuevoArticulo";
            this.tsbtnNuevoArticulo.Click += new System.EventHandler(this.tsbtnNuevoArticulo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 581);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1057, 620);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del comercio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnArticulos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnMarcas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbtnCategorias;
        private System.Windows.Forms.ToolStripButton tsbtnNuevaCategoria;
        private System.Windows.Forms.ToolStripButton tsbtnNuevoArticulo;
        private System.Windows.Forms.ToolStripButton tsbtnNuevaMarca;
    }
}

