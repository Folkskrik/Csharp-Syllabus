using FluentAssertions;
using Persons;
using System.Xml.Linq;

namespace HierarchyTest
{
    public class TestsCat
    {

        private Animal _cat;

        [SetUp]
        public void Setup()
        {
            _cat = new Cat("Tom", 2.5, "Home", "Persian");
        }

        [Test]
        public void MakeSound_MakeAnimalSound_AnimalMakesSound()
        {
            var catSound = "Meow";
            var conslOut = new StringWriter();
            Console.SetOut(conslOut);

            _cat.MakeSound();
            var sound = conslOut.ToString().Trim();

            Assert.AreEqual(catSound, sound);
        }

        [Test]
        public void Eat_GiveAnimalVegetable_AnimalEatsVegetable()
        {
            _cat.Eat(new Vegetable(5));

            _cat.FoodEaten.Should().Be(5);
        }

        [Test]
        public void Eat_GiveAnimalMeat_AnimalEatsMeat()
        {
            _cat.Eat(new Meat(3));

            _cat.FoodEaten.Should().Be(3);
        }

        [Test]
        public void ToString_GivenAnimal_ShouldBeGivenString()
        {
            _cat.ToString().Should().Be("Cat [Tom, 2,5, Home, 0, Persian]");
        }
    }
}