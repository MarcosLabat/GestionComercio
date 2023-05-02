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
    public partial class VentanaCategoriasAdd : Form
    {
        public VentanaCategoriasAdd()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                string descripcion = tbxNombreCategoria.Text;
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                Categoria aux = categoriaNegocio.buscarPorDescripcion(descripcion);
                if (aux != null)
                {
                    lblNuevaMarca.Text = $"Ya existe una categoria con el nombre '{descripcion}'";
                    lblNuevaMarca.ForeColor = Color.Red;
                    return;
                }

                int ok = categoriaNegocio.guardar(descripcion);
                if (ok == -1)
                {
                    lblNuevaMarca.Text = $"No se pudo guardar la categoria '{descripcion}'";
                    lblNuevaMarca.ForeColor = Color.Red;
                    MessageBox.Show("No se pudo guardar la categoria!");
                    return;
                }

                lblNuevaMarca.ForeColor = Color.Green;
                lblNuevaMarca.Text = "Categoria guardada correctamente!";
                MessageBox.Show("Categoria guardada correctamente!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
