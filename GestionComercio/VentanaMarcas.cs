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
            Text = "Marcas";
        }

        private void VentanaMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                listaMarcas = marcas.listar();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnBuscarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                string busqueda = tbxBuscador.Text;
                List<Marca> aux = new List<Marca>();
                lblBusqueda.Visible = true;
                Marca marca = marcas.buscarPorDescripcion(busqueda);
                if (marca != null)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnResetMarca_Click(object sender, EventArgs e)
        {
            VentanaMarcas_Load(sender, e);
            lblBusqueda.Visible = false;
        }

        private void btnActualizarMarca_Click(object sender, EventArgs e)
        {
            VentanaMarcas_Load(sender, e);
            lblBusqueda.Visible = false;
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            VentanaMarcaModificar modificarMarca = new VentanaMarcaModificar(marca);
            modificarMarca.ShowDialog();
            VentanaMarcas_Load(sender, e);
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            VentanaMarcaDetalle detalleMarca = new VentanaMarcaDetalle(marca);
            detalleMarca.ShowDialog();
            VentanaMarcas_Load(sender, e);
        }

        private void nuevaMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaMarcasAdd agregarMarca = new VentanaMarcasAdd();
            agregarMarca.ShowDialog();
            VentanaMarcas_Load(sender, e);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                List <Articulo> lista = articuloNegocio.listarPorMarca(marca.Id);
                if(lista.Count > 0)
                {
                    MessageBox.Show("No se puede eliminar la marca " + marca.Descripcion + ". Existen " + lista.Count + " articulos cargados con esa marca.");
                    return;
                }

                if (MessageBox.Show("¿Seguro desea eliminar la marca " + marca.Descripcion + "?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int rowsAffected = marcas.eliminar(marca.Id);
                    if(rowsAffected == 1)
                        MessageBox.Show("Eliminado correctamente.");
                    else
                        MessageBox.Show("No se pudo eliminar..");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
