using Dominio;
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
    public partial class VentanaMarcaDetalle : Form
    {
        private Marca marca;

        public VentanaMarcaDetalle(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }

        private void VentanaMarcaDetalle_Load(object sender, EventArgs e)
        {
            lblDetalleMarca.Text = "Detalle Marca " + marca.Descripcion;
            lblIdMarca.Text = marca.Id.ToString();
            lblDescripcion.Text = marca.Descripcion.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
