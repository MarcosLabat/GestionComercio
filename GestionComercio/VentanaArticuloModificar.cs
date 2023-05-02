using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class VentanaArticuloModificar : Form
    {
        private MarcaNegocio marcaNegocio;
        private CategoriaNegocio categoriaNegocio;
        private ArticuloNegocio articuloNegocio;
        private ImagenNegocio imagenNegocio;
        private bool previsualizado;
        private Articulo articulo;


        public VentanaArticuloModificar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            previsualizado = false;
            categoriaNegocio = new CategoriaNegocio();
            marcaNegocio = new MarcaNegocio();
            articuloNegocio = new ArticuloNegocio();
            imagenNegocio = new ImagenNegocio();
        }

        private void VentanaArticuloModificar_Load(object sender, EventArgs e)
        {
            lblCodigoArt.Text = articulo.Codigo;

            tbxCodigo.Visible = false;
            tbxNombre.Visible = false;
            rtbxDescripcion.Visible = false;
            tbxPrecio.Visible = false;
            cbxCategoria.Visible = false;
            cbxMarca.Visible = false;
            tbxUrlImagen.Visible = false;

        }

        private void btnVisualizarArticulo_Click(object sender, EventArgs e)
        {
            lvPrevisualizacion.Clear();
            previsualizado = true;
            string codigo, nombre, descripcion, marca, categoria, precio;

            if (chbxCodigo.Checked) codigo = "Codigo: " + tbxCodigo.Text;
            else codigo = "Codigo: " + articulo.Codigo;

            if (chbxNombre.Checked) nombre = "Nombre: " + tbxNombre.Text;
            else nombre = "Nombre: " + articulo.Nombre;

            if (chbxDescripcion.Checked) descripcion = "Descripcion: " + rtbxDescripcion.Text;
            else descripcion = "Descripcion: " + articulo.Descripcion;

            if (chbxMarca.Checked) marca = "Marca: " + cbxMarca.Text;
            else marca = "Marca: " + articulo.Marca.Descripcion;

            if (chbxCategoria.Checked) categoria = "Categoria: " + cbxCategoria.Text;
            else categoria = "Categoria: " + articulo.Categoria.Descripcion;

            if (chbxPrecio.Checked) precio = "Precio: $" + tbxPrecio.Text;
            else precio = "Precio: $" + articulo.Precio;

            lvPrevisualizacion.Items.Add(codigo);
            lvPrevisualizacion.Items.Add(nombre);
            lvPrevisualizacion.Items.Add(descripcion);
            lvPrevisualizacion.Items.Add(marca);
            lvPrevisualizacion.Items.Add(categoria);
            lvPrevisualizacion.Items.Add(precio);
           
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            if (!previsualizado)
            {
                MessageBox.Show("Previzualiza el articulo antes de modificarlo!");
                return;
            }

            try
            {
                if (chbxCodigo.Checked)
                {
                articulo.Codigo = tbxCodigo.Text;
                }

                if (chbxNombre.Checked)
                {
                    articulo.Nombre = tbxNombre.Text;
                }

                if (chbxDescripcion.Checked)
                {
                    articulo.Descripcion = (string)rtbxDescripcion.Text;
                }

                if (chbxPrecio.Checked)
                {
                    articulo.Precio = decimal.Parse(tbxPrecio.Text);
                }

                if (chbxCategoria.Checked)
                {
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                }

                if (chbxMarca.Checked)
                {
                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                }

                if(chbxImagen.Checked)
                {
                    Imagen imagen = new Imagen();
                    imagen.IdArticulo = articulo.Id;
                    imagen.UrlImagen = tbxUrlImagen.Text;
                    int idImagen = imagenNegocio.guardar(imagen);
                    imagen.Id = idImagen;
                    articulo.Imagen = imagen;
                }

           
                int modificado = articuloNegocio.modificar(articulo);
                if (modificado != 1)
                {
                    MessageBox.Show("No se pudo modificar el articulo");
                    return;
                }

                MessageBox.Show("Articulo modificado correctamente!");
                previsualizado = false;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void chbxCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCodigo.Checked) tbxCodigo.Visible = true;
            else tbxCodigo.Visible = false;
        }

        private void chbxNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxNombre.Checked) tbxNombre.Visible = true;
            else tbxNombre.Visible = false;
        }

        private void chbxDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDescripcion.Checked) rtbxDescripcion.Visible = true;
            else rtbxDescripcion.Visible = false;
        }

        private void chbxPrecio_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxPrecio.Checked) tbxPrecio.Visible = true;
            else tbxPrecio.Visible = false;
        }

        private void chbxCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxCategoria.Checked)
            {
                List<Categoria> listaCategorias = categoriaNegocio.listar();
                foreach (var item in listaCategorias)
                {
                    cbxCategoria.Items.Add(item);
                }
                cbxCategoria.Visible = true;
            }
            else cbxCategoria.Visible = false;
        }

        private void chbxMarca_CheckedChanged(object sender, EventArgs e)
        {

            if (chbxMarca.Checked) 
            {
                List<Marca> listaMarcas = marcaNegocio.listar();
                foreach (var item in listaMarcas)
                {
                    cbxMarca.Items.Add(item);
                }
                cbxMarca.Visible = true;
            }
            else cbxMarca.Visible = false;
        }

        private void chbxImagen_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxImagen.Checked) tbxUrlImagen.Visible = true;
            else tbxUrlImagen .Visible = false;
        }
    }
}
