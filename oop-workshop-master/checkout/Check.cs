using System;
using System.Collections.Generic;

namespace oop_workshop_master
{
    public class Check
    {
        private List<Product> products = new List<Product>();

        int points = 0;
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

        internal int getCostByTrademark(Trademark trademark)
        {
            if (trademark == Trademark.NONE)
            {
                return 0;
            }
            int costOfTrademark = 0;
            foreach (Product prod in this.products)
            {
                if (prod.trademark == trademark)
                {
                    costOfTrademark += prod.price;
                }
            }
            return costOfTrademark;
        }

        public int GetTotalPoints()
        {
            return GetTotalCost() + points;
        }

        internal void AddPoints(int points)
        {
            this.points += points; 
        }

        internal int getCostByCategory(Category category)
        {
            int costOfCategoty = 0;
            foreach (Product prod in this.products)
            {
                if (prod.catagory == category)
                {
                    costOfCategoty += prod.price;
                }
            }
            return costOfCategoty;
        }
    }
}