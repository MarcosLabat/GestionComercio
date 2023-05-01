using DB;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
            List<Marca> listaMarcas = new List<Marca>();
            ConexionDB datos = new ConexionDB();

            try
            {
                datos.setearQuery("SELECT Id, Descripcion FROM MARCAS");
                datos.leer();
                while (datos.Reader.Read())
                {
                    Marca aux = new Marca();
                    aux.Descripcion = (string)datos.Reader["Descripcion"];
                    aux.Id = (int)datos.Reader["Id"];

                    listaMarcas.Add(aux);
                }

                return listaMarcas;
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

        public Marca buscarPorDescripcion(string descripcion)
        {
            Marca marca = null;
            ConexionDB db = new ConexionDB();
            string query = $"SELECT Id, Descripcion FROM MARCAS WHERE Descripcion = '{descripcion}'";
            try
            {
                db.setearQuery(query);
                db.leer();
                if (db.Reader.Read())
                {
                    marca = new Marca();
                    marca.Descripcion = (string)db.Reader["Descripcion"];
                    marca.Id = (int)db.Reader["Id"];
                }
                return marca;
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

        public int guardar(string nuevaMarca)
        {
            int idMarca = -1;
            string descripcion = nuevaMarca;

            ConexionDB db = new ConexionDB();
            try
            {
                db.setearQuery($"INSERT INTO MARCAS(Descripcion) VALUES('{descripcion}');" + "SELECT CAST(SCOPE_IDENTITY() AS INT) AS ID;");
                db.leer();

                if (db.Reader.Read())
                {
                    idMarca = (int)db.Reader["ID"];
                }

                return idMarca;
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
