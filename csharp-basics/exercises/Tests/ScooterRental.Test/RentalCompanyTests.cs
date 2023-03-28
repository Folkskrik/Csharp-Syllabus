using FluentAssertions;
using Moq.AutoMock;

namespace ScooterRental.Test
{
    public class RentalCompanyTests
    {
        private IRentalCompany _company;
        private const string CompanyName = "test";
        private AutoMocker _mocker;

        [SetUp]
        public void Setup()
        {
            _mocker = new AutoMocker();
            _company = new RentalCompany(CompanyName, _mocker.GetMock<IScooterService>().Object);
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

            scooter.IsRented.Should().BeTrue();
        }

        [Test]

        public void EndRent_()
        {

        }
    }
}