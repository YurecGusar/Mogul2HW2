using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class CartService
    {
        private static readonly CartService _instance = new CartService();
        private User _user = new User();
        private Cart _cart = Cart.Instance;
        private ProductProvider _productProvider = new ProductProvider();
        private ConfigService _configService = new ConfigService();
        private int _size;
        static CartService()
        {
        }

        private CartService()
        {
            _size = _configService.CartConfig.Size;
            _cart.Product = new Product[_size];
        }

        public static CartService Instance => _instance;
        public void Add(int id)
        {
            if (id <= _size)
            {
                _cart.Product[id] = _productProvider.Products[id];
            }
            else
            {
                Console.WriteLine($"Кол-во допустимых товаров к добавлению в корзину не должно быть больше {_size}");
            }
        }
    }
}
