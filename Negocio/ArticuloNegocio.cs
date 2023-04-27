using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DB;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            ConexionDB datos = new ConexionDB();

            try
            {
                datos.setearQuery("SELECT A.*, M.Descripcion AS Desc_Marca, C.Descripcion AS Desc_Categoria, I.ImagenUrl AS ImagenUrl, I.Id AS IdImagen FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN IMAGENES I ON A.Id = I.IdArticulo");
                datos.leer();
                while (datos.Reader.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    //aux.Imagen = new Imagen();

                    aux.Id = (int)datos.Reader["Id"];
                    aux.Codigo = (string)datos.Reader["Codigo"];
                    aux.Nombre = (string)datos.Reader["Nombre"];
                    aux.Descripcion = (string)datos.Reader["Descripcion"];
                    aux.Precio = (decimal)datos.Reader["Precio"];

                    aux.Marca.Descripcion = (string)datos.Reader["Desc_Marca"];
                    aux.Marca.Id = (int)datos.Reader["IdMarca"];

                    aux.Categoria.Descripcion = (string)datos.Reader["Desc_Categoria"];
                    aux.Categoria.Id = (int)datos.Reader["IdCategoria"];

                    //aux.Imagen.Id = (int)datos.Reader["IdImagen"];
                    //aux.Imagen.UrlImagen = (string)datos.Reader["ImagenUrl"];
                    //aux.Imagen.IdArticulo = (int)datos.Reader["Id"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrar();
            }
        }

        public int guardar(Articulo nuevoArticulo)
        {
            int idArticulo = -1;
            string codigo = nuevoArticulo.Codigo;
            string nombre = nuevoArticulo.Nombre;
            string descripcion = nuevoArticulo.Descripcion;
            int idMarca = nuevoArticulo.Marca.Id;
            int idCategoria = nuevoArticulo.Categoria.Id;
            decimal precio = nuevoArticulo.Precio;

            ConexionDB db = new ConexionDB();
            try
            {
                db.setearQuery($"INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES('{codigo}', '{nombre}', '{descripcion}', '{idMarca}', '{idCategoria}', '{precio}');" + "SELECT CAST(SCOPE_IDENTITY() AS INT) AS ID;");
                db.leer();

                if (db.Reader.Read())
                {
                    idArticulo = (int)db.Reader["ID"];
                }

                return idArticulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                db.cerrar();
            }

        }
    }
}
