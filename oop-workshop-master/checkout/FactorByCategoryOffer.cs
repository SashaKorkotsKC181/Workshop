using System;

namespace oop_workshop_master
{
    public class FactorByCategoryOffer : AnyGoodOffer
    {
        public Category category;
        public int factor;

        public FactorByCategoryOffer(Category category, int factor) : base(0, 0)
        {
            this.category = category;
            this.factor = factor;
        }
    }
}