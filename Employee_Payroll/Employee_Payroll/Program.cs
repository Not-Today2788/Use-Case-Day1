﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int val = rnd.Next(3);
            if (val == 0)
            {
                Console.WriteLine("Absent");
            }
            else if (val == 1)
            {
                Console.WriteLine("Part Time");
            }
            else
            {
                Console.WriteLine("Full Time");

            }
            Console.ReadKey();
        }
    }
}