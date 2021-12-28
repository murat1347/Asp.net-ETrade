using Abc.Northwind.Entities.Concrete;
using Abc.Northwind.MvcWebUI.ExtentionsMethods;
using Microsoft.AspNetCore.Http;

namespace Abc.Northwind.MvcWebUI.Services
{
    public class CartSessionService : ICartSessionService
    {
        private IHttpContextAccessor _httpContextAccessor;
        public Cart GetCart()
        {
            Cart cartToCheck = _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            if (cartToCheck == null)
            {
                _httpContextAccessor.HttpContext.Session.setObject("cart", new Cart());
                cartToCheck= _httpContextAccessor.HttpContext.Session.GetObject<Cart>("cart");
            }
            return cartToCheck;
        }

        public void SetCart(Cart cart)
        {
            _httpContextAccessor.HttpContext.Session.setObject("cart",cart);
        }
    }
}
