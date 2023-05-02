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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Location = new System.Drawing.Point(28, 97);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(0, 13);
            this.lblBusqueda.TabIndex = 25;
            // 
            // btnActualizarMarca
            // 
            this.btnActualizarMarca.Location = new System.Drawing.Point(216, 406);
            this.btnActualizarMarca.Name = "btnActualizarMarca";
            this.btnActualizarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarMarca.TabIndex = 24;
            this.btnActualizarMarca.Text = "Actualizar";
            this.btnActualizarMarca.UseVisualStyleBackColor = true;
            this.btnActualizarMarca.Click += new System.EventHandler(this.btnActualizarMarca_Click);
            // 
            // btnResetMarca
            // 
            this.btnResetMarca.Location = new System.Drawing.Point(243, 73);
            this.btnResetMarca.Name = "btnResetMarca";
            this.btnResetMarca.Size = new System.Drawing.Size(48, 23);
            this.btnResetMarca.TabIndex = 23;
            this.btnResetMarca.Text = "Reset";
            this.btnResetMarca.UseVisualStyleBackColor = true;
            this.btnResetMarca.Click += new System.EventHandler(this.btnResetMarca_Click);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Location = new System.Drawing.Point(190, 73);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(48, 23);
            this.btnBuscarMarca.TabIndex = 22;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click);
            // 
            // tbxBuscador
            // 
            this.tbxBuscador.Location = new System.Drawing.Point(31, 75);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(153, 20);
            this.tbxBuscador.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "MARCAS";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(31, 118);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(260, 278);
            this.dgvMarcas.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seleccionToolStripMenuItem
            // 
            this.seleccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.verDetalleToolStripMenuItem});
            this.seleccionToolStripMenuItem.Name = "seleccionToolStripMenuItem";
            this.seleccionToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.seleccionToolStripMenuItem.Text = "Seleccion";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.verDetalleToolStripMenuItem.Text = "Ver detalle";
            this.verDetalleToolStripMenuItem.Click += new System.EventHandler(this.verDetalleToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMarcaToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // nuevaMarcaToolStripMenuItem
            // 
            this.nuevaMarcaToolStripMenuItem.Name = "nuevaMarcaToolStripMenuItem";
            this.nuevaMarcaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.nuevaMarcaToolStripMenuItem.Text = "Nueva Marca";
            this.nuevaMarcaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMarcaToolStripMenuItem_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(307, 156);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 23);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(307, 118);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(65, 23);
            this.btnDetalle.TabIndex = 28;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(289, 34);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(83, 23);
            this.btnNueva.TabIndex = 32;
            this.btnNueva.Text = "Nueva Marca";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // VentanaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.btnActualizarMarca);
            this.Controls.Add(this.btnResetMarca);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.tbxBuscador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMarcas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(400, 480);
            this.MinimumSize = new System.Drawing.Size(400, 480);
            this.Name = "VentanaMarcas";
            this.Text = "VentanaMarcas";
            this.Load += new System.EventHandler(this.VentanaMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnNueva;
    }
}