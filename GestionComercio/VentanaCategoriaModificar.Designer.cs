﻿namespace GestionComercio
{
    partial class VentanaCategoriaModificar
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
            this.lblNuevaMarca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoriaTitulo = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaMarca
            // 
            this.lblNuevaMarca.AutoSize = true;
            this.lblNuevaMarca.Location = new System.Drawing.Point(31, 109);
            this.lblNuevaMarca.Name = "lblNuevaMarca";
            this.lblNuevaMarca.Size = new System.Drawing.Size(0, 13);
            this.lblNuevaMarca.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "MODIFICAR CATEGORIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion:";
            // 
            // tbxNombreCategoria
            // 
            this.tbxNombreCategoria.Location = new System.Drawing.Point(84, 74);
            this.tbxNombreCategoria.Name = "tbxNombreCategoria";
            this.tbxNombreCategoria.Size = new System.Drawing.Size(100, 20);
            this.tbxNombreCategoria.TabIndex = 0;
            // 
            // lblCategoriaTitulo
            // 
            this.lblCategoriaTitulo.AutoSize = true;
            this.lblCategoriaTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaTitulo.Location = new System.Drawing.Point(22, 36);
            this.lblCategoriaTitulo.Name = "lblCategoriaTitulo";
            this.lblCategoriaTitulo.Size = new System.Drawing.Size(124, 18);
            this.lblCategoriaTitulo.TabIndex = 12;
            this.lblCategoriaTitulo.Text = "ID CATEGORIA";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(84, 153);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 26);
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(190, 71);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 24);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // VentanaCategoriaModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 214);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblCategoriaTitulo);
            this.Controls.Add(this.lblNuevaMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxNombreCategoria);
            this.MinimumSize = new System.Drawing.Size(310, 230);
            this.Name = "VentanaCategoriaModificar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentanaCategoriaModificar";
            this.Load += new System.EventHandler(this.VentanaCategoriaModificar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNuevaMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNombreCategoria;
        private System.Windows.Forms.Label lblCategoriaTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAceptar;
    }
}