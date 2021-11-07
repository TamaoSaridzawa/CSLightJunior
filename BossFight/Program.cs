using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossFight
{
    class Program
    {
        static void Main(string[] args)
        {
            double heroMaxHealth = 200;
            double heroHealth = 200;
            int heroSlashingAttack = 30;
            int heroOutOfBalance = 10;
            int heroFinishingBlow = 40;
            int numberOfTreatments = 2;
            bool heroRebound = false;
            bool knockedDown = false;
            int maxProcentKnocked = 100;
            int mimProcentForKnocked = 50;
            int bossHealth = 300;
            int bossAutoAttac = 20;
            int bossLightningStrike = 80;
            bool bossEnrage = false;

            Console.WriteLine("Вас приветствует пошаговая игра 'Figth Arena'. Вам предстоит сразится с боссом 1х1 и победить!");
            Console.WriteLine("Управление :\n 1 - Рубящая атака, наносит 30 урона\n 2 - Удар в колено, наносит 10 урона , с шансом в 50% выводит из равновесия и сбивает с ног" +
                "\n 3 - Завершающий удар, наносит 40 урона, если цель сбита с ног наносит двойной урон\n 4 - Отскок, вы отпрыгиваете в сторону" +
                "\n 5 - Залечить раны, восстанавливаете 50% здоровье от недостающего . Доступно 2 лечения");
            Console.Write("Вы готовы начать? Для старта нажмите 's':");

            string startGame = Console.ReadLine();

            if (startGame == "s")
            {
                while (heroHealth > 0 && bossHealth > 0)
                {
                    Random rand = new Random();
                    int bossSkil = rand.Next(1, 4);

                    if (bossSkil == 1)
                    {
                        Console.WriteLine("Тучи сгущаются, вы видите, как под вами появилась метка");
                    }
                    else if (bossSkil == 3)
                    {
                        Console.WriteLine("Глаза босса окрасились в красный! Весь урон от атак увеличен");
                        bossEnrage = true;
                    }

                    Console.Write("Делайте ваш ход :");
                    string userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            bossHealth -= heroSlashingAttack;
                            Console.WriteLine($"Вы нанесли {heroSlashingAttack} урона. Здоровье босса :{bossHealth} ед.");
                            break;
                        case "2":
                            bossHealth -= heroOutOfBalance;
                            knockedDown = mimProcentForKnocked < rand.Next(maxProcentKnocked);
                            Console.WriteLine($"Вы нанесли {heroOutOfBalance} урона. Здоровье босса :{bossHealth} ед.");
                            if (knockedDown)
                            {
                                Console.WriteLine("Враг сбит с ног!");
                                bossEnrage = false;
                            }
                            break;
                        case "3":

                            if (knockedDown)
                            {
                                bossHealth -= heroFinishingBlow * 2;
                                knockedDown = false;
                                Console.WriteLine($"Вы нанесли {heroFinishingBlow * 2} урона. Здоровье босса :{bossHealth} ед.");
                            }
                            else
                            {
                                bossHealth -= heroFinishingBlow;
                                Console.WriteLine($"Вы нанесли {heroFinishingBlow} урона. Здоровье босса :{bossHealth} ед.");
                            }
                            break;
                        case "4":
                            heroRebound = true;
                            Console.WriteLine($"Вы делаете отскок назад");
                            break;
                        case "5":

                            if (numberOfTreatments > 0)
                            {
                                double heroHealWounds = (heroMaxHealth - heroHealth) / 2;
                                heroHealth += heroHealWounds;
                                numberOfTreatments--;
                                Console.WriteLine($"Вы восстановили {heroHealWounds}ед. здоровья.Ваше здоровье :{heroHealth} ед. Осталось лечений {numberOfTreatments}");
                            }
                            else
                            {
                                Console.WriteLine("У вас больше не осталось лечений! Будет выполнена рубящая атака!");
                                bossHealth -= heroSlashingAttack;
                                Console.WriteLine($"Вы нанесли {heroSlashingAttack} урона. Здоровье босса :{bossHealth} ед.");
                            }
                            
                            break;
                        default:
                            Console.WriteLine("Нет умения на данной кнопке. Вы пропускаете ход!");
                            break;
                    }

                    switch (bossSkil)
                    {
                        
                        case 1:

                            if (heroRebound)
                            {
                                Console.WriteLine("Прогремел разряд молнии, но вас уже не было на том месте!");
                                heroRebound = false;
                            }
                            else
                            {
                                if (bossEnrage)
                                {
                                    heroHealth -= bossLightningStrike * 2;
                                    Console.WriteLine($"Вам нанесли {bossLightningStrike * 2} урона молнией. Ваше здоровье :{heroHealth} ед.");
                                }
                                else
                                {
                                    heroHealth -= bossLightningStrike;
                                    Console.WriteLine($"Вам нанесли {bossLightningStrike} урона молнией. Ваше здоровье :{heroHealth} ед.");
                                }
                            }
                            break;
                        default:

                            if (bossEnrage)
                            {
                                heroHealth -= bossAutoAttac * 2;
                                Console.WriteLine($"Вам нанесли {bossAutoAttac * 2} урона. Ваше здоровье :{heroHealth} ед.");
                            }
                            else
                            {
                                heroHealth -= bossAutoAttac;
                                Console.WriteLine($"Вам нанесли {bossAutoAttac} урона. Ваше здоровье :{heroHealth} ед.");
                            }
                            break;
                    }
                }

                if (bossHealth <= 0)
                {
                    Console.WriteLine("Вы победили!");
                }
                else if (heroHealth <= 0)
                {
                    Console.WriteLine("Вы проиграли!");
                }

                Console.ReadKey();
            }


        }
    }
}
