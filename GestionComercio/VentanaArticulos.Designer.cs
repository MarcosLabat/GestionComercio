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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tbxBuscadorArticulos = new System.Windows.Forms.TextBox();
            this.cbxFiltroArticulos = new System.Windows.Forms.ComboBox();
            this.lblFiltrarPor = new System.Windows.Forms.Label();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.lblBuscadorRespuesta = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblFotos = new System.Windows.Forms.Label();
            this.chbxFiltroRapido = new System.Windows.Forms.CheckBox();
            this.lblBuscadorRapido = new System.Windows.Forms.Label();
            this.tbxBuscadorRapido = new System.Windows.Forms.TextBox();
            this.btnActualizarArticulos = new FontAwesome.Sharp.IconButton();
            this.btnBuscarArticulo = new FontAwesome.Sharp.IconButton();
            this.btnResetArticulos = new FontAwesome.Sharp.IconButton();
            this.btnFotoDer = new FontAwesome.Sharp.IconButton();
            this.btnFotoIzq = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnDetalle = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnNuevo = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(22, 131);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(596, 355);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // tbxBuscadorArticulos
            // 
            this.tbxBuscadorArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBuscadorArticulos.Location = new System.Drawing.Point(70, 37);
            this.tbxBuscadorArticulos.Name = "tbxBuscadorArticulos";
            this.tbxBuscadorArticulos.Size = new System.Drawing.Size(302, 20);
            this.tbxBuscadorArticulos.TabIndex = 15;
            // 
            // cbxFiltroArticulos
            // 
            this.cbxFiltroArticulos.FormattingEnabled = true;
            this.cbxFiltroArticulos.Location = new System.Drawing.Point(71, 69);
            this.cbxFiltroArticulos.Name = "cbxFiltroArticulos";
            this.cbxFiltroArticulos.Size = new System.Drawing.Size(96, 21);
            this.cbxFiltroArticulos.TabIndex = 16;
            // 
            // lblFiltrarPor
            // 
            this.lblFiltrarPor.AutoSize = true;
            this.lblFiltrarPor.Location = new System.Drawing.Point(12, 72);
            this.lblFiltrarPor.Name = "lblFiltrarPor";
            this.lblFiltrarPor.Size = new System.Drawing.Size(53, 13);
            this.lblFiltrarPor.TabIndex = 17;
            this.lblFiltrarPor.Text = "Filtrar por:";
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(21, 40);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(43, 13);
            this.lblBuscador.TabIndex = 21;
            this.lblBuscador.Text = "Buscar:";
            // 
            // lblBuscadorRespuesta
            // 
            this.lblBuscadorRespuesta.AutoSize = true;
            this.lblBuscadorRespuesta.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscadorRespuesta.Location = new System.Drawing.Point(35, 115);
            this.lblBuscadorRespuesta.Name = "lblBuscadorRespuesta";
            this.lblBuscadorRespuesta.Size = new System.Drawing.Size(132, 13);
            this.lblBuscadorRespuesta.TabIndex = 22;
            this.lblBuscadorRespuesta.Text = "lblBuscadorRespuesta";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(640, 283);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(108, 108);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 23;
            this.pbxArticulo.TabStop = false;
            // 
            // lblFotos
            // 
            this.lblFotos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFotos.AutoSize = true;
            this.lblFotos.Location = new System.Drawing.Point(666, 244);
            this.lblFotos.Name = "lblFotos";
            this.lblFotos.Size = new System.Drawing.Size(54, 13);
            this.lblFotos.TabIndex = 30;
            this.lblFotos.Text = "Foto 1 / 1";
            // 
            // chbxFiltroRapido
            // 
            this.chbxFiltroRapido.AutoSize = true;
            this.chbxFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxFiltroRapido.Location = new System.Drawing.Point(183, 73);
            this.chbxFiltroRapido.Name = "chbxFiltroRapido";
            this.chbxFiltroRapido.Size = new System.Drawing.Size(85, 17);
            this.chbxFiltroRapido.TabIndex = 32;
            this.chbxFiltroRapido.Text = "Filtro Rapido";
            this.chbxFiltroRapido.UseVisualStyleBackColor = true;
            this.chbxFiltroRapido.CheckedChanged += new System.EventHandler(this.chbxFiltroRapido_CheckedChanged);
            // 
            // lblBuscadorRapido
            // 
            this.lblBuscadorRapido.AutoSize = true;
            this.lblBuscadorRapido.Location = new System.Drawing.Point(22, 40);
            this.lblBuscadorRapido.Name = "lblBuscadorRapido";
            this.lblBuscadorRapido.Size = new System.Drawing.Size(43, 13);
            this.lblBuscadorRapido.TabIndex = 35;
            this.lblBuscadorRapido.Text = "Buscar:";
            // 
            // tbxBuscadorRapido
            // 
            this.tbxBuscadorRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBuscadorRapido.Location = new System.Drawing.Point(70, 37);
            this.tbxBuscadorRapido.Name = "tbxBuscadorRapido";
            this.tbxBuscadorRapido.Size = new System.Drawing.Size(302, 20);
            this.tbxBuscadorRapido.TabIndex = 34;
            this.tbxBuscadorRapido.TextChanged += new System.EventHandler(this.tbxBuscadorRapido_TextChanged);
            // 
            // btnActualizarArticulos
            // 
            this.btnActualizarArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarArticulos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarArticulos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarArticulos.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnActualizarArticulos.IconColor = System.Drawing.Color.White;
            this.btnActualizarArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarArticulos.IconSize = 30;
            this.btnActualizarArticulos.Location = new System.Drawing.Point(573, 92);
            this.btnActualizarArticulos.Name = "btnActualizarArticulos";
            this.btnActualizarArticulos.Size = new System.Drawing.Size(45, 33);
            this.btnActualizarArticulos.TabIndex = 36;
            this.btnActualizarArticulos.UseVisualStyleBackColor = false;
            this.btnActualizarArticulos.Click += new System.EventHandler(this.btnActualizarArticulos_Click);
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarArticulo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarArticulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArticulo.ForeColor = System.Drawing.Color.White;
            this.btnBuscarArticulo.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarArticulo.IconColor = System.Drawing.Color.White;
            this.btnBuscarArticulo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarArticulo.IconSize = 20;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(390, 31);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(80, 30);
            this.btnBuscarArticulo.TabIndex = 37;
            this.btnBuscarArticulo.Text = "Buscar";
            this.btnBuscarArticulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarArticulo.UseVisualStyleBackColor = false;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click_1);
            // 
            // btnResetArticulos
            // 
            this.btnResetArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetArticulos.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnResetArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetArticulos.ForeColor = System.Drawing.Color.White;
            this.btnResetArticulos.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnResetArticulos.IconColor = System.Drawing.Color.White;
            this.btnResetArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetArticulos.IconSize = 20;
            this.btnResetArticulos.Location = new System.Drawing.Point(487, 31);
            this.btnResetArticulos.Name = "btnResetArticulos";
            this.btnResetArticulos.Size = new System.Drawing.Size(80, 30);
            this.btnResetArticulos.TabIndex = 38;
            this.btnResetArticulos.Text = "Reset";
            this.btnResetArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetArticulos.UseVisualStyleBackColor = false;
            this.btnResetArticulos.Click += new System.EventHandler(this.btnResetArticulos_Click_1);
            // 
            // btnFotoDer
            // 
            this.btnFotoDer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFotoDer.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFotoDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoDer.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnFotoDer.IconColor = System.Drawing.Color.White;
            this.btnFotoDer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFotoDer.IconSize = 18;
            this.btnFotoDer.Location = new System.Drawing.Point(726, 239);
            this.btnFotoDer.Name = "btnFotoDer";
            this.btnFotoDer.Size = new System.Drawing.Size(26, 23);
            this.btnFotoDer.TabIndex = 39;
            this.btnFotoDer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFotoDer.UseVisualStyleBackColor = false;
            this.btnFotoDer.Click += new System.EventHandler(this.btnFotoDer_Click_1);
            // 
            // btnFotoIzq
            // 
            this.btnFotoIzq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFotoIzq.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFotoIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoIzq.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnFotoIzq.IconColor = System.Drawing.Color.White;
            this.btnFotoIzq.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFotoIzq.IconSize = 18;
            this.btnFotoIzq.Location = new System.Drawing.Point(640, 239);
            this.btnFotoIzq.Name = "btnFotoIzq";
            this.btnFotoIzq.Size = new System.Drawing.Size(26, 23);
            this.btnFotoIzq.TabIndex = 40;
            this.btnFotoIzq.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFotoIzq.UseVisualStyleBackColor = false;
            this.btnFotoIzq.Click += new System.EventHandler(this.btnFotoIzq_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 18;
            this.btnEliminar.Location = new System.Drawing.Point(640, 437);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 39);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnDetalle.IconColor = System.Drawing.Color.White;
            this.btnDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalle.IconSize = 18;
            this.btnDetalle.Location = new System.Drawing.Point(640, 131);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(108, 39);
            this.btnDetalle.TabIndex = 42;
            this.btnDetalle.Text = "DETALLE";
            this.btnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnModificar.IconColor = System.Drawing.Color.White;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 18;
            this.btnModificar.Location = new System.Drawing.Point(640, 176);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 39);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNuevo.IconColor = System.Drawing.Color.White;
            this.btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevo.IconSize = 25;
            this.btnNuevo.Location = new System.Drawing.Point(625, 31);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(135, 51);
            this.btnNuevo.TabIndex = 44;
            this.btnNuevo.Text = "NUEVO ARTICULO";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // VentanaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 632);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnFotoIzq);
            this.Controls.Add(this.btnFotoDer);
            this.Controls.Add(this.btnResetArticulos);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.btnActualizarArticulos);
            this.Controls.Add(this.lblBuscadorRapido);
            this.Controls.Add(this.tbxBuscadorRapido);
            this.Controls.Add(this.chbxFiltroRapido);
            this.Controls.Add(this.lblFotos);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblBuscadorRespuesta);
            this.Controls.Add(this.lblBuscador);
            this.Controls.Add(this.lblFiltrarPor);
            this.Controls.Add(this.cbxFiltroArticulos);
            this.Controls.Add(this.tbxBuscadorArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.MinimumSize = new System.Drawing.Size(788, 671);
            this.Name = "VentanaArticulos";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox tbxBuscadorArticulos;
        private System.Windows.Forms.ComboBox cbxFiltroArticulos;
        private System.Windows.Forms.Label lblFiltrarPor;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Label lblBuscadorRespuesta;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblFotos;
        private System.Windows.Forms.CheckBox chbxFiltroRapido;
        private System.Windows.Forms.Label lblBuscadorRapido;
        private System.Windows.Forms.TextBox tbxBuscadorRapido;
        private FontAwesome.Sharp.IconButton btnActualizarArticulos;
        private FontAwesome.Sharp.IconButton btnBuscarArticulo;
        private FontAwesome.Sharp.IconButton btnResetArticulos;
        private FontAwesome.Sharp.IconButton btnFotoDer;
        private FontAwesome.Sharp.IconButton btnFotoIzq;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnDetalle;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnNuevo;
    }
}