using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesQuantity = 52;
            int picturesInaRow = 3;
            int numbersOfRows = picturesQuantity / picturesInaRow;
            int extraPictures = picturesQuantity % picturesInaRow;
            Console.WriteLine($"Количесво полностью заполненных рядов = {numbersOfRows}, лишних картинок - {extraPictures}");
            Console.ReadKey();
        }
    }
}
