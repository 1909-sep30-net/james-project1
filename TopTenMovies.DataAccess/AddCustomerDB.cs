﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using System.Linq;

namespace TopTenMovies.DataAccess
{
    public class AddCustomerDB
    {
        public void AddNewCustomerDB(Customer cust)
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            //DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
            //    .UseSqlServer(connectionString)
            //    .Options;

            //using var context = new TopTenMoviesContext(options);

            

            //context.Customer.Add(cust);

            //context.SaveChanges();


        }
    }
}
