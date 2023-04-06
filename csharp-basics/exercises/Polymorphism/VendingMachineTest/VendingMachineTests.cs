using System;
using FluentAssertions;
using NUnit.Framework.Internal;
using VendingMachine;

namespace VendingMachineTest
{
    public class VendingMachineTests
    {
        private VendingMachine.VendingMachine _machine;
        private Product[] _products;

        [SetUp]
        public void Setup()
        {
            _machine = new VendingMachine.VendingMachine("yes");
            _products = new Product[0];
        }

        [Test]
        public void Manufacturer_Get_ReturnsCorrectValue()
        {
            var manufacturer = _machine.Manufacturer;

            manufacturer.Should().Be("yes");
        }

        [Test]
        public void HasProducts_NoProducts_ReturnsFalse()
        {
            _machine.HasProducts.Should().BeFalse();
        }

        [Test]
        public void HasProducts_ProductsAvailable_ReturnsTrue()
        {
            var machine = new VendingMachine.VendingMachine("yes");
            machine.AddProduct("Pepsi", new Money(1,50), 3);

            var hasProducts = machine.HasProducts;

            hasProducts.Should().BeTrue();
        }

        [Test]
        public void Products_Set_GetReturnsSameValue()
        {
            var expectedProducts = new Product[]
            {
                new Product { Name = "Skittles", Price = new Money(1, 0), Available = 3 },
                new Product { Name = "Pepsi", Price = new Money(1, 50), Available = 5 }
            };

            _machine.Products = expectedProducts;
            var actualProducts = _machine.Products;

            actualProducts = _machine.Products;

            actualProducts.Should().BeEquivalentTo(expectedProducts);
        }

        [Test]
        public void AddProduct_ValidInput_ProductAdded()
        {
            var machine = new VendingMachine.VendingMachine("yes");
            var expectedProduct = new Product { Name = "Skittles", Price = new Money(1,0),  Available = 3 };

            var result = machine.AddProduct(expectedProduct.Name, expectedProduct.Price, expectedProduct.Available);

            result.Should().BeTrue();
        }

        [Test]
        public void AddProduct_InvalidInput_ReturnsFalse()
        {
            var machine = new VendingMachine.VendingMachine("yes");

            var result = machine.AddProduct(null, new Money(1, 0), 3);

            result.Should().BeFalse();
        }

        [Test]
        public void UpdateProducts_ValidProductGiven_UpdatesProduct()
        {
            var machine = new VendingMachine.VendingMachine("yes");
            machine.AddProduct("Pepsi", new Money(1, 50), 3);

            var result = machine.UpdateProduct(0, "Coke", new Money(2, 0), 5);

            result.Should().BeTrue();
        }

        [Test]
        public void UpdateProducts_InvalidProductGiven_ProductNotUpdated()
        {
            var machine = new VendingMachine.VendingMachine("yes");
            machine.AddProduct("Pepsi", new Money(1, 50), 3);

            var result = machine.UpdateProduct(1, "Coke", new Money(2, 0), 5);

            result.Should().BeFalse();
        }

        [Test]
        public void UpdateProduct_InvalidPrice_ReturnsFalse()
        {
            var machine = new VendingMachine.VendingMachine("yes");
            machine.AddProduct("Pepsi", new Money(2, 0), 5);

            var result = machine.UpdateProduct(0, null, new Money(-1, 0), 3);

            result.Should().BeFalse();
            machine.Products[0].Price.Should().Be(new Money(2, 0));
        }

        [Test]
        public void UpdateProduct_NegativeAmount_ReturnsFalse()
        {
            var machine = new VendingMachine.VendingMachine("yes");
            machine.AddProduct("Pepsi", new Money(2, 0), 5);

            var result = machine.UpdateProduct(0, "Coke", new Money(2, 0), -1);

            result.Should().BeFalse();
            machine.Products[0].Available.Should().Be(5);
        }

        [Test]
        public void UpdateProduct_ProductNameUpdated_ReturnsTrue()
        {
            var machine = new VendingMachine.VendingMachine("yes");
            machine.AddProduct("Pepsi", new Money(1, 50), 3);
            var productToUpdate = machine.Products[0];
            var newProductName = "Coke";

            var result = machine.UpdateProduct(0, newProductName, null, 0);

            result.Should().BeTrue();
        }

        [Test]
        public void InsertCoin_CoinInserted_AmountIncreases()
        {
            _machine.InsertCoin(new Money(1,0)).Should().Be(_machine.Amount);
        }

        [Test]
        public void InsertCoin_TurnCentsToEuros_AmountIncreases()
        {
            var expectedMoney = new Money(2,50);

            _machine.InsertCoin(new Money(0, 50));
            _machine.InsertCoin(new Money(0, 50));
            _machine.InsertCoin(new Money(0, 50));
            _machine.InsertCoin(new Money(0, 50));
            _machine.InsertCoin(new Money(0, 50));
        }

        [Test]
        public void InvalidMoney_MoneyInvalid_InvalidMoney()
        {
            _machine.IsValidMoney(new Money(0, 30)).Should().BeFalse();
        }

        [Test]
        public void ReturnMoney_InsertedNoMoney_ReturnsNoMoney()
        {
            var returnedMoney = _machine.ReturnMoney();

            returnedMoney.Should().Be(new Money(0, 0));
        }

        [Test]
        public void ReturnedMoney_InsertedMoney_InsertedMoneyReturns()
        {
            var insertedMoney = new Money(2, 50);
            _machine.InsertCoin(insertedMoney);

            var returnedMoney = _machine.ReturnMoney();

            returnedMoney.Should().Be(insertedMoney);
        }
    }
}