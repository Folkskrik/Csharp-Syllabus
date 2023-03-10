using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class Poster : Advert
    {
        private double width;
        private double height;
        private int numCopies;
        private double costPerCopy;

        public Poster(double width, double height, int numCopies, double costPerCopy)
        {
            width = width;
            height = height;
            numCopies = numCopies;
            costPerCopy = costPerCopy;
        }

        public override double Cost()
        {
            return(int)(numCopies * costPerCopy);
        }

        public override string ToString()
        {
            return $"Poster: Width={width}, Height={height}, Copies={numCopies}, Cost per copy={costPerCopy}";
        }
    }
}
