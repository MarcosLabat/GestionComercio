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
    public partial class Panel : Form
    {
        private List<Articulo> listaArticulos;
        private List<Categoria> listaCategorias;
        private List<Marca> listaMarcas;

        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articulos = new ArticuloNegocio();
            listaArticulos = articulos.listar();
            dgvArticulos.DataSource = listaArticulos;

            CategoriaNegocio categorias = new CategoriaNegocio();
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;

            MarcaNegocio marcas = new MarcaNegocio();
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void btnActualizarArticulos_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articulos = new ArticuloNegocio();
            listaArticulos = articulos.listar();
            dgvArticulos.DataSource = listaArticulos;

            CategoriaNegocio categorias = new CategoriaNegocio();
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;

            MarcaNegocio marcas = new MarcaNegocio();
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void tsbtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            AgregarArticulo agregarArticulo = new AgregarArticulo();
            agregarArticulo.ShowDialog();
        }
    }
}
