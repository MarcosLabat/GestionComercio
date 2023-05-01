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
    public partial class VentanaMarcas : Form
    {
        private List<Marca> listaMarcas;
        private MarcaNegocio marcas = new MarcaNegocio();

        public VentanaMarcas()
        {
            InitializeComponent();
        }

        private void VentanaMarcas_Load(object sender, EventArgs e)
        {
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            string busqueda = tbxBuscador.Text;
            List<Marca> aux = new List<Marca>();
            lblBusqueda.Visible = true;
            Marca marca = marcas.buscarPorDescripcion(busqueda);
            if(marca != null)
            {
                lblBusqueda.ForeColor = Color.Green;
                lblBusqueda.Text = "Marca encontrada";
                aux.Add(marca);
                dgvMarcas.DataSource = aux;
            }
            else
            {
                lblBusqueda.ForeColor = Color.Red;
                lblBusqueda.Text = "Marca no encontrada";
            }
        }

        private void btnResetMarca_Click(object sender, EventArgs e)
        {
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
            lblBusqueda.Visible = false;
        }

        private void btnActualizarMarca_Click(object sender, EventArgs e)
        {
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
            lblBusqueda.Visible = false;
        }
    }
}
