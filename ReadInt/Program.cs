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
           int number = 0;
           int result = Convert(number);

            Console.WriteLine($"Введенное число :{result}");

            Console.ReadLine();
        }

        static int Convert(int number)
        {
            bool success = false;
            string userInput ="";

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

            return int.Parse(userInput);
        }
    }
}
