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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(lblMarcos.Visible)
            {
                lblManu.Visible = false;
                lblLeo.Visible = false;
                lblMarcos.Visible = false;
            }
            else
            {
                lblManu.Visible = true;
                lblLeo.Visible = true;
                lblMarcos.Visible = true;
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblManu.Visible = false;
            lblLeo.Visible = false;
            lblMarcos.Visible = false;
        }
    }
}
