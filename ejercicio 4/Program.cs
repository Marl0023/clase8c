﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Suma());
            Console.ReadKey();

        }
        static int Suma() {
            int num1 = 4;
            int num2 = 5;
            return num1 + num2;
        }
    }
}
