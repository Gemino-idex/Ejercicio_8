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
            //declaramos variables y pedimos datos
            int nota;
            Console.WriteLine("Ingrese su nota:");
            nota=Convert.ToInt32(Console.ReadLine());
            //while se ejecuta continuamente hasta que ingrese el valor solicitado
            while (nota < 0 || nota > 20)
            {
                Console.WriteLine("El valor es incorrecto");
                Console.WriteLine("Ingrese una nota entera entre 0 y 20:");
                nota= Convert.ToInt32(Console.ReadLine());
            }
            //es el quivalente al si
            if (nota >= 16)
            {
                Console.WriteLine("Excelente");
            }
            //else if se usa cuando vas a ingresar varias "sino"
            else if (nota == 14 || nota == 15)
            {
                Console.WriteLine("Muy bueno");
            }
            else if (nota <= 13 && nota >= 11)
            {
                Console.WriteLine("Bueno");
            }
            //el último "sino" debe ser solo else
            else
            {
                Console.WriteLine("Insuficiente");
            }
        }
    }
}
