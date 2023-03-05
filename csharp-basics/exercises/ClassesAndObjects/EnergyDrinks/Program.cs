using System;

namespace EnergyDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            EnergyDrinkSurvey survey = new EnergyDrinkSurvey(12467, 0.14, 0.64);

            Console.WriteLine("Total number of people surveyed: " + survey.NumberedSurveyed);
            Console.WriteLine("Approximately " + survey.CalculateEnergyDrinkers() + " bought at least one energy drink.");
            Console.WriteLine(survey.CalculatePreferCitrus() + " of those " + "prefer citrus flavored energy drinks.");
        }
    }
}