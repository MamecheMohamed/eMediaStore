using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
