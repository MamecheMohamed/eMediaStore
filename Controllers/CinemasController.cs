using eMediaStore.Data;
using eMediaStore.Data.Services;
using eMediaStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace eMediaStore.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;
        public CinemasController(ICinemasService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var cinemasdata = await _service.getAllAsync();
            return View(cinemasdata);
        }
        //GET : Cinemas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,logo,Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }
        //GET : Cinemas/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);
            if (cinemadetails == null) return View("NotFound");
            return View(cinemadetails);
        }


        //GET : Cinemas/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);
            if (cinemadetails == null) return View("NotFound");
            return View(cinemadetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,logo,Description")] Cinema cinema)
        {
            cinema.Id = id;
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.UpdateAsync(id, cinema);
            return RedirectToAction(nameof(Index));
        }

        //GET : Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);
            if (cinemadetails == null) return View("NotFound");
            return View(cinemadetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cinemadetails = await _service.GetByIdAsync(id);
            if (cinemadetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
