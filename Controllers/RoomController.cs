using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{

    // Changes for Sprint # -- User Story 1A -- Vincent Carlson
// Changes Sprint 1 -- I want to create rooms for categorizing conversations

    public class RoomController : Controller
    {
        // GET: RoomController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {
            // Changes for Sprint 1 -- User Story 1A -- Lonnie Golen
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations --Lonnie Golen
            return View();
        }

        // GET: RoomController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            // Changes for Sprint 1 -- User Story 1A -- Lonnie Golen
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations --Lonnie Golen
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            // Changes for Sprint 1 -- User Story 1A -- Lonnie Golen
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations --Lonnie Golen
            return View();
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            // Changes for Sprint 1 -- User Story 1A -- Lonnie Golen
            // Changes Sprint 1 -- I want to create rooms for categorizing conversations --Lonnie Golen
            return View();
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
