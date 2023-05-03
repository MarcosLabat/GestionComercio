using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DB;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            List<Categoria> listaCategoria = new List<Categoria>();
            ConexionDB consulta = new ConexionDB();
            try
            {
                consulta.setQuery("select Id, Descripcion from CATEGORIAS");
                consulta.leerDB();

                while (consulta.Lector.Read())
                {
                    Categoria aux = new Categoria();

                    aux.id = (int)consulta.Lector["Id"];
                    aux.nombreCategoria = (string)consulta.Lector["Descripcion"];
                    listaCategoria.Add(aux);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                consulta.cerrarConexion();
            }

            return listaCategoria;
        }
    }
}
