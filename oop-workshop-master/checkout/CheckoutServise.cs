using System;

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
            if (check == null)
            {
                openCheck();
            }
            check.AddProduct(product);
        }

        public Check closeCheck()
        {
            Check closedCheck = check;
            check = null;
            return closedCheck;
        }

        public void UseOffer(AnyGoodOffer offer)
        {
            if (new FactorByCategoryOffer(Category.MILK, 2).GetType().IsInstanceOfType(offer))
            {
                FactorByCategoryOffer fbOffer = (FactorByCategoryOffer)offer;
                int points = check.getCostByCategory(fbOffer.category);

                check.AddPoints(points * (fbOffer.factor - 1));
            }
            else if (offer.totalCost <= check.GetTotalCost())
            {
                check.AddPoints(offer.points);
            }
        }
    }
}