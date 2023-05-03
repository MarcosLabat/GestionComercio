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
            bool hayRegistros = false;
            bool NuevaImagen = false;
            try {

                consulta.setQuery("select A.Id, A.Codigo, A.Nombre, A.Descripcion as AD, A.Precio, M.Descripcion as MD, C.Descripcion as CD, I.ImagenUrl from ARTICULOS as A Inner Join MARCAS as M on A.IdMarca = M.Id Inner Join CATEGORIAS as C on A.IdCategoria = C.Id Inner Join IMAGENES as I on A.Id = I.IdArticulo");
                consulta.leerDB();

                while (consulta.Lector.Read()) {
                    Articulo aux = new Articulo();
                    Imagen imagen = new Imagen();
                    aux.imagenes = new List<Imagen>();
                    aux.idArticulo = (int)consulta.Lector["Id"];
                    if(hayRegistros) {

                        foreach (var item in listaArticulos){
                            if (aux.idArticulo == item.idArticulo){
                                imagen.imagenUrl = (string)consulta.Lector["ImagenUrl"];
                                aux.imagenes.Add(imagen);
                                listaArticulos[item.idArticulo - 1].imagenes.Add(imagen);
                                NuevaImagen = true;
                            }
                        }

                        if(NuevaImagen){
                            NuevaImagen = false;
                            continue;
                        }
                    }
                        aux.marca = new Marca();
                        aux.categoria = new Categoria();
                        aux.codigoArticulo = (string)consulta.Lector["Codigo"];
                        aux.nombre = (string)consulta.Lector["Nombre"];
                        aux.descripcion = (string)consulta.Lector["AD"];
                        aux.precio = (decimal)consulta.Lector["Precio"];
                        aux.marca.nombreMarca = (string)consulta.Lector["MD"];
                        aux.categoria.nombreCategoria = (string)consulta.Lector["CD"];
                        imagen.imagenUrl = (string)consulta.Lector["ImagenUrl"];
                        hayRegistros = true;
                        aux.imagenes.Add(imagen);
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
