using System;

namespace oop_workshop_master
{
    public class TatalCost : ICondition
    {
        int totalcost;
        public TatalCost(int totalcost)
        {
            this.totalcost = totalcost;
        }
        public bool Decision(Check check)
        {
            return this.totalcost <= check.GetTotalCost();
        }

    }
}