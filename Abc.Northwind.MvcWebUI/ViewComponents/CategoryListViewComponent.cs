using System;
using Abc.Northwind.Bisuness.Abstract;
using Abc.Northwind.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Abc.Northwind.MvcWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var model = new CategoryListViewModel()
            {
                Categories=_categoryService.GetAll(),
                CurrentCategory= Convert.ToUInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}
