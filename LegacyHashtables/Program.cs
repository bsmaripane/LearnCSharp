using System.Collections;

namespace LegacyHashtables
{
    internal class Program
    {
        // Key - Value
        // Auto - car

        static void Main(string[] args)
        {
            // Create a hashtable - with empty table
            Hashtable studentTable = new Hashtable();
            
            Student student1 = new Student(1, "Legeso", 64);
            Student student2 = new Student(2, "Kganya", 52);
            Student student3 = new Student(3, "Felicia", 99);
            Student student4 = new Student(4, "Maxine", 69);
            Student student5 = new Student(5, "Semape", 75);

            studentTable.Add(student1.Id, student1);
            studentTable.Add(student2.Id, student2);
            studentTable.Add(student3.Id, student3);
            studentTable.Add(student4.Id, student4);
            studentTable.Add(student5.Id, student5);

            Student storedStudent1 = (Student)studentTable[student1.Id];

        
            foreach (Student value in studentTable.Values)
            {
                Console.WriteLine($"Student ID: {value.Id}");
                Console.WriteLine($"Student Name: {value.Name}");
                Console.WriteLine($"Student GPA: {value.GPA}");
            }

            //Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            Console.ReadKey();
        }
    }

    class Student
    {
        // property - Id
        public int Id { get; set; }
        // property - Name
        public string Name { get; set; }
        // property - GPA
        public float GPA { get; set; }
        // simple constructor
        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this. GPA = GPA;
        }
    }
}
