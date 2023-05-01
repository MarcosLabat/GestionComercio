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
            this.Opcion = new System.Windows.Forms.TextBox();
            this.enviarOpcion = new System.Windows.Forms.Button();
            this.labelTitutlo = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // Opcion
            // 
            this.Opcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Opcion.Location = new System.Drawing.Point(500, 244);
            this.Opcion.Name = "Opcion";
            this.Opcion.Size = new System.Drawing.Size(123, 20);
            this.Opcion.TabIndex = 0;
            this.Opcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enviarOpcion
            // 
            this.enviarOpcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.enviarOpcion.Location = new System.Drawing.Point(500, 286);
            this.enviarOpcion.Name = "enviarOpcion";
            this.enviarOpcion.Size = new System.Drawing.Size(118, 27);
            this.enviarOpcion.TabIndex = 1;
            this.enviarOpcion.Text = "Enviar";
            this.enviarOpcion.UseVisualStyleBackColor = true;
            this.enviarOpcion.Click += new System.EventHandler(this.enviarOpcion_Click);
            // 
            // labelTitutlo
            // 
            this.labelTitutlo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitutlo.AutoSize = true;
            this.labelTitutlo.BackColor = System.Drawing.Color.White;
            this.labelTitutlo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitutlo.Location = new System.Drawing.Point(500, 20);
            this.labelTitutlo.Name = "labelTitutlo";
            this.labelTitutlo.Size = new System.Drawing.Size(136, 23);
            this.labelTitutlo.TabIndex = 3;
            this.labelTitutlo.Text = "Menú principal";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 115);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(473, 251);
            this.dgvArticulos.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.labelTitutlo);
            this.Controls.Add(this.enviarOpcion);
            this.Controls.Add(this.Opcion);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del comercio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Opcion;
        private System.Windows.Forms.Button enviarOpcion;
        private System.Windows.Forms.Label labelTitutlo;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}

