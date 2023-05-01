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
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtOpcion = new System.Windows.Forms.TextBox();
            this.labelOpcion1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(397, 289);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(177, 37);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Enviar";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtOpcion
            // 
            this.txtOpcion.Location = new System.Drawing.Point(397, 263);
            this.txtOpcion.Name = "txtOpcion";
            this.txtOpcion.Size = new System.Drawing.Size(173, 20);
            this.txtOpcion.TabIndex = 12;
            // 
            // labelOpcion1
            // 
            this.labelOpcion1.AutoSize = true;
            this.labelOpcion1.BackColor = System.Drawing.Color.DarkGray;
            this.labelOpcion1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpcion1.Location = new System.Drawing.Point(393, 225);
            this.labelOpcion1.Name = "labelOpcion1";
            this.labelOpcion1.Size = new System.Drawing.Size(186, 23);
            this.labelOpcion1.TabIndex = 13;
            this.labelOpcion1.Text = "1 - Lista de articulos ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.Controls.Add(this.labelOpcion1);
            this.Controls.Add(this.txtOpcion);
            this.Controls.Add(this.btnMenu);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion del comercio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtOpcion;
        private System.Windows.Forms.Label labelOpcion1;
    }
}

