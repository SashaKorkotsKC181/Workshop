namespace oop_workshop_master

{
    public class Product
    {
        internal readonly int price;
        internal readonly string name;
        internal readonly Category catagory;
        internal readonly Trademark trademark;

        public Product(int price, string name, Category category)
        {
            this.price = price;
            this.name = name;
            this.catagory = category;
        }
        public Product(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public Product(int price, string name, Category category, Trademark trademark) : this(price, name, category)
        {
            this.trademark = trademark;
        }
    }
}