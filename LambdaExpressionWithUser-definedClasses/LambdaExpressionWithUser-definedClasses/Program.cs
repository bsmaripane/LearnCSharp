namespace LambdaExpressionWithUser_definedClasses
{
    internal class Program
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; } = string.Empty;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.ReadKey();
        }
    }
}
