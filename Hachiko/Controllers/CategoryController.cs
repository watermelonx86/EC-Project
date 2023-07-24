using Hachiko.DataAcess.Data;
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

        [HttpPost]
        public IActionResult Create(Category obj)
        {   //check Model Sate
            /*
            if (obj.Name.ToLower() == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Name","Name và Order Number không được giống nhau");
            }
            */

            if (ModelState.IsValid)
            {
                //add new Category by EF 
                _dbContext.Categories.Add(obj);
                _dbContext.SaveChanges();

                //TempData to message to client
                TempData["success"] = "Category created successfully";

                return RedirectToAction("Index", "Category");

            }

            return View(obj);
            /*Sau khi them Category chuyen huong den Action Index de xem thay doi*/
        }

        public IActionResult Edit(int? id)
        {
            //Validation
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? category = _dbContext.Categories.Find(id);
            /*
            Category? category1 = _dbContext.Categories.FirstOrDefault(item => item.Id == id);
            Category? category2 = _dbContext.Categories.Where(item => item.Id == id).FirstOrDefault();
            */


            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                //eidt Category with EF 
                _dbContext.Categories.Update(obj);
                _dbContext.SaveChanges();

                TempData["success"] = "Category edited successfully";

                /*Sau khi them Category chuyen huong den Action Index de xem thay doi*/
                return RedirectToAction("Index", "Category");
            }

            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            //Validation
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Category? category = _dbContext.Categories.Find(id);
        

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            Category? obj = _dbContext.Categories.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _dbContext.Categories.Remove(obj);
            _dbContext.SaveChanges();

            TempData["success"] = "Category deleted successfully";

            /*Sau khi them Category chuyen huong den Action Index de xem thay doi*/
            return RedirectToAction("Index", "Category");

        }

    }
}
