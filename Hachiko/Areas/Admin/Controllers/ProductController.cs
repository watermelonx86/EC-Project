using Hachiko.DataAccess.Repository;
using Hachiko.DataAccess.Repository.IRepository;
using Hachiko.Models;
using Hachiko.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hachiko.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var productList = _unitOfWork.Product.GetAll().ToList();
            
             
            return View("Index",productList);
        }

        public IActionResult UpdateAndInsert(int? id)
        {
            //Get CategoryList
            IEnumerable<SelectListItem> CategoryList = _unitOfWork.Category.
                GetAll().Select(
              u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() }
                );
            //Pass CategoryList to View by ViewBag
            //ViewBag.CategoryList = CategoryList;
            ProductVM productVM = new ProductVM()
            {
                Product = new Product(),
                CategoryList = CategoryList
            };
            if (id == null || id == 0)
            {
                return View("UpdateAndInsert", productVM);
            } else
            {
                //Update 
                productVM.Product = _unitOfWork.Product.Get(u => u.Id == id);
                return View("UpdateAndInsert", productVM);
            }
        }

        [HttpPost]
        public IActionResult UpdateAndInsert(ProductVM productVM, IFormFile? file)
        {  

            if (ModelState.IsValid)
            {
                //add new Product by EF 
                _unitOfWork.Product.Add(productVM.Product);
                _unitOfWork.Save();

                //TempData to message to client
                TempData["success"] = "Category created successfully";

                return RedirectToAction("Index", "Product");

            } else
            {
                productVM.CategoryList = _unitOfWork.Category.
               GetAll().Select(
             u => new SelectListItem { 
                 Text = u.Name, 
                 Value = u.Id.ToString() 
                });
                
                return View(productVM);
            }

           
            /*Sau khi them Category chuyen huong den Action Index de xem thay doi*/
        }

        
        public IActionResult Delete(int? id)
        {
            //Validation
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product? product = _unitOfWork.Product.Get(u => u.Id == id);


            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //POST
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {

            Product? obj = _unitOfWork.Product.Get(u => u.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            _unitOfWork.Product.Remove(obj);
            _unitOfWork.Save();

            TempData["success"] = "Category deleted successfully";

            /*Sau khi them Category chuyen huong den Action Index de xem thay doi*/
            return RedirectToAction("Index", "Product");

        }

    }
}
