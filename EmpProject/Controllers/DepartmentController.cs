using Microsoft.AspNetCore.Mvc;

namespace EmpProject.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
