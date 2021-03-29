using System;
using Tests;

namespace oop_workshop_master
{
    public class CheckoutServise
    {
        private Check check;

        public void openCheck()
        {
            check = new Check();

        }

        public void AddProduct(Product product)
        {
            check.AddProduct(product);
        }

        public Check closeCheck()
        {
            return check;
        }
    }
}