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
            this.tbxBuscador = new System.Windows.Forms.TextBox();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.btnResetMarca = new FontAwesome.Sharp.IconButton();
            this.btnBuscarMarca = new FontAwesome.Sharp.IconButton();
            this.btnNueva = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnDetalle = new FontAwesome.Sharp.IconButton();
            this.btnActualizarMarca = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
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
            // tbxBuscador
            // 
            this.tbxBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxBuscador.Location = new System.Drawing.Point(32, 56);
            this.tbxBuscador.Name = "tbxBuscador";
            this.tbxBuscador.Size = new System.Drawing.Size(345, 20);
            this.tbxBuscador.TabIndex = 21;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(32, 146);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(515, 390);
            this.dgvMarcas.TabIndex = 19;
            // 
            // btnResetMarca
            // 
            this.btnResetMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetMarca.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnResetMarca.IconColor = System.Drawing.Color.Black;
            this.btnResetMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResetMarca.IconSize = 20;
            this.btnResetMarca.Location = new System.Drawing.Point(484, 52);
            this.btnResetMarca.Name = "btnResetMarca";
            this.btnResetMarca.Size = new System.Drawing.Size(63, 30);
            this.btnResetMarca.TabIndex = 53;
            this.btnResetMarca.Text = "Reset";
            this.btnResetMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetMarca.UseVisualStyleBackColor = true;
            this.btnResetMarca.Click += new System.EventHandler(this.btnResetMarca_Click_1);
            // 
            // btnBuscarMarca
            // 
            this.btnBuscarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarMarca.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarMarca.IconColor = System.Drawing.Color.Black;
            this.btnBuscarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarMarca.IconSize = 20;
            this.btnBuscarMarca.Location = new System.Drawing.Point(409, 52);
            this.btnBuscarMarca.Name = "btnBuscarMarca";
            this.btnBuscarMarca.Size = new System.Drawing.Size(69, 30);
            this.btnBuscarMarca.TabIndex = 52;
            this.btnBuscarMarca.Text = "Buscar";
            this.btnBuscarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarMarca.UseVisualStyleBackColor = true;
            this.btnBuscarMarca.Click += new System.EventHandler(this.btnBuscarMarca_Click_1);
            // 
            // btnNueva
            // 
            this.btnNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNueva.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnNueva.IconColor = System.Drawing.Color.White;
            this.btnNueva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNueva.IconSize = 25;
            this.btnNueva.Location = new System.Drawing.Point(593, 52);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(135, 51);
            this.btnNueva.TabIndex = 51;
            this.btnNueva.Text = "NUEVA MARCA";
            this.btnNueva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Red;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 18;
            this.iconButton2.Location = new System.Drawing.Point(253, 647);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(108, 39);
            this.iconButton2.TabIndex = 56;
            this.iconButton2.Text = "ELIMINAR";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
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
            this.btnModificar.Location = new System.Drawing.Point(607, 204);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 39);
            this.btnModificar.TabIndex = 55;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetalle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDetalle.IconColor = System.Drawing.Color.White;
            this.btnDetalle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalle.IconSize = 18;
            this.btnDetalle.Location = new System.Drawing.Point(607, 146);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(108, 39);
            this.btnDetalle.TabIndex = 54;
            this.btnDetalle.Text = "DETALLE";
            this.btnDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click_1);
            // 
            // btnActualizarMarca
            // 
            this.btnActualizarMarca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarMarca.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarMarca.ForeColor = System.Drawing.Color.White;
            this.btnActualizarMarca.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btnActualizarMarca.IconColor = System.Drawing.Color.White;
            this.btnActualizarMarca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarMarca.IconSize = 30;
            this.btnActualizarMarca.Location = new System.Drawing.Point(502, 556);
            this.btnActualizarMarca.Name = "btnActualizarMarca";
            this.btnActualizarMarca.Size = new System.Drawing.Size(45, 33);
            this.btnActualizarMarca.TabIndex = 57;
            this.btnActualizarMarca.UseVisualStyleBackColor = false;
            this.btnActualizarMarca.Click += new System.EventHandler(this.btnActualizarMarca_Click_1);
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
            this.btnEliminar.Location = new System.Drawing.Point(607, 483);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 39);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // VentanaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 632);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizarMarca);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnResetMarca);
            this.Controls.Add(this.btnBuscarMarca);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.tbxBuscador);
            this.Controls.Add(this.dgvMarcas);
            this.Name = "VentanaMarcas";
            this.Text = "VentanaMarcas";
            this.Load += new System.EventHandler(this.VentanaMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.TextBox tbxBuscador;
        private System.Windows.Forms.DataGridView dgvMarcas;
        private FontAwesome.Sharp.IconButton btnResetMarca;
        private FontAwesome.Sharp.IconButton btnBuscarMarca;
        private FontAwesome.Sharp.IconButton btnNueva;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnDetalle;
        private FontAwesome.Sharp.IconButton btnActualizarMarca;
        private FontAwesome.Sharp.IconButton btnEliminar;
    }
}