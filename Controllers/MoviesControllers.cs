using eMediaStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class MoviesControllers : Controller
    {
        private readonly AppDbContext _context;
        public MoviesControllers(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var moviessdata = _context.Movies.ToList();
            return View();
        }
    }
}
