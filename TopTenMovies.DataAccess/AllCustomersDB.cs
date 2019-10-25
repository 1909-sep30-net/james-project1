using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;

namespace TopTenMovies.DataAccess
{
    public class AllCustomersDB
    {
        public List<Customer> GetAllCustomersDB()
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            //DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
            //    .UseSqlServer(connectionString)
            //    .Options;

            //using var context = new TopTenMoviesContext(options);

            List<Customer> cust = new List<Customer>();

            //foreach (Customer customer in context.Customer)
            //{
            //    Customer tempCust = new Customer();

            //    tempCust.CustomerId = customer.CustomerId;
            //    tempCust.FirstName = customer.FirstName;
            //    tempCust.LastName = customer.LastName;

            //    cust.Add(tempCust);

            //}

            return cust;
        }
    }
}
