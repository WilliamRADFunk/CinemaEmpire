using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CinemaEmpire.Web.ViewModels
{
    /// <summary> The Model of a list of all movies in the database. </summary>
    public class ListViewModel
    {
        public List<Movie> Movies;

        public ListViewModel()
        {
            Movies = new List<Movie>();
        }
    }
    /// <summary> The Model of a single movie and all of it's attributes </summary>
    public class DetailsViewModel
    {
        public Movie movie;

        public DetailsViewModel()
        {
            movie = new Movie();
        }

        public DetailsViewModel(string id, string title, string synopsis, float expectedPopularity, float actualPopularity, int optimalSeason, int worstSeason, float costLicense, int licenseLength, string dateCreated, string dateModified)
        {
            movie = new Movie(id, title, synopsis, expectedPopularity, actualPopularity, optimalSeason, worstSeason, costLicense, licenseLength, dateCreated, dateModified);
        }
    }
    /// <summary> Web-layer version of the Data-layer's Movie Entity </summary>
    public class Movie
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public float ExpectedPopularity { get; set; }
        public float ActualPopularity { get; set; }
        public int OptimalSeason { get; set; }
        public int WorstSeason { get; set; }
        public float CostLicense { get; set; }
        public int LicenseLength { get; set; }
        public string DateCreated { get; set; }
        public string DateModified { get; set; }

        public Movie()
        {

        }

        public Movie(string id, string title, string synopsis, float expectedPopularity, float actualPopularity, int optimalSeason, int worstSeason, float costLicense, int licenseLength, string dateCreated, string dateModified)
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
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
        }
        
        // Return string no greater than legnth == 80
        public string GetShorterSynopsis()
        {
            if(this.Synopsis.Length > 80)
            {
                return (this.Synopsis.Substring(0, 80) + "...");
            }
            return this.Synopsis;
        }
    }
}