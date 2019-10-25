using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;

namespace TopTenMovies.DataAccess
{
    public class AllLocationsDB
    {
        public List<Location> GetAllLocationsDB()
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            //DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
            //    .UseSqlServer(connectionString)
            //    .Options;

            //using var context = new TopTenMoviesContext(options);

            List<Location> locations = new List<Location>();

            //foreach (Location location in context.Location)
            //{
            //    Location displayLocation = new Location();

            //    displayLocation.LocationId = location.LocationId;
            //    displayLocation.City = location.City;

            //    locations.Add(displayLocation);

            //}

            return locations;
        }
    }
}
