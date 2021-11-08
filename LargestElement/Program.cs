using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestElement = 0;
            Random rand = new Random();

            int[,] array = new int[10, 10];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10,100);

                    Console.Write(array[i, j] + " ");

                    if (largestElement < array[i,j])
                    {
                        largestElement = array[i, j];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine($"Максимальный элемент матрицы = {largestElement}");

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j <array.GetLength(1); j++)
                {
                    if (largestElement == array[i,j])
                    {
                        array[i, j] = 0;
                    }

                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

             Console.ReadKey();
        }
    }
}
