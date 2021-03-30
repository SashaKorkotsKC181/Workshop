using System;

namespace oop_workshop_master
{
    public class BonusOffer : Offer
    {
        internal readonly int totalCost;
        internal readonly int points;
        

        public BonusOffer(int totalCost, int points, DateTime endOfValidity ) : base(endOfValidity)
        {
            this.totalCost = totalCost;
            this.points = points;
        }

        internal override bool Condition(Check check)
        {
            return this.totalCost <= check.GetTotalCost();
        }
        internal override int HowMuchPoints(Check check)
        {
            return this.points;
        }
    }
}