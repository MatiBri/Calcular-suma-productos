using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, suma, producto;
            string resultado;
            Console.Write("Ingrese primer valor");
            resultado = Console.ReadLine();
            num1 = int.Parse(resultado);
            Console.Write("Ingrese segundo valor");
            resultado = Console.ReadLine();
            num2 = int.Parse(resultado);
            suma = num1 + num2;
            Console.Write("La suma total es:");
            Console.WriteLine(suma);
            Console.Write("Ingrese primer valor producto");
            resultado = Console.ReadLine();
            num3 = int.Parse(resultado);
            Console.Write("Ingrese segundo valor producto");
            resultado = Console.ReadLine();
            num4 = int.Parse(resultado);
            producto = num3 * num4;
            Console.Write("El producto total es");
            Console.WriteLine(producto);
            Console.ReadKey();
        }
    }
}
