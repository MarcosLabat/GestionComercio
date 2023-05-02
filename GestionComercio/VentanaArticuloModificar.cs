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

            previsualizado = true;
            string codigo, nombre, descripcion, marca, categoria, precio;

            if (chbxCodigo.Checked) codigo = "Codigo: " + tbxCodigo.Text;
            else codigo = "Codigo: " + articulo.Codigo;

            if (chbxNombre.Checked) nombre = "Nombre: " + tbxNombre.Text;
            else nombre = "Nombre: " + articulo.Nombre;

            if (chbxDescripcion.Checked) descripcion = "Descripcion: " + rtbxDescripcion;
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
                MessageBox.Show("Previzualiza el Articulo antes de modificarlo!");
                return;
            }

            List<SqlParameter> parametros = new List<SqlParameter>();

            if (chbxCodigo.Checked)
            {
                SqlParameter codigoParam = new SqlParameter("@codigo", tbxCodigo.Text);
                parametros.Add(codigoParam);
            }

            if (chbxNombre.Checked)
            {
                SqlParameter nombreParam = new SqlParameter("@nombre", tbxNombre.Text);
                parametros.Add(nombreParam);
            }

            if (chbxDescripcion.Checked)
            {
                SqlParameter descripcionParam = new SqlParameter("@descripcion", rtbxDescripcion.Text);
                parametros.Add(descripcionParam);
            }

            if (chbxPrecio.Checked)
            {
                SqlParameter precioParam = new SqlParameter("@precio", tbxPrecio.Text);
                parametros.Add(precioParam);
            }

            if (chbxCategoria.Checked)
            {
                Categoria cat = categoriaNegocio.buscarPorDescripcion(cbxCategoria.Text);
                int idCategoria = cat.Id;
                SqlParameter categoriaParam = new SqlParameter("@categoria", idCategoria);
                parametros.Add(categoriaParam);
            }

            if (chbxMarca.Checked)
            {
                Marca marca = marcaNegocio.buscarPorDescripcion(cbxMarca.Text);
                int idMarca = marca.Id;
                SqlParameter marcaParam = new SqlParameter("@marca", idMarca);
                parametros.Add(marcaParam);
            }

            if(chbxImagen.Checked)
            {
                
                Imagen imagen = new Imagen();
                imagen.IdArticulo = articulo.Id;
                imagen.UrlImagen = tbxUrlImagen.Text;
                imagenNegocio.guardar(imagen);
            }

            SqlParameter idParam = new SqlParameter("@id", articulo.Id);
            parametros.Add(idParam);

            try
            {
                int modificado = articuloNegocio.modificar(articulo, parametros);
                if (modificado != 1)
                {
                    MessageBox.Show("No se pudo modificar el articulo");
                    return;
                }

                MessageBox.Show("Articulo modificado correctamente!");
                previsualizado = false;
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
