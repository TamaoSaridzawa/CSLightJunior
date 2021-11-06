using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя :");
            string name = Console.ReadLine();
            Console.Write("Введите символ, из которого будет состоять рамка :");
            string symbol = Console.ReadLine();

            for (int column = 0; column < 3; column++)
            {
                for (int row = 0; row <= name.Length + 1; row++)
                {
                    if (column == 1)
                    {
                        Console.Write($"{symbol}{name}{symbol}");
                        break;
                    }
                    else
                    {
                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
