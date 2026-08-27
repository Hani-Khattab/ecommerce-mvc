using Ecommerce.Data;
using Ecommerce.Models;
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


        public IActionResult Create()
        {
            return View(new Category());
        }

        public ActionResult Store(Category request)
        {
            if (!ModelState.IsValid)
            {
                return View("Create" , request);
            }
            context.Categories.Add(request);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


    }
}
