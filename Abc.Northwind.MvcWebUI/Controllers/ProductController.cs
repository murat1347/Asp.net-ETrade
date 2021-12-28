using System;
using System.Linq;
using Abc.Northwind.Bisuness.Abstract;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public int PageSize { get; private set; }

        public IActionResult Index(int page = 1, int category = 0)
        {
            int pageSize = 10;

            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page,

            };

            return View(model);
        }

    //    //public string Session()
    //    {
    //        HttpContext.Session.SetString("city","ankara");
    //        HttpContext.Session.SetInt32("age",32);
    //        HttpContext.Session.GetString("city");
    //        HttpContext.Session.GetInt32("age");

    //    }
    }
}
