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
            string userInput = "";

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
                        double summandOne = double.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        double summandTwo = double.Parse(Console.ReadLine());
                        double sumNumbers = summandOne + summandTwo;
                        Console.WriteLine("Сумма чисел = " + sumNumbers);
                        break;
                    case "-" :
                        Console.Write("Введите 1 число: ");
                        double reduced = double.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        double deductible = double.Parse(Console.ReadLine());
                        double differenceNumbers = reduced - deductible;
                        Console.WriteLine("Разность чисел = " + differenceNumbers);
                        break;
                    case "*" :
                        Console.Write("Введите 1 число: ");
                        double numberOne = double.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        double numberTwo = double.Parse(Console.ReadLine());
                        double compositionNumbers = numberOne * numberTwo;
                        Console.WriteLine("Произведение чисел = " + compositionNumbers);
                        break; 
                    case "/" :
                        Console.Write("Введите 1 число: ");
                        double divisible = double.Parse(Console.ReadLine());
                        Console.Write("Введите 2 число: ");
                        double divider = double.Parse(Console.ReadLine());

                        if (divider == 0)
                        {
                            Console.WriteLine("Делить на ноль нельзя!");
                        }
                        else
                        {
                            double privateNumbers = divisible / divider;
                            Console.WriteLine("Частность чисел = " + privateNumbers);
                        }
                        break;
                    case "^" :
                        Console.Write("Введите число: ");
                        double number = double.Parse(Console.ReadLine());
                        double squareNumber = number * number;
                        Console.WriteLine("Квадрат числа = " +  squareNumber);
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
