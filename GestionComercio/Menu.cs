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


        private void tsbtnArticulos_Click_1(object sender, EventArgs e)
        {
            verArticulosToolStripMenuItem_Click(sender, e);
        }


        private void tsbtnMarcas_Click(object sender, EventArgs e)
        {
            verMarcasToolStripMenuItem_Click(sender, e);
        }


        private void tsbtnCategorias_Click(object sender, EventArgs e)
        {
            verCategoríasToolStripMenuItem_Click(sender, e);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verArticulosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void verMarcasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void verCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void nuevoArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaArticulosAdd nuevoArticulo = new VentanaArticulosAdd();
            nuevoArticulo.ShowDialog();
        }

        private void nuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMarcasAdd nuevaMarca = new VentanaMarcasAdd();
            nuevaMarca.ShowDialog();
        }

        private void nuevaCategoríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaCategoriasAdd nuevaCategoria = new VentanaCategoriasAdd();
            nuevaCategoria.ShowDialog();
        }
    }
}
