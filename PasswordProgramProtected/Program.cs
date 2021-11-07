﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordProgramProtected
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasword = "unity";
            int attempts = 0;
            int maxAttempts = 3;

            while (attempts < maxAttempts)
            {
                Console.Write("Введите пароль для получения секретного сообщения:");
                string userInput = Console.ReadLine();

                if (userInput == pasword)
                {
                    string secretMessage = "Никогда не сдавайся";
                    Console.WriteLine($"Пароль верный!\n Секретное сообщение : {secretMessage}");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильный пароль, попробуйте еще раз");
                    attempts++;
                }
            }
        }
    }
}
