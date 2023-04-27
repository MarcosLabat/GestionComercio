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
        public string guardar(Imagen imagen)
        {
            string url = "";
            int idArticulo = imagen.IdArticulo;
            string urlImagen = imagen.UrlImagen;
            string query = $"INSERT INTO IMAGENES(IdArticulo, ImagenUrl) VALUES('{idArticulo}', '{urlImagen}')";
            ConexionDB db = new ConexionDB();
            try
            {
                db.setearQuery(query);
                db.leer();

                if (db.Reader.Read())
                {
                    url = (string)db.Reader["ImagenUrl"];
                }

                return url;
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
