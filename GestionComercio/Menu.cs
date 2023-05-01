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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(txtOpcion.Text == "" || txtOpcion.Text != "1")
            {
                MessageBox.Show("NO SE PUEDE DEJAR EL CAMPO VACIO O SE INGRESO UNA OPCION INCORRECTA");
                return;
            }

            foreach (var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(ListadoArticulos))
                {
                    return;
                }
            }

            ListadoArticulos listado = new ListadoArticulos();
            listado.Show();
        }
    }
}
