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
using Negocio;

namespace GestionComercio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void tsBtnListadoArt_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ViewArticulos))
                {
                    return;
                }
            }

            ViewArticulos listado = new ViewArticulos();
            listado.MdiParent = this;
            listado.Show();

        }

        private void tsBtnListaMarcas_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ViewMarcas))
                {
                    return;
                }
            }

            ViewMarcas listado = new ViewMarcas();
            listado.MdiParent = this;
            listado.Show();
        }

        private void tsBtnListaCategoria_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(ViewCategorias))
                {
                    return;
                }
            }
            ViewCategorias listado = new ViewCategorias();
            listado.MdiParent = this;
            listado.Show();
        }
    }
}
