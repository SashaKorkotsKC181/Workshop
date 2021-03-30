using System;
using System.Collections.Generic;

namespace oop_workshop_master
{
    public class Check
    {
        List<Product> products = new List<Product>();        
        int points = 0;
        int discont = 0;
        Check check;
        public int GetTotalCost()
        {
            int totalCost = 0;
            foreach (Product product in products)
            {
                totalCost += product.price;
            }
            return totalCost - this.discont;
        }

        internal void AddProduct(Product product)
        {
            products.Add(product);
        }

        internal void AddDiscont(int discont)
        {
            this.discont += discont;
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
            if (category == Category.NONE)
            {
                return 0;
            }
            int costOfCategoty = 0;
            foreach (Product prod in this.products)
            {
                if (prod.category == category)
                {
                    costOfCategoty += prod.price;
                }
            }
            return costOfCategoty;
        }
        internal int getCostByProduct(Product product)
        {
            int costOfProduct = 0;
            foreach (Product prod in this.products)
            {
                if (prod.IsExactly(product))
                {
                    costOfProduct += prod.price;
                }
            }
            return costOfProduct;
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
    }
}