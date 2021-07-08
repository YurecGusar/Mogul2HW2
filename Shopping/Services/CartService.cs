using System;

namespace Shopping
{
    public class CartService
    {
        private Cart _cart;
        private ProductProvider _productProvider;
        private ConfigService _configService;
        private int _maxSize;

        public CartService()
        {
            _configService = new ConfigService();
            _productProvider = new ProductProvider();
            _cart = Cart.Instance;
            _maxSize = _configService.CartConfig.Size;
            _cart.Product = new Product[_maxSize];
            _cart.NumberOfProduct = 0;
        }

        public void Add(int id)
        {
                _cart.Product[_cart.NumberOfProduct] = _productProvider.Products[id];
                _cart.NumberOfProduct++;
        }
    }
}
