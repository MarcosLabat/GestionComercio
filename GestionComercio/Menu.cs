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
                if (item.GetType() == typeof(ListadoArticulos))
                {
                    return;
                }
            }

            ListadoArticulos listado = new ListadoArticulos();
            listado.MdiParent = this;
            listado.Show();

        }

        private void tsBtnListaMarcas_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ListadoMarcas))
                {
                    return;
                }
            }

            ListadoMarcas listado = new ListadoMarcas();
            listado.MdiParent = this;
            listado.Show();
        }

        private void tsBtnListaCategoria_Click(object sender, EventArgs e)
        {
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(ListadoCategoria))
                {
                    return;
                }
            }
            ListadoCategoria listado = new ListadoCategoria();
            listado.MdiParent = this;
            listado.Show();
        }
    }
}
