using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = Suma(2,6);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
        static int Suma(int a, int b)
        {
            return a + b;
        }

    }
}
