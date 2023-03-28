using FluentAssertions;
using VendingMachine;

namespace VendingMachineTest
{
    public class VendingMachineTests
    {
        private IVendingMachine _machine;

        [SetUp]
        public void Setup()
        {
            _machine = new VendingMachine.VendingMachine("yes");
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
            _machine.HasProducts.Should().BeTrue();
        }
    }
}