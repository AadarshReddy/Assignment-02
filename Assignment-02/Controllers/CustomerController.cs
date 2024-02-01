using Assignment_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_02.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        static List<Customer> listCus = new List<Customer>
        {
            new Customer {Id=1,Name="Riya",Designation="Manager"},
            new Customer {Id=2,Name="Vijay",Designation="HR"},
            new Customer {Id=3,Name="Sunny",Designation="Developer"}
        };

        public ActionResult Index()
        {
            ViewBag.msg = "Welcome to Customers Page";
            return View(listCus);
        }
        public ActionResult CusList()
        {
            List<string> list = new List<string>()
            {
                "Ravi",
                "Raj",
                "Nitu",
                "Ria"
            };
            ViewBag.CusList = list;

            return View();
        }
       public ActionResult RedirectDemo() {
            ViewData["msg"] = "Welcome Customer";
            return View(new Customer());
        }
        [HttpPost]
        public ActionResult RedirectDemo(Customer cus)
        {
            if (ModelState.IsValid)
            {
                //CusList.Add(cus);
                TempData["tempmsg"] = "New Customer Registered";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}