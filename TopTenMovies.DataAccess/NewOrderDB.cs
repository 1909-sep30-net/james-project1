﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using System.Linq;

namespace TopTenMovies.DataAccess
{
    public class NewOrderDB
    {
        public void PlaceNewOrderDB(int customerId, int filmProductId, int filmLocationId)
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new TopTenMoviesContext(options);

            DateTime dateTime = new DateTime(2019, 10, 16);

            Orders newOrder = new Orders();

            newOrder.CustomerId = customerId;
            newOrder.ProductId = filmProductId;
            newOrder.LocationId = filmLocationId;
            newOrder.Quantity = 1;
            newOrder.OrderTotal = (decimal)10.99;
            newOrder.OrderTime = dateTime;

            context.Orders.Add(newOrder);

            context.SaveChanges();
        }
    }
}
