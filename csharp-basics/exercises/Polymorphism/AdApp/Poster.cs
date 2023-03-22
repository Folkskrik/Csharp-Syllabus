using System;
using System.Collections.Generic;
using System.Text;

namespace AdApp
{
    public class Poster : Advert
    {
        private double _width;
        private double _height;
        private int _numCopies;
        private double _costPerCopy;

        public Poster(double width, double height, int numCopies, double costPerCopy)
        {
            _width = width;
            _height = height;
            _numCopies = numCopies;
            _costPerCopy = costPerCopy;
        }

        public override double Cost()
        {
            return (_numCopies * _costPerCopy);
        }

        public override string ToString()
        {
            return $"Poster: Width={_width}, Height={_height}, Copies={_numCopies}, Cost per copy={_costPerCopy}";
        }
    }
}
