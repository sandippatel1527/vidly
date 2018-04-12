using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;


namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer
        [Route("Customer")]
        public ActionResult CustomerList()
        {
            var customer = GetCustomers();
            return View(customer);
        }

        [Route("Customer/Details/{id}")]
        public ActionResult CustomerDetail(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            
                       if (customer == null)
                               return HttpNotFound();
            
                      return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
               new Customer{ Id=1,Name="Sandip" },
               new Customer{ Id=2,Name="Hiral" }
            };
        }
    }
}