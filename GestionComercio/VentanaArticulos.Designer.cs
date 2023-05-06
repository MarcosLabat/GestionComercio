﻿namespace GestionComercio
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
            this.btnActualizarArticulos = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seleccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxBuscadorArticulos = new System.Windows.Forms.TextBox();
            this.cbxFiltroArticulos = new System.Windows.Forms.ComboBox();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.btnResetArticulos = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.lblBuscadorRespuesta = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnFotoIzq = new System.Windows.Forms.Button();
            this.btnFotoDer = new System.Windows.Forms.Button();
            this.lblFotos = new System.Windows.Forms.Label();
            this.chbxFiltroRapido = new System.Windows.Forms.CheckBox();
            this.lblBuscadorRapido = new System.Windows.Forms.Label();
            this.tbxBuscadorRapido = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarArticulos
            // 
            this.btnActualizarArticulos.BackColor = System.Drawing.Color.MediumPurple;
            this.btnActualizarArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarArticulos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarArticulos.ForeColor = System.Drawing.Color.Lavender;
            this.btnActualizarArticulos.Location = new System.Drawing.Point(673, 41);
            this.btnActualizarArticulos.Name = "btnActualizarArticulos";
            this.btnActualizarArticulos.Size = new System.Drawing.Size(82, 31);
            this.btnActualizarArticulos.TabIndex = 8;
            this.btnActualizarArticulos.Text = "Actualizar";
            this.btnActualizarArticulos.UseVisualStyleBackColor = false;
            this.btnActualizarArticulos.Click += new System.EventHandler(this.btnActualizarArticulos_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 129);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(753, 325);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(753, 325);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(753, 325);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seleccionToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seleccionToolStripMenuItem
            // 
            this.seleccionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
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
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
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
            this.nuevoArticuloToolStripMenuItem.Click += new System.EventHandler(this.nuevoArticuloToolStripMenuItem_Click);
            // 
            // tbxBuscadorArticulos
            // 
            this.tbxBuscadorArticulos.Location = new System.Drawing.Point(72, 47);
            this.tbxBuscadorArticulos.Name = "tbxBuscadorArticulos";
            this.tbxBuscadorArticulos.Size = new System.Drawing.Size(215, 20);
            this.tbxBuscadorArticulos.TabIndex = 15;
            // 
            // cbxFiltroArticulos
            // 
            this.cbxFiltroArticulos.FormattingEnabled = true;
            this.cbxFiltroArticulos.Location = new System.Drawing.Point(358, 47);
            this.cbxFiltroArticulos.Name = "cbxFiltroArticulos";
            this.cbxFiltroArticulos.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltroArticulos.TabIndex = 16;
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Location = new System.Drawing.Point(299, 50);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrarPor.TabIndex = 17;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // btnResetArticulos
            // 
            this.btnResetArticulos.Location = new System.Drawing.Point(566, 45);
            this.btnResetArticulos.Name = "btnResetArticulos";
            this.btnResetArticulos.Size = new System.Drawing.Size(75, 23);
            this.btnResetArticulos.TabIndex = 19;
            this.btnResetArticulos.Text = "Reset";
            this.btnResetArticulos.UseVisualStyleBackColor = true;
            this.btnResetArticulos.Click += new System.EventHandler(this.btnResetArticulos_Click);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(485, 45);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarArticulo.TabIndex = 20;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(23, 50);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(43, 13);
            this.lblBuscador.TabIndex = 21;
            this.lblBuscador.Text = "Buscar:";
            // 
            // lblBuscadorRespuesta
            // 
            this.lblBuscadorRespuesta.AutoSize = true;
            this.lblBuscadorRespuesta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscadorRespuesta.Location = new System.Drawing.Point(25, 113);
            this.lblBuscadorRespuesta.Name = "lblBuscadorRespuesta";
            this.lblBuscadorRespuesta.Size = new System.Drawing.Size(132, 13);
            this.lblBuscadorRespuesta.TabIndex = 22;
            this.lblBuscadorRespuesta.Text = "lblBuscadorRespuesta";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(771, 191);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(200, 200);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 23;
            this.pbxArticulo.TabStop = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnModificar.Location = new System.Drawing.Point(876, 127);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Info;
            this.btnEliminar.Location = new System.Drawing.Point(831, 397);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalle.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDetalle.Location = new System.Drawing.Point(780, 127);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(78, 23);
            this.btnDetalle.TabIndex = 26;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Green;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnNuevo.Location = new System.Drawing.Point(831, 35);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(82, 40);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo Articulo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnFotoIzq
            // 
            this.btnFotoIzq.Location = new System.Drawing.Point(771, 166);
            this.btnFotoIzq.Name = "btnFotoIzq";
            this.btnFotoIzq.Size = new System.Drawing.Size(27, 19);
            this.btnFotoIzq.TabIndex = 28;
            this.btnFotoIzq.Text = "<<";
            this.btnFotoIzq.UseVisualStyleBackColor = true;
            this.btnFotoIzq.Click += new System.EventHandler(this.btnFotoIzq_Click);
            // 
            // btnFotoDer
            // 
            this.btnFotoDer.Location = new System.Drawing.Point(944, 166);
            this.btnFotoDer.Name = "btnFotoDer";
            this.btnFotoDer.Size = new System.Drawing.Size(27, 19);
            this.btnFotoDer.TabIndex = 29;
            this.btnFotoDer.Text = ">>";
            this.btnFotoDer.UseVisualStyleBackColor = true;
            this.btnFotoDer.Click += new System.EventHandler(this.btnFotoDer_Click);
            // 
            // lblFotos
            // 
            this.lblFotos.AutoSize = true;
            this.lblFotos.Location = new System.Drawing.Point(842, 169);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(54, 13);
            this.lblFotos.TabIndex = 30;
            this.lblFotos.Text = "Foto 1 / 1";
            // 
            // chbxFiltroRapido
            // 
            this.chbxFiltroRapido.AutoSize = true;
            this.chbxFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxFiltroRapido.Location = new System.Drawing.Point(485, 82);
            this.chbxFiltroRapido.Name = "chbxFiltroRapido";
            this.chbxFiltroRapido.Size = new System.Drawing.Size(98, 17);
            this.chbxFiltroRapido.TabIndex = 32;
            this.chbxFiltroRapido.Text = "Filtro Rapido";
            this.chbxFiltroRapido.UseVisualStyleBackColor = true;
            this.chbxFiltroRapido.CheckedChanged += new System.EventHandler(this.chbxFiltroRapido_CheckedChanged);
            // 
            // lblBuscadorRapido
            // 
            this.lblBuscadorRapido.AutoSize = true;
            this.lblBuscadorRapido.Location = new System.Drawing.Point(23, 83);
            this.lblBuscadorRapido.Name = "lblBuscadorRapido";
            this.lblBuscadorRapido.Size = new System.Drawing.Size(43, 13);
            this.lblBuscadorRapido.TabIndex = 35;
            this.lblBuscadorRapido.Text = "Buscar:";
            // 
            // tbxBuscadorRapido
            // 
            this.tbxBuscadorRapido.Location = new System.Drawing.Point(72, 80);
            this.tbxBuscadorRapido.Name = "tbxBuscadorRapido";
            this.tbxBuscadorRapido.Size = new System.Drawing.Size(407, 20);
            this.tbxBuscadorRapido.TabIndex = 34;
            this.tbxBuscadorRapido.TextChanged += new System.EventHandler(this.tbxBuscadorRapido_TextChanged);
            // 
            // VentanaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 471);
            this.Controls.Add(this.lblBuscadorRapido);
            this.Controls.Add(this.tbxBuscadorRapido);
            this.Controls.Add(this.chbxFiltroRapido);
            this.Controls.Add(this.lblFotos);
            this.Controls.Add(this.btnFotoDer);
            this.Controls.Add(this.btnFotoIzq);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblBuscadorRespuesta);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.btnResetArticulos);
            this.Controls.Add(this.lblFiltrarPor);
            this.Controls.Add(this.cbxFiltroArticulos);
            this.Controls.Add(this.tbxBuscadorArticulos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnActualizarArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(995, 510);
            this.Name = "VentanaArticulos";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarArticulos;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seleccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArticuloToolStripMenuItem;
        private System.Windows.Forms.TextBox tbxBuscadorArticulos;
        private System.Windows.Forms.ComboBox cbxFiltroArticulos;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Button btnResetArticulos;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.Label lblBuscadorRespuesta;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnFotoIzq;
        private System.Windows.Forms.Button btnFotoDer;
        private System.Windows.Forms.Label lblFotos;
        private System.Windows.Forms.CheckBox chbxFiltroRapido;
        private System.Windows.Forms.Label lblBuscadorRapido;
        private System.Windows.Forms.TextBox tbxBuscadorRapido;
    }
}