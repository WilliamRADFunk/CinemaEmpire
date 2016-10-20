using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEmpire.Data.Entities;
using MySql.Data.MySqlClient;

namespace CinemaEmpire.Data.Repositories
{
    public class SystemRepository : ISystemRepository
    {
        public SystemLog CreateLog(SystemLog log)
        {
            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=mysql.creativecrew.org;uid=williamfunk;pwd=williamchang;database=creativecrew_cinemaempire;";

            try
            {
                using (conn = new MySql.Data.MySqlClient.MySqlConnection())
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "INSERT INTO SystemLog (Id, DateCreated, Message) VALUES (@Id, @DateCreated, @Message)";

                        cmd.Parameters.AddWithValue("@Id", log.Id);
                        cmd.Parameters.AddWithValue("@DateCreated", log.DateCreated);
                        cmd.Parameters.AddWithValue("@Message", log.Message);

                        int numRowsAffected = cmd.ExecuteNonQuery();
                        if(numRowsAffected <= 0)
                        {
                            throw new Exception(String.Format("numRowsAffected: {0}", numRowsAffected));
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return log;
        }

        public void DeleteLog(int id)
        {
            throw new NotImplementedException();
        }

        public SystemLog GetLog(int id)
        {
            throw new NotImplementedException();
        }

        public IList<SystemLog> GetLogs()
        {
            throw new NotImplementedException();
        }

        public SystemLog SetLog(SystemLog log)
        {
            throw new NotImplementedException();
        }
    }
}
