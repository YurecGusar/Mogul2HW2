using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Starter
    {
        private const int _size = 4;
        private Cart _cart = Cart.Instance;
        private CartService _cartService = CartService.Instance;
        private ProductProvider _productProvider = new ProductProvider();
        public Starter()
        {
        }

        public void Run()
        {
            /*var products = _productProvider.Products;
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Name} {item.Cost}");
            }

            Console.WriteLine($"{_configService.CartConfig.Size}");*/
            for (var i = 0; i < _size; i++)
            {
                _cartService.Add(i);
            }

            for (var i = 0; i < _size; i++)
            {
                Console.WriteLine(_cart.Product[i].Name);
            }
        }
    }
}
