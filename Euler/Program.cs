using System;
using System.IO;
using System.Reflection;
using Euler.Properties;

namespace Euler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //var euler11 = new Euler11().Execute();
            Console.WriteLine($"Euler11: {(new Euler12().Execute())}");
            Console.ReadKey();
        }
    }
}