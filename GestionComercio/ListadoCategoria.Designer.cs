namespace GestionComercio
{
    partial class ListadoCategoria
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.labelTituloCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(211, 128);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(327, 205);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.Visible = false;
            this.dgvCategoria.VisibleChanged += new System.EventHandler(this.dgvCategoria_VisibleChanged);
            // 
            // labelTituloCat
            // 
            this.labelTituloCat.AutoSize = true;
            this.labelTituloCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCat.Location = new System.Drawing.Point(252, 56);
            this.labelTituloCat.Name = "labelTituloCat";
            this.labelTituloCat.Size = new System.Drawing.Size(262, 42);
            this.labelTituloCat.TabIndex = 1;
            this.labelTituloCat.Text = "CATEGORIAS";
            // 
            // ListadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTituloCat);
            this.Controls.Add(this.dgvCategoria);
            this.Name = "ListadoCategoria";
            this.Text = "ListadoCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label labelTituloCat;
    }
}