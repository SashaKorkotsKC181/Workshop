using System;

namespace oop_workshop_master
{
    public class AnyGoodOffer : Offer
    {
        internal readonly int totalCost;
        internal readonly int points;
        

        public AnyGoodOffer(int totalCost, int points, DateTime endOfValidity ) : base(endOfValidity)
        {
            this.totalCost = totalCost;
            this.points = points;
        }
        
        
        public override void Apply(Check check)
        {
            if (IsOfferValidity() && this.totalCost <= check.GetTotalCost())
            {
                check.AddPoints(this.points);
            }
            
        }
    }
}