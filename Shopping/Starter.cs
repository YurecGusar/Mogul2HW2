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
        private ConfigService _configService = new ConfigService();
        public void Run()
        {
            var products = _productProvider.Init();
            foreach (var item in products)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine(_configService.Config.Size);
        }
    }
}
