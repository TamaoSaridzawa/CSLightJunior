using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyclinicTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutesPerPerson = 10;
            Console.WriteLine($"Вас приветствует программа расчета времени ожидания в очереди.");
            Console.Write($"Для рассчета времени ожидания введите количество людей в очереди: ");
            int numberOfPeople = int.Parse(Console.ReadLine());
            int waitingTimeHours = minutesPerPerson * numberOfPeople / 60;
            int waitingTimeMinutes = minutesPerPerson * numberOfPeople % 60;
            Console.WriteLine($"Вы должны отстоять в очереди {waitingTimeHours} часов и {waitingTimeMinutes} минут");
            Console.ReadKey();
        }
    }
}
