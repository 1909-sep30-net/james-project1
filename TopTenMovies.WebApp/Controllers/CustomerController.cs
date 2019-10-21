using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopTenMovies.DataAccess.Entities;
using TopTenMovies.DataAccess;


namespace TopTenMovies.WebApp.Controllers
{
    public class CustomerController : Controller
    {
        AllCustomersDB allcust = new AllCustomersDB();
        AddCustomerDB addCust = new AddCustomerDB();
        

        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Customer/Details/5
        public ActionResult ListCustomers()
        {
            List<Customer> customers = allcust.GetAllCustomersDB();
            return View(customers);
        }

        // GET: Customer/Create
        public ActionResult Create()
        {


            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Customer cust = new Customer
                {
                    FirstName = collection["FirstName"],
                    LastName = collection["LastName"]
                };

                addCust.AddNewCustomerDB(cust);

                return RedirectToAction(nameof(ListCustomers));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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