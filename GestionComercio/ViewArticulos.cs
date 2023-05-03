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
    public partial class ViewArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private List<Imagen> listaIamgenes;
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private int indice = 1;
        private int maximo;
        private int minimo = 1;
        public ViewArticulos()
        {
            InitializeComponent();
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            indice = 1;
            prueba.Text = indice.ToString();
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articuloActual.imagenes[0].ToString());
            maximo = articuloActual.imagenes.Count;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {

            if(indice < maximo)
            {
                Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articuloActual.imagenes[indice].ToString());
                indice++;
                prueba.Text = indice.ToString();

            }
            else
            {
                MessageBox.Show("NO SE PUEDE IR MAS ADELANTE");
            }
        }

        private void ViewArticulos_Load(object sender, EventArgs e)
        {
            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            listaIamgenes = listaArticulos[0].imagenes;
            pictureBoxArticulos.Load(listaIamgenes[0].ToString());
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > minimo)
            {
                Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                indice--;
                cargarImagen(articuloActual.imagenes[indice - 1].ToString());
                prueba.Text = indice.ToString();
            }
            else
            {
                MessageBox.Show("NO SE PUEDE IR MAS ATRAS");
            }
        }
    }
}
