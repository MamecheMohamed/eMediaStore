using eMediaStore.Data;
using eMediaStore.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;
        public ProducersController(IProducersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var producersdata = await _service.getAllAsync();
            return View(producersdata);
        }
    }
}
