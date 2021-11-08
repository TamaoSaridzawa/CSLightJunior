using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[30];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10, 100);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.WriteLine(array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
