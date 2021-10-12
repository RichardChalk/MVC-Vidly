using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult CustomersListed()
        {
            List<Customer> customerList = new List<Customer>
            {
                new Customer { Name = "Richard"},
                new Customer { Name = "Heimer"},
                new Customer { Name = "Ghane"}
            };

            var viewModel = new ListsViewModel()
            {
                Customers = customerList
            };


            return View(viewModel);
        }
    }
}





