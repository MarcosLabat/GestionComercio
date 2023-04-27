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
    public partial class AgregarArticulo : Form
    {
        public AgregarArticulo()
        {
            InitializeComponent();
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcas = new MarcaNegocio();
            List<Marca> listaMarcas = marcas.listar();
            foreach (var item in listaMarcas)
            {
                cbxMarca.Items.Add(item);
            }

            CategoriaNegocio categorias = new CategoriaNegocio();
            List<Categoria> listaCategorias = categorias.listar();
            foreach (var item in listaCategorias)
            {
                cbxCategoria.Items.Add(item);
            }
        }


        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && !(e.KeyChar == (char)8 && tbxPrecio.Text.Length > 0))
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = '.';
                if (tbxPrecio.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }


            decimal value;
            if (!decimal.TryParse((sender as TextBox).Text + e.KeyChar, out value))
            {
                MessageBox.Show("Ingrese un valor numérico válido");
                e.Handled = true;
            }
        }

        private void btnVisualizarArticulo_Click(object sender, EventArgs e)
        {
            lvPrevisualizacion.Clear();
            string codigo = tbxCodigo.Text;
            string nombre = tbxNombre.Text;
            string descripcion = rtbxDescripcion.Text;
            string marca = cbxMarca.Text;
            string categoria = cbxCategoria.Text;
            string urlImagen = tbxUrlImagen.Text;

            lvPrevisualizacion.Items.Add("* Codigo: " + codigo);
            lvPrevisualizacion.Items.Add("* Nombre: " + nombre);
            lvPrevisualizacion.Items.Add("* Descripcion: " + descripcion);
            lvPrevisualizacion.Items.Add("* Marca: " + marca);
            lvPrevisualizacion.Items.Add("* Categoria: " + categoria);
            lvPrevisualizacion.Items.Add("* UrlImagen: " + urlImagen);
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = tbxCodigo.Text;
                string nombre = tbxNombre.Text;
                string descripcion = rtbxDescripcion.Text;
                decimal precio = decimal.Parse(tbxPrecio.Text);
                string inMarca = cbxMarca.Text;
                string inCategoria = cbxCategoria.Text;
                string inUrlImagen = tbxUrlImagen.Text;


                MarcaNegocio marcaNegocio = new MarcaNegocio();
                Marca marca = marcaNegocio.buscarPorDescripcion(inMarca);
                if (marca == null)
                {
                    MessageBox.Show("No se ha encontrado una marca con la descripcion: " + inMarca);
                    return;
                }

                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Categoria categoria = categoriaNegocio.buscarPorDescripcion(inCategoria);
                if (categoria == null)
                {
                    MessageBox.Show("No se ha encontrado una categoria con la descripcion: " + inCategoria);
                    return;
                }

                // Guardado de Articulo
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo nuevoArticulo = new Articulo();
                nuevoArticulo.Codigo = codigo;
                nuevoArticulo.Nombre = nombre;
                nuevoArticulo.Descripcion = descripcion;
                nuevoArticulo.Precio = precio;
                nuevoArticulo.Marca = new Marca();
                nuevoArticulo.Marca.Descripcion = marca.Descripcion;
                nuevoArticulo.Marca.Id = marca.Id;
                nuevoArticulo.Categoria = new Categoria();
                nuevoArticulo.Categoria.Descripcion = categoria.Descripcion;
                nuevoArticulo.Categoria.Id = categoria.Id;
                int idArticulo = articuloNegocio.guardar(nuevoArticulo);

                // Guardado de Imagen
                ImagenNegocio imagenNegocio = new ImagenNegocio();
                Imagen nuevaImagen = new Imagen();
                nuevaImagen.IdArticulo = idArticulo;
                nuevaImagen.UrlImagen = inUrlImagen;
                imagenNegocio.guardar(nuevaImagen);

                MessageBox.Show("Guardado Correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
        }


    }
}
