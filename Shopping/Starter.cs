using System;
using Shopping.Services;

namespace Shopping
{
    public class Starter
    {
        private User _user;
        private Cart _cart = Cart.Instance;
        private CartService _cartService = new CartService();
        private OrderService _orderService = new OrderService();
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
            const int addedProducts = 6;
            for (var i = 0; i < addedProducts; i++)
            {
                _cartService.Add(i);
            }

            for (var i = 0; i < _cart.NumberOfProduct; i++)
            {
                Console.WriteLine($"{_cart.Product[i].Name} {_cart.Product[i].Cost} ");
            }

            _orderService.GetOrder(_user);
        }
    }
}
