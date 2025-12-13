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
            private OuterClass outer;
            public void DisplayMessage() => Console.WriteLine("Hello, I'm a string from InnerClass");
            public InnerClass(OuterClass outer) => this.outer = outer;
            public void DisplayOuterField() => Console.WriteLine(outer.outerField);
        }
    }
}
