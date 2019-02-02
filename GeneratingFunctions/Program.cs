using GeneratingFunctions.Definition;
using GeneratingFunctions.Helpers;
using System;

namespace GeneratingFunctions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var firstGen = new GenFunc1(10, 1);
            var secondGen = new GenFunc2(10, 2);
            var thirdGen = new GenFunc3(10);
            var fourthGen = new GenFunc4(1);
            var fifthGen = new GenFunc5(10);
            var sixthGen = new GenFunc6(10);
            Console.WriteLine(firstGen);
            Console.WriteLine("\n");
            Console.WriteLine(secondGen);
            Console.WriteLine("\n");
            Console.WriteLine(thirdGen);
            Console.WriteLine("\n");
            Console.WriteLine(fourthGen);
            Console.WriteLine("\n");
            Console.WriteLine(fifthGen);
            Console.WriteLine("\n");
            Console.WriteLine(sixthGen);

            var cn = new CombinatorialNumber(10, 2);
            Console.WriteLine(cn.Eval());
            Console.ReadLine();
        }
    }
}