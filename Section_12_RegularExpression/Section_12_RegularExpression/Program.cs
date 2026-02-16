using System.Text.RegularExpressions;

namespace Section_12_RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular Expression Example");

            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hey, my student number is 123456789";

            MatchCollection matchCollection = regex.Matches(text);

            Console.WriteLine("{0} hits found:\n{1}", matchCollection.Count, text);

            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            Console.ReadKey();
        }
    }
}
