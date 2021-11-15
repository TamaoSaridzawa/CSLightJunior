using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = { 2, 5, 1, 7, 9, 1, 4, 8 };

            array = ShuffleArray(array, rand);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.ReadKey();
        }

        static int[] ShuffleArray(int[] array, Random rand)
        {
            int tempNumber;
            int tempIndex;
            for (int i = 0; i < array.Length; i++)
            {
                tempIndex = rand.Next(i + 1);
                tempNumber = array[tempIndex];
                array[tempIndex] = array[i];
                array[i] = tempNumber;
            }

            return array;
        }
    }
}
