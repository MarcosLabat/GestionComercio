namespace GestionComercio
{
    partial class ViewArticulos
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
            this.pictureBoxArticulos = new System.Windows.Forms.PictureBox();
            this.btnAnt = new System.Windows.Forms.Button();
            this.btnSig = new System.Windows.Forms.Button();
            this.btnDetalleArt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 97);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(715, 251);
            this.dgvArticulos.TabIndex = 8;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Location = new System.Drawing.Point(733, 97);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(317, 251);
            this.pictureBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulos.TabIndex = 10;
            this.pictureBoxArticulos.TabStop = false;
            // 
            // btnAnt
            // 
            this.btnAnt.Location = new System.Drawing.Point(733, 366);
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Size = new System.Drawing.Size(88, 30);
            this.btnAnt.TabIndex = 11;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Visible = false;
            this.btnAnt.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSig
            // 
            this.btnSig.Location = new System.Drawing.Point(962, 366);
            this.btnSig.Name = "btnSig";
            this.btnSig.Size = new System.Drawing.Size(88, 30);
            this.btnSig.TabIndex = 12;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = true;
            this.btnSig.Visible = false;
            this.btnSig.Click += new System.EventHandler(this.btnSig_Click);
            // 
            // btnDetalleArt
            // 
            this.btnDetalleArt.Location = new System.Drawing.Point(733, 68);
            this.btnDetalleArt.Name = "btnDetalleArt";
            this.btnDetalleArt.Size = new System.Drawing.Size(101, 23);
            this.btnDetalleArt.TabIndex = 13;
            this.btnDetalleArt.Text = "Ver Detalle";
            this.btnDetalleArt.UseVisualStyleBackColor = true;
            this.btnDetalleArt.Click += new System.EventHandler(this.btnDetalleArt_Click);
            // 
            // ViewArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.btnDetalleArt);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.pictureBoxArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "ViewArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.ViewArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pictureBoxArticulos;
        private System.Windows.Forms.Button btnAnt;
        private System.Windows.Forms.Button btnSig;
        private System.Windows.Forms.Button btnDetalleArt;
    }
}