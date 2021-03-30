using System;

namespace oop_workshop_master
{
    public class FactorReward : IReward
    {
        int factor;
        Category category;
        public FactorReward(int factor, Category category)
        {
            this.factor = factor;
            this.category = category; 
        }
        public int CalcPoint(Check check)
        {
            return check.getCostByCategory(this.category) * (this.factor - 1);
        }
    }
}