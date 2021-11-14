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

            char figureHero = '@';
            char figurePotion = '*';
            char figureHunter = '!';
            int potion = 0;
            int positionHeroX, positionHeroY;
            int HeroDX = 0; 
            int HeroDY = 1;
            int positionHunterX = 0;
            int positionHunterY = 0;
            int positionPotionX = 0;
            int positionPotionY = 0;
            int numberPotionHints = 15;
            bool plaing = true;
            int potionEnrage = 0;
            int maxKillHunter = 2;
            
            Console.WriteLine($"Вас приветствует игра 'Охотник или жертва?'\n Правила игры : Вас бросили в комнату, где нужно искать подсказки, с каждой подсказкой появляются охотники: '!'. Им нельзя попадаться." +
                $" \nВ каждой пятнадцатой подсказке лежит элексир бешенства, под действием которого вы можете убить {maxKillHunter} охотников. Для использования зелья нажмите 's'");
            Console.Write("Нажмите людую клавиша для начала игры :");

            Console.ReadKey();

            Console.Clear();

            Random rand = new Random();

            char[,] map = ReadMap("map1", out positionHeroX, out positionHeroY);

            DrawMap(map);

            DrawFigure(rand, ref positionPotionX, ref positionPotionY, figurePotion, map); 

            while (plaing)
            {
                DrawHero(positionHeroY, positionHeroX, figureHero); 

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    Move(key, ref HeroDX, ref HeroDY,ref potionEnrage);
                }

                if (map[positionHeroX + HeroDX, positionHeroY + HeroDY] == '#' || map[positionHeroX + HeroDX, positionHeroY + HeroDY] == figureHunter)
                {
                    if (Console.ForegroundColor == ConsoleColor.Red && maxKillHunter > 0)
                    {
                        ContinueGame(ref positionHeroX, ref positionHeroY, HeroDX, HeroDY, ref potion, ref maxKillHunter, map); 
                    }
                    else
                    {
                        Console.WriteLine("ВЫ проиграли");
                        plaing = false;
                    }
                }
                else
                {
                    if (map[positionHeroX + HeroDX, positionHeroY + HeroDY] == figurePotion) 
                    {
                        DrawFigure(rand, ref positionHunterX, ref positionHunterY, figureHunter, map); 

                        map[positionPotionX, positionPotionY] = ' ';

                        DrawFigure(rand, ref positionPotionX, ref positionPotionY, figurePotion, map); 

                        potion++;

                        if (potion % numberPotionHints == 0)
                        {
                            potionEnrage++;

                            DrawHints(ref potionEnrage);
                        }
                    }

                    ChangeCoordinate(ref positionHeroX, ref positionHeroY, HeroDX, HeroDY); 

                    DrawHero(positionHeroY, positionHeroX, figureHero);
                }

                System.Threading.Thread.Sleep(150);

                Console.SetCursorPosition(0, 25);
                Console.WriteLine($"Количество найденных подсказок :{potion}");
            }
        }

        static void DrawMap(char[,] map)  
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }

        static char[,] ReadMap(string mapName, out int snakeX, out int snakeY)
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

        static void DrawFigure(Random rand, ref int x, ref int y, char figure, char[,] map) // отрисовывает фигуру охотника или подсказки
        {
            x = rand.Next(1, map.GetLength(0) - 2);
            y = rand.Next(1, map.GetLength(1) - 2);
            map[x, y] = figure;

            Console.SetCursorPosition(y, x);
            Console.Write(map[x, y]);
        }

        static void Move(ConsoleKeyInfo key, ref int x, ref int y, ref int potionEnrage)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    x = -1; y = 0;
                    break;
                case ConsoleKey.DownArrow:
                    x = 1; y = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    x = 0; y = -1;
                    break;
                case ConsoleKey.RightArrow:
                    x = 0; y = 1;
                    break;
                case ConsoleKey.S:

                    if (potionEnrage > 0)
                    {
                        potionEnrage--;

                        DrawHints(ref potionEnrage);

                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    break;
            }
        }

        static void DrawHero(int y, int x, char figure)  // отрисовывает фигуру героя
        {
            Console.SetCursorPosition(y, x);
            Console.Write(figure);
        }

        static void ChangeCoordinate(ref int x,ref int y,int dX, int dY) // изменяет координаты фигуры
        {
            Console.SetCursorPosition(y, x);
            Console.Write(" ");
            x += dX;
            y += dY;
        }

        static void ContinueGame(ref int x , ref int y, int dX, int dY,ref int potion,ref int maxKillHunter, char[,] map) // подолжает игру, если игрок под бешенством
        {
            map[x + dX, y + dY] = ' ';
            maxKillHunter--;
            potion++;

            if (maxKillHunter == 0)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                maxKillHunter = 2;
            }
        }

        static void DrawHints(ref int potionEnrage) // отрисовывает подсказку о количесте зелей в сумке
        {
            Console.SetCursorPosition(0, 26);
            Console.Write($"Зелей в сумке : {potionEnrage}");
        }
    }
}
