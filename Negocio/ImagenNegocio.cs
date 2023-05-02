using DB;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public int guardar(Imagen imagen)
        {
            int idImagen = -1;
            int idArticulo = imagen.IdArticulo;
            string urlImagen = imagen.UrlImagen;
            string query = $"INSERT INTO IMAGENES(IdArticulo, ImagenUrl) VALUES('{idArticulo}', '{urlImagen}'); SELECT CAST(SCOPE_IDENTITY() AS INT) AS ID";
            ConexionDB db = new ConexionDB();
            try
            {
                db.setearQuery(query);
                db.leer();

                if (db.Reader.Read())
                {
                    idImagen = (int)db.Reader["ID"];
                }

                return idImagen;
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
