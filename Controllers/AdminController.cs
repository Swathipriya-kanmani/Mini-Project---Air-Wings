using Microsoft.AspNetCore.Mvc;

namespace AirlinesProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
