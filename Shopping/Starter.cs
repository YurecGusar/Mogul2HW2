using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Starter
    {
        private ProductProvider _productProvider = new ProductProvider();
        public void Run()
        {
            var products = _productProvider.Init();
        }
    }
}
