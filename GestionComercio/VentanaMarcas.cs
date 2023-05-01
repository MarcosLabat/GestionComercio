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

        public VentanaMarcas()
        {
            InitializeComponent();
        }

        private void VentanaMarcas_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcas = new MarcaNegocio();
            listaMarcas = marcas.listar();
            dgvMarcas.DataSource = listaMarcas;
        }
    }
}
