using System;

namespace Euler
{
    public class Euler12 : IEuler
    {
        public int Execute()
        {
            var triangles = 1;
            var add = 2;
            while (!(NumberOfDivisors(triangles) > 500))
            {
                triangles = triangles + add++;
            }
            return triangles;
        }

        public int NumberOfDivisors(int value)
        {
            var factorCount = 0;
            var max = (int) Math.Sqrt(value);
            for (var factor = 1; factor <= max; ++factor)
            {
                if (value % factor == 0)
                {
                    factorCount = factor != value / factor
                        ? factorCount + 2
                        : factorCount + 1;
                }
            }
            return factorCount;
        }
    }
}