using System;

namespace oop_workshop_master
{
    public class Gift : IDiscountRule
    {
        Product product;
        int count;
        public Gift(Product product, int count)
        {
            this.product = product;
            this.count = count;
        }
        public int CalcDiscount(Check check) 
        {
            return 
        }
    }
}