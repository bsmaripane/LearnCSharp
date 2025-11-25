namespace ParametersModifiers
{
    internal class Program
    {
        static void ModifyValues(ref int num, in int age)
        {
            num += age;
            Console.WriteLine($"Lesego's age is {age} years old");
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
            int age = 11;
            var name = "";
            var dateOfBirth = "";

            Console.WriteLine($"Before ModifyValues: {number}");
            ModifyValues(ref number, age);
            Console.WriteLine($"After ModifyValues: {number}");

            GetValue(out age, out name, out dateOfBirth);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Date of Birth: {dateOfBirth}");
            Console.WriteLine($"Age: {age}");

            Console.ReadKey();
        }
    }
}
