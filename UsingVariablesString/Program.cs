namespace UsingVariablesString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C# Programming MasterClass!\n\n");

            // Declare a variable of type string
            string myGirlFriendsName;

            // Assign a string
            myGirlFriendsName = "Felicia";

            // Display the string store in myGirlFriendName
            Console.WriteLine(myGirlFriendsName);

            // Overite the string in a variable
            myGirlFriendsName = "Maxine";

            Console.WriteLine(myGirlFriendsName);

            Console.ReadKey();
        }
    }
}
