using System.Xml.Linq;

namespace LINQ_WithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simply Student Structure to XML
            string studentsXML = @"<Students>
                                        <Student>
                                            <Name>Felicia</Name>
                                            <Age>29</Age>
                                            <Course>BEd in Senior Phase and FET Teaching</Course>
                                            <University>UJ</University>
                                        </Student>
                                        <Student>
                                            <Name>Belicia</Name>
                                            <Age>20</Age>
                                            <Course>BEng in Electrical Engineering</Course>
                                            <University>Wits</University>
                                        </Student>
                                        <Student>
                                            <Name>Lesego</Name>
                                            <Age>17</Age>
                                            <Course>Bcom in Law</Course>
                                            <University>Wits</University>
                                        </Student>
                                        <Student>
                                            <Name>Emily</Name>
                                            <Age>54</Age>
                                            <Course>NDip in Fasion Designer</Course>
                                            <University>UNISA</University>
                                        </Student>
                                        <Student>
                                            <Name>Emily</Name>
                                            <Age>30</Age>
                                            <Course>BSc in Computing</Course>
                                            <University>UNISA</University>
                                        </Student>
                                    </Students>";

            XDocument studentXdoc = new XDocument();
            studentXdoc = XDocument.Parse(studentsXML);

            var students = from student in studentXdoc.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               Course = student.Element("Course").Value,
                               University = student.Element("University").Value
                           };

            foreach (var student in students )
                Console.WriteLine($"Student {student.Name} with age {student.Age} years old, studying {student.Course} from University {student.University}");

            var sortStudentsByAge = from student in students
                                    orderby student.Age
                                    select student;

            Console.WriteLine("\nSotr the list of student by age:");
            foreach (var student in sortStudentsByAge )
                Console.WriteLine($"Student {student.Name} with age {student.Age} years old, studying {student.Course} from University {student.University}");
            
            Console.ReadKey();
        }
    }
}
