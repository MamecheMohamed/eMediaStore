using eMediaStore.Data;
using eMediaStore.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data=await _service.getAll();
            return View(data);
        }
    }
}
