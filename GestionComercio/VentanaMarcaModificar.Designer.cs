namespace GestionComercio
{
    partial class VentanaMarcaModificar
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
            this.lblMarcaTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombreMarca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMarcaTitulo
            // 
            this.lblMarcaTitulo.AutoSize = true;
            this.lblMarcaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaTitulo.Location = new System.Drawing.Point(17, 33);
            this.lblMarcaTitulo.Name = "lblMarcaTitulo";
            this.lblMarcaTitulo.Size = new System.Drawing.Size(87, 18);
            this.lblMarcaTitulo.TabIndex = 19;
            this.lblMarcaTitulo.Text = "ID MARCA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(95, 135);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(192, 69);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMarca.TabIndex = 17;
            this.btnAgregarMarca.Text = "Aceptar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Location = new System.Drawing.Point(26, 106);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(0, 13);
            this.lblNuevaMarca.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "MODIFICAR MARCA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Descripcion:";
            // 
            // tbxNombreMarca
            // 
            this.tbxNombreMarca.Location = new System.Drawing.Point(79, 71);
            this.tbxNombreMarca.Name = "tbxNombreMarca";
            this.tbxNombreMarca.Size = new System.Drawing.Size(100, 20);
            this.tbxNombreMarca.TabIndex = 13;
            // 
            // VentanaMarcaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 164);
            this.Controls.Add(this.lblMarcaTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblNuevaMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNombreMarca);
            this.MaximumSize = new System.Drawing.Size(291, 203);
            this.MinimumSize = new System.Drawing.Size(291, 203);
            this.Name = "VentanaMarcaModificar";
            this.Text = "VentanaMarcaModificar";
            this.Load += new System.EventHandler(this.VentanaMarcaModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarcaTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Label lblNuevaMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombreMarca;
    }
}