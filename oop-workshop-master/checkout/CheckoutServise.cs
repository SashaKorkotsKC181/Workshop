using System;
using System.Collections.Generic;

namespace oop_workshop_master
{
    public class CheckoutServise
    {
        private Check check;
        List<Offer> offers;

        public void openCheck()
        {
            check = new Check();
            offers = new List<Offer>();
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
            UseOffers();
            Check closedCheck = check;
            check = null;
            return closedCheck;
        }
        public void AddOffer(Offer offer)
        {
            offers.Add(offer);
        }

        void UseOffer(Offer offer)
        {
            offer.Apply(check);
        }
        void UseOffers()
        {
            if (offers.Count != 0)
            {
                foreach (Offer offer in offers)
                {
                    UseOffer(offer);
                }
            }
        }
    }
}