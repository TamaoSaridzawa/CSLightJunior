using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ConvertString(out number);

            Console.WriteLine($"Введенное число :{number}");

            Console.ReadLine();
        }

        static int ConvertString(out int number)
        {
            number = 0;
            bool success = false;

            while (!success)
            {
                Console.Write("Введите число для конвертации :");
                string userInput = Console.ReadLine();

               success = int.TryParse(userInput, out number);

                if (success)
                {
                    number = int.Parse(userInput);
                    Console.WriteLine("Конвертация прошла успешно");
                }
                else
                {
                    Console.WriteLine("Ошибка конвертации, попробуйте еще раз");
                }
            }

            return number;
        }
    }
}
