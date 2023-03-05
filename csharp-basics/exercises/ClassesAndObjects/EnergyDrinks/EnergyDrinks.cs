using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyDrinks
{
    class EnergyDrinkSurvey
    {
        public int NumberedSurveyed { get; private set; }
        private double PurchasedEnergyDrinks { get; }
        private double PreferCitrusDrinks { get; }

        public EnergyDrinkSurvey(int numberedSurveyed, double purchasedEnergyDrinks, double preferCitrusDrinks)
        {
            NumberedSurveyed = numberedSurveyed;
            PurchasedEnergyDrinks = purchasedEnergyDrinks;
            PreferCitrusDrinks = preferCitrusDrinks;
        }

        public int CalculateEnergyDrinkers()
        {
            return (int)Math.Round(NumberedSurveyed * PurchasedEnergyDrinks);
        }

        public int CalculatePreferCitrus()
        {
            return (int)Math.Round(CalculateEnergyDrinkers() * PreferCitrusDrinks);
        }
    }
}