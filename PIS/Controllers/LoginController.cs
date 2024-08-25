using Microsoft.AspNetCore.Mvc;

namespace PIS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
