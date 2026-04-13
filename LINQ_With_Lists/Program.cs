namespace LINQ_With_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager universityManager = new UniversityManager();

            Console.WriteLine("Filter only Male Students:");
            universityManager.MaleStudents();
            Console.WriteLine("\nFilter only Femake Students:");
            universityManager.FemaleStudents();
            Console.WriteLine("\nFilter All Students:");
            universityManager.AllStudents();

            Console.ReadKey();
        }
    }
}
