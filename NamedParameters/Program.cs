namespace NamedParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Salary R{AddBonus(6784.79)}");
            Console.WriteLine($"Salary R{AddBonus(11458.88, allowance: 3500)}");
            Console.WriteLine($"Salary R{AddBonus(21458.88, bonus: 6500)}");
            Console.WriteLine($"Salary R{AddBonus(salary: 38458.88, bonus: 1500, allowance: 1800)}");
            Console.WriteLine($"Salary R{AddBonus(bonus: 20000, allowance: 8500, salary: 65458.88)}");

            Console.ReadKey();
        }

        static double AddBonus(double salary, double bonus = 0.0, double allowance = 0.0) => salary += (bonus + allowance);
    }
}
