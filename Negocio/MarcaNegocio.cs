using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DB;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> listaMarca = new List<Marca>();
            ConexionDB consulta = new ConexionDB();

            try
            {
                consulta.setQuery("select Id, Descripcion from Marcas");
                consulta.leerDB();
                while (consulta.Lector.Read())
                {
                    Marca aux = new Marca();

                    aux.id = (int)consulta.Lector["Id"];
                    aux.nombreMarca = (string)consulta.Lector["Descripcion"];

                    listaMarca.Add(aux);
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


            return listaMarca;

        }
    }
}
