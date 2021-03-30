using System;

namespace oop_workshop_master
{
    public interface IDiscountRule
    {        
        int CalcDiscount(Check check);
    }
}