using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelAccounting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] initials = new string[0];
            string[] post = new string[0];
            string userInput = "";

            Console.WriteLine("Меню :");
            while (userInput != "5")
            {
                Console.WriteLine($"1) добавить досье\n2) Вывысти все досье\n3) Удалить досье\n4) Поиск по фамилии\n5) Выход");
                Console.Write("Выберите пункт :");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddDosier(ref initials,ref post);
                        Console.WriteLine("Пользователь добавлен!");
                        break;
                    case "2":
                        OutputDossier(initials, post);
                        break;
                    case "3":
                        RemoveDosier(ref initials, ref post);
                        break;
                    case "4":
                        Console.Write("Введите фамилию для поиска сотрудника(ов) :");
                        string userAnser = Console.ReadLine();
                        SearchSurname(initials, post, userAnser);
                        break;
                    case "5":
                        break;
                    default:
                        Console.WriteLine("Неверный ввод данных");
                        break;
                }
            }

            Console.ReadKey();
        }

        static string[] ExpandArray(string[] array)
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            array = tempArray;
            return array;
        }

        static string[] ReducingArray( string[] array)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i];
            }

            array = tempArray;
            return array;
        }

        static void AddDosier(ref string[] initials,ref string[] post)
        {
            initials = ExpandArray(initials);
            post = ExpandArray(post);

            Console.Write("Введите инициалы :");
            string inputInitial = Console.ReadLine();

            Console.Write("Введите должность :");
            string inputPost = Console.ReadLine();

            initials[initials.Length - 1] = inputInitial;
            post[post.Length - 1] = inputPost;
        }

        static void OutputDossier(string[] initials, string[] post)
        {
            for (int i = 0; i < initials.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {initials[i]} , {post[i]}");
            }
        }

        static void RemoveDosier(ref string[] initials, ref string[] post)
        {
            Console.Write("Введите порядковый номер человека, чье досье вы хотите удалить :");
            int userAnswer = int.Parse(Console.ReadLine());

            if (userAnswer - 1 < initials.Length)
            {
                for (int i = 0; i < initials.Length; i++)
                {
                    if (i == userAnswer - 1)
                    {
                        for (int j = i; j < initials.Length - 1; j++)
                        {
                            initials[j] = initials[j + 1];
                            post[j] = post[j + 1];
                        }

                        initials = ReducingArray(initials);
                        post = ReducingArray(post);

                        Console.WriteLine("Пользователь удален");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Пользователя с таким номером не существует!");
            }
        }

        static void SearchSurname(string[] initials, string[] post, string surname)
        {
            int numberFound = 0;

            for (int i = 0; i < initials.Length; i++)
            {
                if (initials[i].ToLower().Contains(surname.ToLower()))
                {
                    Console.WriteLine($"Информация о введенной фамилии - {initials[i]}, {post[i]} ");
                    numberFound++;
                }
            }

            if (numberFound <= 0)
            {
                Console.WriteLine("Пользователь с такой фамилией не найден");
            }
        }
    }
}
