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
            List<Articulo> listaArticulos = new List<Articulo>();
            ConexionDB consulta = new ConexionDB();
            try
            {
                consulta.setQuery("select A.Id, A.Codigo, A.Nombre, A.Descripcion as AD, A.Precio, M.Descripcion as MD, C.Descripcion as CD, I.ImagenUrl from ARTICULOS as A Inner Join MARCAS as M on A.IdMarca = M.Id Inner Join CATEGORIAS as C on A.IdCategoria = C.Id Inner Join IMAGENES as I on A.Id = I.IdArticulo");
                consulta.leerDB();

                while (consulta.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.marca = new Marca();
                    aux.categoria = new Categoria();
                    aux.imagen = new Imagen();
                    aux.idArticulo = (int)consulta.Lector["Id"];
                    aux.codigoArticulo = (string)consulta.Lector["Codigo"];
                    aux.nombre = (string)consulta.Lector["Nombre"];
                    aux.descripcion = (string)consulta.Lector["AD"];
                    aux.precio = (decimal)consulta.Lector["Precio"];
                    aux.marca.nombreMarca = (string)consulta.Lector["MD"];
                    aux.categoria.nombreCategoria = (string)consulta.Lector["CD"];
                    aux.imagen.imagenUrl = (string)consulta.Lector["ImagenUrl"];

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

            return listaArticulos;
        }
    }
}
