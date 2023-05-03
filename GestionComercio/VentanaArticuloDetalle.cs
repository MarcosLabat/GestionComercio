using Dominio;
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
    public partial class VentanaArticuloDetalle : Form
    {
        private Articulo articulo;
        public VentanaArticuloDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo #" + this.articulo.Codigo;
        }

        private void VentanaArticuloDetalle_Load(object sender, EventArgs e)
        {
            cargarImagen(articulo.Imagen.UrlImagen);

            lblDetalleArticulo.Text = "DETALLE ARTICULO # " + articulo.Codigo;
            lblTitulo.Text = articulo.Nombre;
            
            lblCodigo.Text = articulo.Codigo;
            lblNombre.Text = articulo.Nombre;
            lblDescripcion.Text = articulo.Descripcion;
            lblCategoria.Text = articulo.Categoria.Descripcion;
            lblMarca.Text = articulo.Marca.Descripcion;
            lblPrecio.Text = "$" + articulo.Precio.ToString();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArt.Load(imagen);

            }
            catch (Exception)
            {

                pbxArt.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
