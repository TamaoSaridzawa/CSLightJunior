using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? : ");
            String name = Console.ReadLine();
            Console.Write("Сколько вам лет? : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Какой ваш любимый цвет? : ");
            String color = Console.ReadLine();
            Console.Write("В каком городе вы живете? : ");
            String city = Console.ReadLine();
            Console.WriteLine($"Вас зовут {name}, ваш возраст - {age}, любимый цвет {color}, живете в городе {city}");
            Console.ReadKey();
        }
    }
}
