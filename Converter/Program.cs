using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = 5;
            double rub = 1850;
            double uah = 16800;
            double usdToRub = 77;
            double uahToRub = 2.7;
            double usdToUah = 26;
            string userInput = "";
            double currencyCount;

            Console.WriteLine($"Вас приветствует программа конвертаци валют." +
                $"\n Для перевода рублей в доллары нажмите :1 . Для перевода долларов в рубли нажмите :2" +
                $"\n Для перевода рублей в гривны нажмите :3.Для перевода гривен в рубли нажмите :4\n" +
                $"Для перевода гривен в доллары нажмите :5 . Для перевода долларов в гривны нажмите 6:" +
                $"\n Для выхода из программы нажмите :exit" );
           
            while (userInput != "exit")
            {
                Console.WriteLine($"Ваш баланс: рубли - {rub} , доллары - {usd} , гривны - {uah}");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1" :
                        Console.Write("Сколько рублей вы хотите перести в доллары? ");
                        currencyCount = double.Parse(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            usd += currencyCount / usdToRub;
                            rub -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "2":
                        Console.Write("Сколько долларов вы хотите перести в рубли? ");
                        currencyCount = double.Parse(Console.ReadLine());

                        if (usd >= currencyCount)
                        {
                            rub += currencyCount * usdToRub;
                            usd -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "3":
                        Console.Write("Сколько рублей вы хотите перести в гривны? ");
                        currencyCount = double.Parse(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            uah += currencyCount / uahToRub;
                            rub -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "4":
                        Console.Write("Сколько гривен вы хотите перести в рубли? ");
                        currencyCount = double.Parse(Console.ReadLine());

                        if (uah >= currencyCount)
                        {
                            rub += currencyCount * uahToRub;
                            uah -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "5":
                        Console.Write("Сколько гривен вы хотите перести в доллары? ");
                        currencyCount = double.Parse(Console.ReadLine());

                        if (uah >= currencyCount)
                        {
                            usd += currencyCount / usdToUah;
                            uah -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "6":
                        Console.Write("Сколько долларов вы хотите перести в гривны? ");
                        currencyCount = double.Parse(Console.ReadLine());

                        if (usd >= currencyCount)
                        {
                            uah += currencyCount * usdToUah;
                            usd -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "exit":
                        Console.WriteLine("Спасибо за использования нашего сервиса. Всего доброго!");
                        break;
                    default:
                        Console.WriteLine("Неверный формат ввода");
                        break;
                }
            }

            Console.WriteLine($"Ваш баланс после выполненных операций: рубли - {rub} , доллары - {usd} , гривны - {uah}");
            Console.ReadKey();
        }
    }
}
