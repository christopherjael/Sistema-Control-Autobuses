using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCA.Entity;
using System.Data.SqlClient;
using System.Data;

namespace SCA.DL.Repositories
{
    public class AsignacionesRepository
    {
        private SqlConnection conn;

        public List<AsignacionesVW> Populate(string search)
        {
            conn = Data.GetConnection();
            string storedProcedure = "BuscarAsignacion";
            List<AsignacionesVW> asignacionesVW = new List<AsignacionesVW>();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametroBusqueda", SqlDbType.NVarChar).Value = search;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    asignacionesVW.Add(new AsignacionesVW()
                    {
                        AsingnacionId = Convert.ToInt32(reader[0]),
                        ChoferId = Convert.ToInt32(reader[1]),
                        Chofer = Convert.ToString(reader[2]),
                        Cedula = Convert.ToString(reader[3]),
                        FechaNacimiento = Convert.ToDateTime(reader[4]),
                        AutobusId = Convert.ToInt32(reader[5]),
                        Marca = Convert.ToString(reader[6]),
                        Modelo = Convert.ToString(reader[7]),
                        Placa = Convert.ToString(reader[8]),
                        Color = Convert.ToString(reader[9]),
                        Año = Convert.ToString(reader[10]),
                        RutaId = Convert.ToInt32(reader[11]),
                        Nombre_Ruta = Convert.ToString(reader[12]),
                    });
                }
                conn.Close();
                return asignacionesVW;
            }
        }
        public Asignaciones GetAsignacionById(int asignacionId)
        {
            conn = Data.GetConnection();
            string sql = $"SELECT * FROM Asignaciones WHERE AsingnacionId = {asignacionId}";
            Asignaciones asignaciones = new Asignaciones();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    asignaciones.AsingnacionId = Convert.ToInt32(reader["ID"]);
                    asignaciones.ChoferId = Convert.ToInt32(reader["ChoferId"]);
                    asignaciones.AutobusId = Convert.ToInt32(reader["AutobusId"]);
                    asignaciones.RutaId = Convert.ToInt32(reader["RutaId"]);

                }
                conn.Close();
                return asignaciones;
            }

        }
        public List<Asignaciones> GetAllAsignaciones()
        {
            conn = Data.GetConnection();
            List<Asignaciones> asignacionesList = new List<Asignaciones>();
            string sql = "SELECT * FROM Asignaciones";
            using (conn)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    asignacionesList.Add(new Asignaciones()
                    {
                        AsingnacionId = Convert.ToInt32(reader[0]),
                        ChoferId = Convert.ToInt32(reader[1]),
                        AutobusId = Convert.ToInt32(reader[2]),
                        RutaId = Convert.ToInt32(reader[3])
                    });
                }
                conn.Close();

                return asignacionesList.ToList();
            }
        }

        public List<AsignacionesVW> GetAllAsignacionesVW()
        {
            conn = Data.GetConnection();
            List<AsignacionesVW> asignacionesVWList = new List<AsignacionesVW>();
            string sql = "SELECT * FROM vwAsignaciones";

            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    asignacionesVWList.Add(new AsignacionesVW()
                    {
                        AsingnacionId = Convert.ToInt32(reader[0]),
                        ChoferId = Convert.ToInt32(reader[1]),
                        Chofer = Convert.ToString(reader[2]),
                        Cedula = Convert.ToString(reader[3]),
                        FechaNacimiento = Convert.ToDateTime(reader[4]),
                        AutobusId = Convert.ToInt32(reader[5]),
                        Marca = Convert.ToString(reader[6]),
                        Modelo = Convert.ToString(reader[7]),
                        Placa = Convert.ToString(reader[8]),
                        Color = Convert.ToString(reader[9]),
                        Año = Convert.ToString(reader[10]),
                        RutaId = Convert.ToInt32(reader[11]),
                        Nombre_Ruta = Convert.ToString(reader[12]),
                    });
                }
                conn.Close();
                return asignacionesVWList;

            }
        }

        public int AddAsignacion(Asignaciones asignacion)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "CrearAsignacion";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@choferId", SqlDbType.Int).Value = asignacion.ChoferId;
                    cmd.Parameters.AddWithValue("@autobusId", SqlDbType.Int).Value = asignacion.AutobusId;
                    cmd.Parameters.AddWithValue("@rutaId", SqlDbType.Int).Value = asignacion.RutaId;
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

        public int UpdateAsignacion(Asignaciones asignacion)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "ActualizarAsignaciones";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@asignacionId", SqlDbType.Int).Value = asignacion.AsingnacionId;
                    cmd.Parameters.AddWithValue("@choferId", SqlDbType.Int).Value = asignacion.ChoferId;
                    cmd.Parameters.AddWithValue("@autobusId", SqlDbType.Int).Value = asignacion.AutobusId;
                    cmd.Parameters.AddWithValue("@rutaId", SqlDbType.Int).Value = asignacion.RutaId;
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

        public int DeleteAsignacion(Asignaciones asignacion)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "EliminarAsignaciones";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@asignacionId", SqlDbType.Int).Value = asignacion.AsingnacionId;
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
