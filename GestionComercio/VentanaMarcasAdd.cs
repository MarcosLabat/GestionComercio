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
    public partial class VentanaMarcasAdd : Form
    {
        public VentanaMarcasAdd()
        {
            InitializeComponent();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            string descripcion = tbxNombreMarca.Text;
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            Marca aux = marcaNegocio.buscarPorDescripcion(descripcion);
            if(aux != null)
            {
                lblNuevaMarca.Text = $"Ya existe una marca con el nombre '{descripcion}'";
                lblNuevaMarca.ForeColor = Color.Red;
                return;
            }

            int ok = marcaNegocio.guardar(descripcion);
            if(ok == -1)
            {
                lblNuevaMarca.Text = $"No se pudo guardar la marca '{descripcion}'";
                lblNuevaMarca.ForeColor = Color.Red;
                return;
            }

            lblNuevaMarca.ForeColor = Color.Green;
            lblNuevaMarca.Text = "Marca guardada correctamente!";
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
