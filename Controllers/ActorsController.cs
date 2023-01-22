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
            if (actordetails == null) return View("Not Found");
            return View(actordetails);
        }


        //GET : Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);
            if (actordetails == null) return View("Not Found");
            return View(actordetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("ActorId,FullName,ProfilePicUrl,Biography")] Actor actor)
        {
            actor.ActorId = id;
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id,actor);
            return RedirectToAction(nameof(Index));
        }

        //GET : Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);
            if (actordetails == null) return View("Not Found");
            return View(actordetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actordetails = await _service.GetByIdAsync(id);
            if (actordetails == null) return View("Not Found");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
