using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 5;
            Console.WriteLine("Введите сообщение");
            String message = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < score; i++)
            {
                Console.WriteLine(message);
            }
            Console.ReadKey();
        }
    }
}
