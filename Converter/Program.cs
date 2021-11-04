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
            double balanceUsd = 5;
            double balnceRub = 1850;
            int balanceHryvnia = 16800;
            int rubToUsd = 77;
            double hryvniaToRub = 2.7;
            int usdToHryvnia = 26;
            String userInput = "";
            int currencyCount;

            Console.WriteLine($"Вас приветствует программа конвертаци валют." +
                $"\n Для перевода рублей в доллары нажмите :1\n Для перевода гривен в рубли нажмите :2\n Для перевода долларов в гривны нажмите :3\n Для выхода из программы нажмите :exit" );
           
            while (userInput != "exit")
            {
                Console.WriteLine($"Ваш баланс: рубли - {balnceRub} , доллары - {balanceUsd} , гривны - {balanceHryvnia}");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1" :
                        Console.Write("Сколько рублей вы хотите перести в доллары? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (balnceRub >= currencyCount)
                        {
                            balanceUsd += Convert.ToDouble(currencyCount) / rubToUsd;
                            balnceRub -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "2":
                        Console.Write("Сколько гривен вы хотите перести в рубли? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (balanceHryvnia >= currencyCount)
                        {
                            balnceRub += currencyCount * hryvniaToRub;
                            balanceHryvnia -= currencyCount;
                        }
                        else
                        {
                            Console.WriteLine("У вас недостаточно средств");
                        }
                        break;
                    case "3":
                        Console.Write("Сколько долларов вы хотите перести в гривны? ");
                        currencyCount = int.Parse(Console.ReadLine());

                        if (balanceUsd >= currencyCount)
                        {
                            balanceHryvnia += currencyCount * usdToHryvnia;
                            balanceUsd -= currencyCount;
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

            Console.WriteLine($"Ваш баланс после выполненных операций: рубли - {balnceRub} , доллары - {balanceUsd} , гривны - {balanceHryvnia}");
            Console.ReadKey();
        }
    }
}
