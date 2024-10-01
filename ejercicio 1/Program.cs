using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Suma(15,5);
        }
        static void Suma(int num1,int num2) {
            Console.WriteLine($"La suma de ambos numero es de: {num1 + num2}");
        }
    }
}
