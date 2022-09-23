using Microsoft.AspNetCore.Mvc;
using EmpProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmpProject.Controllers
{
    public class CompanyController : Controller
    {

        private readonly InfoContext _db;
        public CompanyController(InfoContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var companyList = _db.Compas.ToList();
            return View(companyList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comp = _db.Compas.FirstOrDefault(x => x.Id == id);


            if (comp == null)
            {
                return NotFound();
            }
            return View(comp);
        }


        public IActionResult Create()
        {
            ViewData["Company"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Company", "Company");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Compa dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Company"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Company", "Company");
            return View(dataPass);
        }

        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var comp = _db.Compas.FirstOrDefault(x => x.Id == id);
            if (comp == null)
            {
                return NotFound();
            }
            ViewData["Company"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Company", "Company");
            return View(comp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Compa comp)
        {
            if (comp == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(comp);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Company"] = new SelectList(_db.Compas.Where(a => a.IsActive == true), "Company", "Company");
            return View(comp);
 
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comp = _db.Compas.FirstOrDefault(x => x.Id == id);
            _db.Compas.Remove(comp);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


    }
}