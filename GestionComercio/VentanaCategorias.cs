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
using Dominio;

namespace GestionComercio
{
    public partial class VentanaCategorias : Form
    {
        private List<Categoria> listaCategorias;
        CategoriaNegocio categorias = new CategoriaNegocio();

        public VentanaCategorias()
        {
            InitializeComponent();
        }

        private void VentanaCategorias_Load(object sender, EventArgs e)
        {
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;
        }

        private void btnResetCategoria_Click(object sender, EventArgs e)
        {
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            listaCategorias = categorias.listar();
            dgvCategorias.DataSource = listaCategorias;
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            string busqueda = tbxBuscador.Text;
            
            List<Categoria> aux = new List<Categoria>();
            Categoria cat = categorias.buscarPorDescripcion(busqueda);
            if(cat != null)
            {
                lblBusqueda.ForeColor = Color.Green;
                lblBusqueda.Text = "Categoria encontrada";
                listaCategorias.Clear();
                aux.Add(cat);
                listaCategorias = aux;
                dgvCategorias.DataSource = listaCategorias;
            }
            else
            {
                lblBusqueda.ForeColor = Color.Red;
                lblBusqueda.Text = "Categoria no encontrada";
            }
        }
    }
}
