using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
    internal class Program
    {
        static double dolar = 3.78;
        static double euro = 4.20;
        static void Main(string[] args)
        {
            do
            {
                string moneda = "";
                Console.WriteLine("Ingrese el valor en soles: ");
                double soles = double.Parse(Console.ReadLine());
                Console.WriteLine("Escriba a que tipo de moneda lo desea cambiar (Dolar - Euro): ");
                moneda = Console.ReadLine().ToUpper();
                switch (moneda)
                {
                    case "DOLAR":
                        Console.WriteLine("El total en dolares es de " + Math.Round(CambioD(soles), 2));
                        break;
                    case "EURO":
                        Console.WriteLine("El total en euros es de " + Math.Round(CambioE(soles), 2));
                        break;
                    default:
                        Console.WriteLine("ERROR, Tipo de moneda no reconocido,vuelva a intentarlo");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
                Console.WriteLine("Desea continuar con otra operacion ? (Y = si o Cualquier tecla para finalizar): ");
                char resp = char.Parse(Console.ReadLine().ToUpper());
                if (resp != 'Y')
                {
                    break;
                }
                else
                    Console.Clear();
            } while (true);
            Console.Clear();
            Console.WriteLine("Operacion terminada");

        }
        static double CambioD(double soles) { 
            return soles / dolar;
        }
        static double CambioE(double soles)
        {
            return soles / euro;
        }
    }
}
