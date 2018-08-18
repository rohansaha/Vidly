using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        // GET: Customers
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer> { new Customer { Id = 1, Name = "Rohan Big Face" }, new Customer { Id = 2, Name = "Pooh Pooh Sexy Ass" } };
        }
    }
}