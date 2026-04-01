namespace LambdaExpressionWithUser_definedClasses
{
    internal class Program
    {
        public class Student
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; } = string.Empty;
        }

        static void Main(string[] args)
        {
            List<Student> student = new List<Student>()
            {
                new Student{StudentId = 101, StudentName = "Maxine"},
                new Student{StudentId = 102, StudentName = "Lesego"},
                new Student{StudentId = 103, StudentName = "Felicia"},
                new Student{StudentId = 104, StudentName = "Semape"},
                new Student{StudentId = 105, StudentName = "Kganya"}
            };

            // Sorting by student name using lambda
            var sortedList = student.OrderBy(x => x.StudentName);

            foreach (var studentName in sortedList)
                Console.WriteLine($"{studentName.StudentId} {studentName.StudentName}");

            Console.ReadKey();
        }
    }
}
