using System;

namespace oop_workshop_master
{
    public class FactorByCategoryOffer : Offer
    {
        public Category category;
        public int factor;

        public FactorByCategoryOffer(Category category, int factor, DateTime endOfValidity ) : base(endOfValidity)
        {
            this.category = category;
            this.factor = factor;
        }
        public override void Apply(Check check)
        {
            int points = check.getCostByCategory(this.category);

            check.AddPoints(points * (this.factor - 1));
        }
    }
}