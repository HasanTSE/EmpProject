using Microsoft.AspNetCore.Mvc;
using EmpProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmpProject.Controllers
{
    public class NationalityController : Controller
    {
        private readonly InfoContext _db;
        public NationalityController(InfoContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var nationalityList = _db.Nations.ToList();
            return View(nationalityList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var desh = _db.Nations.FirstOrDefault(x => x.Id == id);
            

            if (desh == null)
            {
                return NotFound();
            }
            return View(desh);
        }

        public IActionResult Create()
        {
            ViewData["Nationality"] = new SelectList(_db.Nations.Where(a => a.IsActive == true), "Nationality", "Nationality");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Nation dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Nationality"] = new SelectList(_db.Nations.Where(a => a.IsActive == true), "Nationality", "Nationality");
            return View(dataPass);
        }


        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var desh = _db.Nations.FirstOrDefault(x => x.Id == id);
            if (desh == null)
            {
                return NotFound();
            }
            ViewData["Nationality"] = new SelectList(_db.Nations.Where(a => a.IsActive == true), "Nationality", "Nationality");
            return View(desh);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Nation desh)
        {
            if (desh == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(desh);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Nationality"] = new SelectList(_db.Nations.Where(a => a.IsActive == true), "Nationality", "Nationality");
            return View(desh);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var desh = _db.Nations.FirstOrDefault(x => x.Id == id);
            _db.Nations.Remove(desh);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


    }
}
