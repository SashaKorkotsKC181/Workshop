using System;

namespace oop_workshop_master
{
    public class DiscanOffer : Offer
    {
        private Category category;
        private int discantPicent;

        public DiscanOffer(Category category, int discantPicent, DateTime endDiscant) : base(endDiscant)
        {
            this.category = category;
            this.discantPicent = discantPicent;
        }
        public override void Apply(Check check)
        {
            double points = check.getCostByCategory(this.category);
            double discantInDouble = discantPicent;
            check.AddPoints(-Convert.ToInt32(points * (discantInDouble / 100)));
        }
    }
}