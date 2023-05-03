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
    public partial class ViewMarcas : Form
    {
        private List<Marca> listaMarcas;
        private MarcaNegocio marcaNegocio = new MarcaNegocio();
        public ViewMarcas()
        {
            InitializeComponent();
            dgvMarcas.Visible = true;
        }

        private void dgvMarcas_VisibleChanged(object sender, EventArgs e)
        {
            listaMarcas = marcaNegocio.listar();
            dgvMarcas.DataSource = listaMarcas;
        }
    }
}
