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
            Text = "Categorias";
        }

        private void VentanaCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                listaCategorias = categorias.listar();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentanaCategoriasAdd agregarCategoria = new VentanaCategoriasAdd();
            agregarCategoria.ShowDialog();
            VentanaCategorias_Load(sender, e);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            VentanaCategoriaModificar modificarCategoria = new VentanaCategoriaModificar(categoria);
            modificarCategoria.ShowDialog();
            VentanaCategorias_Load(sender, e);
        }

        private void btnDetalle_Click_1(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            VentanaCategoriaDetalle detalleCategoria = new VentanaCategoriaDetalle(categoria);
            detalleCategoria.ShowDialog();
            VentanaCategorias_Load(sender, e);
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                List<Articulo> lista = articuloNegocio.listarPorCategoria(categoria.Id);
                if (lista.Count > 0)
                {
                    MessageBox.Show("No se puede eliminar la categoria " + categoria.Descripcion + ". Existen " + lista.Count + " articulos cargados con esa categoria.");
                    return;
                }

                if (MessageBox.Show("¿Seguro desea eliminar la categoria " + categoria.Descripcion + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowsAffected = categorias.eliminar(categoria.Id);
                    if (rowsAffected == 1)
                        MessageBox.Show("Eliminado correctamente.");
                    else
                        MessageBox.Show("No se pudo eliminar..");
                }
                VentanaCategorias_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        private void btnBuscarCategoria_Click_1(object sender, EventArgs e)
        {
            try
            {
                string busqueda = tbxBuscador.Text;
                List<Categoria> aux = new List<Categoria>();
                lblBusqueda.Visible = true;
                Categoria cat = categorias.buscarPorDescripcion(busqueda);
                if (cat != null)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnResetCategoria_Click_1(object sender, EventArgs e)
        {
            VentanaCategorias_Load(sender, e);
            lblBusqueda.Visible = false;

        }

        private void btnActualizarCategoria_Click_1(object sender, EventArgs e)
        {
            VentanaCategorias_Load(sender, e);
            lblBusqueda.Visible = false;
        }
    }
}
