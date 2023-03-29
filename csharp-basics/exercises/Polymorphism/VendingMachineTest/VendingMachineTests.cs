using FluentAssertions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
using VendingMachine;

namespace VendingMachineTest
{
    public class VendingMachineTests
    {
        private IVendingMachine _machine;
        private List<Product> _products;

        [SetUp]
        public void Setup()
        {
            _machine = new VendingMachine.VendingMachine("yes");
            _products = new List<Product>();
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
            machine.AddProduct("Pepsi", new Money(), 3);

            var hasProducts = machine.HasProducts;

            hasProducts.Should().BeTrue();
        }

    }
}