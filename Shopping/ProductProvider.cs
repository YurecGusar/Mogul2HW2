using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public class ProductProvider
    {
        private Product[] _products;
        public ProductProvider()
        {
            _products = new Product[16];
           /* Init();*/
        }

        public Product[] Init()
        {
            /*var minCost = 10;
            var maxCost = 100;
            int numOfProd;
            ProdNames prodName;
            var endOfProdNames = (int)ProdNames.EndOfProdNames;
            for (var i = 0; i < _products.Length; i++)
            {
                numOfProd = new Random().Next(0, endOfProdNames);
                prodName = (ProdNames)numOfProd;
                _products[i] = new Product { Name = prodName.ToString(), Cost = new Random().Next(minCost, maxCost) };
            }*/
            var minCost = 10;
            var maxCost = 100;
            _products[0] = new Product { Name = ProdNames.Apple.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[1] = new Product { Name = ProdNames.Banana.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[2] = new Product { Name = ProdNames.Buriak.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[3] = new Product { Name = ProdNames.Cabbage.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[4] = new Product { Name = ProdNames.Carrot.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[5] = new Product { Name = ProdNames.Dill.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[6] = new Product { Name = ProdNames.Flour.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[7] = new Product { Name = ProdNames.Juehtw.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[8] = new Product { Name = ProdNames.Orange.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[9] = new Product { Name = ProdNames.Parsley.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[10] = new Product { Name = ProdNames.Pineapple.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[11] = new Product { Name = ProdNames.Potato.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[12] = new Product { Name = ProdNames.Tomato.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[13] = new Product { Name = ProdNames.Strawberry.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[14] = new Product { Name = ProdNames.Blueberry.ToString(), Cost = new Random().Next(minCost, maxCost) };
            _products[15] = new Product { Name = ProdNames.Juehtw.ToString(), Cost = new Random().Next(minCost, maxCost) };
            return _products;
        }
    }
}
