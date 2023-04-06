using FluentAssertions;
using Moq;
using Moq.AutoMock;
using ScooterRental.Exceptions;
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
        public void StartRent_InvalidScooterId_ShouldThrowScooterNotFoundException()
        {
            var invalidScooterId = "invalidId";
            var mockScooterService = _mocker.GetMock<IScooterService>();
            mockScooterService.Setup(x => x.GetScooterById(invalidScooterId)).Throws<ScooterNotFoundException>();

            Action act = () => _company.StartRent(invalidScooterId);

            act.Should().Throw<ScooterNotFoundException>();
        }

        [Test]
        public void StartRent_AlreadyRentedScooter_ShouldThrowScooterAlreadyRentedException()
        {
            var rentedScooterId = "rentedId";
            var mockScooterService = _mocker.GetMock<IScooterService>();
            mockScooterService.Setup(x => x.GetScooterById(rentedScooterId)).Throws<ScooterAlreadyRentedException>();

            Action act = () => _company.StartRent(rentedScooterId);

            act.Should().Throw<ScooterAlreadyRentedException>();
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
        public void EndRent_RentedMoreThanOneDay_RentSopped()
        {
            var scooter = new Scooter("1", 1m) { IsRented = true };
            var rentedScooter = new RentedScooter("1", 1m, It.IsAny<DateTime>())
            {
                RentEnded = DateTime.UtcNow,
            };

            var scooterService = _mocker.GetMock<IScooterService>();

            scooterService.Setup(x => x.GetScooterById("1")).Returns(scooter);
            _mocker.GetMock<IRentalArchive>()
                .Setup(s => s.EndRent("1", It.IsAny<DateTime>().AddDays(2))).Returns(rentedScooter);
            _mocker.GetMock<IRentalCalculator>().Setup(s => s.CalculateRent(rentedScooter)).Returns(40m);

            _company.EndRent("1").Should().Be(40m);

            scooter.IsRented.Should().BeFalse();
        }

        [Test]
        public void EndRent_InvalidIdProvided_ShouldThrowScooterIdNotProvidedException()
        {
            var invalidScooterId = "";

            Action act = () => _company.EndRent(invalidScooterId);

            act.Should().Throw<ScooterIdNotProvidedException>();
        }

        [Test]
        public void CalculateIncome()
        {
            
        }
    }
}