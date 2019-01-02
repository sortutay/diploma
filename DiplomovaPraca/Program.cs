using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomovaPraca
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Unit x0 = new Unit("x", 1, 0);
            Unit x1 = new Unit("x", 1, 1);
            Unit x2 = new Unit("x", 1, 2);
            Unit x3 = new Unit("x", 1, 3);
            Unit x4 = new Unit("x", 1, 4);
            Unit x5 = new Unit("x", 1, 5);
            Unit x6 = new Unit("x", 1, 6);

            


            List < Unit> arr1 = new List<Unit>();
            arr1.Add(x0);
            arr1.Add(x1);
            arr1.Add(x2);
            arr1.Add(x3);
            arr1.Add(x4);
            arr1.Add(x5);
            arr1.Add(x6);

            List<Unit> arr2 = new List<Unit>();
            arr2.Add(x0);
            arr2.Add(x2);
            arr2.Add(x4);
            arr2.Add(x6);

            List<Unit> arr3 = new List<Unit>();
            arr3.Add(x0);
            arr3.Add(x3);
            arr3.Add(x6);

            Poly p1 = new Poly(arr1);
            Poly p2 = new Poly(arr2);
            Poly p3 = new Poly(arr3);

            Console.WriteLine(p1);

            Poly p = p1.Multiply(p2);
            Poly res = p.Multiply(p3);
            

            bool run = true;

            //while (run)
            //{
            //    Console.WriteLine("Write your Poly -> ");
            //    String poly = Console.ReadLine();
            //    Console.WriteLine(poly);
            //    Console.WriteLine("Do you want to exit? Y/N");
            //    if ("y".Equals(Console.ReadLine())) run = false;
                
            //}
           


        }
    }
}
