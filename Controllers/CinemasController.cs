using eMediaStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cinemasdata = _context.Cinemas.ToList();
            return View();
        }
    }
}
