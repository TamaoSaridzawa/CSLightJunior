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
            int rowWithName = 1;

            Console.Write("Введите имя :");
            string name = Console.ReadLine();
            Console.Write("Введите символ, из которого будет состоять рамка :");
            string symbol = Console.ReadLine();

            for (int column = 0; column < 3; column++)
            {
                if (column == rowWithName)
                {
                    Console.Write($"{symbol}{name}{symbol}");
                }
                else
                {
                    for (int row = 0; row <= name.Length + 1; row++)
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
