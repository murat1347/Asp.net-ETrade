using Abc.Northwind.Bisuness.Abstract;
using Abc.Northwind.MvcWebUI.Services;
using Microsoft.AspNetCore.Mvc;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCard(int productId)
        {
            var productToBeAdded = _productService.GetById(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.addToCart(cart,productToBeAdded);
            _cartSessionService.SetCart(cart);
            TempData.Add("message",string.Format("Your product,{0},was successfully added to the cart",productToBeAdded.ProductName));
            return RedirectToAction("List", "Product");

        }
    }
}
