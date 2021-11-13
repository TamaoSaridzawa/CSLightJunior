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
           int result = GetNumber();

            Console.WriteLine($"Введенное число :{result}");

            Console.ReadLine();
        }

        static int GetNumber()
        {
            int number = 0;
            bool success = false;
            string userInput;

            while (success == false)
            {
                Console.Write("Введите число для конвертации :");
                userInput = Console.ReadLine();

                success = int.TryParse(userInput,out number);

                if (success == false)
                {
                    Console.WriteLine("Ошибка конвертации, попробуйте еще раз");
                }
            }

            Console.WriteLine("Конвертация прошла успешно");

            return number;
        }
    }
}
