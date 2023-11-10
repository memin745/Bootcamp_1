using Bootcamp_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bootcamp_1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Products);
        }
        public IActionResult Details(int? id)
        {

            if (id == null)
            {
                return Redirect("/Home/Index");
            }
            var kurs = Repository.GetById(id);
            return View(kurs);
        }
    }
}
