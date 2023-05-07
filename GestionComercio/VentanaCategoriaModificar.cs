using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class VentanaCategoriaModificar : Form
    {
        private Categoria categoria;
        private CategoriaNegocio categoriaNegocio;

        public VentanaCategoriaModificar(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria " + this.categoria.Descripcion;
            this.categoriaNegocio = new CategoriaNegocio();
        }

        private void VentanaCategoriaModificar_Load(object sender, EventArgs e)
        {
            lblCategoriaTitulo.Text = "ID " + categoria.Id + " " + categoria.Descripcion;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = tbxNombreCategoria.Text;
                int idCategoria = categoria.Id;
                int rowsAffected = categoriaNegocio.modificar(descripcion, idCategoria);
                if (rowsAffected != 1)
                {
                    MessageBox.Show("Algo paso al intentar modificar la categoria");
                    return;
                }

                MessageBox.Show("Categoria modificada correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}
