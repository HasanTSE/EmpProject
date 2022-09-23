using Microsoft.AspNetCore.Mvc;
using EmpProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmpProject.Controllers
{
    public class DepartmentController : Controller
    {

        private readonly InfoContext _db;
        public DepartmentController(InfoContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var deptList = _db.Depts.ToList();
            return View(deptList);
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var depart = _db.Depts.FirstOrDefault(x => x.Id == id);


            if (depart == null)
            {
                return NotFound();
            }
            return View(depart);
        }

        public IActionResult Create()
        {
            ViewData["Department"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Department", "Department");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Dept dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Department"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Department", "Department");
            return View(dataPass);
        }

        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var depart = _db.Depts.FirstOrDefault(x => x.Id == id);
            if (depart == null)
            {
                return NotFound();
            }
            ViewData["Department"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Department", "Department");
            return View(depart);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Dept depart)
        {
            if (depart == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(depart);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Department"] = new SelectList(_db.Depts.Where(a => a.IsActive == true), "Department", "Department");
            return View(depart);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var depart = _db.Depts.FirstOrDefault(x => x.Id == id);
            _db.Depts.Remove(depart);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }


    }
}
