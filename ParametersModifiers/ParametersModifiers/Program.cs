namespace ParametersModifiers
{
    internal class Program
    {
        static void ModifyValues(ref int num)
        {
            num += 10;
        }

        static void GetValue(out int age, out string name, out string dob)
        {
            age = 30;
            name = "Belmy S Maripane";
            dob = "17 May 1995";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Parameter Modifers in C#!");

            int number = 5;
            int age;
            var name = "";
            var dateOfBirth = "";

            Console.WriteLine($"Before ModifyValues: {number}");
            ModifyValues(ref number);
            Console.WriteLine($"After ModifyValues: {number}");

            GetValue(out age, out name, out dateOfBirth);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Date of Birth: {dateOfBirth}");
            Console.WriteLine($"Age: {age}");

            Console.ReadKey();
        }
    }
}
