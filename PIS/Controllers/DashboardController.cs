using Microsoft.AspNetCore.Mvc;

namespace PIS.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
