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
    public partial class VentanaArticuloEliminar : Form
    {
        private Articulo articulo;
        private ArticuloNegocio articuloNegocio;
        private ImagenNegocio imagenNegocio;

        public VentanaArticuloEliminar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Eliminar Articulo #" + this.articulo.Codigo;
            articuloNegocio = new ArticuloNegocio();
            imagenNegocio = new ImagenNegocio();
        }

        private void VentanaArticuloEliminar_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "Se eliminara el articulo #" + articulo.Codigo;
            lblAdvertencia.Text = articulo.Nombre + " " + articulo.Descripcion;
            lblNombre.Text = articulo.Nombre;
            lblCodigo.Text = articulo.Codigo;
            lblDescripcion.Text = articulo.Descripcion;
            lblPrecio.Text = articulo.Precio.ToString();
            lblMarca.Text = articulo.Marca.Descripcion;
            lblCategoria.Text = articulo.Categoria.Descripcion;
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro desea eliminar el articulo #" + articulo.Codigo + " " + articulo.Nombre + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int imgRows = imagenNegocio.eliminar(articulo.Id);
                    int rowsAffected = articuloNegocio.eliminar(articulo.Id);
                    if (rowsAffected == 1 && imgRows == 1)
                    {
                        MessageBox.Show("Eliminado correctamente");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Algo ha ocurrido al intentar eliminar el articulo");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else
            {
                this.Close();
                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
