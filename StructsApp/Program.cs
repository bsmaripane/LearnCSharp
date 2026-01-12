namespace StructsApp
{
    public struct Point
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Point(int x, int y) { X = x; Y = y; }

        public void Display() { Console.WriteLine($"Point: ({X}, {Y})"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(29,30);
            p.Display();

            Console.ReadKey();
        }
    }
}
