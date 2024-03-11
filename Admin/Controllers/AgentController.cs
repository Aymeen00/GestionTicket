using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class AgentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
