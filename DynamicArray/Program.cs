using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array =  new int[0];
            int sum = 0;
            string userInput = "";
            
            while (userInput != "exit")
            {
                int[] tempArray = new int[array.Length + 1];
                userInput = Console.ReadLine();

                if (userInput == "exit")
                {
                    continue;
                }
                if (userInput == "sum")
                {
                    Console.WriteLine($"Сумма введенных чисел = {sum}");
                }
                else
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }
                   
                    tempArray[tempArray.Length - 1] = int.Parse(userInput);
                    array = tempArray;
                    sum += array[array.Length - 1];
                }
            }
        }
    }
}
