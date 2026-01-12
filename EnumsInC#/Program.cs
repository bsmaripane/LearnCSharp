namespace EnumsInC_
{
    enum Day { Mon, Tue, Wed, Thu, Fri, Sat, Sun };

    internal class Program
    {
        static void Main(string[] args)
        {
            Day mo = Day.Mon;
            Day tu = Day.Tue;
            Day we = Day.Wed;
            Day thu = Day.Thu;
            Day fr = Day.Fri;

            Console.WriteLine(fr == mo);
            Console.WriteLine(Day.Sun);
            Console.WriteLine(Day.Sat);
            Console.WriteLine((int)Day.Wed);

            Console.ReadKey();
        }
    }
}
