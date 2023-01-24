using eMediaStore.Data;
using eMediaStore.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMediaStore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;
        public MoviesController(IMoviesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var moviesdata = await _service.GetAllAsync(n=>n.Cinema);
            //var moviesdata = await _service.getAllAsync();
            return View(moviesdata);
        }
    }
}
