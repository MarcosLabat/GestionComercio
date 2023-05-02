namespace GestionComercio
{
    partial class VentanaArticuloModificar
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
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.tbxUrlImagen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVisualizarArticulo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbxDescripcion = new System.Windows.Forms.RichTextBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lvPrevisualizacion = new System.Windows.Forms.ListView();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.chbxCodigo = new System.Windows.Forms.CheckBox();
            this.chbxNombre = new System.Windows.Forms.CheckBox();
            this.chbxDescripcion = new System.Windows.Forms.CheckBox();
            this.chbxPrecio = new System.Windows.Forms.CheckBox();
            this.chbxCategoria = new System.Windows.Forms.CheckBox();
            this.chbxMarca = new System.Windows.Forms.CheckBox();
            this.chbxImagen = new System.Windows.Forms.CheckBox();
            this.lblCodigoArt = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxPrecio
            // 
            this.tbxPrecio.Location = new System.Drawing.Point(119, 153);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(188, 20);
            this.tbxPrecio.TabIndex = 2;
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            // 
            // tbxUrlImagen
            // 
            this.tbxUrlImagen.Location = new System.Drawing.Point(119, 265);
            this.tbxUrlImagen.Name = "tbxUrlImagen";
            this.tbxUrlImagen.Size = new System.Drawing.Size(188, 20);
            this.tbxUrlImagen.TabIndex = 5;
            this.tbxUrlImagen.Leave += new System.EventHandler(this.tbxUrlImagen_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 56;
            this.label9.Text = "UrlImagen:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(246, 24);
            this.label8.TabIndex = 55;
            this.label8.Text = "MODIFICAR ARTICULO";
            // 
            // btnVisualizarArticulo
            // 
            this.btnVisualizarArticulo.Location = new System.Drawing.Point(138, 414);
            this.btnVisualizarArticulo.Name = "btnVisualizarArticulo";
            this.btnVisualizarArticulo.Size = new System.Drawing.Size(153, 48);
            this.btnVisualizarArticulo.TabIndex = 7;
            this.btnVisualizarArticulo.Text = "Visualizar Articulo";
            this.btnVisualizarArticulo.UseVisualStyleBackColor = true;
            this.btnVisualizarArticulo.Click += new System.EventHandler(this.btnVisualizarArticulo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Marca:";
            // 
            // rtbxDescripcion
            // 
            this.rtbxDescripcion.Location = new System.Drawing.Point(119, 303);
            this.rtbxDescripcion.Name = "rtbxDescripcion";
            this.rtbxDescripcion.Size = new System.Drawing.Size(188, 96);
            this.rtbxDescripcion.TabIndex = 6;
            this.rtbxDescripcion.Text = "";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(119, 229);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(188, 21);
            this.cbxMarca.TabIndex = 4;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(119, 190);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(188, 21);
            this.cbxCategoria.TabIndex = 3;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(119, 116);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(188, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(119, 79);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(188, 20);
            this.tbxCodigo.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "Codigo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "PRE-CARGA";
            // 
            // lvPrevisualizacion
            // 
            this.lvPrevisualizacion.HideSelection = false;
            this.lvPrevisualizacion.Location = new System.Drawing.Point(333, 79);
            this.lvPrevisualizacion.Name = "lvPrevisualizacion";
            this.lvPrevisualizacion.RightToLeftLayout = true;
            this.lvPrevisualizacion.Size = new System.Drawing.Size(167, 125);
            this.lvPrevisualizacion.TabIndex = 60;
            this.lvPrevisualizacion.UseCompatibleStateImageBehavior = false;
            this.lvPrevisualizacion.View = System.Windows.Forms.View.List;
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(333, 416);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(167, 46);
            this.btnAgregarArticulo.TabIndex = 8;
            this.btnAgregarArticulo.Text = "Agregar Articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // chbxCodigo
            // 
            this.chbxCodigo.AutoSize = true;
            this.chbxCodigo.Location = new System.Drawing.Point(93, 82);
            this.chbxCodigo.Name = "chbxCodigo";
            this.chbxCodigo.Size = new System.Drawing.Size(15, 14);
            this.chbxCodigo.TabIndex = 62;
            this.chbxCodigo.UseVisualStyleBackColor = true;
            this.chbxCodigo.CheckedChanged += new System.EventHandler(this.chbxCodigo_CheckedChanged);
            // 
            // chbxNombre
            // 
            this.chbxNombre.AutoSize = true;
            this.chbxNombre.Location = new System.Drawing.Point(93, 119);
            this.chbxNombre.Name = "chbxNombre";
            this.chbxNombre.Size = new System.Drawing.Size(15, 14);
            this.chbxNombre.TabIndex = 63;
            this.chbxNombre.UseVisualStyleBackColor = true;
            this.chbxNombre.CheckedChanged += new System.EventHandler(this.chbxNombre_CheckedChanged);
            // 
            // chbxDescripcion
            // 
            this.chbxDescripcion.AutoSize = true;
            this.chbxDescripcion.Location = new System.Drawing.Point(93, 306);
            this.chbxDescripcion.Name = "chbxDescripcion";
            this.chbxDescripcion.Size = new System.Drawing.Size(15, 14);
            this.chbxDescripcion.TabIndex = 64;
            this.chbxDescripcion.UseVisualStyleBackColor = true;
            this.chbxDescripcion.CheckedChanged += new System.EventHandler(this.chbxDescripcion_CheckedChanged);
            // 
            // chbxPrecio
            // 
            this.chbxPrecio.AutoSize = true;
            this.chbxPrecio.Location = new System.Drawing.Point(93, 156);
            this.chbxPrecio.Name = "chbxPrecio";
            this.chbxPrecio.Size = new System.Drawing.Size(15, 14);
            this.chbxPrecio.TabIndex = 65;
            this.chbxPrecio.UseVisualStyleBackColor = true;
            this.chbxPrecio.CheckedChanged += new System.EventHandler(this.chbxPrecio_CheckedChanged);
            // 
            // chbxCategoria
            // 
            this.chbxCategoria.AutoSize = true;
            this.chbxCategoria.Location = new System.Drawing.Point(93, 193);
            this.chbxCategoria.Name = "chbxCategoria";
            this.chbxCategoria.Size = new System.Drawing.Size(15, 14);
            this.chbxCategoria.TabIndex = 66;
            this.chbxCategoria.UseVisualStyleBackColor = true;
            this.chbxCategoria.CheckedChanged += new System.EventHandler(this.chbxCategoria_CheckedChanged);
            // 
            // chbxMarca
            // 
            this.chbxMarca.AutoSize = true;
            this.chbxMarca.Location = new System.Drawing.Point(93, 232);
            this.chbxMarca.Name = "chbxMarca";
            this.chbxMarca.Size = new System.Drawing.Size(15, 14);
            this.chbxMarca.TabIndex = 67;
            this.chbxMarca.UseVisualStyleBackColor = true;
            this.chbxMarca.CheckedChanged += new System.EventHandler(this.chbxMarca_CheckedChanged);
            // 
            // chbxImagen
            // 
            this.chbxImagen.AutoSize = true;
            this.chbxImagen.Location = new System.Drawing.Point(93, 269);
            this.chbxImagen.Name = "chbxImagen";
            this.chbxImagen.Size = new System.Drawing.Size(15, 14);
            this.chbxImagen.TabIndex = 68;
            this.chbxImagen.UseVisualStyleBackColor = true;
            this.chbxImagen.CheckedChanged += new System.EventHandler(this.chbxImagen_CheckedChanged);
            // 
            // lblCodigoArt
            // 
            this.lblCodigoArt.AutoSize = true;
            this.lblCodigoArt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArt.Location = new System.Drawing.Point(18, 47);
            this.lblCodigoArt.Name = "lblCodigoArt";
            this.lblCodigoArt.Size = new System.Drawing.Size(57, 18);
            this.lblCodigoArt.TabIndex = 69;
            this.lblCodigoArt.Text = "Articulo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(258, 484);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(354, 220);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(120, 113);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 73;
            this.pbImagen.TabStop = false;
            // 
            // VentanaArticuloModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 531);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblCodigoArt);
            this.Controls.Add(this.chbxImagen);
            this.Controls.Add(this.chbxMarca);
            this.Controls.Add(this.chbxCategoria);
            this.Controls.Add(this.chbxPrecio);
            this.Controls.Add(this.chbxDescripcion);
            this.Controls.Add(this.chbxNombre);
            this.Controls.Add(this.chbxCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvPrevisualizacion);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxUrlImagen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnVisualizarArticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbxDescripcion);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(562, 570);
            this.MinimumSize = new System.Drawing.Size(562, 570);
            this.Name = "VentanaArticuloModificar";
            this.Text = "VentanaArticuloModificar";
            this.Load += new System.EventHandler(this.VentanaArticuloModificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.TextBox tbxUrlImagen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVisualizarArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbxDescripcion;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvPrevisualizacion;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.CheckBox chbxCodigo;
        private System.Windows.Forms.CheckBox chbxNombre;
        private System.Windows.Forms.CheckBox chbxDescripcion;
        private System.Windows.Forms.CheckBox chbxPrecio;
        private System.Windows.Forms.CheckBox chbxCategoria;
        private System.Windows.Forms.CheckBox chbxMarca;
        private System.Windows.Forms.CheckBox chbxImagen;
        private System.Windows.Forms.Label lblCodigoArt;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}