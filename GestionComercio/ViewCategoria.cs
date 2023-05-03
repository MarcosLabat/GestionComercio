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
    public partial class ViewCategorias : Form
    {
        private List<Dominio.Categoria> listadoCategorias;
        private CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        public ViewCategorias()
        {
            InitializeComponent();
            dgvCategoria.Visible = true;
        }

        private void dgvCategoria_VisibleChanged(object sender, EventArgs e)
        {
            listadoCategorias = categoriaNegocio.listar();
            dgvCategoria.DataSource = listadoCategorias;

        }
    }
}
