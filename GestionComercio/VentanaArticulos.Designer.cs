namespace GestionComercio
{
    partial class VentanaArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaArticulos));
            this.btnActualizarArticulos = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnAgregarArticulo = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxBuscadorArticulos = new System.Windows.Forms.TextBox();
            this.cbxFiltroArticulos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetArticulos = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnActualizarArticulos
            // 
            this.btnActualizarArticulos.Location = new System.Drawing.Point(785, 536);
            this.btnActualizarArticulos.Name = "btnActualizarArticulos";
            this.btnActualizarArticulos.Size = new System.Drawing.Size(82, 31);
            this.btnActualizarArticulos.TabIndex = 8;
            this.btnActualizarArticulos.Text = "Actualizar";
            this.btnActualizarArticulos.UseVisualStyleBackColor = true;
            this.btnActualizarArticulos.Click += new System.EventHandler(this.btnActualizarArticulos_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(98, 185);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(789, 325);
            this.dgvArticulos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "ARTICULOS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAgregarArticulo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(993, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnAgregarArticulo
            // 
            this.tsbtnAgregarArticulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAgregarArticulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAgregarArticulo.Image")));
            this.tsbtnAgregarArticulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAgregarArticulo.Name = "tsbtnAgregarArticulo";
            this.tsbtnAgregarArticulo.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAgregarArticulo.Text = "toolStripButton1";
            this.tsbtnAgregarArticulo.Click += new System.EventHandler(this.tsbtnAgregarArticulo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seleccionToolStripMenuItem
            // 
            this.seleccionToolStripMenuItem.Name = "seleccionToolStripMenuItem";
            this.seleccionToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.seleccionToolStripMenuItem.Text = "Seleccion";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArticuloToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // nuevoArticuloToolStripMenuItem
            // 
            this.nuevoArticuloToolStripMenuItem.Name = "nuevoArticuloToolStripMenuItem";
            this.nuevoArticuloToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nuevoArticuloToolStripMenuItem.Text = "Nuevo Articulo";
            // 
            // tbxBuscadorArticulos
            // 
            this.tbxBuscadorArticulos.Location = new System.Drawing.Point(225, 134);
            this.tbxBuscadorArticulos.Name = "tbxBuscadorArticulos";
            this.tbxBuscadorArticulos.Size = new System.Drawing.Size(215, 20);
            this.tbxBuscadorArticulos.TabIndex = 15;
            // 
            // cbxFiltroArticulos
            // 
            this.cbxFiltroArticulos.FormattingEnabled = true;
            this.cbxFiltroArticulos.Location = new System.Drawing.Point(511, 134);
            this.cbxFiltroArticulos.Name = "cbxFiltroArticulos";
            this.cbxFiltroArticulos.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroArticulos.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtrar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "ARTICULOS";
            // 
            // btnResetArticulos
            // 
            this.btnResetArticulos.Location = new System.Drawing.Point(791, 131);
            this.btnResetArticulos.Name = "btnResetArticulos";
            this.btnResetArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnResetArticulos.TabIndex = 19;
            this.btnResetArticulos.Text = "Reset";
            this.btnResetArticulos.UseVisualStyleBackColor = true;
            this.btnResetArticulos.Click += new System.EventHandler(this.btnResetArticulos_Click);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(710, 131);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarArticulo.TabIndex = 20;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Buscar:";
            // 
            // VentanaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 579);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.btnResetArticulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFiltroArticulos);
            this.Controls.Add(this.tbxBuscadorArticulos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizarArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1009, 618);
            this.Name = "VentanaArticulos";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnAgregarArticulo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxBuscadorArticulos;
        private System.Windows.Forms.ComboBox cbxFiltroArticulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetArticulos;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Label label4;
    }
}