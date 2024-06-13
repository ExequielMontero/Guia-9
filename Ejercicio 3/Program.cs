using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //metodo iterativo

            #region Inicio Factorial con iterativo
            //int total;
            //Console.WriteLine("Ingrese Numero para sacar factorial");   

            //int num = Convert.ToInt32(Console.ReadLine());
            //total = num;
            //for (int i=1; i<num; i++)
            //{
            //    total *= (i);
            //}
            //Console.Clear();
            //Console.WriteLine(total);
            #endregion Fin Factorial con iterativo


            //metodo recursivo

            #region Inicio Factorial con recursividad
            Console.WriteLine("Ingrese el numero al que quiere sacarle factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sacarfactorial(num));
            #endregion Fin Factorial con recursividad




            Console.ReadKey();

        }


        //Metodo recursivo

        static int sacarfactorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }
            else
            {
                return num * sacarfactorial(num - 1);
            }
        }
    }
}
