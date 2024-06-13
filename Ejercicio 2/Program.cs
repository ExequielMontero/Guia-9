using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0, num1=0;
            Console.WriteLine("Ingrese el primer numero del intervalo");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ingrese el segundo numero del intervao");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Números primos entre {num} y {num1}:");
            ImprimirPrimosEnRango(num, num1);
            Console.ReadKey();


        }

        static void ImprimirPrimosEnRango(int num, int num1)
        {
            if (num > num1)
                return;

            if (esprimo(num, 2))
                Console.WriteLine(num);

            ImprimirPrimosEnRango(num + 1, num1);
        }

        static bool esprimo(int num, int divisor)
        {
            if (num <= 2)
            {
                return num == 2;
            }
            else if(num % divisor == 0)
            {
                return false;
            }
            else if (divisor * divisor > num)
            {
                return true;
         
            }


            return esprimo(num, divisor + 1);
        }

    }
}
