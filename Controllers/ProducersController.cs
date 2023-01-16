using eMediaStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class ProducersController : Controller
    {
        private readonly AppDbContext _context;
        public ProducersController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var producersdata = _context.Producers.ToList();
            return View();
        }
    }
}
