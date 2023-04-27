using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class ConexionDB
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public ConexionDB()
        {
            conn = new SqlConnection("server=DESKTOP-D0T1FC1\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            cmd = new SqlCommand();
        }

        public void setearQuery(string query)
        {
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = query;
        }

        public void leer()
        {
            cmd.Connection = this.conn;
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int guardar()
        {
            cmd.Connection = this.conn;
            int rowsAffected = 0;
            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cerrar()
        {
            if (reader != null)
            {
                reader.Close();
            }
            conn.Close();
        }
    }
}
