using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputedPropertiesAndNoConstructor
{
    internal class Rectange
    {
        public double Width {  get; set; }
        public double Height {  get; set; }

        // Computed property - read only property
        public double Area
        {
            get { return Width * Height; }
        }
    }
}
