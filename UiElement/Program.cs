using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameBarHealth = "HP";
            string nameBarMana = "MP";
            bool cycleOperation = true;

            Console.Write("Введите максимальное количество здоровья :");
            double maxHealth = double.Parse(Console.ReadLine());

            Console.Write("Введите максимальное количество маны :");
            double maxMana = double.Parse(Console.ReadLine());

            while (cycleOperation)
            {
                Console.SetCursorPosition(0, 2);

                Console.Write("Введите процент желаемого здоровья :");
                double procentHealth = double.Parse(Console.ReadLine());

                Console.Write("Введите процент желаемой маны :");
                double procentMana = double.Parse(Console.ReadLine());

                Console.Clear();

                DrawBar(nameBarHealth ,maxHealth, procentHealth, '♥', 0, 0);
                DrawBar(nameBarMana ,maxMana, procentMana, '@', 0, 1, ConsoleColor.Blue);
            }
        }

        static void DrawBar(string nameBar ,double maxValue, double procent, char symbol, int positionX, int positionY, ConsoleColor color = ConsoleColor.Black)
        {
            ConsoleColor defaultColor = ConsoleColor.Black;
            ConsoleColor defaultGround = Console.ForegroundColor;
            int maxProcent = 100;
            string bar = "";
            double percentagesInNumber = (maxValue / maxProcent) * procent;

            Console.ForegroundColor = ConsoleColor.Green;
  
            Console.SetCursorPosition(positionX, positionY);

            Console.Write(nameBar +":");

            Console.ForegroundColor = defaultGround;

            for (int i = 0; i < percentagesInNumber; i++)
            {
                bar += symbol;
            }

            Console.Write("[");

            if (color == ConsoleColor.Black)
            {
                if (procent > 70)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else if (procent > 30 && percentagesInNumber <= 70)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else if (procent <= 30)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }
            }
            else
            {
                Console.BackgroundColor = color;
            }

            Console.Write(bar);

            Console.BackgroundColor = defaultColor;

            bar = "";

            for (double i = percentagesInNumber; i < maxValue; i++)
            {
                bar += " "; 
            }

            Console.Write(bar + "]");
        }
    }
}
