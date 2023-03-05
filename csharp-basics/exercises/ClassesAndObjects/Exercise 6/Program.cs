using System;

public class DogTest
{
    static void Main(string[] args)
    {
        Dog max = new Dog("Max", "male");
        Dog rocky = new Dog("Rocky", "male");
        Dog sparky = new Dog("Sparky", "male");
        Dog buster = new Dog("Buster", "male");
        Dog sam = new Dog("Sam", "male");
        Dog lady = new Dog("Lady", "female");
        Dog molly = new Dog("Molly", "female");
        Dog coco = new Dog("Coco", "female");

        max.Mother = lady;
        max.Father = rocky;

        coco.Mother = molly;
        coco.Father = buster;

        rocky.Mother = molly;
        rocky.Father = sam;

        buster.Mother = lady;
        buster.Father = sparky;

        Console.WriteLine("Fathers Name:");
        Console.WriteLine("Coco's father's name: " + coco.FathersName());
        Console.WriteLine("Sparky's father's name: " + sparky.FathersName());

        Console.WriteLine("\nHas Same Mother:");
        bool hasSameMother = coco.HasSameMotherAs(rocky);
        Console.WriteLine("Coco and Rocky have the same mother: " + hasSameMother);
    }
}