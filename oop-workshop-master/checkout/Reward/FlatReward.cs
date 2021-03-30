using System;

namespace oop_workshop_master
{
    public class FlatReward : IReward
    {
        private int points;

        public FlatReward(int points)
        {
            this.points = points;
        }
        public int CalcPoint(Check check)
        {
            return this.points;
        }
    }
}