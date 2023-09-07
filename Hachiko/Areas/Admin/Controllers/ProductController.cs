using Hachiko.DataAccess.Repository;
using Hachiko.DataAccess.Repository.IRepository;
using Hachiko.Models;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Create()
        {
            return View("Create",new Product());
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {  

            if (ModelState.IsValid)
            {
                //add new Product by EF 
                _unitOfWork.Product.Add(obj);
                _unitOfWork.Save();

                //TempData to message to client
                TempData["success"] = "Category created successfully";

                return RedirectToAction("Index", "Product");

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

            Product? product = _unitOfWork.Product.Get(u => u.Id == id);
          


            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                //edit Product with EF 
                _unitOfWork.Product.Update(obj);
                _unitOfWork.Save();

                TempData["success"] = "Category edited successfully";

                /*Sau khi them Category chuyen huong den Action Index de xem thay doi*/
                return RedirectToAction("Index", "Product");
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
