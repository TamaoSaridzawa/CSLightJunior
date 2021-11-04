using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            String userInput = "";
            String userAnswer = "";
            int numberOne;
            double numberTwo;

            Console.WriteLine("Вас приветствует программа калькулятор ");

            while (userInput != "exit")
            {
                Console.WriteLine("Нажмите '+' - Сложение двух чисел\nНажмите '-' - Вычитание двух чисел\n Нажмите '*' - Умножение двух чисел" +
                    "\nНажмите '/' - Деление двух чисел\nНажмите '^' - Возведение числа в квадрат\nНажмите 'clear' - Очистить консоль\n Наберите 'exit' - выход из программы");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "+" :
                        Console.Write("Введите 1 число: ");
                        numberOne = int.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        numberTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Сумма чисел = " + (numberOne + numberTwo));
                        break;
                    case "-" :
                        Console.Write("Введите 1 число: ");
                        numberOne = int.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        numberTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Разность чисел = " + (numberOne - numberTwo));
                        break;
                    case "*" :
                        Console.Write("Введите 1 число: ");
                        numberOne = int.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        numberTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Произведение чисел = " + (numberOne * numberTwo));
                        break; 
                    case "/" :
                        Console.Write("Введите 1 число: ");
                        numberOne = int.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        numberTwo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Частность чисел = " + (numberOne / numberTwo));
                        break;
                    case "^" :
                        Console.Write("Введите число: ");
                        numberOne = int.Parse(Console.ReadLine());
                        Console.WriteLine("Квадрат числа = " +  (numberOne * numberOne));
                        break;
                    case "clear" :
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Введена неправильная команда");
                        break;
                }
            }
        }
    }
}
