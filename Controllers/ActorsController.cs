using eMediaStore.Data.Services;
using eMediaStore.Models;
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
            var data=await _service.getAllAsync();
            return View(data);
        }

        //GET : Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePicUrl,Biography")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        //GET : Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actordetails= await _service.GetByIdAsync(id);
            if (actordetails == null) return View("Empty");
            return View(actordetails);
        }
    }
}
