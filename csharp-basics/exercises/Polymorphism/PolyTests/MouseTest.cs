using FluentAssertions;
using Persons;

namespace HierarcyTest
{
    public class TestsMouse
    {
        private Animal _mouse;

        [SetUp]
        public void Setup()
        {
            _mouse = new Mouse("Jerry", 0.1, "House - Basement");
        }

        [Test]
        public void MakeSound_MakeAnimalSound_AnimalMakesSound()
        {
            var mouseSound = "Squeeek";
            var conslOut = new StringWriter();
            Console.SetOut(conslOut);

            _mouse.MakeSound();
            var sound = conslOut.ToString().Trim();

            Assert.AreEqual(mouseSound, sound);
        }

        [Test]
        public void Eat_GiveAnimalVegetable_AnimalEatsVegetable()
        {
            _mouse.Eat(new Vegetable(5));

            _mouse.FoodEaten.Should().Be(5);
        }

        [Test]
        public void Eat_GiveAnimalMeat_AnimalEatsMeat()
        {
            Action act = () => _mouse.Eat(new Meat(5));

            act.Should().Throw<MouseInvalidFoodException>();
        }

        [Test]
        public void ToString_GivenAnimal_ShouldBeGivenString()
        {
            _mouse.ToString().Should().Be("Mouse [Jerry, 0,1, House - Basement, 0]");
        }
    }
}