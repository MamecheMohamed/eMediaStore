using eMediaStore.Data;
using eMediaStore.Data.Services;
using eMediaStore.Models;
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
        //GET : Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePicUrl,Biography")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));
        }
        //GET : Producers/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var producerdetails = await _service.GetByIdAsync(id);
            if (producerdetails == null) return View("NotFound");
            return View(producerdetails);
        }


        //GET : Producers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var producerdetails = await _service.GetByIdAsync(id);
            if (producerdetails == null) return View("NotFound");
            return View(producerdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePicUrl,Biography")] Producer producer)
        {
            producer.Id = id;
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));
        }

        //GET : Producers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerdetails = await _service.GetByIdAsync(id);
            if (producerdetails == null) return View("NotFound");
            return View(producerdetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerdetails = await _service.GetByIdAsync(id);
            if (producerdetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
