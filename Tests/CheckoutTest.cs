using System;
using Xunit;
using oop_workshop_master;

namespace Tests
{
    public class ChekoutTesk
    {
        Product milk_7 = new Product(7, "Milk");
        Product bread_3 = new Product(3, "Bread");
        CheckoutServise checkoutServise = new CheckoutServise();

        [Fact]
        void closeCheck_withAddProduct()
        {
            checkoutServise.openCheck();

            
            checkoutServise.AddProduct(milk_7);
            Check check = checkoutServise.closeCheck();
            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        void closeCheck_withAddTwoProducts()
        {
            checkoutServise.openCheck();

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
    }
}