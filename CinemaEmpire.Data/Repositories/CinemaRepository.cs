using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaEmpire.Data.Entities;
using MySql.Data.MySqlClient;

namespace CinemaEmpire.Data.Repositories
{
    public class CinemaRepository
    {
        /// <summary> Gets all of the movies in the Movie table and returns them in list form </summary>
        public List<Movie> GetAvailableMovies()
        {
            List<Movie> Movies = new List<Movie>();

            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=mysql.creativecrew.org;uid=williamfunk;pwd=williamchang;database=creativecrew_cinemaempire;";

            try
            {
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM Movie";

                        MySqlDataReader data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            Movie movie = new Movie()
                            {
                                Id = (int)data["Id"],
                                Title = (string)data["Title"],
                                Synopsis = (string)data["Synopsis"],
                                ExpectedPopularity = (float)data["ExpectedPopularity"],
                                ActualPopularity = (float)data["ActualPopularity"],
                                OptimalSeason = (int)data["OptimalSeason"],
                                WorstSeason = (int)data["WorstSeason"],
                                CostLicense = (float)data["CostLicense"],
                                LicenseLength = (int)data["LicenseLength"]
                            };
                            Movies.Add(movie);
                        };
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }

            return Movies;
        }
    }
}
