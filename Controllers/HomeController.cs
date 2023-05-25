using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Templated.Models;

namespace Templated.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        
    }
}