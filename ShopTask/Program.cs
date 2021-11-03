using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfCrystals = 15;
            Console.Write("Введите стартовое количество золота : ");
            int gold = int.Parse(Console.ReadLine());
            Console.Write($"Какое количество кристаллов вы хотите купить?" 
                + $"  Цена за шт. = {priceOfCrystals} монет: ");
            int numberOfCrystals = int.Parse(Console.ReadLine());
            int remainingGold = gold - priceOfCrystals * numberOfCrystals;
            Console.WriteLine($"Поздравляем с покупкой! : Счет кошелька : Кристаллы - {numberOfCrystals} . Золото - {remainingGold}");
            Console.ReadLine();
        }
    }
}
