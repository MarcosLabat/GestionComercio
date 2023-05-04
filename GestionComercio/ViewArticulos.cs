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
        private List<Imagen> listaImagenes;
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
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(articuloActual.imagenes[0].ToString());
            maximo = articuloActual.imagenes.Count;
            if(articuloActual.imagenes.Count > 1){
                btnAnt.Visible = true;
                btnSig.Visible = true;
            }
            else{
                btnAnt.Visible = false;
                btnSig.Visible = false;
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {

            if(indice < maximo)
            {
                Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articuloActual.imagenes[indice].ToString());
                indice++;

            }
            else
            {
                MessageBox.Show("No hay mas imagenes");
            }
        }

        private void ViewArticulos_Load(object sender, EventArgs e)
        {
            listaArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = listaArticulos;
            listaImagenes = listaArticulos[0].imagenes;
            pictureBoxArticulos.Load(listaImagenes[0].ToString());
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > minimo)
            {
                Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                indice--;
                cargarImagen(articuloActual.imagenes[indice - 1].ToString());
            }
            else
            {
                MessageBox.Show("No hay mas imagenes");
            }
        }

        private void btnDetalleArt_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(ViewArticuloDetalle))
                {
                    return;
                }
            }
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            ViewArticuloDetalle ventana = new ViewArticuloDetalle();
            ventana.idDetalle = articuloActual.idArticulo.ToString();
            ventana.Show();
        }
    }
}
