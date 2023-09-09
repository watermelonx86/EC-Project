﻿using Hachiko.DataAccess.Repository.IRepository;
using Hachiko.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hachiko.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            
        }

        //Ref: https://stackoverflow.com/questions/21249670/implementing-luhn-algorithm-using-c-sharp
        //Luhn Algorithm
        public static bool Luhn(string digits)
        {
            return digits.All(char.IsDigit) && digits.Reverse()
                .Select(c => c - 48)
                .Select((thisNum, i) => i % 2 == 0
                    ? thisNum
                    : (thisNum *= 2) > 9 ? thisNum - 9 : thisNum
                ).Sum() % 10 == 0;
        }


        public IActionResult Index()
        {
            List<Product>? productList = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            List<Category>? categories = _unitOfWork.Category.GetAll().ToList();
            ViewBag.Categories = categories;
            return View("Index",productList);
        }

        public IActionResult ProductByCategory(int id)
        {
            var productList = _unitOfWork.Product.GetAll(includeProperties: "Category").Where(i => i.CategoryId == id).ToList();
            return View("ProductByCategory", productList);
        }

        [HttpPost]
        public IActionResult Search(string query)
        {
            var productList = _unitOfWork.Product.GetAll(includeProperties: "Category").Where(u => u.Title.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
            return View("ProductByCategory", productList);
        }

        public IActionResult Details(int id)
        {
            Product product = _unitOfWork.Product.Get(u => u.Id == id, includeProperties: "Category");
            return View("Details",product);
        }



        public IActionResult Privacy()
        {
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}