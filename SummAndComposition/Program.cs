using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummAndComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            int summTwoLine = 0;
            int compositionOneColumn = 1;

            int[,] array =
            {
                {1, 3, 4, 5},
                {2, 4, 6, 8},
                {4, 4, 5, 1},
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {           
                    if (i != 1)
                    {
                        break;
                    }
                    else
                    {
                        summTwoLine += array[i, j];
                    }
                }

                compositionOneColumn *= array[i, 0];
            }

            Console.WriteLine($"Сумма второй строки = {summTwoLine}, Произведение первого столбца = {compositionOneColumn}");
            Console.ReadKey();
        }
    }
}
