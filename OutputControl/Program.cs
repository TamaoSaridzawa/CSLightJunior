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
            String userAnswer = "";
            while (rightAnswer != userAnswer)
            {
                Console.Write("Введите правильный ответ для выхода: ");
                userAnswer = Console.ReadLine();
            }
            Console.WriteLine("Правильный ответ!");
            Console.ReadKey();
        }
    }
}
