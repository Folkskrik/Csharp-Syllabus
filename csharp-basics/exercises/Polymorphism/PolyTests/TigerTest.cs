using FluentAssertions;
using Persons;

namespace HierarcyTest
{
    public class TestsTiger
    {
        private Animal _tiger;

        [SetUp]
        public void Setup()
        {
            _tiger = new Tiger("Sergey", 200, "Jungle");
        }

        [Test]
        public void MakeSound_MakeAnimalSound_AnimalMakesSound()
        {
            var tigroSound = "Rawr!";
            var conslOut = new StringWriter();
            Console.SetOut(conslOut);

            _tiger.MakeSound();
            var sound = conslOut.ToString().Trim();

            Assert.AreEqual(tigroSound, sound);
        }

        [Test]
        public void Eat_GiveAnimalMeat_AnimalEatsMeat()
        {
            _tiger.Eat(new Meat(3));

            _tiger.FoodEaten.Should().Be(3);
        }

        [Test]
        public void Eat_GiveAnimalMeat_AnimalEatsVegetable()
        {
            Action act = () => _tiger.Eat(new Vegetable(5));

            act.Should().Throw<TigroFoodInvalidException>();
        }

        [Test]
        public void ToString_GivenAnimal_ShouldBeGivenString()
        {
            _tiger.ToString().Should().Be("Tiger [Sergey, 200, Jungle, 0]");
        }
    }
}