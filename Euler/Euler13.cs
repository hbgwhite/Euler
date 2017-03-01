using System.Linq;
using System.Numerics;
using Euler.Properties;

namespace Euler
{
    public class Euler13
    {
        public string Execute()
        {
            return Resources.Euler13
                .Split('\n')
                .Select(BigInteger.Parse)
                .Aggregate((x, y) => x + y)
                .ToString()
                .Take(10)
                .ToString();
        }
    }
}