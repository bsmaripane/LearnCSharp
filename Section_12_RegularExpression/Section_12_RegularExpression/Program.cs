using System.Text.RegularExpressions;

namespace Section_12_RegularExpression
{
    internal class Program
    {
        public static void ExtractEmailAddressPattern(string input)
        {
            string emailPattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            Regex regex = new Regex(emailPattern);

            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine(group[0].Value);
            }
        }

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

            string message = "Hello! You can reach our support team at help@example.com or " +
                "contact our sales representative at sales_department123@business.org. " +
                "For general inquiries, email info.test@service-provider.net.";

            ExtractEmailAddressPattern(message);

            Console.ReadKey();
        }
    }
}
