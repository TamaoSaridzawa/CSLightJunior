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
            double hryvnia = 16800;
            double usdToRub = 77;
            double hryvniaToRub = 2.7;
            double usdToHryvnia = 26;
            String userInput = "";
            double currencyCount;

            Console.WriteLine($"Вас приветствует программа конвертаци валют." +
                $"\n Для перевода рублей в доллары нажмите :1 . Для перевода долларов в рубли нажмите :2" +
                $"\n Для перевода рублей в гривны нажмите :3.Для перевода гривен в рубли нажмите :4\n" +
                $"Для перевода гривен в доллары нажмите :5 . Для перевода долларов в гривны нажмите 6:" +
                $"\n Для выхода из программы нажмите :exit" );
           
            while (userInput != "exit")
            {
                Console.WriteLine($"Ваш баланс: рубли - {rub} , доллары - {usd} , гривны - {hryvnia}");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1" :
                        Console.Write("Сколько рублей вы хотите перести в доллары? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            usd += Convert.ToDouble(currencyCount) / usdToRub;
                            rub -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "2":
                        Console.Write("Сколько долларов вы хотите перести в рубли? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (usd >= currencyCount)
                        {
                            rub += Convert.ToDouble(currencyCount) * usdToRub;
                            usd -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "3":
                        Console.Write("Сколько рублей вы хотите перести в гривны? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            hryvnia += currencyCount / hryvniaToRub;
                            rub -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "4":
                        Console.Write("Сколько гривен вы хотите перести в рубли? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (hryvnia >= currencyCount)
                        {
                            rub += currencyCount * hryvniaToRub;
                            hryvnia -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "5":
                        Console.Write("Сколько гривен вы хотите перести в доллары? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (hryvnia >= currencyCount)
                        {
                            usd += currencyCount / usdToHryvnia;
                            hryvnia -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "6":
                        Console.Write("Сколько долларов вы хотите перести в гривны? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (usd >= currencyCount)
                        {
                            hryvnia += currencyCount * usdToHryvnia;
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

            Console.WriteLine($"Ваш баланс после выполненных операций: рубли - {rub} , доллары - {usd} , гривны - {hryvnia}");
            Console.ReadKey();
        }
    }
}
