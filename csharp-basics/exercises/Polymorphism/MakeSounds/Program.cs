using System;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var firework = new Firework();
            var parrot1 = new Parrot("I want a cracker!");
            var parrot2 = new Parrot("Double or nothing!");
            var radio1 = new Radio("SWH radio station");
            var radio2 = new Radio("101.5 new station in the region!");

            ISound[] sounds = {firework, parrot1, parrot2, radio1, radio2};

            foreach (ISound sound in sounds)
            {
                sound.PlaySound();
            }

            Console.ReadLine();
        }
    }
}