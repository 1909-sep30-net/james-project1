using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;

namespace TopTenMovies.DataAccess
{
    public class AllProductsDB
    {
        public List<Product> GetAllProducts()
        {
            //string connectionString = SecretConfiguration.ConnectionString;

            //DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
            //    .UseSqlServer(connectionString)
            //    .Options;

            //using var context = new TopTenMoviesContext(options);

            List<Product> products = new List<Product>();

            //foreach (Product product in context.Product)
            //{
            //    Product displayProduct = new Product();

            //    displayProduct.ProductId = product.ProductId;
            //    displayProduct.Title = product.Title;

            //    products.Add(displayProduct);

            //}

            return products;
        }
    }
}
