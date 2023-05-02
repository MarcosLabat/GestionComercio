using Dominio;
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

namespace GestionComercio
{
    public partial class VentanaArticulos : Form
    {
        private List<Articulo> listaArticulos;
        ArticuloNegocio articulos = new ArticuloNegocio();

        public VentanaArticulos()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            listaArticulos = articulos.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns["Imagen"].Visible = false;

            lblBuscador.Visible = false;
            cbxFiltroArticulos.Items.Add("Sin Filtro");
            cbxFiltroArticulos.Items.Add("Nombre");
            cbxFiltroArticulos.Items.Add("Descripcion");
            cbxFiltroArticulos.Items.Add("Codigo");
            cbxFiltroArticulos.Items.Add("Marca");
            cbxFiltroArticulos.Items.Add("Categoria");
        }

        private void btnActualizarArticulos_Click(object sender, EventArgs e)
        {
            lblBuscador.Visible = false;
            listaArticulos = articulos.listar();
            dgvArticulos.DataSource = listaArticulos;
        }

        private void tsbtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            VentanaArticulosAdd agregarArticulo = new VentanaArticulosAdd();
            agregarArticulo.ShowDialog();
        }

        private void nuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaArticulosAdd agregarArticulo = new VentanaArticulosAdd();
            agregarArticulo.ShowDialog();
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            string filtro = cbxFiltroArticulos.Text;
            string busqueda = tbxBuscadorArticulos.Text;
            if (busqueda.Length == 0) return;
            lblBuscador.Visible = true;

            try
            {
                List<Articulo> aux = articulos.buscar(busqueda, filtro);
                if (aux.Count != 0)
                {
                    lblBuscador.ForeColor = Color.Green;
                    lblBuscador.Text = "Coincidencias encontradas";
                    dgvArticulos.DataSource = aux;
                }
                else
                {
                    lblBuscador.ForeColor = Color.Red;
                    lblBuscador.Text = "No se han encontrado coincidencias";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnResetArticulos_Click(object sender, EventArgs e)
        {
            lblBuscador.Visible = false;
            tbxBuscadorArticulos.Text = "";
            cbxFiltroArticulos.Text = "Sin Filtro";
            listaArticulos = articulos.listar();
            dgvArticulos.DataSource = listaArticulos;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            VentanaArticuloModificar modificarArticulo = new VentanaArticuloModificar(seleccionado);
            modificarArticulo.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            VentanaArticuloEliminar eliminarArticulo = new VentanaArticuloEliminar(seleccionado);
            eliminarArticulo.ShowDialog();
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            VentanaArticuloDetalle detalleArticulo = new VentanaArticuloDetalle(seleccionado);
            detalleArticulo.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }
    }
}
