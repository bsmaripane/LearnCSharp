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
            
            Console.ReadKey();
        }
    }
}
