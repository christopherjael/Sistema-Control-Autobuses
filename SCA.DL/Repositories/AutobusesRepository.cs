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
    public class AutobusesRepository
    {
        private SqlConnection conn;
        public Autobuses GetAutobusById(int asignacionId)
        {
            conn = Data.GetConnection();
            string sql = $"SELECT * FROM Autobuses WHERE AutobusId = {asignacionId}";
            Autobuses autobuses = new Autobuses();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    autobuses.AutobusId = Convert.ToInt32(reader["AutobusId"]);
                    autobuses.Marca = Convert.ToString(reader["Marca"]);
                    autobuses.Modelo = Convert.ToString(reader["Modelo"]);
                    autobuses.Placa = Convert.ToString(reader["Placa"]);
                    autobuses.Color = Convert.ToString(reader["Color"]);
                    autobuses.Año = Convert.ToString(reader["Año"]);

                }
                conn.Close();
                return autobuses;
            }

        }
        public List<Autobuses> GetAllAutobuses()
        {
            conn = Data.GetConnection();
            List<Autobuses> autobusesList = new List<Autobuses>();
            string sql = "SELECT * FROM Autobuses";
            using (conn)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    autobusesList.Add(new Autobuses()
                    {
                        AutobusId = Convert.ToInt32(reader[0]),
                        Marca = Convert.ToString(reader[1]),
                        Modelo = Convert.ToString(reader[2]),
                        Placa = Convert.ToString(reader[3]),
                        Color = Convert.ToString(reader[4]),
                        Año = Convert.ToString(reader[5]),
                    });
                }
                conn.Close();

                return autobusesList.ToList();
            }
        }

        public List<Autobuses> GetAllAutobusesFree()
        {
            conn = Data.GetConnection();
            List<Autobuses> autobusesList = new List<Autobuses>();
            string sql = "SELECT * FROM vwAutobusesLibres";
            using (conn)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    autobusesList.Add(new Autobuses()
                    {
                        AutobusId = Convert.ToInt32(reader[0]),
                        Marca = Convert.ToString(reader[1]),
                        Modelo = Convert.ToString(reader[2]),
                        Placa = Convert.ToString(reader[3]),
                        Color = Convert.ToString(reader[4]),
                        Año = Convert.ToString(reader[5]),
                    });
                }
                conn.Close();

                return autobusesList.ToList();
            }
        }

        public int AddAutobuse(Autobuses autobus)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "CrearAutobuses";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@marca", SqlDbType.NVarChar).Value = autobus.Marca;
                    cmd.Parameters.AddWithValue("@modelo", SqlDbType.NVarChar).Value = autobus.Modelo;
                    cmd.Parameters.AddWithValue("@placa", SqlDbType.NVarChar).Value = autobus.Placa;
                    cmd.Parameters.AddWithValue("@color", SqlDbType.NVarChar).Value = autobus.Color;
                    cmd.Parameters.AddWithValue("@año", SqlDbType.NVarChar).Value = autobus.Año;

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

        public int UpdateAutobuse(Autobuses autobus)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "ActualizarAutobuses";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@autobusId", SqlDbType.Int).Value = autobus.AutobusId;
                    cmd.Parameters.AddWithValue("@marca", SqlDbType.NVarChar).Value = autobus.Marca;
                    cmd.Parameters.AddWithValue("@modelo", SqlDbType.NVarChar).Value = autobus.Modelo;
                    cmd.Parameters.AddWithValue("@placa", SqlDbType.NVarChar).Value = autobus.Placa;
                    cmd.Parameters.AddWithValue("@color", SqlDbType.NVarChar).Value = autobus.Color;
                    cmd.Parameters.AddWithValue("@año", SqlDbType.NVarChar).Value = autobus.Año;

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

        public int DeleteAutobuse(Autobuses autobus)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "EliminarAutobuses";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@autobusId", SqlDbType.Int).Value = autobus.AutobusId;

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
