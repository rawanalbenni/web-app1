using Microsoft.AspNetCore.Mvc;
using support_task3.Models;

namespace support_task3.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product() { 
                Id = 1,
                Name = "Product1",
                Company = new Company()
                {
                    Id = 1,
                    Name = "Company1",
                }
            }; 
            return View(product);
        }
    }
}
