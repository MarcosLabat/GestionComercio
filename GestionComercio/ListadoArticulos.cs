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
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        public ListadoArticulos()
        {
            InitializeComponent();
            dgvArticulos.Visible = true;
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

        private void dgvArticulos_VisibleChanged(object sender, EventArgs e)
        {
            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            dgvArticulos.Columns[7].Visible = false;
            pictureBoxArticulos.Load(listaArticulos[0].imagen.imagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articuloActual.imagen.imagenUrl);
        }

        private void btnSig_Click(object sender, EventArgs e)
        {

        }
    }
}
