namespace DataTypes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myname = "Belmy";
            string message = "Hello";
            int age = 28;
            float COS1511 = 75;
            float COS1521 = 62;
            float INF1505 = 56;
            float INF1511 = 83;
            float INF1520 = 76;

            float avarage = (COS1511+COS1521+INF1505+INF1511+INF1520) / 5;
            
            Console.WriteLine(message + ", My name is " + myname.ToUpper());
            Console.WriteLine("I am a " + age + " years old and a student at UNISA");
            Console.WriteLine("with an avarage of " + avarage + "% for final exams for Bsc in Computing (first level).");
            Console.Read();
        }
    }
}
