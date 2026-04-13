namespace LINQ_With_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniversityManager universityManager = new UniversityManager();

            Console.WriteLine("Male Students:");
            universityManager.MaleStudents();
            Console.WriteLine("\nFemake Students:");
            universityManager.FemaleStudents();

            Console.ReadKey();
        }
    }
}
