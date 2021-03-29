using System;
using System.Collections.Generic;

namespace Tests
{
    public class Check
    {
        private List<Product> products = new List<Product>();


        public int GetTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in products)
            {
                totalCost += product.price;
            }
            return totalCost;
        }

        internal void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}