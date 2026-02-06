namespace SimpleDependencyInjectionExample
{
    public interface IWritingTool
    {
        void Write();
    }

    public class Pen : IWritingTool
    {
        public void Write()
        {
            Console.WriteLine("Writing with a pen");
        }
    }

    public class Pencil : IWritingTool
    {
        public void Write()
        {
            Console.WriteLine("Writing with a pencil");
        }
    }

    public class Marker : IWritingTool
    {
        public void Write()
        {
            Console.WriteLine("Writing with a marker");
        }
    }

    class Student
    {
        // Student depends on an idea (interface)
        IWritingTool _tool;

        public Student (IWritingTool tool)
        {
            _tool = tool;
        }
        public void DoHomework(string active)
        {
            Console.Write($"{active}: ");
            _tool.Write();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(new Pen());
            Student student1 = new Student(new Pencil());
            Student student2 = new Student(new Marker());

            student1.DoHomework("Draw a mind map");
            student.DoHomework("Write an essay of about yourself with 1000 words");
            student2.DoHomework("Write notes on the board");
            
            Console.ReadKey();
        }
    }
}
