namespace LINQ_BasicSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var number in evenNumbers)
                Console.WriteLine(number);


            var names = new[] { "Lesego", "Alice", "Charlie", "David", "Bob", "Chris", "Chesta" };

            var filterName = names.Where(name => name.StartsWith("C"));

            Console.WriteLine("\nFiltered names by 'C':");
            foreach (var name in filterName)
                Console.WriteLine(name);
    
            var orderNames = names.OrderBy(name => name);

            Console.WriteLine("\nSorted names:");
            foreach (var name in orderNames)
                Console.WriteLine(name);
            
            var countNames = names.Count();

            Console.WriteLine($"\nTotal number of names: {countNames}");

            var nums = new[] { 1, 2, 3 };
            var letters = new[] { 'A', 'B', 'C' };
            var zipped = nums.Zip(letters, (num, letter) => $"{num}-{letter}");

            foreach (var item in zipped)
                Console.WriteLine(item);


            var people = new[]
            {
                new {Name = "Alice", Age = 30},
                new {Name = "Bob", Age = 30},
                new {Name = "Charlie", Age = 25}
            };

            var grouped = people.GroupBy(p => p.Age);

            Console.WriteLine("\nGroup people by age:");
            foreach (var group in grouped)
            {
                Console.WriteLine($"Age: {group.Key}");
                foreach (var person in group)
                    Console.WriteLine(person.Name);
            }

            Console.ReadKey();
        }
    }
}
