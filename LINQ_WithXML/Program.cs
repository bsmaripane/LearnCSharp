using System.Xml.Linq;

namespace LINQ_WithXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simply Student Structure to XML
            string studentsXML =  @"<Students>
                                        <Student>
                                            <Name>Felicia</Name>
                                            <Age>29</Age>
                                            <University>UJ</University>
                                        </Student>
                                        <Student>
                                            <Name>Belicia</Name>
                                            <Age>20</Age>
                                            <University>Wits</University>
                                        </Student>
                                        <Student>
                                            <Name>Lesego</Name>
                                            <Age>17</Age>
                                            <University>Wits</University>
                                        </Student>
                                        <Student>
                                            <Name>Emily</Name>
                                            <Age>54</Age>
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
                               University = student.Element("University").Value
                           };

            foreach (var student in students )
                Console.WriteLine($"Student {student.Name} with age {student.Age} years old from University {student.University}");
            
            Console.ReadKey();
        }
    }
}
