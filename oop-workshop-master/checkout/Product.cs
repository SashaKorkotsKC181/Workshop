namespace oop_workshop_master

{
    public class Product
    {
        internal readonly int price;
        internal readonly string name;
        internal readonly Category category;
        internal readonly Trademark trademark;

        public Product(int price, string name, Category category)
        {
            this.price = price;
            this.name = name;
            this.category = category;
        }
        public Product(int price, string name, Trademark trademark) : this (price, name)
        {
            this.trademark = trademark;
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

        internal bool IsExactly(Product product)
        {
            return this.name == product.name && this.price == product.price && this.trademark == product.trademark && this.category == product.category;

        } 
    }
}