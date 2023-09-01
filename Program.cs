using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursividad
{
   
       class Program
       {
            static int CalcularFactorial(int n)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                else
                {
                    return n * CalcularFactorial(n - 1);
                }
            }

            static void Main(string[] args)
            {
                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                int resultado = CalcularFactorial(num);
                Console.WriteLine($"El factorial de {num} es {resultado}");
            }
       }

}


