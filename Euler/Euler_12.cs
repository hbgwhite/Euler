using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    public class Euler12 : IEuler
    {
        public int Execute()
        {
            var triangles = new List<int> {1};
            var add = 2;
            while (!(NumberOfDivisors(triangles.Last()).Count() >= 500))
            {
                triangles.Add(triangles.Last()+add++);
            }
            return triangles.Last();
        }

        public List<int> NumberOfDivisors(int value)
        {
            var factors = new List<int>();
            var max = (int)Math.Sqrt(value);
            for (var factor = 1; factor <= max; ++factor)
            {
                if (value % factor != 0)
                {
                    continue;
                }
                factors.Add(factor);
                if (factor != value / factor)
                {
                    factors.Add(value / factor);
                }
            }
            return factors;
        }
    }
}
