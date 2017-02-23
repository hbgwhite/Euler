using System;
using System.Linq;
using System.Numerics;
using Euler.Properties;

namespace Euler
{
    public class Euler13
    {
        public long Execute()
        {
            return long.Parse(Resources.Euler13.Split('\n').Select(BigInteger.Parse).Aggregate((x, y) => x + y).ToString().Substring(0,10));
        }
    }
}