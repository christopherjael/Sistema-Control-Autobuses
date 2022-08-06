using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SCA.Entity;

namespace SCA.DL.Repositories
{
    public class RutasRepository
    {
        private SqlConnection conn;

        public Rutas GetRutaById(int rutaId)
        {
            conn = Data.GetConnection();
            string sql = $"SELECT * FROM Rutas WHERE RutaId = {rutaId}";
            Rutas ruta = new Rutas();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    ruta.RutaId = Convert.ToInt32(reader["RutaId"]);
                    ruta.Nombre = Convert.ToString(reader["Nombre"]);

                }
                conn.Close();
                return ruta;
            }
        }
        public List<Rutas> GetAllRutas()
        {
            conn = Data.GetConnection();
            List<Rutas> rutasList = new List<Rutas>();
            string sql = "SELECT * FROM dbo.Rutas";
            using (conn)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rutasList.Add(new Rutas()
                    {
                        RutaId = Convert.ToInt32(reader[0]),
                        Nombre = Convert.ToString(reader[1])
                    });
                }
                conn.Close();

                return rutasList.ToList();
            }
        }

        public List<Rutas> GetAllRutasFree()
        {
            conn = Data.GetConnection();
            List<Rutas> rutasList = new List<Rutas>();
            string sql = "SELECT * FROM vwRutasLibres;";
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    rutasList.Add(new Rutas()
                    {
                        RutaId = Convert.ToInt32(reader[0]),
                        Nombre = Convert.ToString(reader[1])
                    });
                }
                conn.Close();

                return rutasList.ToList();
            }
        }

        public int AddRutas(Rutas rutas)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "CrearRutas";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = rutas.Nombre;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return 1;
                }
            }
            catch (SqlException ex)
            {
                return 0;
                throw ex;
            }

        }

        public int UpdateRuta(Rutas rutas)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "ActualizarRutas";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rutaId", SqlDbType.Int).Value = rutas.RutaId;
                    cmd.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = rutas.Nombre;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return 1;
                }
            }
            catch (SqlException ex)
            {
                return 0;
                throw ex;
            }

        }

        public int DeleteRuta(Rutas ruta)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "EliminarRutas";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rutaId", SqlDbType.Int).Value = ruta.RutaId;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return 1;
                }
            }
            catch (SqlException ex)
            {
                return 0;
                throw ex;
            }

        }
    }
}
