using System;

namespace oop_workshop_master
{
    public class ByCategory : ICondition
    {
        Category category;
        public ByCategory(Category category)
        {
            this.category = category;
        }
        public bool Decision(Check check)
        {            
            return check.getCostByCategory(this.category) > 0;
        }
        
    }
}