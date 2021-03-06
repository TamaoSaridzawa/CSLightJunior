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
            int doubleFinishingBlow = heroFinishingBlow * 2;
            int numberOfTreatments = 4;
            double percentageHealthRecovery = 50;
            bool heroRebound = false;
            bool knockedDown = false;
            int maxProcentKnocked = 100;
            int mimProcentForKnocked = 50;
            int bossHealth = 300;
            int bossAutoAttac = 20;
            int enrageOfAutoAttac = bossAutoAttac * 2;
            int bossLightningStrike = 80;
            int enrageLightningStrike = bossLightningStrike * 2;
            bool bossEnrage = false;

            Console.WriteLine("Вас приветствует пошаговая игра 'Figth Arena'. Вам предстоит сразится с боссом 1х1 и победить!");
            Console.WriteLine($"Управление :\n 1 - Рубящая атака, наносит {heroSlashingAttack} урона\n 2 - Удар в колено, наносит {heroOutOfBalance} урона , с шансом в {mimProcentForKnocked}% выводит из равновесия и сбивает с ног" +
                $"\n 3 - Завершающий удар, наносит {heroFinishingBlow} урона, если цель сбита с ног наносит {doubleFinishingBlow} урона\n 4 - Отскок, вы отпрыгиваете в сторону" +
                $"\n 5 - Залечить раны, восстанавливаете {percentageHealthRecovery}% здоровье от недостающего . Доступно {numberOfTreatments} лечения");
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
                                bossHealth -= doubleFinishingBlow;
                                knockedDown = false;
                                Console.WriteLine($"Вы нанесли {doubleFinishingBlow} урона. Здоровье босса :{bossHealth} ед.");
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
                                double heroHealWounds = (heroMaxHealth - heroHealth) / 100 * percentageHealthRecovery;
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
                                    heroHealth -= enrageLightningStrike;
                                    Console.WriteLine($"Вам нанесли {enrageLightningStrike} урона молнией. Ваше здоровье :{heroHealth} ед.");
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
                                heroHealth -= enrageOfAutoAttac;
                                Console.WriteLine($"Вам нанесли {enrageOfAutoAttac} урона. Ваше здоровье :{heroHealth} ед.");
                            }
                            else
                            {
                                heroHealth -= bossAutoAttac;
                                Console.WriteLine($"Вам нанесли {bossAutoAttac} урона. Ваше здоровье :{heroHealth} ед.");
                            }
                            break;
                    }
                }

                if (bossHealth <= 0 && heroHealth <= 0)
                {
                    Console.WriteLine("Ничья : в этой битве пали оба бойца");
                }
                else if (bossHealth <= 0)
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
