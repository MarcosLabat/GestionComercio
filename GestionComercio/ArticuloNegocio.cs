using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GestionComercio
{
    internal class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select A.Codigo,A.Nombre,A.Descripcion as AD,A.Precio,M.Descripcion as MD,C.Descripcion as CD, I.ImagenUrl as UrlImagen from ARTICULOS A\r\ninner JOIN MARCAS M on A.IdMarca=M.Id\r\nINNER join CATEGORIAS C on C.Id = A.IdCategoria\r\ninner join IMAGENES I on I.IdArticulo = A.Id";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while(lector.Read())
                {
                    Articulo auxarticulo = new Articulo();
                    auxarticulo.Marca = new Marca();   
                    auxarticulo.Categoria = new Categoria();
                    auxarticulo.Imagen = new Imagen();

                    auxarticulo.Codigo = (string)lector["Codigo"];
                    auxarticulo.Nombre = (string)lector["Nombre"];
                    auxarticulo.Descripcion = (string)lector["AD"];
                    auxarticulo.Precio = (float)lector.GetDecimal(3);
                    auxarticulo.Marca.Descripcion = (string)lector["MD"];
                    auxarticulo.Categoria.Descripcion = (string)lector["CD"];
                    auxarticulo.Imagen.UrlImagen = (string)lector["UrlImagen"];
                    articulos.Add(auxarticulo);

                }
                conexion.Close();
                return articulos;
            }
            catch (Exception)
            {

                throw;
            }




        }
    }
}
