using System;

namespace oop_workshop_master
{
    public class DiscanOffer : Offer
    {
        private Product product;
        private int discantPicent;

        public DiscanOffer(Product product, int discantPicent, DateTime endDiscant) : base(endDiscant)
        {
            this.product = product;
            this.discantPicent = discantPicent;
        }
        /*internal override void UseOffer(Check check)
        {
            double points = check.getCostByProduct(product);
            double discantInDouble = discantPicent;
            check.AddDiscont(Convert.ToInt32(points * (discantInDouble / 100)));
        }*/
        internal override bool Condition(Check check)
        {
            return true;
        }

        internal override int HowMuchPoints(Check check)
        {
            return 0;
        }
    }
}