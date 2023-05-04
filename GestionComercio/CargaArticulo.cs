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
using Negocio;

namespace GestionComercio
{
    public partial class CargaArticulo : Form
    {
        public CargaArticulo()
        {
            InitializeComponent();
        }

        private void btnPrevisualizar_Click(object sender, EventArgs e)
        {

        

            txtbPrevisualizar.Text = "Código: " + txtCodigo.Text + "\nNombre: " + txtNombre.Text + "\nDescripcion: " + txtbDescripcion.Text + "\nMarca: " + cboMarca.Text + "\nCategoria: " + cboCategoria.Text + "\nPrecio: $" + float.Parse(txtPrecio.Text);
            


        }

        private void btnCargar_Click(object sender, EventArgs e) //chequear la carga de imagen, falta poder asignar varias imagenes a un mismo artículo
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {

                //guardado del articulo
                articulo.Marca = new Marca();
                articulo.Categoria= new Categoria();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtbDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria= (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = float.Parse(txtPrecio.Text);

                int idArticulo = negocio.agregarArticulo(articulo);

                //guardado de la imagen
                Imagen nuevaImagen = new Imagen();
                ImagenNegocio imagenNegocio = new ImagenNegocio();  

                nuevaImagen.UrlImagen = txtUrlImagen.Text;
                nuevaImagen.IdArticulo = idArticulo;
                imagenNegocio.guardar(nuevaImagen);


                MessageBox.Show("Agregado Exitosamente..");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.ToString());
            }
            
        }

        private void Ventana_Load(object sender, EventArgs e) 
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboCategoria.DataSource = categoriaNegocio.listarCategorias();
                cboMarca.DataSource = marcaNegocio.listarMarcas();
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.ToString());
            }

        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        public void cargarImagen(string url)
        {
            try
            {
                pcbImagen.Load(url);

            }
            catch (Exception)
            {
                pcbImagen.Load("https://static.vecteezy.com/system/resources/previews/005/337/799/non_2x/icon-image-not-found-free-vector.jpg");
            }
        }
    }
}
