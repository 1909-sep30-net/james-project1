using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopTenMovies.DataAccess;
using TopTenMovies.DataAccess.Entities;

namespace TopTenMovies.WebApp.Controllers
{
    public class OrderController : Controller
    {
        AllCustomersDB allCustomers = new AllCustomersDB();
        AllProductsDB allProducts = new AllProductsDB();
        AllLocationsDB allLocations = new AllLocationsDB();
        NewOrderDB newOrder = new NewOrderDB();
        AllOrdersDB allOrders = new AllOrdersDB();


        static int customerId;
        static int productId;
        static int locationId;


        // GET: Order
        public ActionResult Index()
        {
            return View();
        }

        // GET: Order/Select Customer
        public ActionResult SelectCustomer()
        {
            List<Customer> customers = allCustomers.GetAllCustomersDB();

            return View(customers);
        }

        // GET: Order/Display Products
        public ActionResult ProductList()
        {
            List<Product> products = allProducts.GetAllProducts();

            return View(products);
        }

        public ActionResult SelectLocation()
        {
            List<Location> locations = allLocations.GetAllLocationsDB();

            return View(locations);
        }

        public ActionResult CreateOrder()
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateOrder(IFormCollection collection)
        {
            try
            {
                newOrder.PlaceNewOrderDB(customerId, productId, locationId);

                return RedirectToAction(nameof(OrderPlaced));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetCustomer(IFormCollection collection)
        {
            try
            {
                customerId = int.Parse(collection["selectCustomer"]);

                return RedirectToAction(nameof(ProductList));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetProduct(IFormCollection collection)
        {
            try
            {
                productId = int.Parse(collection["selectProduct"]);

                return RedirectToAction(nameof(SelectLocation));
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SetLocation(IFormCollection collection)
        {
            try
            {
                locationId = int.Parse(collection["selectLocation"]);

                return RedirectToAction(nameof(CreateOrder));
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult OrderPlaced()
        {
            List<OrderDisplay> displayAllOrders = allOrders.GetAllOrdersDB();

            return View(displayAllOrders);
        }

        // POST: Order/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}