using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BraveNewWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.CursorVisible = false;
            int eatNumber = 0;
            char figureSnake = '@';
            char figureEat = '*';

            char figureHunter = '!';
            bool plaing = true;
            int snakeX, snakeY;

            int potionEnrage = 0;
            int maxKillHunter = 2;
            Console.WriteLine($"Вас приветствует игра 'Охотник или жертва?' Правила игры : Вас бросили в комнату, где нужно искать подсказки, с каждой подсказкой появляются охотники: '!'. Им нельзя попадаться." +
                $" В каждой пятнадцатой подсказке лежит элексир бешенства, под действием которого вы можете убить {maxKillHunter} охотников. Для использования зелья нажмите 's'");
            Console.Write("Нажмите людую клавиша для начала игры :");
            Console.ReadKey();
            Console.Clear();
            int snakeDX = 0, snakeDY = 1;

            char[,] map = ReadMap("map1", out snakeX, out snakeY);
            Random rand = new Random();

            int positionCharX = rand.Next(1, map.GetLength(0) - 2);
            int positionCharY = rand.Next(1, map.GetLength(1) - 2);

            DrawMap(map);

            map[positionCharX, positionCharY] = figureEat;
            Console.SetCursorPosition(positionCharY, positionCharX);
            Console.Write(map[positionCharX, positionCharY]);

            while (plaing)
            {
                Console.SetCursorPosition(snakeY, snakeX);
                Console.Write(figureSnake);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow :
                            snakeDX = -1; snakeDY = 0;
                            break;
                        case ConsoleKey.DownArrow:
                            snakeDX = 1; snakeDY = 0;
                            break;
                        case ConsoleKey.LeftArrow:
                            snakeDX = 0; snakeDY = -1;
                            break;
                        case ConsoleKey.RightArrow:
                            snakeDX = 0; snakeDY = 1;
                            break;
                        case ConsoleKey.S:
                            if (potionEnrage > 0)
                            {
                                potionEnrage--;
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            break;
                    }
                }

                if (map[snakeX + snakeDX, snakeY + snakeDY] == '#' || map[snakeX + snakeDX, snakeY + snakeDY] == figureHunter)
                {
                    if (Console.ForegroundColor == ConsoleColor.Red && maxKillHunter > 0)
                    {
                        map[snakeX + snakeDX, snakeY + snakeDY] = ' ';
                        maxKillHunter--;
                        eatNumber++;
                        if (maxKillHunter == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            maxKillHunter = 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ВЫ проиграли");
                        plaing = false;
                    }
                }
                else
                {
                    if (map[snakeX + snakeDX, snakeY + snakeDY] == figureEat)
                    {
                        int positionHunterX = rand.Next(1, map.GetLength(0) - 2);
                        int positionHunterY = rand.Next(1, map.GetLength(1) - 2);
                        map[positionHunterX, positionHunterY] = figureHunter;
                        Console.SetCursorPosition(positionHunterY, positionHunterX);
                        Console.Write(map[positionHunterX,positionHunterY]);
                        map[positionCharX, positionCharY] = ' ';
                        positionCharX = rand.Next(1, map.GetLength(0) - 2);
                        positionCharY = rand.Next(1, map.GetLength(1) - 2);
                        map[positionCharX, positionCharY] = figureEat;
                        Console.SetCursorPosition(positionCharY, positionCharX);
                        Console.Write(map[positionCharX, positionCharY]);
                        eatNumber++;
                        if (eatNumber % 15 == 0)
                        {
                            potionEnrage++;
                            Console.SetCursorPosition(0, 26);
                            Console.Write($"Зелей в сумке : {potionEnrage}");
                        }
                    }

                    Console.SetCursorPosition(snakeY, snakeX);
                    Console.Write(" ");
                    snakeX += snakeDX;
                    snakeY += snakeDY;

                    Console.SetCursorPosition(snakeY, snakeX);
                    Console.Write(figureSnake);
                }

                System.Threading.Thread.Sleep(200);

                Console.SetCursorPosition(0, 25);
                Console.WriteLine($"Количество съеденной пищи :{eatNumber}");
            }
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i,j]);
                }

                Console.WriteLine();
            }
        }

        static char[,] ReadMap (string mapName, out int snakeX, out int snakeY)
        {
            snakeX = 1;
            snakeY = 1;
            string[] newFile = File.ReadAllLines($"Maps/{mapName}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];
                }
            }

            return map;
        }
    }
}
