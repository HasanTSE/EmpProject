using Microsoft.AspNetCore.Mvc;
using EmpProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EmpProject.Controllers
{
    public class InformationController : Controller
    {
        private readonly InfoContext _db;
        public InformationController(InfoContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var infoList = _db.Infos.ToList();
            return View(infoList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = _db.Infos.FirstOrDefault(x => x.Id == id);


            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Info dataPass)
        {
            if (dataPass != null && ModelState.IsValid)
            {
                _db.Add(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(dataPass);
        }



        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            var employee = _db.Infos.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]


        public IActionResult Edit(Info dataPass)
        {
            if (dataPass == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Update(dataPass);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(dataPass);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var employee = _db.Infos.FirstOrDefault(x => x.Id == id);
            _db.Infos.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}