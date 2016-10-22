using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaEmpire.Web.ViewModels
{
    public class AvailableMoviesViewModel
    {
        public List<Movie> Movies;

        public AvailableMoviesViewModel()
        {
            Movies = new List<Movie>();
        }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public float ExpectedPopularity { get; set; }
        public float ActualPopularity { get; set; }
        public int OptimalSeason { get; set; }
        public int WorstSeason { get; set; }
        public float CostLicense { get; set; }
        public int LicenseLength { get; set; }

        public Movie()
        {

        }

        public Movie(int id, string title, string synopsis, float expectedPopularity, float actualPopularity, int optimalSeason, int worstSeason, float costLicense, int licenseLength)
        {
            this.Id = id;
            this.Title = title;
            this.Synopsis = synopsis;
            this.ExpectedPopularity = expectedPopularity;
            this.ActualPopularity = actualPopularity;
            this.OptimalSeason = optimalSeason;
            this.WorstSeason = worstSeason;
            this.CostLicense = costLicense;
            this.LicenseLength = licenseLength;
        }
    }
}