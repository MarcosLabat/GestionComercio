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
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void btnPrevisualizar_Click(object sender, EventArgs e)
        {

        

            txtbPrevisualizar.Text = "Código: " + int.Parse(txtCodigo.Text) + "\nNombre: " + txtNombre.Text + "\nDescripcion: " + txtbDescripcion.Text + "\nMarca: " + cboMarca.Text + "\nCategoria: " + cboCategoria.Text + "\nPrecio: $" + float.Parse(txtPrecio.Text);
            


        }
    }
}
