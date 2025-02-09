using Microsoft.AspNetCore.Mvc;

namespace support_task3.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
