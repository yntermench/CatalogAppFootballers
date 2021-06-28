using CatalogApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Controllers
{
    public class HomeController : Controller
    {
        private IFootballerRepository repository;

        public HomeController(IFootballerRepository repo)
        {
            repository = repo;
        }
        public ActionResult Edit()
        {
            ViewBag.NameCommand = repository.Footballers.Select(footballer => footballer.NameCommand);
            ViewBag.Countries = repository.Footballers.Select(footballer => footballer.Country);
            return View();
        }
    }
}
