namespace GestionComercio
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblManu = new System.Windows.Forms.Label();
            this.lblLeo = new System.Windows.Forms.Label();
            this.lblMarcos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KenVector Future", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(75, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(625, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "EQUIPO 12";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconButton1.BackColor = System.Drawing.SystemColors.Desktop;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(274, 548);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(234, 46);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Developers";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // lblManu
            // 
            this.lblManu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblManu.AutoSize = true;
            this.lblManu.Font = new System.Drawing.Font("KenVector Future", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManu.ForeColor = System.Drawing.SystemColors.Control;
            this.lblManu.Location = new System.Drawing.Point(10, 402);
            this.lblManu.Name = "lblManu";
            this.lblManu.Size = new System.Drawing.Size(286, 31);
            this.lblManu.TabIndex = 2;
            this.lblManu.Text = "Manuel Firman";
            // 
            // lblLeo
            // 
            this.lblLeo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLeo.AutoSize = true;
            this.lblLeo.Font = new System.Drawing.Font("KenVector Future", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLeo.Location = new System.Drawing.Point(477, 402);
            this.lblLeo.Name = "lblLeo";
            this.lblLeo.Size = new System.Drawing.Size(281, 31);
            this.lblLeo.TabIndex = 3;
            this.lblLeo.Text = "Leonas Zidonis";
            // 
            // lblMarcos
            // 
            this.lblMarcos.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMarcos.AutoSize = true;
            this.lblMarcos.Font = new System.Drawing.Font("KenVector Future", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMarcos.Location = new System.Drawing.Point(256, 453);
            this.lblMarcos.Name = "lblMarcos";
            this.lblMarcos.Size = new System.Drawing.Size(270, 31);
            this.lblMarcos.TabIndex = 4;
            this.lblMarcos.Text = "Marcos Labat";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(772, 632);
            this.Controls.Add(this.lblMarcos);
            this.Controls.Add(this.lblLeo);
            this.Controls.Add(this.lblManu);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lblManu;
        private System.Windows.Forms.Label lblLeo;
        private System.Windows.Forms.Label lblMarcos;
    }
}