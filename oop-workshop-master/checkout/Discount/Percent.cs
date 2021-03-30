using System;

namespace oop_workshop_master
{
    public class Percent
    {
        Product product;
        int discount;        
        public Percent(Product product, int discount)
        {
            this.product = product;
            this.discount = discount;
        }
        public int CalcDiscount(Check check)
        {
            double points = check.getCostByProduct(product);
            double discantInDouble = discount;
            return Convert.ToInt32(points * (discantInDouble / 100));
        }
    }
}