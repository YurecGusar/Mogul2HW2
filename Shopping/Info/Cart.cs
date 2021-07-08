using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class Cart
    {
        private static readonly Cart _instance = new Cart();

        static Cart()
        {
        }

        private Cart()
        {
        }

        public static Cart Instance => _instance;
        public Product[] Product { get; set; }
        public int NumberOfProduct { get; set; }
    }
}
