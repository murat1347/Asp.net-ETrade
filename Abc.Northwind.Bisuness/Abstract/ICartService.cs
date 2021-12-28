using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.Bisuness.Abstract
{
    public interface ICartService
    {
        void addToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }

}
