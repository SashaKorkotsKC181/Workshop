using System;

namespace oop_workshop_master
{
    public class FactorByCategoryOffer : Offer
    {
        internal readonly Category category;
        internal readonly int factor;
        internal readonly Trademark trademark;
        int points;
        public FactorByCategoryOffer(Trademark trademark, DateTime endOfValidity ) : base(endOfValidity)
        {
            this.trademark = trademark;
        }
        public FactorByCategoryOffer(Category category, int factor, DateTime endOfValidity ) : base(endOfValidity)
        {
            this.category = category;
            this.factor = factor;
        }

        internal override bool Condition(Check check)
        {
            return check.getCostByCategory(this.category) > 0;
        }

        internal override int HowMuchPoints(Check check)
        {
            return check.getCostByCategory(this.category) * (this.factor - 1);
        }
    }
}