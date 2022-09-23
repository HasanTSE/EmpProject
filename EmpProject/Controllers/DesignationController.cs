using Microsoft.AspNetCore.Mvc;
using EmpProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmpProject.Controllers
{
    public class DesignationController : Controller
    {
        private readonly InfoContext _db;
        public DesignationController(InfoContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var desigList = _db.Desigs.ToList();
            return View(desigList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var podobi = _db.Desigs.FirstOrDefault(x => x.Id == id);


            if (podobi == null)
            {
                return NotFound();
            }
            return View(podobi);
        }


        public IActionResult Create()
        {
            ViewData["Designation"] = new SelectList(_db.Desigs.Where(a => a.IsActive == true), "Designation", "Designation");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Desig dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Designation"] = new SelectList(_db.Desigs.Where(a => a.IsActive == true), "Designation", "Designation");
            return View(dataPass);
        }


        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var podobi = _db.Desigs.FirstOrDefault(x => x.Id == id);
            if (podobi == null)
            {
                return NotFound();
            }
            ViewData["Designation"] = new SelectList(_db.Desigs.Where(a => a.IsActive == true), "Designation", "Designation");
            return View(podobi);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Desig podobi)
        {
            if (podobi == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(podobi);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Nationality"] = new SelectList(_db.Nations.Where(a => a.IsActive == true), "Nationality", "Nationality");
            return View(podobi);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var podobi = _db.Desigs.FirstOrDefault(x => x.Id == id);
            _db.Desigs.Remove(podobi);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


    }
}
