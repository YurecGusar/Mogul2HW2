using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Starter
    {
        private const int _size = 5;
        private User _user;
        private Cart _cart = Cart.Instance;
        private CartService _cartService = CartService.Instance;
        private ProductProvider _productProvider = new ProductProvider();
        public Starter()
        {
            _user = new User
            {
                FirstName = "Yurii",
                SecondName = "Leonov",
                Phone = "0509132128",
                Mail = "leoonovn@gmail.com"
            };
        }

        public void Run()
        {
            for (var i = 0; i < _size; i++)
            {
                _cartService.Add(i);
            }

            for (var i = 0; i < _cart.NumberOfProduct; i++)
            {
                Console.WriteLine($"{_cart.Product[i].Name} {_cart.Product[i].Cost} ");
            }
        }
    }
}
