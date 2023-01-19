using Microsoft.AspNetCore.Mvc;
using RecipeWeb.Models;
using System.Diagnostics;
using RecipeBizObjects;

namespace RecipeWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<bizRecipe> lst = bizRecipe.GetAll();
            return View(lst);
        }
        public IActionResult API()
        {
            return View();
        }
        public IActionResult RecipeListJS()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}