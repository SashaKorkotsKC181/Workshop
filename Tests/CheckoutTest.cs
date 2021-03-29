using System;
using Xunit;
using oop_workshop_master;

namespace Tests
{
    public class ChekoutTesk
    {
        [Fact]
        public void closeCheck_withAddProduct()
        {
            CheckoutServise checkoutServise = new CheckoutServise();
            checkoutServise.openCheck();

            checkoutServise.AddProduct(new Product(7,"Milk"));
            Check check = checkoutServise.closeCheck();
            Assert.Equal(check.GetTotalCost(), 7);
        }

        [Fact]
        public void closeCheck_withAddTwoProducts()
        {
            CheckoutServise checkoutServise = new CheckoutServise();
            checkoutServise.openCheck();

            checkoutServise.AddProduct(new Product(7,"Milk"));
            checkoutServise.AddProduct(new Product(3,"Bread"));
            Check check = checkoutServise.closeCheck();

            Assert.Equal(check.GetTotalCost(), 10);
        }
    }
}