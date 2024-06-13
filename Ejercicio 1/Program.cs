using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int anterior = 0, actual = 1, ahora;*/     //variables para algoritmo iterativo
            Console.WriteLine("Ingrese hasta donde quiere que vaya su serie de Fibonacci");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            #region Inicio Algoritmo Iterativo de Fibonacci
            //Console.WriteLine(0);
            //Console.WriteLine(1);
            //for (int i = 0; i < num; i++)
            //{
            //    ahora = anterior + actual;
            //    anterior = actual;
            //    actual = ahora;
            //    Console.WriteLine(ahora);
            //}
            #endregion Fin Algoritmo Iterativo de Fibonacci

            #region Algorito Fibonacci Recursivo
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            Console.ReadKey();
        }

        static int Fibonacci(int num)
        
        {
            if (num <= 1)
            {
                return num;
            }
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }
        #endregion Algorito Fibonacci Recursivo

    }
}
