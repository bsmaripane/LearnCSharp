namespace SimpleDependencyInjectionExample
{
    public class Pen
    {
        public void Write()
        {
            Console.WriteLine("Writing with a pen");
        }
    }

    class Student
    {
        Pen pen = new Pen();

        public void DoHomework(string active)
        {
            Console.Write($"{active}: ");
            pen.Write();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.DoHomework("Draw a mind map");
            student.DoHomework("Write an essay of about yourself with 1000 words");
            
            Console.ReadKey();
        }
    }
}
