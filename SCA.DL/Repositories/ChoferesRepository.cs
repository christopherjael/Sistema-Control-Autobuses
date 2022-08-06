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
    public class ChoferesRepository
    {
        private SqlConnection conn;
        public Choferes GetChoferById(int choferId)
        {
            conn = Data.GetConnection();
            string sql = $"SELECT * FROM Choferes WHERE ChoferId = {choferId}";
            Choferes chofer = new Choferes();
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    chofer.ChoferId = Convert.ToInt32(reader["ChoferId"]);
                    chofer.Nombre = Convert.ToString(reader["Nombre"]);
                    chofer.Apellido = Convert.ToString(reader["Apellido"]);
                    chofer.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                    chofer.Cedula = Convert.ToString(reader["Cedula"]);

                }
                conn.Close();
                return chofer;
            }
        }
        public List<Choferes> GetAllChoferes()
        {
            conn = Data.GetConnection();
            List<Choferes> choferesList = new List<Choferes>();
            string sql = "SELECT * FROM dbo.Choferes";
            using (conn)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    choferesList.Add(new Choferes()
                    {
                        ChoferId = Convert.ToInt32(reader[0]),
                        Nombre = Convert.ToString(reader[1]),
                        Apellido = Convert.ToString(reader[2]),
                        FechaNacimiento = Convert.ToDateTime(reader[3]),
                        Cedula = Convert.ToString(reader[4]),
                    });
                }
                conn.Close();

                return choferesList.ToList();
            }
        }

        public List<Choferes> GetAllChoferesFree()
        {
            conn = Data.GetConnection();
            List<Choferes> choferesList = new List<Choferes>();
            string sql = "SELECT * FROM vwChoferesLibres;";
            using (conn)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    choferesList.Add(new Choferes()
                    {
                        ChoferId = Convert.ToInt32(reader[0]),
                        Nombre = Convert.ToString(reader[1]),
                        FechaNacimiento = Convert.ToDateTime(reader[2]),
                        Cedula = Convert.ToString(reader[3]),
                    });
                }
                conn.Close();

                return choferesList.ToList();
            }
        }

        public int AddChoferes(Choferes chofer)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "CrearChofer";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = chofer.Nombre;
                    cmd.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar).Value = chofer.Apellido;
                    cmd.Parameters.AddWithValue("@fechaNacimiento", SqlDbType.Date).Value = chofer.FechaNacimiento;
                    cmd.Parameters.AddWithValue("@cedula", SqlDbType.NVarChar).Value = chofer.Cedula;

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

        public int UpdateChoferes(Choferes chofer)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "ActualizarChofer";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@choferId", SqlDbType.Int).Value = chofer.ChoferId;
                    cmd.Parameters.AddWithValue("@nombre", SqlDbType.NVarChar).Value = chofer.Nombre;
                    cmd.Parameters.AddWithValue("@apellido", SqlDbType.NVarChar).Value = chofer.Apellido;
                    cmd.Parameters.AddWithValue("@fechaNacimiento", SqlDbType.Date).Value = chofer.FechaNacimiento;
                    cmd.Parameters.AddWithValue("@cedula", SqlDbType.NVarChar).Value = chofer.Cedula;

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

        public int DeleteChofer(Choferes chofer)
        {
            try
            {
                conn = Data.GetConnection();
                string storedProcedure = "EliminarChofer";
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(storedProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@choferId", SqlDbType.Int).Value = chofer.ChoferId;

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
