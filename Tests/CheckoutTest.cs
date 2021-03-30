using System;
using Xunit;
using oop_workshop_master;

namespace Tests
{
    public class CheckoutTesk
    {
        private Product milk_7;
        private CheckoutServise checkoutService;
        private Product bread_3;
        public CheckoutTesk()
        {
            checkoutService = new CheckoutServise();
            milk_7 = new Product(7, "Milk", Category.MILK, Trademark.FARM);
            bread_3 = new Product(3, "Bread", Trademark.FARM);
        }

        [Fact]
        public void useOfferDiscand_AddPoins()
        {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);
            checkoutService.UseOffer(new BonusOffer(new DateTime(2023, 01, 02), new ByCategory(Category.BREAD), new FlatReward(40)));
            Check check = checkoutService.CloseCheck();
            Assert.Equal(57, check.GetTotalPoints());
        }
        [Fact]
        void UseDiscountOffer()
        {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);
            checkoutService.UseOffer(new DiscountOffer(new DateTime(2023, 01, 02), new ByTradeMark(TM.PROSTOKWASHINO), new PercentDiscount(50)));
            Check check = checkoutService.CloseCheck();
            Assert.Equal(11, check.GetTotalPoints());
        }
    }
}