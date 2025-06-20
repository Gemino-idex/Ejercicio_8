using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;
            Console.WriteLine("Ingrese su nota:");
            nota=Convert.ToInt32(Console.ReadLine());
            if (nota >= 16)
            {
                Console.WriteLine("Excelente");
            }
            else if (nota == 14 || nota == 15)
            {
                Console.WriteLine("Muy bueno");
            }
            else if (nota <= 13 && nota >= 11)
            {
                Console.WriteLine("Bueno");
            }
            else
            {
                Console.WriteLine("Insuficiente");
            }
        }
    }
}
