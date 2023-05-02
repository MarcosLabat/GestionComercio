using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace GestionComercio
{
    public partial class VentanaCategorias : Form
    {
        private List<Categoria> listaCategorias;
        CategoriaNegocio categorias = new CategoriaNegocio();

        public VentanaCategorias()
        {
            InitializeComponent();
        }

        private void VentanaCategorias_Load(object sender, EventArgs e)
        {
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;
        }

        private void btnResetCategoria_Click(object sender, EventArgs e)
        {
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;
            lblBusqueda.Visible = false;
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;
            lblBusqueda.Visible = false;
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            string busqueda = tbxBuscador.Text;
            List<Categoria> aux = new List<Categoria>();

            lblBusqueda.Visible = true;
            Categoria cat = categorias.buscarPorDescripcion(busqueda);
            if(cat != null)
            {
                lblBusqueda.ForeColor = Color.Green;
                lblBusqueda.Text = "Categoria encontrada";
                aux.Add(cat);
                dgvCategorias.DataSource = aux;
            }
            else
            {
                lblBusqueda.ForeColor = Color.Red;
                lblBusqueda.Text = "Categoria no encontrada";
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            VentanaCategoriaDetalle detalleCategoria = new VentanaCategoriaDetalle(categoria);
            detalleCategoria.ShowDialog();
        }

        private void nuevaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCategoriasAdd agregarCategoria = new VentanaCategoriasAdd();
            agregarCategoria.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            verDetalleToolStripMenuItem_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarToolStripMenuItem_Click(sender, e);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            nuevaCategoriaToolStripMenuItem_Click(sender, e);
        }
    }
}
