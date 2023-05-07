using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;

namespace GestionComercio
{
    public partial class MenuPrincipal : Form
    {
        private IconButton btnActual;
        private Panel bordeIzquierdoBtn;
        private Form formularioActual;

        public MenuPrincipal()
        {
            InitializeComponent();
            bordeIzquierdoBtn = new Panel();
            bordeIzquierdoBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(bordeIzquierdoBtn);
            this.Text = string.Empty;
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivarBoton(object senderBtn)
        {
            if(senderBtn != null)
            {
                DesactivarBoton();
                btnActual = (IconButton)senderBtn;
                btnActual.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.HotTrack);
                btnActual.ForeColor = System.Drawing.Color.LightGreen;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = System.Drawing.Color.LightGreen;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;

                bordeIzquierdoBtn.BackColor = System.Drawing.Color.LightGreen;
                bordeIzquierdoBtn.Location = new Point(0, btnActual.Location.Y);
                bordeIzquierdoBtn.Visible = true;
                bordeIzquierdoBtn.BringToFront();

                iconTitulo.IconChar = btnActual.IconChar;
                iconTitulo.IconColor = System.Drawing.Color.LightGreen;
                lblTitulo.Text = btnActual.Text;
            }
        }

        private void DesactivarBoton()
        {
            if(btnActual != null)
            {
                btnActual.BackColor = System.Drawing.Color.FromKnownColor(KnownColor.Highlight);
                btnActual.ForeColor = System.Drawing.Color.White;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = System.Drawing.Color.White;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void AbrirFormulario(Form formulario)
        {
            if(formularioActual != null)
            {
                formularioActual.Close();
            }

            formularioActual = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formulario);
            formulario.BringToFront();
            formulario.Show();
            lblTitulo.Text = formulario.Text;
            
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new Inicio());
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new VentanaArticulos());
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new VentanaMarcas());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            AbrirFormulario(new VentanaCategorias());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender);
            this.Close();
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            formularioActual.Close();
            ResetBotones();
        }

        private void ResetBotones()
        {
            DesactivarBoton();
            bordeIzquierdoBtn.Visible = false;
            iconTitulo.IconChar = IconChar.Home;
            iconTitulo.IconColor = System.Drawing.Color.White;
            lblTitulo.Text = "HOME";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
