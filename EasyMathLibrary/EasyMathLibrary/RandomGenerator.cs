using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMathLibrary
{
    public class RandomGenerator
    {
        private Random random;

        public RandomGenerator()
        {
            random = new Random();
        }

        public double NextDouble(double start, double end)
        {
            return random.NextDouble() * (end - start) + start;
        }

        public int Next(int start,)
    }
}