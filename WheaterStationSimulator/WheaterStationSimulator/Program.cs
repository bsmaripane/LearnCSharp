namespace WeaterStationSimulator
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Weather Station Simulator!");

            Console.Write("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Cloudy", "Rainy", "Windy", "Stormy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-5, 42);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];

            }

            DisplayWeatherReport(temperature, weatherConditions);


            Console.ReadKey(true);
        }

        static void DisplayWeatherReport(int[] temps, string[] conditions)
        {
            string[] daysName = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine("\nWeather Report:");
            Console.WriteLine("Day\tTemperature (°C)\tCondition");
            for (int i = 0; i < temps.Length; i++)
            {
                Console.WriteLine($"{daysName[i]}\t{temps[i]}\t\t{conditions[i]}");
            }
            double averageTemp = CalculateAverageTemperature(temps);
            Console.WriteLine($"\nAverage Temperature over {temps.Length} days: {averageTemp:F3} °C");
        }
        static double CalculateAverageTemperature(int[] temps)
        {
            int sum = 0;

            foreach (var temp in temps)
            {
                sum += temp;
            }

            return (double)sum / temps.Length;
        }
    }
}
