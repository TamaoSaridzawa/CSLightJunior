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

            name = symbol + name + symbol;
            string frame = "";

            for (int row = 0; row < name.Length; row++)
            {
                frame += symbol;
            }                     

            Console.WriteLine(frame);
            Console.WriteLine(name);
            Console.WriteLine(frame);

            Console.ReadKey();
        }
    }
}

