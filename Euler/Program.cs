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
            //Console.WriteLine($"Euler12: {(new Euler12().Execute())}");
            //Console.WriteLine($"Euler13: {(new Euler13().Execute())}");
            Console.WriteLine($"Euler14: {new Euler14().Execute()}");
            Console.ReadKey();
        }
    }
}