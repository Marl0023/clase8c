using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            string op = "";
            do {
                Console.WriteLine("Ingrese el primer numero: ");
                num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                num2 = double.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Escriba que operacon quiere realizar (SUMA - RESTA - MULTIPLICACION - DIVISION)");
                    op = Console.ReadLine().ToUpper();
                    switch (op)
                    {
                        case "SUMA":
                            Suma(num1,num2);
                            break;
                        case "RESTA":
                            Resta(num1, num2);
                            break;
                        case "MULTIPLICACION":
                            Multiplicacion(num1,num2);
                            break;
                        case "DIVISION":
                            Division(num1,num2);
                            break;
                        default:
                            Console.Clear();
                            op = "";
                            Console.WriteLine("OPCION NO VALIDA , VUELVA A INTENTARLO");
                            break;
                    }
                    if (op != "")
                    {
                        break;
                    }

                } while (true);
                Console.WriteLine("Desea continuar con otra operacion ? (Y = si o Cualquier tecla para finalizar): ");
                char resp = char.Parse(Console.ReadLine().ToUpper());
                if (resp != 'Y')
                {
                    break;
                }
                else
                    Console.Clear();
            } while (true);
            Console.WriteLine("Codigo finalizado");
            
        }
        static void Suma(double num1, double num2) {
            Console.WriteLine(num1 + num2);
            Console.ReadKey();
        }
        static void Resta(double num1, double num2) { 
            Console.WriteLine(num1-num2);
            Console.ReadKey();
        }
        static void Multiplicacion(double num1, double num2)
        {
            Console.WriteLine(num1 * num2);
            Console.ReadKey();
        }
        static void Division(double num1, double num2) {
            Console.WriteLine(num1 / num2);
            Console.ReadKey();
        }
    }
}
