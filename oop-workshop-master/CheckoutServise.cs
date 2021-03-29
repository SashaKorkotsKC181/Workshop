using System;
using System.Collections.Generic;
using Tests;

namespace oop_workshop_master
{
    public class CheckoutServise
    {
        private Check check;

        public void openCheck()
        {
            check = new Check();
            check.products = new List<Product>();
            check.totalCost = 0;
        }

        public void AddProduct(Product product)
        {
            check.products.Add(product);
        }

        public Check closeCheck()
        {
            foreach (Product product in check.products)
            {
                check.totalCost += product.price;
            }
            return check;
        }
    }
}