using System;
using System.Collections.Generic;

namespace oop_workshop_master
{
    public class AnyGoodOffer : Offer
    {
        public readonly int totalCost;
        public readonly int points;

        public AnyGoodOffer(int totalCost, int points)
        {
            this.totalCost = totalCost;
            this.points = points;
        }
        public override void Apply(Check check)
        {
            if (this.totalCost <= check.GetTotalCost())
            {
                check.AddPoints(this.points);
            }
        }
    }
}