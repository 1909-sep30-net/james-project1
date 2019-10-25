using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;

namespace TopTenMovies.DataAccess
{
    public class AllOrdersDB
    {   
        public List<OrderDisplay> GetAllOrdersDB()
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            //DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
            //    .UseSqlServer(connectionString)
            //    .Options;

            //using var context = new TopTenMoviesContext(options);
            //using var context2 = new TopTenMoviesContext(options);
            //using var context3 = new TopTenMoviesContext(options);
            //using var context4 = new TopTenMoviesContext(options);

            List<OrderDisplay> allOrders = new List<OrderDisplay>();

            //foreach (Orders order in context.Orders)
            //{
            //    OrderDisplay eachOrder = new OrderDisplay();

            //    var title = context2.Product.FirstOrDefault(p => p.ProductId == order.ProductId);
            //    var location = context3.Location.FirstOrDefault(p => p.LocationId == order.LocationId);
            //    var customerName = context4.Customer.FirstOrDefault(p => p.CustomerId == order.CustomerId);

            //    eachOrder.OrderId = order.OrderId;
            //    eachOrder.CustomerName = customerName.FirstName + " " + customerName.LastName;
            //    eachOrder.ProductTitle = title.Title;
            //    eachOrder.LocationCity = location.City;
                

            //    allOrders.Add(eachOrder);

            //}

            return allOrders;
        }
    }
}
