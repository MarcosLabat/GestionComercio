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
    public partial class ListadoArticulos : Form
    {
        private List<Articulo> listaArticulos;
        public ListadoArticulos()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            pictureBoxArticulos.Load(listaArticulos[0].imagen.imagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articuloActual.imagen.imagenUrl);
        }

        private void cargarImagen(string url)
        {
            try
            {
                pictureBoxArticulos.Load(url);
            }
            catch (Exception)
            {
                pictureBoxArticulos.Load("https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
            }
        }
    }
}
