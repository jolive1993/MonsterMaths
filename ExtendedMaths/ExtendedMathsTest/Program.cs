﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedMaths;

namespace ExtendedMathsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var whatever = ExtendedMaths.Math.happyFinder(100);
            //foreach (int i in whatever)
            {
                //Console.WriteLine(i);
            }
            //string garbage = "1078";
            //ExtendedMaths.Math.romanConverter(ref garbage);
            //Console.WriteLine(garbage);
            var whatever = ExtendedMaths.Math.euclidean(210, 45);
            Console.WriteLine(whatever);
            Console.ReadLine();
        }
    }
}
