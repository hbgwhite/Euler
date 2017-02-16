using System;
using Euler.Properties;

namespace Euler
{
    public class Euler11 : IEuler
    {
        public int Execute()
        {
            var resource = Resources.Euler_11;
            var grid = PossibleCombinations(resource);
            return 0;
        }

        public int[,] PossibleCombinations(string input)
        {
            var rows = input.Split(new[] {Environment.NewLine}, StringSplitOptions.None);
            var grid = new int[rows.Length, rows.Length];
            for (var i = 0; i < rows.Length; i++)
            {
                var row = rows[i].Split();
                for (var j = 0; j < rows.Length; j++)
                {
                    int x;
                    grid[i, j] = int.TryParse(row[j], out x)
                        ? x
                        : 0;
                }
            }
            return grid;
        }
    }
}