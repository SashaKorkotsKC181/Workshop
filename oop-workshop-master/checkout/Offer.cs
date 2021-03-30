using System;

namespace oop_workshop_master
{
    public abstract class Offer
    {
        DateTime endOfValidity;
        public Offer(DateTime endOfValidity)
        {
            this.endOfValidity = endOfValidity;
        }
        public abstract void Apply(Check check);

        internal virtual bool IsOfferValidity()
        {
            return DateTime.Now < this.endOfValidity;
        }
    }
}