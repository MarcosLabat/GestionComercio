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
    public partial class ListadoArticulos : Form
    {
        private List<Articulo> articulos;
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void ListadoArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            articulos = articuloNegocio.listarArticulos();
            dgvListadoArticulos.DataSource = articulos;

            pbxUrlImagen.Load(articulos[0].Imagen.UrlImagen);
        }

        private void dgvListadoArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.UrlImagen);
        }

        public void cargarImagen(string url)
        {
            try
            {
                pbxUrlImagen.Load(url);

            }
            catch (Exception)
            {
                pbxUrlImagen.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg"); 
            }
        }
    }
}
