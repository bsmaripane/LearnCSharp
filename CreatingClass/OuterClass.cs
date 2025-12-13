using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingClass
{
    internal class OuterClass
    {
        private string outerField = "I am string from OuterClass";

        public class InnerClass
        {
            public void DisplayMessage() => Console.WriteLine("Hello, I'm a string from InnerClass");
        }
    }
}
