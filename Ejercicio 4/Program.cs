using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static int[] vector = new int[1000];
        static void Main(string[] args)
        {
            int opcion;
            Random aleatorio = new Random();
            for (int i = 0; i<20; i++)
            {
                vector[i] = aleatorio.Next(500)+1;
            }

            Console.WriteLine("1 -Metodo Burbuja");
            Console.WriteLine("2 - Metodo Quicksort");
            Console.WriteLine("3 - Metodo Merge");
            opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Vector desordenado");
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }
                        Console.WriteLine("--------------------------------\n");
                        ordenamientoburbuja();
                        Console.WriteLine("Vector odenado");
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }
                    }
                    break;
                case 2:
                    {
                        Console.Clear();
                        Console.WriteLine("Vector desordenado");
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }
                        Console.WriteLine("--------------------------------\n");
                        QuickSort(0, 19);
                        Console.WriteLine("Vector odenado");
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }

                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Console.WriteLine("Vector desordenado");
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }
                        Console.WriteLine("--------------------------------\n");
                        vector = MergeSort(vector, 0, 19);
                        Console.WriteLine("Vector odenado");
                        for (int i = 0; i < 20; i++)
                        {
                            Console.WriteLine(vector[i]);
                        }

                    }
                    break;

            }

            
            Console.ReadKey();
        }
        static void ordenamientoburbuja()
        {
            for(int i=0; i<20-1; i++)
            {
                for(int h=i+1; h<20; h++)
                {
                    if (vector[i] > vector[h])
                    {
                        int aux = vector[i];
                        vector[i] = vector[h];
                        vector[h] = aux;
                    }
                }
            }
        }

        static void QuickSort(int inicio, int fin)
        {
            #region partición
            int p = vector[inicio];
            int m = inicio + 1;
            int n = fin;
            int aux = 0;

            while (m <= n)
            {
                while (m <= fin && vector[m] < p) m++;
                while (n > inicio && p <= vector[n]) n--;

                if (m < n)
                {
                    aux = vector[m];
                    vector[m] = vector[n];
                    vector[n] = aux;
                }
            }
            vector[inicio] = vector[n];
            vector[n] = p;
            #endregion

            if (inicio < n - 1)
                QuickSort(inicio, n - 1);
            if (n + 1 < fin)
                QuickSort(n + 1, fin);
        }

        static int[] MergeSort(int[] lista, int inicio, int fin)
        {
            int[] resultado = null;
            if (inicio < fin)
            {
                int centro = (inicio + fin) / 2;
                int[] izq = MergeSort(lista, inicio, centro);
                int[] der = MergeSort(lista, centro + 1, fin);

                #region merge         
                resultado = new int[izq.Length + der.Length];

                int n = 0, i = 0, d = 0;
                while (i < izq.Length || d < der.Length)
                {
                    if (d >= der.Length)
                    {
                        resultado[n] = izq[i];
                        i++;
                    }
                    else if (i >= izq.Length)
                    {
                        resultado[n] = der[d];
                        d++;
                    }
                    else if (izq[i] < der[d])
                    {
                        resultado[n] = izq[i];
                        i++;
                    }
                    else
                    {
                        resultado[n] = der[d];
                        d++;
                    }
                    n++;
                }
            }
            else
            {
                resultado = new int[1];
                resultado[0] = lista[inicio];
            }
            #endregion

            return resultado;

        }




    }
}
