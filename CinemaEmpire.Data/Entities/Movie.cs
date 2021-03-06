﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEmpire.Data.Entities
{
    /// <summary> The structure of a movie and all of its properties. </summary>
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
    }
}
