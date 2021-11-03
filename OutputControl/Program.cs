using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputControl
{
    class Program
    {
        static void Main(string[] args)
        {
            String rightAnswer = "exit";
            while (true)
            {
                Console.Write("Введите правильный ответ для выхода: ");
                String userAnswer = Console.ReadLine();
                if (rightAnswer == userAnswer)
                {
                    Console.WriteLine("Правильный ответ!");
                    break;
                }
                else
                    Console.WriteLine("Ответ не верный попробуйте еще раз!");
            }
            Console.ReadKey();
        }
    }
}
