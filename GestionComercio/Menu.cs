using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;
using Dominio;

namespace GestionComercio
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void enviarOpcion_Click(object sender, EventArgs e)
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            ConexionDB consulta = new ConexionDB();
            try
            {
                consulta.setQuery("select A.Id, A.Codigo, A.Nombre, A.Descripcion as AD, A.Precio, M.Descripcion as MD, C.Descripcion as CD from ARTICULOS as A Inner Join MARCAS as M on A.IdMarca = M.Id Inner Join CATEGORIAS as C on A.IdCategoria = C.Id");
                consulta.leerDB();

                while (consulta.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.marca = new Marca();
                    aux.categoria = new Categoria();
                    aux.idArticulo = (int)consulta.Lector["Id"];
                    aux.codigoArticulo = (string)consulta.Lector["Codigo"];
                    aux.nombre = (string)consulta.Lector["Nombre"];
                    aux.descripcion = (string)consulta.Lector["AD"];
                    aux.precio = (decimal)consulta.Lector["Precio"];
                    aux.marca.nombreMarca = (string)consulta.Lector["MD"];
                    aux.categoria.nombreCategoria = (string)consulta.Lector["CD"];

                    listaArticulos.Add(aux);

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                consulta.cerrarConexion();
            }


            dgvArticulos.DataSource = listaArticulos;
        }
    }
}
