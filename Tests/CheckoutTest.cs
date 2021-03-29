using System;
using Xunit;
using oop_workshop_master;

namespace Tests
{
    public class ChekoutTesk
    {
        [Fact]
        void closeCheck_withAddProduct()
        {
            CheckoutServise checkoutServise = new CheckoutServise();
            checkoutServise.openCheck();

            checkoutServise.AddProduct(new Product(7, "Milk"));
            Check check = checkoutServise.closeCheck();
            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        void closeCheck_withAddTwoProducts()
        {
            CheckoutServise checkoutServise = new CheckoutServise();
            checkoutServise.openCheck();

            checkoutServise.AddProduct(new Product(7, "Milk"));
            checkoutServise.AddProduct(new Product(3, "Bread"));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalCost(), 10);
        }

        [Fact]
        void AddProduct_whenCHeckIsCLosed_opensNewCheck()
        {
            CheckoutServise checkoutServise = new CheckoutServise();

            checkoutServise.AddProduct(new Product(7, "Milk"));            
            Check checkMilk = checkoutServise.closeCheck();
            Assert.Equal(checkMilk.GetTotalCost(), 7);

            checkoutServise.AddProduct(new Product(3, "Bread"));
            Check checkBread = checkoutServise.closeCheck();
            Assert.Equal(checkBread.GetTotalCost(), 3);
        }
    }
}