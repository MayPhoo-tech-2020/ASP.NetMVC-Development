using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Start()
        {
            var movie = new Movie();
            var customers = new List<Customer>();
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Customers()
        {
            var movie = new Movie() { Name = "Customers" };
            var customers = new List<Customer>
                {
                    new Customer {Name = "Su Hlaing"},
                    new Customer {Name= "Kyaw Kyaw Kyaw"}
                };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Movies()
        {
            var movie = new Movie() { Name = "Customers" };
            var customers = new List<Customer>
                {
                    new Customer {Name = "Mya Mya "},
                    new Customer {Name= "Kyaing Kyaing"}
                };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Details(string customerName)
        {
            return Content(customerName);
        }
    }
}