using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BethanysPieShop.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller //controller always inheirits from base controller class
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository) //dependancy injection will automatically inject an instance of the MockPieRepository here becuase of the Startup class, also known as constructor injection
        {
            _pieRepository = pieRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
