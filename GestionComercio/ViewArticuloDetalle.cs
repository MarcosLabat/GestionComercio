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
    public partial class ViewArticuloDetalle : Form
    {
        private Articulo articulo = new Articulo();
        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        private int indice = 1;
        private int minimo = 1;
        private int maximo;
        public string idDetalle { get; set; }
        public ViewArticuloDetalle()
        {
            InitializeComponent();
        }

        private void ViewArticuloDetalle_Load(object sender, EventArgs e)
        {
            articulo = articuloNegocio.detalleArticulo(idDetalle);
            maximo = articulo.imagenes.Count;
            labelValorNombre.Text = articulo.nombre;
            labelValorCodigo.Text = articulo.codigoArticulo;
            labelValorPrecio.Text = articulo.precio.ToString();
            labelValorMarca.Text = articulo.marca.ToString();
            labelValorCat.Text = articulo.categoria.ToString();
            cargarImagen(articulo.imagenes[0].ToString());
            if (articulo.imagenes.Count > 1)
            {
                btnAnt.Visible = true;
                btnSig.Visible = true;
            }
            else
            {
                btnAnt.Visible = false;
                btnSig.Visible = false;
            }
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            if(indice < maximo){
                cargarImagen(articulo.imagenes[indice].ToString());
                indice++;
            }
            else{
                MessageBox.Show("No hay mas imagenes");
            }
        }

        private void btnAnt_Click(object sender, EventArgs e){
            if(indice > minimo)
            {
                indice--;
                cargarImagen(articulo.imagenes[indice - 1].ToString());
            }
            else
            {
                MessageBox.Show("No hay mas imagenes");
            }
        }

        private void cargarImagen(string url){
            try
            {
                pxbDetalleArt.Load(url);
            }
            catch (Exception)
            {
                pxbDetalleArt.Load("https://www.shutterstock.com/image-vector/ui-image-placeholder-wireframes-apps-260nw-1037719204.jpg");
            }
        }

    }
}
