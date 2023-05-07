﻿using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class VentanaCategoriaDetalle : Form
    {
        private Categoria categoria;

        public VentanaCategoriaDetalle(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Detalle Categoria " + this.categoria.Descripcion;
        }

        private void VentanaCategoriaDetalle_Load(object sender, EventArgs e)
        {
            lblDetalleCategoria.Text = "Detalle Categoria " + categoria.Descripcion;
            lblDescripcion.Text = categoria.Descripcion;
            lblIdCategoria.Text = categoria.Id.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
