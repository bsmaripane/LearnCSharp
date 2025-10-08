using System;

namespace BuildTextAdventureGame4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Adventure Game!");
            Console.Write("Enter your character's name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Choose your character type (Warrior, Wizard, Archer)");
            string characterType = Console.ReadLine();

            Console.WriteLine($"You, {playerName} the {characterType} find yourself at the edge of a dark forest.");
            Console.WriteLine("Do you enter the forest or camp outside? (Enter/Camp)");
            string choice1 = Console.ReadLine();

            if (choice1.Trim().ToLower() == "enter")
            {
                Console.WriteLine("You bravely enter the forest");
            }
            else
            {
                Console.WriteLine("You decide to camp out and wait for daylight.");
            }

            bool gameContinues = true;
            bool isWin = false;

            while (gameContinues)
            {
                Console.WriteLine("You come to a fork in the road. Go left or right?");
                string direction = Console.ReadLine();

                if (direction.Trim().ToLower() == "left")
                {
                    Console.WriteLine("You find a treasure chest!");
                    isWin = true;
                    gameContinues = false;
                }
                else
                {
                    Console.WriteLine("You encounter a wild beast!");
                    Console.WriteLine("Fight or flee? (fight/flee)");
                    string fightChoice = Console.ReadLine();

                    if (fightChoice.Trim().ToLower() == "fight")
                    {
                        Random random = new Random();
                        int luck = random.Next(1, 11);

                        if (luck > 5)
                        {
                            Console.WriteLine("You beat the wild beast!");

                            if (luck > 8)
                            {
                                Console.WriteLine("The wild beast dropped a treasure!");
                                isWin = true;
                                gameContinues = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The beast attacked you where you didn't expect it!");
                            Console.WriteLine("It rammed it's  tusks into your chest and you bleed out!");
                            isWin = false;
                            gameContinues = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wish to continue? (yes or no)");
                        string continues = Console.ReadLine();

                        if (continues.Trim().ToLower() == "yes")
                        {
                            Console.WriteLine("Get ready to fight the beast!");

                            for (int i = 1; i <= 3; i++)
                            {
                                Console.WriteLine($"\t\t{i}");
                                Thread.Sleep(1000);
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                Console.Write(new string(' ', Console.WindowWidth));
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                            }
                            Console.WriteLine("\n\t\tGO\n");
                        }
                        else
                        {
                            Console.WriteLine("Game end in (Press x to retry)");
                            bool startAgain = false;

                            for (int i = 1; i <= 10; i++)
                            {
                                DateTime start = DateTime.Now;
                                while ((DateTime.Now - start).TotalSeconds < 1)
                                {
                                    if (Console.KeyAvailable)
                                    {
                                        ConsoleKeyInfo key = Console.ReadKey(true);
                                        if (key.Key == ConsoleKey.X)
                                        {
                                            startAgain = true;
                                            break;
                                        }
                                    }
                                    Thread.Sleep(50);
                                }

                                if (startAgain) break;
                                Console.Write($"\t\t{i}");
                                Console.Write("\r" + new string(' ', $"\t\t{i}".Length) + "\r");
                                Thread.Sleep(1000);
                            }
                            if (startAgain)
                                gameContinues = true;
                            else
                                gameContinues = false;
                        }
                    }
                }
            }
            Console.WriteLine(isWin ? "\n\t\t\twinner".ToUpper() : "\n\t\t\tLoser".ToUpper());

            Console.WriteLine("\n\n\t\t\tGame Over!\n\n");
            Thread.Sleep(2000);
            Console.WriteLine("================= Thank you for playing the game!================");
            Console.ReadKey();
        }
    }
}
