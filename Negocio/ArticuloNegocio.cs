using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Windows.Forms;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List <Articulo> articulos = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();


            try
            {
                accesoDatos.setearQuery("select A.Id as idArticulo,A.Codigo,A.Nombre,A.Descripcion as AD,A.Precio,M.Descripcion as MD,M.Id as IdMarca,C.Id as IdCategoria ,C.Descripcion as CD, I.ImagenUrl as UrlImagen from ARTICULOS A\r\ninner JOIN MARCAS M on A.IdMarca=M.Id\r\nINNER join CATEGORIAS C on C.Id = A.IdCategoria\r\ninner join IMAGENES I on I.IdArticulo = A.Id");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo auxarticulo = new Articulo();
                    auxarticulo.Marca = new Marca();
                    auxarticulo.Categoria = new Categoria();
                    auxarticulo.Imagen = new Imagen();

                    auxarticulo.Id = (int)accesoDatos.Lector["idArticulo"];
                    auxarticulo.Codigo = (string)accesoDatos.Lector["Codigo"];
                    auxarticulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    auxarticulo.Descripcion = (string)accesoDatos.Lector["AD"];
                    auxarticulo.Precio = (float)accesoDatos.Lector.GetDecimal(4);
                    auxarticulo.Marca.IdMarca = (int)accesoDatos.Lector["IdMarca"];
                    auxarticulo.Marca.Descripcion = (string)accesoDatos.Lector["MD"];
                    auxarticulo.Categoria.IdCategoria = (int)accesoDatos.Lector["IdCategoria"];
                    auxarticulo.Categoria.Descripcion = (string)accesoDatos.Lector["CD"];
                    auxarticulo.Imagen.UrlImagen = (string)accesoDatos.Lector["UrlImagen"];
                    articulos.Add(auxarticulo);
                }

                return articulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }

        public int agregarArticulo(Articulo nuevoArticulo)
        {

            int idArticulo = -1;
            string codigo = nuevoArticulo.Codigo;
            string nombre = nuevoArticulo.Nombre;
            string descripcion = nuevoArticulo.Descripcion;
            int idMarca = nuevoArticulo.Marca.IdMarca;
            int idCategoria = nuevoArticulo.Categoria.IdCategoria;
            decimal precio = (decimal)nuevoArticulo.Precio;

            string query = $"INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES(@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @precio);" + "SELECT CAST(SCOPE_IDENTITY() AS INT) AS ID;";
            AccesoDatos db = new AccesoDatos();

            try
            {
                db.setearQuery(query);
                db.setearParametro("@nombre", nombre);
                db.setearParametro("@codigo", codigo);
                db.setearParametro("@descripcion", descripcion);
                db.setearParametro("@precio", precio);
                db.setearParametro("@idCategoria", idCategoria);
                db.setearParametro("@idMarca", idMarca);
                db.ejecutarLectura();


                if (db.Lector.Read())
                {
                    idArticulo = (int)db.Lector["ID"];
                }

                return idArticulo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                db.cerrarConexion();
            }
        }


        public void modificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("update ARTICULOS SET  Codigo = @codigo,Nombre = @nombre, Descripcion = @descrip, IdMarca = @idMarca, IdCategoria = @idCat,Precio = @precio where Id = @idArticulo");
                datos.setearParametro("@codigo", articulo.Codigo);
                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@descrip", articulo.Descripcion);
                datos.setearParametro("@idMarca", articulo.Marca.IdMarca);
                datos.setearParametro("@idCat", articulo.Categoria.IdCategoria);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@idArticulo", articulo.Id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("DELETE from ARTICULOS where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
