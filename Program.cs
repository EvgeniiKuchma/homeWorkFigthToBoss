using System;
using System.Threading;

namespace homeWorkFigthToBoss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandMeleeAttack = "1";
            const string CommandfireBall = "2";
            const string CommandExplosion = "3";
            const string CommandHealing = "4";

            Random random = new Random();

            int death = 0;

            int bossHealth = 150;
            int minRangeBossAttack = 15;
            int maxRangeBossAttack = 26;
            int bossAttack = random.Next(minRangeBossAttack, maxRangeBossAttack);

            int heroHealth = 100;
            int mana = 100;
            int minRangeHeroAttack = 10;
            int maxRangeHeroAttack = 16;
            int heroAttack = random.Next(minRangeHeroAttack, maxRangeHeroAttack);
            int fireBallDamage = 20;
            int fireBallCost = 10;
            int fireBallCount = 0;
            int explosionDamage = 30;
            int explosionCost = 15;
            int healing = 15;
            int endMusic = 1;

            bool isWork = true;

            string inputPlayer;

            Console.WindowHeight = 50;
            Console.WindowWidth = 150;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.SetCursorPosition(65, 20);
            Console.WriteLine("GREETINGS HERO!");
            Console.SetCursorPosition(48, 21);
            Console.WriteLine("YOU ARE READY FOR THE GREATEST BATTLE IN HISTORY?");
            Console.SetCursorPosition(35, 22);
            Console.WriteLine($"The man who enslaved your people and killed your family before you, Nidrazad \"blazing\". ");
            Console.SetCursorPosition(55, 23);
            Console.WriteLine("Will you have the courage to fight him?");

            for (int i = 0; i < endMusic; i++)
            {
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(932, 150);
                Thread.Sleep(150);
                Console.Beep(1047, 150);
                Thread.Sleep(150);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(784, 150);
                Thread.Sleep(300);
                Console.Beep(699, 150);
                Thread.Sleep(150);
                Console.Beep(740, 150);
                Thread.Sleep(150);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(587, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(554, 1200);
                Thread.Sleep(75);
                Console.Beep(932, 150);
                Console.Beep(784, 150);
                Console.Beep(523, 1200);
                Thread.Sleep(150);
                Console.Beep(466, 150);
                Console.Beep(523, 150);
            }

            Console.Clear();
            Console.SetCursorPosition(57, 24);
            Console.WriteLine("AND, LET THERE BE A FIRESTORM!!!");
            Console.Clear();

            while (bossHealth > death && heroHealth > death)
            {
                

                while (isWork)
                {
                    Console.WriteLine("Greetings hero, the challenge of battle awaits you");

                    Console.WriteLine("        | |");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("    ===========        ^");
                    Console.WriteLine("      ( -  -)         | |");
                    Console.WriteLine("       | --|          | |");
                    Console.WriteLine("      |~~~~~|         | |");
                    Console.WriteLine("|||---   *   ---|||   | |");
                    Console.WriteLine("||| | |  *  | | |||   | |");
                    Console.WriteLine("  | | |  *  | | |    _____");
                    Console.WriteLine("  | | |  *  | | ===== (|)");

                    Console.SetCursorPosition(48, 1);
                    Console.WriteLine("         ^    ^");
                    Console.SetCursorPosition(48, 2);
                    Console.WriteLine("        | |__| |");
                    Console.SetCursorPosition(48, 3);
                    Console.WriteLine("       |-   - *|");
                    Console.SetCursorPosition(48, 4);
                    Console.WriteLine("       |(~~~)|*|");
                    Console.SetCursorPosition(48, 5);
                    Console.WriteLine("     ||+++++++++||");
                    Console.SetCursorPosition(48, 6);
                    Console.WriteLine("    / /|*******/ /");
                    Console.SetCursorPosition(48, 7);
                    Console.WriteLine("   / / |******/ /");
                    Console.SetCursorPosition(48, 8);
                    Console.WriteLine("  / /  |*****/ /|");
                    Console.SetCursorPosition(48, 9);
                    Console.WriteLine(" | |   |****| |*|");
                    Console.SetCursorPosition(48, 10);
                    Console.WriteLine(" (((   |****(((*|");

                    isWork = false;

                    Console.WriteLine("press any key to pay RESPECT");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine($"\n{bossHealth} - boss health");
                Console.WriteLine($"{heroHealth} - hero health");
                Console.WriteLine($"{mana} - mana");

                Console.WriteLine("choose you action: ");
                Console.WriteLine($"{CommandMeleeAttack}.take melee attack.");
                Console.WriteLine($"{CommandfireBall}.take a fireball.");
                Console.WriteLine($"{CommandExplosion}.take explosion.");
                Console.WriteLine($"{CommandHealing}.take healing.");

                Console.WriteLine("        | |");
                Console.WriteLine("       |   |");
                Console.WriteLine("    ===========        ^");
                Console.WriteLine("      ( =  =)         | |");
                Console.WriteLine("       |  O|" + " <--(Charge!!!)");
                Console.WriteLine("      |~~~~~|         | |");
                Console.WriteLine("|||---   *   ---|||   | |");
                Console.WriteLine("||| | |  *  | | |||   | |");
                Console.WriteLine("  | | |  *  | | |    _____");
                Console.WriteLine("  | | |  *  | | ===== (|)");

                Console.SetCursorPosition(48, 9);
                Console.WriteLine("         ^    ^");
                Console.SetCursorPosition(48, 10);
                Console.WriteLine("        | |__| |");
                Console.SetCursorPosition(48, 11);
                Console.WriteLine("       |0   0 *|");
                Console.SetCursorPosition(48, 12);
                Console.WriteLine("       |(===)|*|");
                Console.SetCursorPosition(48, 13);
                Console.WriteLine("     ||+++++++++||");
                Console.SetCursorPosition(48, 14);
                Console.WriteLine("    / /|*******/ /");
                Console.SetCursorPosition(48, 15);
                Console.WriteLine("   / / |******/ /");
                Console.SetCursorPosition(48, 16);
                Console.WriteLine("  / /  |*****/ /|");
                Console.SetCursorPosition(48, 17);
                Console.WriteLine(" | |   |****| |*|");
                Console.SetCursorPosition(48, 18);
                Console.WriteLine(" (((   |****(((*|");

                Console.WriteLine("\n");
                inputPlayer = Console.ReadLine();
                Console.Clear();

                switch (inputPlayer)
                {
                    case CommandMeleeAttack:

                        bossHealth -= heroAttack;
                        heroHealth -= bossAttack;
                        break;

                    case CommandfireBall:
                        if (fireBallCost <= mana)
                        {
                            bossHealth -= fireBallDamage;
                            mana -= fireBallCost;
                            fireBallCount++;
                            heroHealth -= bossAttack;
                        }
                        else
                        {
                            Console.WriteLine("not enoth mana.");
                        }
                        break;

                    case CommandExplosion:
                        if (fireBallCount > 0 && explosionCost <= mana)
                        {
                            bossHealth -= explosionDamage;
                            mana -= explosionCost;
                            fireBallCount--;
                            heroHealth -= bossAttack;
                        }
                        else if (explosionCost > mana)
                        {
                            Console.WriteLine("not enoth mana.");
                        }
                        else if (fireBallCount == 0)
                        {
                            Console.WriteLine("use the fireball first.");
                        }
                        break;

                    case CommandHealing:
                        heroHealth += healing;
                        mana += healing;
                        heroHealth -= bossAttack;
                        break;

                    default:
                        heroHealth -= bossAttack;
                        break;
                }

                if(heroHealth <= 0 && bossHealth <= 0)
                {
                    Console.WriteLine("Tie!");
                    Console.WriteLine("        | |");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("    ===========        ^");
                    Console.WriteLine("      ( 0  0)         | |");
                    Console.WriteLine("       | ==|" + " <--(Oh no WAY!)");
                    Console.WriteLine("      |~~~~~|         | |");
                    Console.WriteLine("|||---   *   ---|||   | |");
                    Console.WriteLine("||| | |  *  | | |||   | |");
                    Console.WriteLine("  | | |  *  | | |    _____");
                    Console.WriteLine("  | | |  *  | | ===== (|)");
                }
                else if (heroHealth <= 0)
                {
                    Console.WriteLine("You lose");
                    Console.WriteLine("        | |");
                    Console.WriteLine("           |");
                    Console.WriteLine("    =========== ");
                    Console.WriteLine("      ( х  х)");
                    Console.WriteLine("       | хх|" + " <--(xxx)");
                    Console.WriteLine("      |~~~~~|");
                    Console.WriteLine("||---   *   ---|");
                    Console.WriteLine("||| | |  *  | | ||");
                    Console.WriteLine("  | | |  *  | | |  ");
                    Console.WriteLine("  | | |  *  | | ");
                }
                else if (bossHealth <= 0) 
                {
                    Console.WriteLine("You WIN!!!");
                    Console.WriteLine("        | |");
                    Console.WriteLine("       |   |");
                    Console.WriteLine("    ===========        ^");
                    Console.WriteLine("      ( ^  ^)         | |");
                    Console.WriteLine("       | --|" + " <--(URA!!!!!!)");
                    Console.WriteLine("      |~~~~~|         | |");
                    Console.WriteLine("|||---   *   ---|||   | |");
                    Console.WriteLine("||| | |  *  | | |||   | |");
                    Console.WriteLine("  | | |  *  | | |    _____");
                }
            }
        }
    }
}
