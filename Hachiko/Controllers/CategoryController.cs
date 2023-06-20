using Hachiko.Data;
using Hachiko.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hachiko.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        //Constructor
        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var categoryList = _dbContext.Categories.ToList();
            return View("Index",categoryList);
        }

        public IActionResult Create()
        {
            return View("Create",new Category());
        }

    }
}
