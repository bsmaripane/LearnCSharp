namespace ComputedPropertiesAndNoConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Computed Properties and No Constructor!\n");
            Rectange rec1 = new Rectange();
            rec1.Width = 3;
            rec1.Height = 11;
            Console.WriteLine($"Area of rec1 is {rec1.Area}");

            Console.ReadKey();
        }
    }
}
