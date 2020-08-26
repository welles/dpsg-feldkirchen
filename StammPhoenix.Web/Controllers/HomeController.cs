using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace StammPhoenix.Web.Controllers
{
    public class HomeController : Controller
    {
        private IWebHostEnvironment _environment;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            var path = System.IO.Path.Combine(_environment.WebRootPath, "html/index.html");

            var content = System.IO.File.ReadAllText(path);

            return this.View("Index", content);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View();
        }
    }
}
