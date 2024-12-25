using Microsoft.AspNetCore.Mvc;

namespace WebMvcAngular.Controllers
{
    public class AngularController : Controller
    {
        public IActionResult Index()
        {
            var filePath = Path.Combine(
                Directory.GetCurrentDirectory(),
                "clientApp", "angular-app", "dist", "angular-app","browser", "index.html");

            if (System.IO.File.Exists(filePath))
            {
                return PhysicalFile(filePath, "text/html");
            }

            return NotFound("Angular index.html not found.");
        }
    }
}
