namespace StructsApp
{
    public struct Point
    {
        //public int X {  get; set; }
        //public int Y { get; set; }
        public int X;
        public int Y;

        public Point(int x, int y) { X = x; Y = y; }

        public void Display() { Console.WriteLine($"Point: ({X}, {Y})"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(29,30);
            p.Display();

            Point p1;
            p1.X = 3;
            p1.Y = 11;
            p1.Display();

            Console.ReadKey();
        }
    }
}
