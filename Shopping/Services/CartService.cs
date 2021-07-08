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
        private Cart _cart;
        private ProductProvider _productProvider;
        private ConfigService _configService;
        private int _maxSize;
        static CartService()
        {
        }

        private CartService()
        {
            _configService = new ConfigService();
            _productProvider = new ProductProvider();
            _cart = Cart.Instance;
            _maxSize = _configService.CartConfig.Size;
            _cart.Product = new Product[_maxSize];
            _cart.NumberOfProduct = 0;
        }

        public static CartService Instance => _instance;
        public void Add(int id)
        {
            if (_cart.NumberOfProduct <= _maxSize)
            {
                _cart.Product[_cart.NumberOfProduct] = _productProvider.Products[id];
                _cart.NumberOfProduct++;
            }
        }
    }
}
