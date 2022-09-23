using Microsoft.AspNetCore.Mvc;

namespace EmpProject.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
