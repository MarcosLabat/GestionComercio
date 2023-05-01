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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tsbtnArticulos_Click(object sender, EventArgs e)
        {

            VentanaArticulos panel = new VentanaArticulos();
            panel.MdiParent = this;
            panel.Show();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(VentanaMarcas))
                {
                    return;
                }
            }
            VentanaMarcas marcas = new VentanaMarcas();
            marcas.MdiParent = this;
            marcas.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(VentanaCategorias))
                {
                    return;
                }
            }
            VentanaCategorias categorias = new VentanaCategorias();
            categorias.MdiParent = this;
            categorias.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(VentanaArticulos))
                {
                    return;
                }
            }
            VentanaArticulos articulos = new VentanaArticulos();
            articulos.MdiParent = this;
            articulos.Show();
        }
    }
}
