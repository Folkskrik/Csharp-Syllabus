using FluentAssertions;
using Persons;

namespace HierarcyTest
{
    public class TestsZebra
    {
        private Animal _zebara;

        [SetUp]
        public void Setup()
        {
            _zebara = new Zebra("Marty", 350, "Land - Africa");
        }

        [Test]
        public void MakeSound_MakeAnimalSound_AnimalMakesSound()
        {
            var zebaraSound = "Braaaayy";
            var conslOut = new StringWriter();
            Console.SetOut(conslOut);

            _zebara.MakeSound();
            var sound = conslOut.ToString().Trim();

            Assert.AreEqual(zebaraSound, sound);
        }

        [Test]
        public void Eat_GiveAnimalVegetable_AnimalEatsVegetable()
        {
            _zebara.Eat(new Vegetable(5));

            _zebara.FoodEaten.Should().Be(5);
        }

        [Test]
        public void Eat_GiveAnimalMeat_AnimalEatsMeat()
        {
            Action act = () => _zebara.Eat(new Meat(5));

            act.Should().Throw<ZebaraFoodInvalidException>();
        }

        [Test]
        public void ToString_GivenAnimal_ShouldBeGivenString()
        {
            _zebara.ToString().Should().Be("Zebra [Marty, 350, Land - Africa, 0]");
        }
    }
}