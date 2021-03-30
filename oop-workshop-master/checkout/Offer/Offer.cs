using System;

namespace oop_workshop_master
{
    public abstract class Offer
    {
        DateTime expiration;
        Condition condition;

        public Offer(DateTime expiration)
        {
            this.expiration = expiration;
        }
        internal virtual void Apply(Check check)
        {
            if (IsOfferValidity() && Condition(check)) 
            {
                check.AddPoints(HowMuchPoints(check));
            }
        }
        abstract internal bool Condition(Check check); 
        abstract internal int HowMuchPoints(Check check);

        bool IsOfferValidity()
        {
            return DateTime.Now < this.expiration;
        }
    }
}