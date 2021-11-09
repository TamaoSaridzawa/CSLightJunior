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
            string[] patronymics = new string[0];
            string[] posts = new string[0];
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
                        AddDosier(ref patronymics,ref posts);
                        break;
                    case "2":
                        OutputDossier(patronymics, posts);
                        break;
                    case "3":
                        RemoveDosier(ref patronymics, ref posts);
                        break;
                    case "4":
                        SearchSurname(patronymics, posts);
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

        static string[] ReduceArray( string[] array, int index)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (i != index)
                {
                    tempArray[i] = array[i];
                }
            }
            array = tempArray;
            return array;
        }

        static void AddDosier(ref string[] patronymics,ref string[] posts)
        {
            patronymics = ExpandArray(patronymics);
            posts = ExpandArray(posts);

            Console.Write("Введите инициалы :");
            string inputInitial = Console.ReadLine();

            Console.Write("Введите должность :");
            string inputPost = Console.ReadLine();

            patronymics[patronymics.Length - 1] = inputInitial;
            posts[posts.Length - 1] = inputPost;

            Console.WriteLine("Пользователь добавлен!");
        }

        static void OutputDossier(string[] patronymics, string[] posts)
        {
            for (int i = 0; i < patronymics.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {patronymics[i]} , {posts[i]}");
            }
        }

        static void RemoveDosier(ref string[] patronymics, ref string[] posts)
        {
            Console.Write("Введите порядковый номер человека, чье досье вы хотите удалить :");
            int index = int.Parse(Console.ReadLine());

            if (index <= patronymics.Length && index > 0)
            {
                patronymics = ReduceArray(patronymics, index);
                posts = ReduceArray(posts, index);

                Console.WriteLine("Пользователь удален");
            }
            else
            {
                Console.WriteLine("Пользователя с таким номером не существует!");
            }
        }

        static void SearchSurname(string[] patronymics, string[] posts)
        {
            int numberFound = 0;

            Console.Write("Введите фамилию для поиска сотрудника(ов) :");
            string userName = Console.ReadLine();

            for (int i = 0; i < patronymics.Length; i++)
            {
                if (patronymics[i].ToLower().Contains(userName.ToLower()))
                {
                    Console.WriteLine($"Информация о введенной фамилии - {patronymics[i]}, {posts[i]} ");
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
