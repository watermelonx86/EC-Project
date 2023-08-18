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

    }
}
