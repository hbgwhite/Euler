using System.Collections.Generic;
using System.Linq;

namespace Euler
{
    public class Euler14
    {
        public ulong Execute()
        {
            var seenLongs = new Dictionary<ulong, ulong>
            {
                {0, 0},
                {1, 1}
            };
            for (ulong i = 2; i < 1000000; i++)
            {
                var functionValue = i;

                ulong numberInSequence = 0;
                while (!seenLongs.ContainsKey(functionValue) && functionValue != 1)
                {
                    functionValue = functionValue % 2 == 0 ? functionValue >> 1 : 3 * functionValue + 1;
                    numberInSequence++;
                }
                seenLongs.Add(i, numberInSequence + seenLongs[functionValue]);
            }
            return seenLongs
                .OrderByDescending(x => x.Value)
                .First()
                .Key;
        }
    }
}