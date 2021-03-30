using System;
using Xunit;
using oop_workshop_master;

namespace Tests
{
    public class ChekoutTesk
    {
        Product milk_7 = new Product(7, "Milk", Category.MILK);
        Product bread_3 = new Product(3, "Bread");
        CheckoutServise checkoutServise = new CheckoutServise();

        [Fact]
        void closeCheck_withAddProduct()
        {


            checkoutServise.AddProduct(milk_7);
            Check check = checkoutServise.closeCheck();
            Assert.Equal(7, check.GetTotalCost());
        }

        [Fact]
        void closeCheck_withAddTwoProducts()
        {

            checkoutServise.AddProduct(milk_7);

            checkoutServise.AddProduct(bread_3);
            Check check = checkoutServise.closeCheck();

            Assert.Equal(10, check.GetTotalCost());
        }

        [Fact]
        void AddProduct_whenCHeckIsCLosed_opensNewCheck()
        {


            checkoutServise.AddProduct(milk_7);
            Check checkMilk = checkoutServise.closeCheck();
            Assert.Equal(7, checkMilk.GetTotalCost());

            checkoutServise.AddProduct(bread_3);
            Check checkBread = checkoutServise.closeCheck();
            Assert.Equal(3, checkBread.GetTotalCost());
        }

        [Fact]
        void closeCheck_calcTOtalPoints()
        {

            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);
            Check check = checkoutServise.closeCheck();

            Assert.Equal(10, check.GetTotalPoints());
        }

        [Fact]
        void useOffer_addOfferPoints()
        {

            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            checkoutServise.AddOffer(new AnyGoodOffer(6, 2, new DateTime(2021,3,31)));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(12, check.GetTotalPoints());
        }

        [Fact]
        void useOffer_whenCostLessThanRequired_doNothing()
        {
            checkoutServise.AddProduct(bread_3);


            checkoutServise.AddOffer(new AnyGoodOffer(6, 2, new DateTime(2021,3,31)));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(3, check.GetTotalPoints());
        }

        [Fact]
        void useOffer_factorByCategory()
        {
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            checkoutServise.AddOffer(new FactorByCategoryOffer(Category.MILK, 2, new DateTime(2021,3,31)));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(31, check.GetTotalPoints());
        }

        [Fact]
        public void useOffer_BeforeEndOfAddProduction()
        {
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddOffer(new FactorByCategoryOffer(Category.MILK, 2, new DateTime(2021,3,31)));
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            
            Check check = checkoutServise.closeCheck();

            Assert.Equal(31, check.GetTotalPoints());
        }

        [Fact]
        public void useOffer_IfVarity()
        {
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddOffer(new FactorByCategoryOffer(Category.MILK, 2, new DateTime(2021,3,31)));
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            
            Check check = checkoutServise.closeCheck();

            Assert.Equal(31, check.GetTotalPoints());
        }

        [Fact]
        public void useOffer_factorByTrademarkOrCategory()
        {
            Product milk_5_Farm = new Product(5,"childrenMilk",Category.MILK,Trademark.FARM);
            checkoutServise.AddProduct(milk_5_Farm);
            checkoutServise.AddOffer(new FactorByCategoryOffer(Trademark.FARM,new DateTime(2021,3,31)));
            

            Check check = checkoutServise.closeCheck();
            Assert.Equal(10, check.GetTotalPoints());
        }
    }
}