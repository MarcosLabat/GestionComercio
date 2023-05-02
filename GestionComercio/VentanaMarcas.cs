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

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            //VentanaMarcaModificar modificarMarca = new VentanaMarcaModificar(marca);
            //modificarMarca.ShowDialog();
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            VentanaMarcaDetalle detalleMarca = new VentanaMarcaDetalle(marca);
            detalleMarca.ShowDialog();
        }

        private void nuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMarcasAdd agregarMarca = new VentanaMarcasAdd();
            agregarMarca.ShowDialog();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            verDetalleToolStripMenuItem_Click(sender, e);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            nuevaMarcaToolStripMenuItem_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarToolStripMenuItem_Click(sender, e);
        }
    }
}
