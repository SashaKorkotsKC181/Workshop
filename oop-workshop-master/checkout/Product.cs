namespace oop_workshop_master

{
    public class Product
    {
        public int price;
        public string name;
        public Category catagory;

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
    }
}