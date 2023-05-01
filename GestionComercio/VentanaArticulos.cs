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
            AgregarArticulo agregarArticulo = new AgregarArticulo();
            agregarArticulo.ShowDialog();
        }

        private void nuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregarArticulo = new AgregarArticulo();
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

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
