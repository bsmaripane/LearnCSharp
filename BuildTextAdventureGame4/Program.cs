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



            Console.ReadKey();
        }
    }
}
