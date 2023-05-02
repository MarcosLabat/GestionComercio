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
                db.SetearQuery(query);
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
        public int eliminar(int idArticuloImagen)
        {
            ConexionDB db = new ConexionDB();
            string query = "DELETE FROM IMAGENES WHERE IdArticulo = @idArticuloImagen";
            int rowsAffected = 0;
            try
            {
                db.SetearQuery(query);
                db.setearParametro("@idArticuloImagen", idArticuloImagen);
                rowsAffected = db.ejecutarQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
