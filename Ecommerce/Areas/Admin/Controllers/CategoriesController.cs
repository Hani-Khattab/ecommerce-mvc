using Ecommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Areas.Admin.Controllers 
{
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var categories = context.Categories.ToList();
            return View(categories);
        }
    }
}
