using Microsoft.AspNetCore.Mvc;

namespace Administration.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
