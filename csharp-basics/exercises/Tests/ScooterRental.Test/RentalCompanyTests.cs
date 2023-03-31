using FluentAssertions;
using Moq;
using Moq.AutoMock;
using ScooterRental.Interfaces;
using ScooterRental.Models;

namespace ScooterRental.Test
{
    public class RentalCompanyTests
    {
        private IRentalCompany _company = null!;
        private const string CompanyName = "test";
        private AutoMocker _mocker = null!;

        [SetUp]
        public void Setup()
        {
            _mocker = new AutoMocker();
            _company = new RentalCompany(CompanyName,
                _mocker.GetMock<IScooterService>().Object,
                _mocker.GetMock<IRentalArchive>().Object,
                _mocker.GetMock<IRentalCalculator>().Object);
        }

        [Test]
        public void CreateRentalCompany_TestAsNameProvided_NameShouldBeTest()
        {
            _company.Name.Should().Be(CompanyName);
        }

        [Test]
        public void StartRent_ValidIdProvided_ScooterIsRented()
        {
            var scooter = new Scooter("1", 1m);
            var mock = _mocker.GetMock<IScooterService>();
            mock.Setup(x => x.GetScooterById("1")).Returns(scooter);

            _company.StartRent("1");
            _mocker.GetMock<IRentalArchive>().Verify(s => s.AddRent("1", 1m, It.IsAny<DateTime>()), Times.Once);
            scooter.IsRented.Should().BeTrue();
        }

        [Test]

        public void EndRent_ValidIdProvided_ScooterRentStopped()
        {
            var scooter = new Scooter("1", 1m) { IsRented = true };
            var rentedScooter = new RentedScooter("1", 1m, DateTime.UtcNow.AddHours(-2))
            {
                RentEnded = DateTime.UtcNow,
            };
            
            var scooterService = _mocker.GetMock<IScooterService>();

            scooterService.Setup(x => x.GetScooterById("1")).Returns(scooter);
            _mocker.GetMock<IRentalArchive>()
                .Setup(s => s.EndRent("1", It.IsAny<DateTime>())).Returns(rentedScooter);

            _mocker.GetMock<IRentalCalculator>().Setup(s => s.CalculateRent(rentedScooter)).Returns(20m);
            
            _company.EndRent("1");

            scooter.IsRented.Should().BeFalse();

        }

        [Test]

        public void CalculateIncome()
        {
            var rentals = new List<RentedScooter>();
            _mocker.GetMock<IRentalArchive>().Setup(s => s.GetRentedScooterArchive())
                .Returns(rentals);
            _mocker.GetMock<IRentalCalculator>().Setup(s => s.CalculateIncome(rentals)).Returns(0);
            var result = _company.CalculateIncome(null, false);
            result.Should().Be(0);
        }
    }
}