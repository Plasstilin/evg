﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            String strokaWithout;
            Console.WriteLine("Введите строку");
            String originStroka = Console.ReadLine();
            strokaWithout = originStroka;

            strokaWithout = strokaWithout.Replace(" ", string.Empty);
            Console.WriteLine(strokaWithout);

            Console.ReadLine();
        }
    }
}