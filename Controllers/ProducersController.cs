using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class ProducersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
