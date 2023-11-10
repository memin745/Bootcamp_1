using Bootcamp_1.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using System.Diagnostics;
using Repository = Bootcamp_1.Models.Repository;

namespace Bootcamp_1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Products);
        }
        public IActionResult About()
        {
            return View(Repository.Products);
        }
    }
}