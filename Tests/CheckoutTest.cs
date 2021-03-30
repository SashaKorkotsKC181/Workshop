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
            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        void closeCheck_withAddTwoProducts()
        {

            checkoutServise.AddProduct(milk_7);

            checkoutServise.AddProduct(bread_3);
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalCost(), 10);
        }

        [Fact]
        void AddProduct_whenCHeckIsCLosed_opensNewCheck()
        {


            checkoutServise.AddProduct(milk_7);
            Check checkMilk = checkoutServise.closeCheck();
            Assert.Equal(checkMilk.GetTotalCost(), 7);

            checkoutServise.AddProduct(bread_3);
            Check checkBread = checkoutServise.closeCheck();
            Assert.Equal(checkBread.GetTotalCost(), 3);
        }

        [Fact]
        void closeCheck_calcTOtalPoints()
        {

            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalPoints(), 10);
        }

        [Fact]
        void useOffer_addOfferPoints()
        {

            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            checkoutServise.AddOffer(new AnyGoodOffer(6, 2, new DateTime(2021,3,31)));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalPoints(), 12);
        }

        [Fact]
        void useOffer_whenCostLessThanRequired_doNothing()
        {
            checkoutServise.AddProduct(bread_3);


            checkoutServise.AddOffer(new AnyGoodOffer(6, 2, new DateTime(2021,3,31)));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalPoints(), 3);
        }

        [Fact]
        void useOffer_factorByCategory()
        {
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            checkoutServise.AddOffer(new FactorByCategoryOffer(Category.MILK, 2, new DateTime(2021,3,31)));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalPoints(), 31);
        }

        [Fact]
        public void useOffer_BeforeEndOfAddProduction()
        {
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddOffer(new FactorByCategoryOffer(Category.MILK, 2, new DateTime(2021,3,31)));
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalPoints(), 31);
        }

        [Fact]
        public void useOffer_IfVarity()
        {
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddOffer(new FactorByCategoryOffer(Category.MILK, 2, new DateTime(2021,3,31)));
            checkoutServise.AddProduct(milk_7);
            checkoutServise.AddProduct(bread_3);


            
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalPoints(), 31);
        }
    }
}