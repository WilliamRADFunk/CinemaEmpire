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
        public List<Movie> GetListOfMovies()
        {
            List<Movie> Movies = new List<Movie>();

            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=mysql.creativecrew.org;uid=williamfunk;pwd=williamchang;database=creativecrew_cinemaempire;Convert Zero Datetime = True;Allow Zero Datetime=True;";

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
                                Id = data["Id"].ToString(),
                                Title = (string)data["Title"],
                                Synopsis = (string)data["Synopsis"],
                                ExpectedPopularity = (float)data["ExpectedPopularity"],
                                ActualPopularity = (float)data["ActualPopularity"],
                                OptimalSeason = (int)data["OptimalSeason"],
                                WorstSeason = (int)data["WorstSeason"],
                                CostLicense = (float)data["CostLicense"],
                                LicenseLength = (int)data["LicenseLength"],
                                DateCreated = data["DateCreated"].ToString(),
                                DateModified = data["DateModified"].ToString()
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
        /// <summary> Gets a specific movie based on its Id </summary>
        public Movie GetMovie(string id)
        {
            Movie movie = new Movie();

            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=mysql.creativecrew.org;uid=williamfunk;pwd=williamchang;database=creativecrew_cinemaempire;Convert Zero Datetime = True;Allow Zero Datetime=True;";

            try
            {
                using (conn = new MySqlConnection())
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.CommandText = "SELECT * FROM Movie WHERE Id=@Id";

                        cmd.Parameters.AddWithValue("@Id", id);

                        MySqlDataReader data = cmd.ExecuteReader();
                        while (data.Read())
                        {
                            Movie mov = new Movie()
                            {
                                Id = data["Id"].ToString(),
                                Title = (string)data["Title"],
                                Synopsis = (string)data["Synopsis"],
                                ExpectedPopularity = (float)data["ExpectedPopularity"],
                                ActualPopularity = (float)data["ActualPopularity"],
                                OptimalSeason = (int)data["OptimalSeason"],
                                WorstSeason = (int)data["WorstSeason"],
                                CostLicense = (float)data["CostLicense"],
                                LicenseLength = (int)data["LicenseLength"],
                                DateCreated = data["DateCreated"].ToString(),
                                DateModified = data["DateModified"].ToString()
                            };
                            movie = mov;
                            break;
                        };
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return movie;
        }
        /// <summary> Deletes a specific movie from the database (by Id) </summary>
        public void EditMovie(string id, string title, string synopsis, float expectedPopularity, float actualPopularity, int optimalSeason, int worstSeason, float costLicense, int licenseLength)
        {
            MySqlConnection conn;
            string myConnectionString;
            myConnectionString = "server=mysql.creativecrew.org;uid=williamfunk;pwd=williamchang;database=creativecrew_cinemaempire;";
            
            using (conn = new MySqlConnection())
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "UPDATE Movie SET Title=@Title," +
                                        "Synopsis=@Synopsis," +
                                        "ExpectedPopularity=@ExpectedPopularity," +
                                        "ActualPopularity=@ActualPopularity," +
                                        "OptimalSeason=@OptimalSeason," +
                                        "WorstSeason=@WorstSeason," +
                                        "CostLicense=@CostLicense," +
                                        "LicenseLength=@LicenseLength," +
                                        "DateModified=@DateModified" +
                                        "WHERE Id=@Id";

                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Synopsis", synopsis);
                    cmd.Parameters.AddWithValue("@ExpectedPopularity", expectedPopularity);
                    cmd.Parameters.AddWithValue("@ActualPopularity", actualPopularity);
                    cmd.Parameters.AddWithValue("@OptimalSeason", optimalSeason);
                    cmd.Parameters.AddWithValue("@WorstSeason", worstSeason);
                    cmd.Parameters.AddWithValue("@CostLicense", costLicense);
                    cmd.Parameters.AddWithValue("@LicenseLength", licenseLength);
                    cmd.Parameters.AddWithValue("@DateModified", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@Id", id);

                    int numRowsAffected = cmd.ExecuteNonQuery();
                    if (numRowsAffected <= 0)
                    {
                        throw new Exception(String.Format("numRowsAffected: {0}", numRowsAffected));
                    }
                }
            }
        }
        /// <summary> Deletes a specific movie from the database (by Id) </summary>
        public void DeleteMovie(string id)
        {
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
                        cmd.CommandText = "DELETE FROM Movie WHERE Id=@Id";

                        cmd.Parameters.AddWithValue("@Id", id);

                        int numRowsAffected = cmd.ExecuteNonQuery();
                        if (numRowsAffected <= 0)
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
        }
    }
}
