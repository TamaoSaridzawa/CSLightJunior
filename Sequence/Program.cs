using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 7;
            int finalNumber = 98;
            int step = 7;

            for (int i = startNumber; i <= finalNumber; i += step)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
