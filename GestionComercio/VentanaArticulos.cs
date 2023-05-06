using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionComercio
{
    public partial class VentanaArticulos : Form
    {
        private List<Articulo> listaArticulos;
        ArticuloNegocio articulos = new ArticuloNegocio();
        Articulo seleccionado;
        private int countPic;

        public VentanaArticulos()
        {
            InitializeComponent();
            Text = "Articulos";
            this.countPic = 0;
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            try
            {
                listaArticulos = articulos.listar();
                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            lblFotos.Text = "Foto " + (countPic + 1) + " / " + seleccionado.Imagen.Count;


            lblBuscadorRespuesta.Visible = false;
            lblBuscadorRapido.Visible = false;
            tbxBuscadorRapido.Visible = false;

            cbxFiltroArticulos.Items.Clear();
            cbxFiltroArticulos.Items.Add("Sin Filtro");
            cbxFiltroArticulos.Items.Add("Nombre");
            cbxFiltroArticulos.Items.Add("Descripcion");
            cbxFiltroArticulos.Items.Add("Codigo");
            cbxFiltroArticulos.Items.Add("Marca");
            cbxFiltroArticulos.Items.Add("Categoria");

            dgvArticulos.Columns["Precio"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
        }

        private void btnActualizarArticulos_Click(object sender, EventArgs e)
        {
            lblBuscadorRespuesta.Visible = false;
            try
            {
                listaArticulos = articulos.listar();
                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void tsbtnAgregarArticulo_Click(object sender, EventArgs e)
        {
            VentanaArticulosAdd agregarArticulo = new VentanaArticulosAdd();
            agregarArticulo.ShowDialog();
            Panel_Load(sender, e);
        }

        private void nuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaArticulosAdd agregarArticulo = new VentanaArticulosAdd();
            agregarArticulo.ShowDialog();
            Panel_Load(sender, e);
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            string filtro = cbxFiltroArticulos.Text;
            string busqueda = tbxBuscadorArticulos.Text;
            if (busqueda.Length == 0) return;
            lblBuscadorRespuesta.Visible = true;

            try
            {
                List<Articulo> aux = articulos.buscar(busqueda, filtro);
                if (aux.Count != 0)
                {
                    lblBuscadorRespuesta.ForeColor = Color.Green;
                    lblBuscadorRespuesta.Text = "Coincidencias encontradas";
                    dgvArticulos.DataSource = aux;
                }
                else
                {
                    lblBuscadorRespuesta.ForeColor = Color.Red;
                    lblBuscadorRespuesta.Text = "No se han encontrado coincidencias";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnResetArticulos_Click(object sender, EventArgs e)
        {
            lblBuscadorRespuesta.Visible = false;
            tbxBuscadorArticulos.Text = "";
            cbxFiltroArticulos.Text = "Sin Filtro";
            try
            {
                listaArticulos = articulos.listar();
                dgvArticulos.DataSource = listaArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            VentanaArticuloModificar modificarArticulo = new VentanaArticuloModificar(seleccionado);
            modificarArticulo.ShowDialog();
            Panel_Load(sender, e);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            VentanaArticuloEliminar eliminarArticulo = new VentanaArticuloEliminar(seleccionado);
            eliminarArticulo.ShowDialog();
            Panel_Load(sender, e);
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            VentanaArticuloDetalle detalleArticulo = new VentanaArticuloDetalle(seleccionado);
            detalleArticulo.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            countPic = 0;
            if(seleccionado.Imagen.Count != 0)
            {
                cargarImagen(seleccionado.Imagen.First().UrlImagen);
                lblFotos.Text = "Foto " + (countPic + 1) + " / " + seleccionado.Imagen.Count;
            }
            else 
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarToolStripMenuItem_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificarToolStripMenuItem_Click(sender, e);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            verDetalleToolStripMenuItem_Click(sender, e);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevoArticuloToolStripMenuItem_Click(sender, e);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void btnFotoDer_Click(object sender, EventArgs e)
        {
            int cantImagenes = seleccionado.Imagen.Count;
            if (cantImagenes > 0)
            {
                if (countPic < cantImagenes - 1)
                countPic++;
                else
                    countPic = 0;

                lblFotos.Text = "Foto " + (countPic + 1) + " / " + seleccionado.Imagen.Count;
                if (seleccionado.Imagen.Count > 0)
                    cargarImagen(seleccionado.Imagen[countPic].UrlImagen);
            }
            else
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
            }
        }

        private void btnFotoIzq_Click(object sender, EventArgs e)
        {
            int cantImagenes = seleccionado.Imagen.Count;
            if (cantImagenes > 0)
            {
                if (countPic > 0) countPic--;
                else if (countPic == 0)
                    countPic = cantImagenes - 1;

                lblFotos.Text = "Foto " + (countPic + 1) + " / " + seleccionado.Imagen.Count;
                cargarImagen(seleccionado.Imagen[countPic].UrlImagen);
            }
            else
            {
                cargarImagen("asd");
                lblFotos.Text = "Foto 0 / 0";
            }
            
        }


        private void chbxFiltroRapido_CheckedChanged(object sender, EventArgs e)
        {
            if(chbxFiltroRapido.Checked)
            {
                lblBuscadorRapido.Visible = true;
                tbxBuscadorRapido.Visible = true;

                lblBuscador.Visible = false;
                lblFiltrarPor.Visible = false;
                tbxBuscadorArticulos.Visible = false;
                cbxFiltroArticulos.Visible = false;
                btnBuscarArticulo.Visible = false;
                btnResetArticulos.Visible = false;
            }
            else
            {
                lblBuscadorRapido.Visible = false;
                tbxBuscadorRapido.Visible = false;

                lblBuscador.Visible = true;
                lblFiltrarPor.Visible = true;
                tbxBuscadorArticulos.Visible = true;
                cbxFiltroArticulos.Visible = true;
                btnBuscarArticulo.Visible = true;
                btnResetArticulos.Visible = true;
            }
        }

        private void tbxBuscadorRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            string busqueda = tbxBuscadorRapido.Text;
            if(busqueda.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(art => 
                    art.Nombre.ToUpper().Contains(busqueda.ToUpper()) || 
                    art.Descripcion.ToUpper().Contains(busqueda.ToUpper()) ||
                    art.Codigo.ToUpper().Contains(busqueda.ToUpper()) ||
                    art.Categoria.Descripcion.ToUpper().Contains(busqueda.ToUpper()) ||
                    art.Marca.Descripcion.ToUpper().Contains(busqueda.ToUpper())
                );
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
        }
    }
}
