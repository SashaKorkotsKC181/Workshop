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

        public void UseOffer(Offer offer)
        {
            offer.Apply(check);
        }
    }
}