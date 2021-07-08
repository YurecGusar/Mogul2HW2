using System;

namespace Shopping
{
    public class ProductProvider
    {
        private int _quantity = (int)ProdNames.EndOfProdNames;
        public ProductProvider()
        {
            Products = new Product[_quantity];
            Init();
        }

        public Product[] Products { get; }
        public void Init()
        {
            var minCost = 10;
            var maxCost = 100;
            ProdNames prodName;

            for (var i = 0; i < _quantity; i++)
            {
                prodName = (ProdNames)i;
                Products[i] = new Product { Name = prodName.ToString(), Cost = new Random().Next(minCost, maxCost) };
            }
        }
    }
}
